Partial Public Class frmClientesDG
    ''' <summary>
    ''' Required designer variable.
    ''' </summary>
    Private components As System.ComponentModel.IContainer = Nothing

    ''' <summary>
    ''' Clean up any resources being used.
    ''' </summary>
    ''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso (components IsNot Nothing) Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

#Region "Windows Form Designer generated code"

    ''' <summary>
    ''' Required method for Designer support - do not modify
    ''' the contents of this method with the code editor.
    ''' </summary>
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmClientesDG))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.tsMenu = New System.Windows.Forms.ToolStrip()
        Me.btnNovo = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.btnEtiqMalaDireta = New System.Windows.Forms.ToolStripButton()
        Me.btnEtiqAniv = New System.Windows.Forms.ToolStripButton()
        Me.btnEmails = New System.Windows.Forms.ToolStripButton()
        Me.btnEndereços = New System.Windows.Forms.ToolStripButton()
        Me.btnTelefones = New System.Windows.Forms.ToolStripButton()
        Me.btnFechar = New System.Windows.Forms.ToolStripButton()
        Me.pnlTopo = New System.Windows.Forms.Panel()
        Me.txtPesquisa = New System.Windows.Forms.TextBox()
        Me.lblTitulo = New System.Windows.Forms.Label()
        Me.picAjuda = New System.Windows.Forms.PictureBox()
        Me.ckTodas = New System.Windows.Forms.CheckBox()
        Me.dgvClientes = New System.Windows.Forms.DataGridView()
        Me.colAbrir = New System.Windows.Forms.DataGridViewImageColumn()
        Me.colVenda = New System.Windows.Forms.DataGridViewImageColumn()
        Me.colTítulo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colNome = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colCliente = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colEndereço = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colBairro = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colTelefone = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colAniv = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colImp = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.lblPosicao = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.ttAjuda = New System.Windows.Forms.ToolTip(Me.components)
        Me.tmrPesquisa = New System.Windows.Forms.Timer(Me.components)
        Me.DsPrincipal = New Pepe.DataSet1()
        Me.ClientesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ClientesTableAdapter = New Pepe.DataSet1TableAdapters.ClientesTableAdapter()
        Me.TableAdapterManager = New Pepe.DataSet1TableAdapters.TableAdapterManager()
        Me.ClientesBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.DsNovo = New Pepe.dsNovo()
        Me.ClientesTableAdapter1 = New Pepe.dsNovoTableAdapters.ClientesTableAdapter()
        Me.TableAdapterManager1 = New Pepe.dsNovoTableAdapters.TableAdapterManager()
        Me.tsMenu.SuspendLayout()
        Me.pnlTopo.SuspendLayout()
        CType(Me.picAjuda, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvClientes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.StatusStrip1.SuspendLayout()
        CType(Me.DsPrincipal, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ClientesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ClientesBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsNovo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tsMenu
        '
        Me.tsMenu.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.tsMenu.ImageScalingSize = New System.Drawing.Size(32, 32)
        Me.tsMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnNovo, Me.ToolStripSeparator1, Me.btnEtiqMalaDireta, Me.btnEtiqAniv, Me.btnEmails, Me.btnEndereços, Me.btnTelefones, Me.btnFechar})
        Me.tsMenu.Location = New System.Drawing.Point(0, 0)
        Me.tsMenu.Name = "tsMenu"
        Me.tsMenu.Padding = New System.Windows.Forms.Padding(6, 2, 6, 2)
        Me.tsMenu.Size = New System.Drawing.Size(1338, 59)
        Me.tsMenu.TabIndex = 0
        '
        'btnNovo
        '
        Me.btnNovo.Image = CType(resources.GetObject("btnNovo.Image"), System.Drawing.Image)
        Me.btnNovo.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnNovo.Name = "btnNovo"
        Me.btnNovo.Size = New System.Drawing.Size(80, 52)
        Me.btnNovo.Text = "Novo cliente"
        Me.btnNovo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 55)
        '
        'btnEtiqMalaDireta
        '
        Me.btnEtiqMalaDireta.Image = CType(resources.GetObject("btnEtiqMalaDireta.Image"), System.Drawing.Image)
        Me.btnEtiqMalaDireta.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnEtiqMalaDireta.Name = "btnEtiqMalaDireta"
        Me.btnEtiqMalaDireta.Size = New System.Drawing.Size(127, 52)
        Me.btnEtiqMalaDireta.Text = "Etiquetas mala direta"
        Me.btnEtiqMalaDireta.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'btnEtiqAniv
        '
        Me.btnEtiqAniv.Image = CType(resources.GetObject("btnEtiqAniv.Image"), System.Drawing.Image)
        Me.btnEtiqAniv.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnEtiqAniv.Name = "btnEtiqAniv"
        Me.btnEtiqAniv.Size = New System.Drawing.Size(126, 52)
        Me.btnEtiqAniv.Text = "Etiquetas aniversário"
        Me.btnEtiqAniv.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'btnEmails
        '
        Me.btnEmails.Image = CType(resources.GetObject("btnEmails.Image"), System.Drawing.Image)
        Me.btnEmails.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnEmails.Name = "btnEmails"
        Me.btnEmails.Size = New System.Drawing.Size(98, 52)
        Me.btnEmails.Text = "Lista de E-mails"
        Me.btnEmails.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'btnEndereços
        '
        Me.btnEndereços.Image = Global.Pepe.My.Resources.Resources.print_32x32
        Me.btnEndereços.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnEndereços.Name = "btnEndereços"
        Me.btnEndereços.Size = New System.Drawing.Size(128, 52)
        Me.btnEndereços.Text = "Endereços de Clientes"
        Me.btnEndereços.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'btnTelefones
        '
        Me.btnTelefones.Image = Global.Pepe.My.Resources.Resources.print_32x32
        Me.btnTelefones.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnTelefones.Name = "btnTelefones"
        Me.btnTelefones.Size = New System.Drawing.Size(125, 52)
        Me.btnTelefones.Text = "Telefones de Clientes"
        Me.btnTelefones.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'btnFechar
        '
        Me.btnFechar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.btnFechar.Image = CType(resources.GetObject("btnFechar.Image"), System.Drawing.Image)
        Me.btnFechar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnFechar.Name = "btnFechar"
        Me.btnFechar.Size = New System.Drawing.Size(47, 52)
        Me.btnFechar.Text = "Fechar"
        Me.btnFechar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'pnlTopo
        '
        Me.pnlTopo.Controls.Add(Me.txtPesquisa)
        Me.pnlTopo.Controls.Add(Me.lblTitulo)
        Me.pnlTopo.Controls.Add(Me.picAjuda)
        Me.pnlTopo.Controls.Add(Me.ckTodas)
        Me.pnlTopo.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlTopo.Location = New System.Drawing.Point(0, 59)
        Me.pnlTopo.Name = "pnlTopo"
        Me.pnlTopo.Size = New System.Drawing.Size(1338, 36)
        Me.pnlTopo.TabIndex = 1
        '
        'txtPesquisa
        '
        Me.txtPesquisa.Font = New System.Drawing.Font("Tahoma", 9.75!)
        Me.txtPesquisa.Location = New System.Drawing.Point(8, 7)
        Me.txtPesquisa.Name = "txtPesquisa"
        Me.txtPesquisa.Size = New System.Drawing.Size(360, 23)
        Me.txtPesquisa.TabIndex = 0
        Me.ToolTip1.SetToolTip(Me.txtPesquisa, "Digite parte do nome, endereço, bairro, telefone ou aniversário. Várias palavras: todas precisam aparecer.")
        '
        'lblTitulo
        '
        Me.lblTitulo.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitulo.Location = New System.Drawing.Point(557, 3)
        Me.lblTitulo.Name = "lblTitulo"
        Me.lblTitulo.Size = New System.Drawing.Size(224, 30)
        Me.lblTitulo.TabIndex = 1
        Me.lblTitulo.Text = "Cadastro de Clientes"
        Me.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'picAjuda
        '
        Me.picAjuda.Image = CType(resources.GetObject("picAjuda.Image"), System.Drawing.Image)
        Me.picAjuda.Location = New System.Drawing.Point(1180, 10)
        Me.picAjuda.Name = "picAjuda"
        Me.picAjuda.Size = New System.Drawing.Size(16, 16)
        Me.picAjuda.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.picAjuda.TabIndex = 2
        Me.picAjuda.TabStop = False
        Me.ttAjuda.SetToolTip(Me.picAjuda, "Marcar todo o cadastro pode levar algum tempo." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Este recurso deve ser utilizado para marcar somente um grupo selecionado de" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "clientes para gerar as etiquetas (filtre antes pela pesquisa).")
        '
        'ckTodas
        '
        Me.ckTodas.AutoSize = True
        Me.ckTodas.Location = New System.Drawing.Point(1202, 9)
        Me.ckTodas.Name = "ckTodas"
        Me.ckTodas.Size = New System.Drawing.Size(92, 17)
        Me.ckTodas.TabIndex = 3
        Me.ckTodas.Text = "Marcar todas"
        Me.ckTodas.UseVisualStyleBackColor = True
        '
        'dgvClientes
        '
        Me.dgvClientes.AllowUserToAddRows = False
        Me.dgvClientes.AllowUserToDeleteRows = False
        Me.dgvClientes.BackgroundColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Tahoma", 9.0!)
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvClientes.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvClientes.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colAbrir, Me.colVenda, Me.colTítulo, Me.colNome, Me.colCliente, Me.colEndereço, Me.colBairro, Me.colTelefone, Me.colAniv, Me.colImp})
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Tahoma", 9.75!)
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvClientes.DefaultCellStyle = DataGridViewCellStyle2
        Me.dgvClientes.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvClientes.Location = New System.Drawing.Point(0, 95)
        Me.dgvClientes.MultiSelect = False
        Me.dgvClientes.Name = "dgvClientes"
        Me.dgvClientes.RowHeadersVisible = False
        Me.dgvClientes.Size = New System.Drawing.Size(1338, 605)
        Me.dgvClientes.TabIndex = 2
        '
        'colAbrir
        '
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Window
        Me.colAbrir.DefaultCellStyle = DataGridViewCellStyle8
        Me.colAbrir.HeaderText = ""
        Me.colAbrir.Image = CType(resources.GetObject("colAbrir.Image"), System.Drawing.Image)
        Me.colAbrir.Name = "colAbrir"
        Me.colAbrir.ReadOnly = True
        Me.colAbrir.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.colAbrir.ToolTipText = "Abrir cadastro do cliente"
        Me.colAbrir.Width = 28
        '
        'colVenda
        '
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Window
        Me.colVenda.DefaultCellStyle = DataGridViewCellStyle9
        Me.colVenda.HeaderText = ""
        Me.colVenda.Image = CType(resources.GetObject("colVenda.Image"), System.Drawing.Image)
        Me.colVenda.Name = "colVenda"
        Me.colVenda.ReadOnly = True
        Me.colVenda.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.colVenda.ToolTipText = "Registra venda para o cliente"
        Me.colVenda.Width = 29
        '
        'colTítulo
        '
        Me.colTítulo.DataPropertyName = "Título"
        Me.colTítulo.HeaderText = "Título"
        Me.colTítulo.Name = "colTítulo"
        Me.colTítulo.ReadOnly = True
        Me.colTítulo.Width = 66
        '
        'colNome
        '
        Me.colNome.DataPropertyName = "Nome"
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.colNome.DefaultCellStyle = DataGridViewCellStyle3
        Me.colNome.HeaderText = "Cliente"
        Me.colNome.Name = "colNome"
        Me.colNome.ReadOnly = True
        Me.colNome.Width = 234
        '
        'colCliente
        '
        Me.colCliente.DataPropertyName = "Cliente"
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.colCliente.DefaultCellStyle = DataGridViewCellStyle4
        Me.colCliente.HeaderText = "Mala direta"
        Me.colCliente.Name = "colCliente"
        Me.colCliente.ReadOnly = True
        Me.colCliente.Width = 235
        '
        'colEndereço
        '
        Me.colEndereço.DataPropertyName = "Endereço"
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.colEndereço.DefaultCellStyle = DataGridViewCellStyle5
        Me.colEndereço.HeaderText = "Endereço"
        Me.colEndereço.Name = "colEndereço"
        Me.colEndereço.ReadOnly = True
        Me.colEndereço.Width = 274
        '
        'colBairro
        '
        Me.colBairro.DataPropertyName = "Bairro"
        Me.colBairro.HeaderText = "Bairro"
        Me.colBairro.Name = "colBairro"
        Me.colBairro.ReadOnly = True
        Me.colBairro.Width = 115
        '
        'colTelefone
        '
        Me.colTelefone.DataPropertyName = "Telefone"
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.colTelefone.DefaultCellStyle = DataGridViewCellStyle6
        Me.colTelefone.HeaderText = "Telefone"
        Me.colTelefone.Name = "colTelefone"
        Me.colTelefone.ReadOnly = True
        Me.colTelefone.Width = 192
        '
        'colAniv
        '
        Me.colAniv.DataPropertyName = "Aniv"
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle7.Format = "d"
        Me.colAniv.DefaultCellStyle = DataGridViewCellStyle7
        Me.colAniv.HeaderText = "Aniversário"
        Me.colAniv.Name = "colAniv"
        Me.colAniv.ReadOnly = True
        Me.colAniv.Width = 80
        '
        'colImp
        '
        Me.colImp.DataPropertyName = "Imp"
        Me.colImp.HeaderText = "Etiquetas"
        Me.colImp.Name = "colImp"
        Me.colImp.Width = 64
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.lblPosicao})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 700)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(1338, 22)
        Me.StatusStrip1.SizingGrip = False
        Me.StatusStrip1.TabIndex = 3
        '
        'lblPosicao
        '
        Me.lblPosicao.Name = "lblPosicao"
        Me.lblPosicao.Size = New System.Drawing.Size(30, 17)
        Me.lblPosicao.Text = "0 / 0"
        '
        'ttAjuda
        '
        Me.ttAjuda.AutoPopDelay = 15000
        Me.ttAjuda.InitialDelay = 300
        Me.ttAjuda.ReshowDelay = 100
        Me.ttAjuda.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Warning
        Me.ttAjuda.ToolTipTitle = "ATENÇÃO"
        '
        'tmrPesquisa
        '
        Me.tmrPesquisa.Interval = 400
        '
        'DsPrincipal
        '
        Me.DsPrincipal.DataSetName = "dsPrincipal"
        Me.DsPrincipal.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ClientesBindingSource
        '
        Me.ClientesBindingSource.DataMember = "Clientes"
        Me.ClientesBindingSource.DataSource = Me.DsPrincipal
        Me.ClientesBindingSource.Sort = "Nome, Cliente"
        '
        'ClientesTableAdapter
        '
        Me.ClientesTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager._1TabPeçasTableAdapter = Nothing
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.cboClientesTableAdapter = Nothing
        Me.TableAdapterManager.cboVendedorasTableAdapter = Nothing
        Me.TableAdapterManager.Clientes1TableAdapter = Nothing
        Me.TableAdapterManager.ClientesTableAdapter = Me.ClientesTableAdapter
        Me.TableAdapterManager.UpdateOrder = Pepe.DataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.Vencto_CartãoTableAdapter = Nothing
        Me.TableAdapterManager.Vencto_ChequesTableAdapter = Nothing
        Me.TableAdapterManager.VENDAS_DETTableAdapter = Nothing
        Me.TableAdapterManager.VendasDetTableAdapter = Nothing
        Me.TableAdapterManager.VENDASTableAdapter = Nothing
        '
        'ClientesBindingSource1
        '
        Me.ClientesBindingSource1.DataMember = "Clientes"
        Me.ClientesBindingSource1.DataSource = Me.DsNovo
        Me.ClientesBindingSource1.Sort = "Nome, Cliente"
        '
        'DsNovo
        '
        Me.DsNovo.DataSetName = "dsNovo"
        Me.DsNovo.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ClientesTableAdapter1
        '
        Me.ClientesTableAdapter1.ClearBeforeFill = True
        '
        'TableAdapterManager1
        '
        Me.TableAdapterManager1._1TabPeçasTableAdapter = Nothing
        Me.TableAdapterManager1.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager1.cboClientesTableAdapter = Nothing
        Me.TableAdapterManager1.cboVendedorasTableAdapter = Nothing
        Me.TableAdapterManager1.Clientes1TableAdapter = Nothing
        Me.TableAdapterManager1.ClientesTableAdapter = Me.ClientesTableAdapter1
        Me.TableAdapterManager1.UpdateOrder = Pepe.dsNovoTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager1.Vencto_CartãoTableAdapter = Nothing
        Me.TableAdapterManager1.Vencto_ChequesTableAdapter = Nothing
        Me.TableAdapterManager1.VENDAS_DETTableAdapter = Nothing
        Me.TableAdapterManager1.VendasDetTableAdapter = Nothing
        Me.TableAdapterManager1.VENDASTableAdapter = Nothing
        '
        'frmClientesDG
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1338, 722)
        Me.Controls.Add(Me.dgvClientes)
        Me.Controls.Add(Me.pnlTopo)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.tsMenu)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frmClientesDG"
        Me.ShowIcon = False
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "PEPE TORRAS DESIGN"
        Me.tsMenu.ResumeLayout(False)
        Me.tsMenu.PerformLayout()
        Me.pnlTopo.ResumeLayout(False)
        Me.pnlTopo.PerformLayout()
        CType(Me.picAjuda, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvClientes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        CType(Me.DsPrincipal, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ClientesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ClientesBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsNovo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region

    Friend WithEvents tsMenu As System.Windows.Forms.ToolStrip
    Friend WithEvents btnNovo As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents btnEtiqMalaDireta As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnEtiqAniv As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnEmails As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnEndereços As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnTelefones As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnFechar As System.Windows.Forms.ToolStripButton
    Friend WithEvents pnlTopo As System.Windows.Forms.Panel
    Friend WithEvents txtPesquisa As System.Windows.Forms.TextBox
    Friend WithEvents lblTitulo As System.Windows.Forms.Label
    Friend WithEvents picAjuda As System.Windows.Forms.PictureBox
    Friend WithEvents ckTodas As System.Windows.Forms.CheckBox
    Friend WithEvents dgvClientes As System.Windows.Forms.DataGridView
    Friend WithEvents colAbrir As System.Windows.Forms.DataGridViewImageColumn
    Friend WithEvents colVenda As System.Windows.Forms.DataGridViewImageColumn
    Friend WithEvents colTítulo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colNome As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colCliente As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colEndereço As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colBairro As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colTelefone As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colAniv As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colImp As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents lblPosicao As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents ttAjuda As System.Windows.Forms.ToolTip
    Friend WithEvents tmrPesquisa As System.Windows.Forms.Timer
    Friend WithEvents DsPrincipal As Pepe.DataSet1
    Friend WithEvents ClientesBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ClientesTableAdapter As Pepe.DataSet1TableAdapters.ClientesTableAdapter
    Friend WithEvents TableAdapterManager As Pepe.DataSet1TableAdapters.TableAdapterManager
    Friend WithEvents ClientesBindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents DsNovo As Pepe.dsNovo
    Friend WithEvents ClientesTableAdapter1 As Pepe.dsNovoTableAdapters.ClientesTableAdapter
    Friend WithEvents TableAdapterManager1 As Pepe.dsNovoTableAdapters.TableAdapterManager
End Class
