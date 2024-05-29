<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class EmployeeMod
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(EmployeeMod))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.EmployeeIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FirstNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LastNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AddressDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ContactDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GenderDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.OutletDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PositionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AcctUsernameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EmployeeQueryBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.POS_databaseDataSet = New POS_Project.POS_databaseDataSet()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.btnAll = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cmbSearchBy = New System.Windows.Forms.ComboBox()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.txtSearch = New System.Windows.Forms.TextBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.EmployeeQueryTableAdapter = New POS_Project.POS_databaseDataSetTableAdapters.EmployeeQueryTableAdapter()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.txtuserappear = New System.Windows.Forms.TextBox()
        Me.lblPosition = New System.Windows.Forms.Label()
        Me.lblOutlet = New System.Windows.Forms.Label()
        Me.lblGender = New System.Windows.Forms.Label()
        Me.lblContact = New System.Windows.Forms.Label()
        Me.lblAddress = New System.Windows.Forms.Label()
        Me.lblLName = New System.Windows.Forms.Label()
        Me.lblFName = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.pbEmployee = New System.Windows.Forms.PictureBox()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.txtIDNum = New System.Windows.Forms.TextBox()
        Me.Label29 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.Label26 = New System.Windows.Forms.Label()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmployeeQueryBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.POS_databaseDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        CType(Me.pbEmployee, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(5, 12)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(246, 42)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Employee List"
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToOrderColumns = True
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(117, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(125, Byte), Integer))
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.EmployeeIDDataGridViewTextBoxColumn, Me.FirstNameDataGridViewTextBoxColumn, Me.LastNameDataGridViewTextBoxColumn, Me.AddressDataGridViewTextBoxColumn, Me.ContactDataGridViewTextBoxColumn, Me.GenderDataGridViewTextBoxColumn, Me.OutletDataGridViewTextBoxColumn, Me.PositionDataGridViewTextBoxColumn, Me.AcctUsernameDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.EmployeeQueryBindingSource
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.MintCream
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridView1.DefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridView1.Location = New System.Drawing.Point(26, 173)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(544, 260)
        Me.DataGridView1.TabIndex = 25
        '
        'EmployeeIDDataGridViewTextBoxColumn
        '
        Me.EmployeeIDDataGridViewTextBoxColumn.DataPropertyName = "EmployeeID"
        Me.EmployeeIDDataGridViewTextBoxColumn.HeaderText = "EmployeeID"
        Me.EmployeeIDDataGridViewTextBoxColumn.Name = "EmployeeIDDataGridViewTextBoxColumn"
        '
        'FirstNameDataGridViewTextBoxColumn
        '
        Me.FirstNameDataGridViewTextBoxColumn.DataPropertyName = "FirstName"
        Me.FirstNameDataGridViewTextBoxColumn.HeaderText = "FirstName"
        Me.FirstNameDataGridViewTextBoxColumn.Name = "FirstNameDataGridViewTextBoxColumn"
        '
        'LastNameDataGridViewTextBoxColumn
        '
        Me.LastNameDataGridViewTextBoxColumn.DataPropertyName = "LastName"
        Me.LastNameDataGridViewTextBoxColumn.HeaderText = "LastName"
        Me.LastNameDataGridViewTextBoxColumn.Name = "LastNameDataGridViewTextBoxColumn"
        '
        'AddressDataGridViewTextBoxColumn
        '
        Me.AddressDataGridViewTextBoxColumn.DataPropertyName = "Address"
        Me.AddressDataGridViewTextBoxColumn.HeaderText = "Address"
        Me.AddressDataGridViewTextBoxColumn.Name = "AddressDataGridViewTextBoxColumn"
        '
        'ContactDataGridViewTextBoxColumn
        '
        Me.ContactDataGridViewTextBoxColumn.DataPropertyName = "Contact"
        Me.ContactDataGridViewTextBoxColumn.HeaderText = "Contact"
        Me.ContactDataGridViewTextBoxColumn.Name = "ContactDataGridViewTextBoxColumn"
        '
        'GenderDataGridViewTextBoxColumn
        '
        Me.GenderDataGridViewTextBoxColumn.DataPropertyName = "Gender"
        Me.GenderDataGridViewTextBoxColumn.HeaderText = "Gender"
        Me.GenderDataGridViewTextBoxColumn.Name = "GenderDataGridViewTextBoxColumn"
        '
        'OutletDataGridViewTextBoxColumn
        '
        Me.OutletDataGridViewTextBoxColumn.DataPropertyName = "Outlet"
        Me.OutletDataGridViewTextBoxColumn.HeaderText = "Outlet"
        Me.OutletDataGridViewTextBoxColumn.Name = "OutletDataGridViewTextBoxColumn"
        '
        'PositionDataGridViewTextBoxColumn
        '
        Me.PositionDataGridViewTextBoxColumn.DataPropertyName = "Position"
        Me.PositionDataGridViewTextBoxColumn.HeaderText = "Position"
        Me.PositionDataGridViewTextBoxColumn.Name = "PositionDataGridViewTextBoxColumn"
        '
        'AcctUsernameDataGridViewTextBoxColumn
        '
        Me.AcctUsernameDataGridViewTextBoxColumn.DataPropertyName = "AcctUsername"
        Me.AcctUsernameDataGridViewTextBoxColumn.HeaderText = "AcctUsername"
        Me.AcctUsernameDataGridViewTextBoxColumn.Name = "AcctUsernameDataGridViewTextBoxColumn"
        '
        'EmployeeQueryBindingSource
        '
        Me.EmployeeQueryBindingSource.DataMember = "EmployeeQuery"
        Me.EmployeeQueryBindingSource.DataSource = Me.POS_databaseDataSet
        '
        'POS_databaseDataSet
        '
        Me.POS_databaseDataSet.DataSetName = "POS_databaseDataSet"
        Me.POS_databaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(91, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.Panel2.Controls.Add(Me.btnAll)
        Me.Panel2.Location = New System.Drawing.Point(395, 82)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(175, 61)
        Me.Panel2.TabIndex = 28
        '
        'btnAll
        '
        Me.btnAll.BackColor = System.Drawing.Color.FromArgb(CType(CType(185, Byte), Integer), CType(CType(220, Byte), Integer), CType(CType(180, Byte), Integer))
        Me.btnAll.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAll.Location = New System.Drawing.Point(9, 10)
        Me.btnAll.Name = "btnAll"
        Me.btnAll.Size = New System.Drawing.Size(154, 41)
        Me.btnAll.TabIndex = 21
        Me.btnAll.Text = "Show All Item(s)"
        Me.btnAll.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(203, Byte), Integer), CType(CType(217, Byte), Integer), CType(CType(166, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.cmbSearchBy)
        Me.Panel1.Controls.Add(Me.btnSearch)
        Me.Panel1.Controls.Add(Me.txtSearch)
        Me.Panel1.Location = New System.Drawing.Point(26, 70)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(354, 86)
        Me.Panel1.TabIndex = 27
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(27, 22)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(64, 16)
        Me.Label2.TabIndex = 18
        Me.Label2.Text = "Search By:"
        '
        'cmbSearchBy
        '
        Me.cmbSearchBy.FormattingEnabled = True
        Me.cmbSearchBy.Items.AddRange(New Object() {"EmployeeID", "FirstName", "LastName", "Gender", "Outlet", "Position"})
        Me.cmbSearchBy.Location = New System.Drawing.Point(97, 21)
        Me.cmbSearchBy.Name = "cmbSearchBy"
        Me.cmbSearchBy.Size = New System.Drawing.Size(116, 21)
        Me.cmbSearchBy.TabIndex = 17
        '
        'btnSearch
        '
        Me.btnSearch.BackColor = System.Drawing.Color.FromArgb(CType(CType(117, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(125, Byte), Integer))
        Me.btnSearch.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSearch.Image = CType(resources.GetObject("btnSearch.Image"), System.Drawing.Image)
        Me.btnSearch.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnSearch.Location = New System.Drawing.Point(230, 21)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(110, 47)
        Me.btnSearch.TabIndex = 4
        Me.btnSearch.Text = "Search"
        Me.btnSearch.UseVisualStyleBackColor = False
        '
        'txtSearch
        '
        Me.txtSearch.Location = New System.Drawing.Point(14, 48)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(199, 20)
        Me.txtSearch.TabIndex = 16
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(241, 8)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(100, 50)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 29
        Me.PictureBox1.TabStop = False
        '
        'EmployeeQueryTableAdapter
        '
        Me.EmployeeQueryTableAdapter.ClearBeforeFill = True
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(145, Byte), Integer), CType(CType(132, Byte), Integer))
        Me.Panel3.Controls.Add(Me.txtuserappear)
        Me.Panel3.Controls.Add(Me.lblPosition)
        Me.Panel3.Controls.Add(Me.lblOutlet)
        Me.Panel3.Controls.Add(Me.lblGender)
        Me.Panel3.Controls.Add(Me.lblContact)
        Me.Panel3.Controls.Add(Me.lblAddress)
        Me.Panel3.Controls.Add(Me.lblLName)
        Me.Panel3.Controls.Add(Me.lblFName)
        Me.Panel3.Controls.Add(Me.Label18)
        Me.Panel3.Controls.Add(Me.pbEmployee)
        Me.Panel3.Controls.Add(Me.Label27)
        Me.Panel3.Controls.Add(Me.Label28)
        Me.Panel3.Controls.Add(Me.txtIDNum)
        Me.Panel3.Controls.Add(Me.Label29)
        Me.Panel3.Controls.Add(Me.Label16)
        Me.Panel3.Controls.Add(Me.Label20)
        Me.Panel3.Controls.Add(Me.Label24)
        Me.Panel3.Controls.Add(Me.Label26)
        Me.Panel3.Location = New System.Drawing.Point(580, 12)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(372, 421)
        Me.Panel3.TabIndex = 58
        '
        'txtuserappear
        '
        Me.txtuserappear.BackColor = System.Drawing.Color.Honeydew
        Me.txtuserappear.Location = New System.Drawing.Point(139, 393)
        Me.txtuserappear.Name = "txtuserappear"
        Me.txtuserappear.ReadOnly = True
        Me.txtuserappear.Size = New System.Drawing.Size(166, 20)
        Me.txtuserappear.TabIndex = 82
        '
        'lblPosition
        '
        Me.lblPosition.AutoSize = True
        Me.lblPosition.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPosition.ForeColor = System.Drawing.Color.FromArgb(CType(CType(185, Byte), Integer), CType(CType(220, Byte), Integer), CType(CType(180, Byte), Integer))
        Me.lblPosition.Location = New System.Drawing.Point(68, 337)
        Me.lblPosition.Name = "lblPosition"
        Me.lblPosition.Size = New System.Drawing.Size(15, 17)
        Me.lblPosition.TabIndex = 79
        Me.lblPosition.Text = "_"
        '
        'lblOutlet
        '
        Me.lblOutlet.AutoSize = True
        Me.lblOutlet.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOutlet.ForeColor = System.Drawing.Color.FromArgb(CType(CType(185, Byte), Integer), CType(CType(220, Byte), Integer), CType(CType(180, Byte), Integer))
        Me.lblOutlet.Location = New System.Drawing.Point(58, 301)
        Me.lblOutlet.Name = "lblOutlet"
        Me.lblOutlet.Size = New System.Drawing.Size(15, 17)
        Me.lblOutlet.TabIndex = 78
        Me.lblOutlet.Text = "_"
        '
        'lblGender
        '
        Me.lblGender.AutoSize = True
        Me.lblGender.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGender.ForeColor = System.Drawing.Color.FromArgb(CType(CType(185, Byte), Integer), CType(CType(220, Byte), Integer), CType(CType(180, Byte), Integer))
        Me.lblGender.Location = New System.Drawing.Point(68, 265)
        Me.lblGender.Name = "lblGender"
        Me.lblGender.Size = New System.Drawing.Size(15, 17)
        Me.lblGender.TabIndex = 77
        Me.lblGender.Text = "_"
        '
        'lblContact
        '
        Me.lblContact.AutoSize = True
        Me.lblContact.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblContact.ForeColor = System.Drawing.Color.FromArgb(CType(CType(185, Byte), Integer), CType(CType(220, Byte), Integer), CType(CType(180, Byte), Integer))
        Me.lblContact.Location = New System.Drawing.Point(70, 229)
        Me.lblContact.Name = "lblContact"
        Me.lblContact.Size = New System.Drawing.Size(15, 17)
        Me.lblContact.TabIndex = 75
        Me.lblContact.Text = "_"
        '
        'lblAddress
        '
        Me.lblAddress.AutoSize = True
        Me.lblAddress.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAddress.ForeColor = System.Drawing.Color.FromArgb(CType(CType(185, Byte), Integer), CType(CType(220, Byte), Integer), CType(CType(180, Byte), Integer))
        Me.lblAddress.Location = New System.Drawing.Point(70, 193)
        Me.lblAddress.Name = "lblAddress"
        Me.lblAddress.Size = New System.Drawing.Size(15, 17)
        Me.lblAddress.TabIndex = 74
        Me.lblAddress.Text = "_"
        '
        'lblLName
        '
        Me.lblLName.AutoSize = True
        Me.lblLName.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLName.ForeColor = System.Drawing.Color.FromArgb(CType(CType(185, Byte), Integer), CType(CType(220, Byte), Integer), CType(CType(180, Byte), Integer))
        Me.lblLName.Location = New System.Drawing.Point(138, 157)
        Me.lblLName.Name = "lblLName"
        Me.lblLName.Size = New System.Drawing.Size(15, 17)
        Me.lblLName.TabIndex = 73
        Me.lblLName.Text = "_"
        '
        'lblFName
        '
        Me.lblFName.AutoSize = True
        Me.lblFName.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFName.ForeColor = System.Drawing.Color.FromArgb(CType(CType(185, Byte), Integer), CType(CType(220, Byte), Integer), CType(CType(180, Byte), Integer))
        Me.lblFName.Location = New System.Drawing.Point(56, 157)
        Me.lblFName.Name = "lblFName"
        Me.lblFName.Size = New System.Drawing.Size(15, 17)
        Me.lblFName.TabIndex = 71
        Me.lblFName.Text = "_"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.ForeColor = System.Drawing.Color.FromArgb(CType(CType(185, Byte), Integer), CType(CType(220, Byte), Integer), CType(CType(180, Byte), Integer))
        Me.Label18.Location = New System.Drawing.Point(3, 397)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(130, 16)
        Me.Label18.TabIndex = 66
        Me.Label18.Text = "Account Username"
        '
        'pbEmployee
        '
        Me.pbEmployee.BackColor = System.Drawing.Color.Honeydew
        Me.pbEmployee.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pbEmployee.Location = New System.Drawing.Point(127, 29)
        Me.pbEmployee.Name = "pbEmployee"
        Me.pbEmployee.Size = New System.Drawing.Size(120, 120)
        Me.pbEmployee.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pbEmployee.TabIndex = 60
        Me.pbEmployee.TabStop = False
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label27.ForeColor = System.Drawing.Color.FromArgb(CType(CType(185, Byte), Integer), CType(CType(220, Byte), Integer), CType(CType(180, Byte), Integer))
        Me.Label27.Location = New System.Drawing.Point(3, 158)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(47, 16)
        Me.Label27.TabIndex = 59
        Me.Label27.Text = "Name"
        '
        'Label28
        '
        Me.Label28.AutoSize = True
        Me.Label28.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label28.ForeColor = System.Drawing.Color.FromArgb(CType(CType(185, Byte), Integer), CType(CType(220, Byte), Integer), CType(CType(180, Byte), Integer))
        Me.Label28.Location = New System.Drawing.Point(3, 194)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(61, 16)
        Me.Label28.TabIndex = 60
        Me.Label28.Text = "Address"
        '
        'txtIDNum
        '
        Me.txtIDNum.BackColor = System.Drawing.Color.Honeydew
        Me.txtIDNum.Location = New System.Drawing.Point(230, 3)
        Me.txtIDNum.Name = "txtIDNum"
        Me.txtIDNum.ReadOnly = True
        Me.txtIDNum.Size = New System.Drawing.Size(64, 20)
        Me.txtIDNum.TabIndex = 59
        '
        'Label29
        '
        Me.Label29.AutoSize = True
        Me.Label29.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label29.ForeColor = System.Drawing.Color.FromArgb(CType(CType(185, Byte), Integer), CType(CType(220, Byte), Integer), CType(CType(180, Byte), Integer))
        Me.Label29.Location = New System.Drawing.Point(5, 338)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(57, 16)
        Me.Label29.TabIndex = 61
        Me.Label29.Text = "Position"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.Color.FromArgb(CType(CType(185, Byte), Integer), CType(CType(220, Byte), Integer), CType(CType(180, Byte), Integer))
        Me.Label16.Location = New System.Drawing.Point(83, 3)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(146, 18)
        Me.Label16.TabIndex = 58
        Me.Label16.Text = "Employee ID: EMP-"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.ForeColor = System.Drawing.Color.FromArgb(CType(CType(185, Byte), Integer), CType(CType(220, Byte), Integer), CType(CType(180, Byte), Integer))
        Me.Label20.Location = New System.Drawing.Point(5, 230)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(59, 16)
        Me.Label20.TabIndex = 58
        Me.Label20.Text = "Contact"
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label24.ForeColor = System.Drawing.Color.FromArgb(CType(CType(185, Byte), Integer), CType(CType(220, Byte), Integer), CType(CType(180, Byte), Integer))
        Me.Label24.Location = New System.Drawing.Point(5, 266)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(57, 16)
        Me.Label24.TabIndex = 64
        Me.Label24.Text = "Gender"
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label26.ForeColor = System.Drawing.Color.FromArgb(CType(CType(185, Byte), Integer), CType(CType(220, Byte), Integer), CType(CType(180, Byte), Integer))
        Me.Label26.Location = New System.Drawing.Point(5, 302)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(47, 16)
        Me.Label26.TabIndex = 62
        Me.Label26.Text = "Outlet"
        '
        'EmployeeMod
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightGreen
        Me.ClientSize = New System.Drawing.Size(973, 451)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Label1)
        Me.Name = "EmployeeMod"
        Me.Text = "EmployeeMod"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmployeeQueryBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.POS_databaseDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        CType(Me.pbEmployee, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Panel2 As Panel
    Friend WithEvents btnAll As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnSearch As Button
    Friend WithEvents txtSearch As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents cmbSearchBy As ComboBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents POS_databaseDataSet As POS_databaseDataSet
    Friend WithEvents EmployeeQueryBindingSource As BindingSource
    Friend WithEvents EmployeeQueryTableAdapter As POS_databaseDataSetTableAdapters.EmployeeQueryTableAdapter
    Friend WithEvents EmployeeIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FirstNameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents LastNameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents AddressDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ContactDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents GenderDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents OutletDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PositionDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents AcctUsernameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Panel3 As Panel
    Friend WithEvents txtuserappear As TextBox
    Friend WithEvents lblPosition As Label
    Friend WithEvents lblOutlet As Label
    Friend WithEvents lblGender As Label
    Friend WithEvents lblContact As Label
    Friend WithEvents lblAddress As Label
    Friend WithEvents lblLName As Label
    Friend WithEvents lblFName As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents pbEmployee As PictureBox
    Friend WithEvents Label27 As Label
    Friend WithEvents Label28 As Label
    Friend WithEvents txtIDNum As TextBox
    Friend WithEvents Label29 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents Label20 As Label
    Friend WithEvents Label24 As Label
    Friend WithEvents Label26 As Label
End Class
