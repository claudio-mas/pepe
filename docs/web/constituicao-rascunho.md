# Constituição do Pepe Web (rascunho)

> Rascunho a ser levado para `.specify/memory/constitution.md` com `/speckit.constitution`. Vale para pessoas e agentes.
> Toda spec, plano e tarefa precisa respeitar estes princípios; o `/speckit.analyze` deve apontar violações.

## I. O banco é compartilhado com o desktop

1. **Nunca alterar nem remover objeto existente** do `BDTorras` (tabela, coluna, view, proc, função, trigger).
2. Objetos novos ficam no schema **`web`** (tabelas da aplicação web: usuários, sessões, auditoria) ou, se forem de
   leitura analítica, com o prefixo `VW_RG2_*`, como já é a convenção.
3. Toda mudança de banco é um par aditivo `_up.sql`/`_down.sql` em `Pepe/Scripts/`, rodado **primeiro no contêiner
   Docker** com uma cópia do banco.
4. Enquanto houver desktop em uso, a web **grava exatamente o que o desktop gravaria**: mesmas tabelas, mesmos campos
   derivados, mesmas procs. Uma diferença intencional só entra com ADR e com o desktop ajustado junto.
5. A web **não depende** do SQL de manutenção que o desktop roda ao abrir as telas (`docs/legado/00-mapa-de-navegacao.md`):
   cada caso é tratado na leitura ou vira job explícito.
6. **Há um terceiro sistema usando o `BDTorras`**, só para leitura e mantido pelo dono, e ele precisa continuar
   funcionando. As views
   `VI_Pecas_Web`, `Beth` e `BasePrecos` e os objetos de que dependem (`1TabPeças`, `METAIS`, `PEDRAS`, `VENDAS`,
   `[VENDAS DET]`, `Clientes`, `PeçasEstoque`) não mudam de forma nem de significado. Ver `docs/legado/90-banco.md` §6.

## II. Regras de negócio rastreáveis

1. Nenhuma regra é implementada sem uma RN catalogada em `docs/legado/` (`RN-<MÓD>-nnn`), com origem `arquivo:linha`
   no legado ou decisão registrada do dono.
2. Toda spec lista as RNs que cobre e os critérios de aceite de cada uma.
3. Divergência entre o código legado e o que o dono diz: vale o dono, e a divergência fica registrada.

## III. Paridade comprovada

1. Relatórios e cálculos (saldos, totais, comissões, custos, gerencial) têm **golden master**: a web precisa bater valor
   a valor com o legado nos períodos de referência.
2. Um módulo só é aceito com testes de contrato da API, E2E das jornadas principais e golden master verde.

## IV. Gravação segura

1. Toda operação que grava em mais de uma tabela roda **numa transação** (o legado não usa transação; a web usa).
2. SQL **sempre parametrizado**. Nada de concatenar valores em SQL (o legado concatena).
3. Conflito de edição simultânea com o desktop: concorrência otimista. A regra de detecção por tabela fica no ADR de
   convivência.

## V. Segurança e dados pessoais

1. Sem segredo no código nem no repositório. Configuração por variável de ambiente ou arquivo fora do git.
2. Usuários individuais, senha com hash (argon2id), perfis de acesso. A senha compartilhada do desktop não é reaproveitada.
3. Dados de clientes (nome, endereço, telefone, aniversário) são pessoais (LGPD): só ficam visíveis para quem precisa,
   não vão para logs e não entram no git (nem em golden master, nem em fixtures de teste, salvo anonimizados).
4. Intranet não é desculpa: HTTPS interno e sessão com expiração.

## VI. Domínio em português

1. Vocabulário do `docs/web/glossario.md` em telas, specs e código de domínio.
2. Nomes do banco são preservados exatamente, com acento (`[1TabPeças]`, `[Vencto Cartão]`), e o mapeamento para
   nomes TypeScript fica num único lugar (tipos gerados).
3. Cultura pt-BR na interface: datas `dd/MM/aaaa`, moeda `R$ 1.234,56`, vírgula decimal. No banco e na API, valores
   são tipados (nunca texto formatado).

## VII. Simplicidade

1. Uma loja, poucos usuários: sem microserviços, sem filas, sem cache distribuído. Um processo de API, uma SPA, um banco.
2. Dependência nova precisa se justificar no plano da spec.
3. Nada de copiar a UI do desktop tela a tela: a spec descreve a tarefa do usuário, e a tela web é desenhada para ela.
