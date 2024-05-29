<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FileMaintenanceMod
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FileMaintenanceMod))
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtAddress = New System.Windows.Forms.TextBox()
        Me.TblFileMaintenanceBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.POS_databaseDataSet3 = New POS_Project.POS_databaseDataSet3()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtFirstName = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.EmployeeIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FirstNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LastNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MiddleNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AddressDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ContactDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BirthdayDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GenderDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.OutletDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PositionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MaritalStatusDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EmploymentStatusDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AcctUsernameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AcctPasswordDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PhotoDirectoryDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.txtSearch = New System.Windows.Forms.TextBox()
        Me.btnEdit = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.btnAll = New System.Windows.Forms.Button()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnUpload = New System.Windows.Forms.Button()
        Me.txtAcctPass = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.txtAcctUser = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.cmbMaritalStat = New System.Windows.Forms.ComboBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txtContact = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtMiddleName = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtLastName = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.dtpBirthday = New System.Windows.Forms.DateTimePicker()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cmbGender = New System.Windows.Forms.ComboBox()
        Me.cmbEmploymentStat = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.cmbOutlet = New System.Windows.Forms.ComboBox()
        Me.cmbPosition = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblDate = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.txtpassappear = New System.Windows.Forms.TextBox()
        Me.txtuserappear = New System.Windows.Forms.TextBox()
        Me.lblEmpStat = New System.Windows.Forms.Label()
        Me.lblMaritStat = New System.Windows.Forms.Label()
        Me.lblPosition = New System.Windows.Forms.Label()
        Me.lblOutlet = New System.Windows.Forms.Label()
        Me.lblGender = New System.Windows.Forms.Label()
        Me.lblBirthday = New System.Windows.Forms.Label()
        Me.lblContact = New System.Windows.Forms.Label()
        Me.lblAddress = New System.Windows.Forms.Label()
        Me.lblLName = New System.Windows.Forms.Label()
        Me.lblMName = New System.Windows.Forms.Label()
        Me.lblFName = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.pbEmployee = New System.Windows.Forms.PictureBox()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.txtIDNum = New System.Windows.Forms.TextBox()
        Me.Label29 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.OpenFD = New System.Windows.Forms.OpenFileDialog()
        Me.TblFileMaintenanceTableAdapter = New POS_Project.POS_databaseDataSet3TableAdapters.tblFileMaintenanceTableAdapter()
        CType(Me.TblFileMaintenanceBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.POS_databaseDataSet3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        CType(Me.pbEmployee, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(3, 18)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(62, 16)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "First Name"
        '
        'txtAddress
        '
        Me.txtAddress.Location = New System.Drawing.Point(54, 40)
        Me.txtAddress.Name = "txtAddress"
        Me.txtAddress.Size = New System.Drawing.Size(326, 19)
        Me.txtAddress.TabIndex = 17
        '
        'TblFileMaintenanceBindingSource
        '
        Me.TblFileMaintenanceBindingSource.DataMember = "tblFileMaintenance"
        Me.TblFileMaintenanceBindingSource.DataSource = Me.POS_databaseDataSet3
        '
        'POS_databaseDataSet3
        '
        Me.POS_databaseDataSet3.DataSetName = "POS_databaseDataSet3"
        Me.POS_databaseDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(3, 42)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(49, 16)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "Address"
        '
        'txtFirstName
        '
        Me.txtFirstName.Location = New System.Drawing.Point(66, 14)
        Me.txtFirstName.Name = "txtFirstName"
        Me.txtFirstName.Size = New System.Drawing.Size(158, 19)
        Me.txtFirstName.TabIndex = 16
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label7.Location = New System.Drawing.Point(3, 96)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(48, 16)
        Me.Label7.TabIndex = 13
        Me.Label7.Text = "Position"
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(117, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(125, Byte), Integer))
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.EmployeeIDDataGridViewTextBoxColumn, Me.FirstNameDataGridViewTextBoxColumn, Me.LastNameDataGridViewTextBoxColumn, Me.MiddleNameDataGridViewTextBoxColumn, Me.AddressDataGridViewTextBoxColumn, Me.ContactDataGridViewTextBoxColumn, Me.BirthdayDataGridViewTextBoxColumn, Me.GenderDataGridViewTextBoxColumn, Me.OutletDataGridViewTextBoxColumn, Me.PositionDataGridViewTextBoxColumn, Me.MaritalStatusDataGridViewTextBoxColumn, Me.EmploymentStatusDataGridViewTextBoxColumn, Me.AcctUsernameDataGridViewTextBoxColumn, Me.AcctPasswordDataGridViewTextBoxColumn, Me.PhotoDirectoryDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.TblFileMaintenanceBindingSource
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.Azure
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridView1.DefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridView1.Location = New System.Drawing.Point(18, 212)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(643, 312)
        Me.DataGridView1.TabIndex = 32
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
        'MiddleNameDataGridViewTextBoxColumn
        '
        Me.MiddleNameDataGridViewTextBoxColumn.DataPropertyName = "MiddleName"
        Me.MiddleNameDataGridViewTextBoxColumn.HeaderText = "MiddleName"
        Me.MiddleNameDataGridViewTextBoxColumn.Name = "MiddleNameDataGridViewTextBoxColumn"
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
        'BirthdayDataGridViewTextBoxColumn
        '
        Me.BirthdayDataGridViewTextBoxColumn.DataPropertyName = "Birthday"
        Me.BirthdayDataGridViewTextBoxColumn.HeaderText = "Birthday"
        Me.BirthdayDataGridViewTextBoxColumn.Name = "BirthdayDataGridViewTextBoxColumn"
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
        'MaritalStatusDataGridViewTextBoxColumn
        '
        Me.MaritalStatusDataGridViewTextBoxColumn.DataPropertyName = "MaritalStatus"
        Me.MaritalStatusDataGridViewTextBoxColumn.HeaderText = "MaritalStatus"
        Me.MaritalStatusDataGridViewTextBoxColumn.Name = "MaritalStatusDataGridViewTextBoxColumn"
        '
        'EmploymentStatusDataGridViewTextBoxColumn
        '
        Me.EmploymentStatusDataGridViewTextBoxColumn.DataPropertyName = "EmploymentStatus"
        Me.EmploymentStatusDataGridViewTextBoxColumn.HeaderText = "EmploymentStatus"
        Me.EmploymentStatusDataGridViewTextBoxColumn.Name = "EmploymentStatusDataGridViewTextBoxColumn"
        '
        'AcctUsernameDataGridViewTextBoxColumn
        '
        Me.AcctUsernameDataGridViewTextBoxColumn.DataPropertyName = "AcctUsername"
        Me.AcctUsernameDataGridViewTextBoxColumn.HeaderText = "AcctUsername"
        Me.AcctUsernameDataGridViewTextBoxColumn.Name = "AcctUsernameDataGridViewTextBoxColumn"
        '
        'AcctPasswordDataGridViewTextBoxColumn
        '
        Me.AcctPasswordDataGridViewTextBoxColumn.DataPropertyName = "AcctPassword"
        Me.AcctPasswordDataGridViewTextBoxColumn.HeaderText = "AcctPassword"
        Me.AcctPasswordDataGridViewTextBoxColumn.Name = "AcctPasswordDataGridViewTextBoxColumn"
        '
        'PhotoDirectoryDataGridViewTextBoxColumn
        '
        Me.PhotoDirectoryDataGridViewTextBoxColumn.DataPropertyName = "PhotoDirectory"
        Me.PhotoDirectoryDataGridViewTextBoxColumn.HeaderText = "PhotoDirectory"
        Me.PhotoDirectoryDataGridViewTextBoxColumn.Name = "PhotoDirectoryDataGridViewTextBoxColumn"
        '
        'btnSearch
        '
        Me.btnSearch.BackColor = System.Drawing.Color.MediumAquamarine
        Me.btnSearch.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSearch.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSearch.ForeColor = System.Drawing.Color.Black
        Me.btnSearch.Image = CType(resources.GetObject("btnSearch.Image"), System.Drawing.Image)
        Me.btnSearch.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnSearch.Location = New System.Drawing.Point(9, 281)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(110, 31)
        Me.btnSearch.TabIndex = 4
        Me.btnSearch.Text = "Search"
        Me.btnSearch.UseVisualStyleBackColor = False
        '
        'btnAdd
        '
        Me.btnAdd.BackColor = System.Drawing.Color.ForestGreen
        Me.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAdd.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdd.ForeColor = System.Drawing.Color.Black
        Me.btnAdd.Image = CType(resources.GetObject("btnAdd.Image"), System.Drawing.Image)
        Me.btnAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnAdd.Location = New System.Drawing.Point(9, 101)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(110, 31)
        Me.btnAdd.TabIndex = 0
        Me.btnAdd.Text = "Add"
        Me.btnAdd.UseVisualStyleBackColor = False
        '
        'btnDelete
        '
        Me.btnDelete.BackColor = System.Drawing.Color.DarkSeaGreen
        Me.btnDelete.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnDelete.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDelete.ForeColor = System.Drawing.Color.Black
        Me.btnDelete.Image = CType(resources.GetObject("btnDelete.Image"), System.Drawing.Image)
        Me.btnDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnDelete.Location = New System.Drawing.Point(9, 191)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(110, 31)
        Me.btnDelete.TabIndex = 1
        Me.btnDelete.Text = "Delete"
        Me.btnDelete.UseVisualStyleBackColor = False
        '
        'txtSearch
        '
        Me.txtSearch.Location = New System.Drawing.Point(9, 326)
        Me.txtSearch.Multiline = True
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(110, 20)
        Me.txtSearch.TabIndex = 5
        Me.txtSearch.Tag = ""
        '
        'btnEdit
        '
        Me.btnEdit.BackColor = System.Drawing.Color.PaleGreen
        Me.btnEdit.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnEdit.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEdit.ForeColor = System.Drawing.Color.Black
        Me.btnEdit.Image = CType(resources.GetObject("btnEdit.Image"), System.Drawing.Image)
        Me.btnEdit.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnEdit.Location = New System.Drawing.Point(9, 146)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(110, 31)
        Me.btnEdit.TabIndex = 2
        Me.btnEdit.Text = "Edit"
        Me.btnEdit.UseVisualStyleBackColor = False
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(117, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(125, Byte), Integer))
        Me.Panel2.Controls.Add(Me.btnAll)
        Me.Panel2.Controls.Add(Me.txtSearch)
        Me.Panel2.Controls.Add(Me.Label11)
        Me.Panel2.Controls.Add(Me.btnSearch)
        Me.Panel2.Controls.Add(Me.btnClear)
        Me.Panel2.Controls.Add(Me.btnEdit)
        Me.Panel2.Controls.Add(Me.btnAdd)
        Me.Panel2.Controls.Add(Me.btnDelete)
        Me.Panel2.Location = New System.Drawing.Point(1045, 54)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(127, 470)
        Me.Panel2.TabIndex = 33
        '
        'btnAll
        '
        Me.btnAll.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(145, Byte), Integer), CType(CType(132, Byte), Integer))
        Me.btnAll.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAll.ForeColor = System.Drawing.Color.Honeydew
        Me.btnAll.Location = New System.Drawing.Point(9, 417)
        Me.btnAll.Name = "btnAll"
        Me.btnAll.Size = New System.Drawing.Size(110, 41)
        Me.btnAll.TabIndex = 58
        Me.btnAll.Text = "Show All Item(s)"
        Me.btnAll.UseVisualStyleBackColor = False
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Agency FB", 20.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(45, 3)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(75, 32)
        Me.Label11.TabIndex = 7
        Me.Label11.Text = "Options"
        '
        'btnClear
        '
        Me.btnClear.BackColor = System.Drawing.Color.MintCream
        Me.btnClear.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnClear.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.ForeColor = System.Drawing.Color.Black
        Me.btnClear.Image = CType(resources.GetObject("btnClear.Image"), System.Drawing.Image)
        Me.btnClear.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnClear.Location = New System.Drawing.Point(9, 236)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(110, 31)
        Me.btnClear.TabIndex = 6
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(203, Byte), Integer), CType(CType(217, Byte), Integer), CType(CType(166, Byte), Integer))
        Me.Panel1.Controls.Add(Me.btnUpload)
        Me.Panel1.Controls.Add(Me.txtAcctPass)
        Me.Panel1.Controls.Add(Me.Label15)
        Me.Panel1.Controls.Add(Me.txtAcctUser)
        Me.Panel1.Controls.Add(Me.Label14)
        Me.Panel1.Controls.Add(Me.cmbMaritalStat)
        Me.Panel1.Controls.Add(Me.Label13)
        Me.Panel1.Controls.Add(Me.txtContact)
        Me.Panel1.Controls.Add(Me.Label12)
        Me.Panel1.Controls.Add(Me.txtMiddleName)
        Me.Panel1.Controls.Add(Me.Label10)
        Me.Panel1.Controls.Add(Me.txtLastName)
        Me.Panel1.Controls.Add(Me.Label9)
        Me.Panel1.Controls.Add(Me.dtpBirthday)
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.cmbGender)
        Me.Panel1.Controls.Add(Me.cmbEmploymentStat)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.cmbOutlet)
        Me.Panel1.Controls.Add(Me.cmbPosition)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.txtAddress)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.txtFirstName)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Font = New System.Drawing.Font("Century Gothic", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel1.Location = New System.Drawing.Point(18, 54)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(643, 152)
        Me.Panel1.TabIndex = 31
        '
        'btnUpload
        '
        Me.btnUpload.BackColor = System.Drawing.Color.FromArgb(CType(CType(117, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(125, Byte), Integer))
        Me.btnUpload.Font = New System.Drawing.Font("Century Gothic", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUpload.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnUpload.Location = New System.Drawing.Point(487, 118)
        Me.btnUpload.Name = "btnUpload"
        Me.btnUpload.Size = New System.Drawing.Size(142, 29)
        Me.btnUpload.TabIndex = 82
        Me.btnUpload.Text = "Upload Employee Photo"
        Me.btnUpload.UseVisualStyleBackColor = False
        '
        'txtAcctPass
        '
        Me.txtAcctPass.Location = New System.Drawing.Point(352, 118)
        Me.txtAcctPass.Name = "txtAcctPass"
        Me.txtAcctPass.Size = New System.Drawing.Size(113, 19)
        Me.txtAcctPass.TabIndex = 55
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label15.Location = New System.Drawing.Point(238, 121)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(108, 16)
        Me.Label15.TabIndex = 54
        Me.Label15.Text = "Account Password"
        '
        'txtAcctUser
        '
        Me.txtAcctUser.Location = New System.Drawing.Point(120, 118)
        Me.txtAcctUser.Name = "txtAcctUser"
        Me.txtAcctUser.Size = New System.Drawing.Size(112, 19)
        Me.txtAcctUser.TabIndex = 53
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label14.Location = New System.Drawing.Point(3, 121)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(111, 16)
        Me.Label14.TabIndex = 45
        Me.Label14.Text = "Account Username"
        '
        'cmbMaritalStat
        '
        Me.cmbMaritalStat.FormattingEnabled = True
        Me.cmbMaritalStat.Items.AddRange(New Object() {"Single", "Married", "Separated", "Divorced", "Widowed"})
        Me.cmbMaritalStat.Location = New System.Drawing.Point(268, 92)
        Me.cmbMaritalStat.Name = "cmbMaritalStat"
        Me.cmbMaritalStat.Size = New System.Drawing.Size(110, 21)
        Me.cmbMaritalStat.TabIndex = 51
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label13.Location = New System.Drawing.Point(180, 96)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(82, 16)
        Me.Label13.TabIndex = 50
        Me.Label13.Text = "Marital Status"
        '
        'txtContact
        '
        Me.txtContact.Location = New System.Drawing.Point(446, 40)
        Me.txtContact.Name = "txtContact"
        Me.txtContact.Size = New System.Drawing.Size(169, 19)
        Me.txtContact.TabIndex = 45
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label12.Location = New System.Drawing.Point(386, 43)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(54, 16)
        Me.Label12.TabIndex = 8
        Me.Label12.Text = "Contact"
        '
        'txtMiddleName
        '
        Me.txtMiddleName.Location = New System.Drawing.Point(529, 14)
        Me.txtMiddleName.Name = "txtMiddleName"
        Me.txtMiddleName.Size = New System.Drawing.Size(108, 19)
        Me.txtMiddleName.TabIndex = 49
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label10.Location = New System.Drawing.Point(441, 18)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(82, 16)
        Me.Label10.TabIndex = 48
        Me.Label10.Text = "Middle Name"
        '
        'txtLastName
        '
        Me.txtLastName.Location = New System.Drawing.Point(294, 14)
        Me.txtLastName.Name = "txtLastName"
        Me.txtLastName.Size = New System.Drawing.Size(141, 19)
        Me.txtLastName.TabIndex = 47
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label9.Location = New System.Drawing.Point(230, 18)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(65, 16)
        Me.Label9.TabIndex = 46
        Me.Label9.Text = "Last Name"
        '
        'dtpBirthday
        '
        Me.dtpBirthday.CustomFormat = ""
        Me.dtpBirthday.Location = New System.Drawing.Point(54, 67)
        Me.dtpBirthday.Name = "dtpBirthday"
        Me.dtpBirthday.Size = New System.Drawing.Size(200, 19)
        Me.dtpBirthday.TabIndex = 45
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label8.Location = New System.Drawing.Point(3, 71)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(52, 16)
        Me.Label8.TabIndex = 44
        Me.Label8.Text = "Birthday"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(260, 71)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(50, 16)
        Me.Label2.TabIndex = 42
        Me.Label2.Text = "Gender"
        '
        'cmbGender
        '
        Me.cmbGender.FormattingEnabled = True
        Me.cmbGender.Items.AddRange(New Object() {"Male", "Female", "Other(s)"})
        Me.cmbGender.Location = New System.Drawing.Point(310, 66)
        Me.cmbGender.Name = "cmbGender"
        Me.cmbGender.Size = New System.Drawing.Size(121, 21)
        Me.cmbGender.TabIndex = 41
        '
        'cmbEmploymentStat
        '
        Me.cmbEmploymentStat.FormattingEnabled = True
        Me.cmbEmploymentStat.Items.AddRange(New Object() {"Active", "Inactive"})
        Me.cmbEmploymentStat.Location = New System.Drawing.Point(501, 94)
        Me.cmbEmploymentStat.Name = "cmbEmploymentStat"
        Me.cmbEmploymentStat.Size = New System.Drawing.Size(114, 21)
        Me.cmbEmploymentStat.TabIndex = 40
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label6.Location = New System.Drawing.Point(384, 96)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(111, 16)
        Me.Label6.TabIndex = 39
        Me.Label6.Text = "Employment Status"
        '
        'cmbOutlet
        '
        Me.cmbOutlet.FormattingEnabled = True
        Me.cmbOutlet.Items.AddRange(New Object() {"Manila (Main)", "Quezon", "Laguna", "Cavite", "Batangas", "Cebu", "Leyte"})
        Me.cmbOutlet.Location = New System.Drawing.Point(484, 67)
        Me.cmbOutlet.Name = "cmbOutlet"
        Me.cmbOutlet.Size = New System.Drawing.Size(121, 21)
        Me.cmbOutlet.TabIndex = 38
        '
        'cmbPosition
        '
        Me.cmbPosition.FormattingEnabled = True
        Me.cmbPosition.Items.AddRange(New Object() {"Admin", "HR", "Cashier"})
        Me.cmbPosition.Location = New System.Drawing.Point(53, 92)
        Me.cmbPosition.Name = "cmbPosition"
        Me.cmbPosition.Size = New System.Drawing.Size(121, 21)
        Me.cmbPosition.TabIndex = 37
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(441, 71)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(42, 16)
        Me.Label5.TabIndex = 34
        Me.Label5.Text = "Outlet"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(11, 12)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(311, 42)
        Me.Label1.TabIndex = 30
        Me.Label1.Text = "File Maintenance"
        '
        'lblDate
        '
        Me.lblDate.AutoSize = True
        Me.lblDate.BackColor = System.Drawing.Color.Honeydew
        Me.lblDate.Location = New System.Drawing.Point(664, 38)
        Me.lblDate.Name = "lblDate"
        Me.lblDate.Size = New System.Drawing.Size(30, 13)
        Me.lblDate.TabIndex = 44
        Me.lblDate.Text = "Date"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(310, 4)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(61, 47)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 56
        Me.PictureBox1.TabStop = False
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(145, Byte), Integer), CType(CType(132, Byte), Integer))
        Me.Panel3.Controls.Add(Me.txtpassappear)
        Me.Panel3.Controls.Add(Me.txtuserappear)
        Me.Panel3.Controls.Add(Me.lblEmpStat)
        Me.Panel3.Controls.Add(Me.lblMaritStat)
        Me.Panel3.Controls.Add(Me.lblPosition)
        Me.Panel3.Controls.Add(Me.lblOutlet)
        Me.Panel3.Controls.Add(Me.lblGender)
        Me.Panel3.Controls.Add(Me.lblBirthday)
        Me.Panel3.Controls.Add(Me.lblContact)
        Me.Panel3.Controls.Add(Me.lblAddress)
        Me.Panel3.Controls.Add(Me.lblLName)
        Me.Panel3.Controls.Add(Me.lblMName)
        Me.Panel3.Controls.Add(Me.lblFName)
        Me.Panel3.Controls.Add(Me.Label18)
        Me.Panel3.Controls.Add(Me.Label17)
        Me.Panel3.Controls.Add(Me.Label23)
        Me.Panel3.Controls.Add(Me.pbEmployee)
        Me.Panel3.Controls.Add(Me.Label27)
        Me.Panel3.Controls.Add(Me.Label28)
        Me.Panel3.Controls.Add(Me.txtIDNum)
        Me.Panel3.Controls.Add(Me.Label29)
        Me.Panel3.Controls.Add(Me.Label19)
        Me.Panel3.Controls.Add(Me.Label16)
        Me.Panel3.Controls.Add(Me.Label20)
        Me.Panel3.Controls.Add(Me.Label24)
        Me.Panel3.Controls.Add(Me.Label26)
        Me.Panel3.Controls.Add(Me.Label25)
        Me.Panel3.Location = New System.Drawing.Point(667, 54)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(372, 470)
        Me.Panel3.TabIndex = 57
        '
        'txtpassappear
        '
        Me.txtpassappear.BackColor = System.Drawing.Color.Honeydew
        Me.txtpassappear.Location = New System.Drawing.Point(135, 438)
        Me.txtpassappear.Name = "txtpassappear"
        Me.txtpassappear.ReadOnly = True
        Me.txtpassappear.Size = New System.Drawing.Size(170, 20)
        Me.txtpassappear.TabIndex = 83
        '
        'txtuserappear
        '
        Me.txtuserappear.BackColor = System.Drawing.Color.Honeydew
        Me.txtuserappear.Location = New System.Drawing.Point(139, 412)
        Me.txtuserappear.Name = "txtuserappear"
        Me.txtuserappear.ReadOnly = True
        Me.txtuserappear.Size = New System.Drawing.Size(166, 20)
        Me.txtuserappear.TabIndex = 82
        '
        'lblEmpStat
        '
        Me.lblEmpStat.AutoSize = True
        Me.lblEmpStat.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEmpStat.ForeColor = System.Drawing.Color.FromArgb(CType(CType(185, Byte), Integer), CType(CType(220, Byte), Integer), CType(CType(180, Byte), Integer))
        Me.lblEmpStat.Location = New System.Drawing.Point(141, 373)
        Me.lblEmpStat.Name = "lblEmpStat"
        Me.lblEmpStat.Size = New System.Drawing.Size(15, 17)
        Me.lblEmpStat.TabIndex = 81
        Me.lblEmpStat.Text = "_"
        '
        'lblMaritStat
        '
        Me.lblMaritStat.AutoSize = True
        Me.lblMaritStat.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMaritStat.ForeColor = System.Drawing.Color.FromArgb(CType(CType(185, Byte), Integer), CType(CType(220, Byte), Integer), CType(CType(180, Byte), Integer))
        Me.lblMaritStat.Location = New System.Drawing.Point(108, 346)
        Me.lblMaritStat.Name = "lblMaritStat"
        Me.lblMaritStat.Size = New System.Drawing.Size(15, 17)
        Me.lblMaritStat.TabIndex = 80
        Me.lblMaritStat.Text = "_"
        '
        'lblPosition
        '
        Me.lblPosition.AutoSize = True
        Me.lblPosition.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPosition.ForeColor = System.Drawing.Color.FromArgb(CType(CType(185, Byte), Integer), CType(CType(220, Byte), Integer), CType(CType(180, Byte), Integer))
        Me.lblPosition.Location = New System.Drawing.Point(68, 319)
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
        Me.lblOutlet.Location = New System.Drawing.Point(58, 292)
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
        'lblBirthday
        '
        Me.lblBirthday.AutoSize = True
        Me.lblBirthday.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBirthday.ForeColor = System.Drawing.Color.FromArgb(CType(CType(185, Byte), Integer), CType(CType(220, Byte), Integer), CType(CType(180, Byte), Integer))
        Me.lblBirthday.Location = New System.Drawing.Point(74, 238)
        Me.lblBirthday.Name = "lblBirthday"
        Me.lblBirthday.Size = New System.Drawing.Size(15, 17)
        Me.lblBirthday.TabIndex = 76
        Me.lblBirthday.Text = "_"
        '
        'lblContact
        '
        Me.lblContact.AutoSize = True
        Me.lblContact.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblContact.ForeColor = System.Drawing.Color.FromArgb(CType(CType(185, Byte), Integer), CType(CType(220, Byte), Integer), CType(CType(180, Byte), Integer))
        Me.lblContact.Location = New System.Drawing.Point(70, 211)
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
        Me.lblAddress.Location = New System.Drawing.Point(70, 184)
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
        Me.lblLName.Location = New System.Drawing.Point(226, 157)
        Me.lblLName.Name = "lblLName"
        Me.lblLName.Size = New System.Drawing.Size(15, 17)
        Me.lblLName.TabIndex = 73
        Me.lblLName.Text = "_"
        '
        'lblMName
        '
        Me.lblMName.AutoSize = True
        Me.lblMName.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMName.ForeColor = System.Drawing.Color.FromArgb(CType(CType(185, Byte), Integer), CType(CType(220, Byte), Integer), CType(CType(180, Byte), Integer))
        Me.lblMName.Location = New System.Drawing.Point(141, 157)
        Me.lblMName.Name = "lblMName"
        Me.lblMName.Size = New System.Drawing.Size(15, 17)
        Me.lblMName.TabIndex = 72
        Me.lblMName.Text = "_"
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
        Me.Label18.Location = New System.Drawing.Point(3, 416)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(130, 16)
        Me.Label18.TabIndex = 66
        Me.Label18.Text = "Account Username"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.ForeColor = System.Drawing.Color.FromArgb(CType(CType(185, Byte), Integer), CType(CType(220, Byte), Integer), CType(CType(180, Byte), Integer))
        Me.Label17.Location = New System.Drawing.Point(3, 440)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(126, 16)
        Me.Label17.TabIndex = 70
        Me.Label17.Text = "Account Password"
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.ForeColor = System.Drawing.Color.FromArgb(CType(CType(185, Byte), Integer), CType(CType(220, Byte), Integer), CType(CType(180, Byte), Integer))
        Me.Label23.Location = New System.Drawing.Point(5, 239)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(63, 16)
        Me.Label23.TabIndex = 65
        Me.Label23.Text = "Birthday"
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
        Me.Label28.Location = New System.Drawing.Point(3, 185)
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
        Me.Label29.Location = New System.Drawing.Point(5, 320)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(57, 16)
        Me.Label29.TabIndex = 61
        Me.Label29.Text = "Position"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.ForeColor = System.Drawing.Color.FromArgb(CType(CType(185, Byte), Integer), CType(CType(220, Byte), Integer), CType(CType(180, Byte), Integer))
        Me.Label19.Location = New System.Drawing.Point(5, 347)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(97, 16)
        Me.Label19.TabIndex = 69
        Me.Label19.Text = "Marital Status"
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
        Me.Label20.Location = New System.Drawing.Point(5, 213)
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
        Me.Label26.Location = New System.Drawing.Point(5, 293)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(47, 16)
        Me.Label26.TabIndex = 62
        Me.Label26.Text = "Outlet"
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label25.ForeColor = System.Drawing.Color.FromArgb(CType(CType(185, Byte), Integer), CType(CType(220, Byte), Integer), CType(CType(180, Byte), Integer))
        Me.Label25.Location = New System.Drawing.Point(5, 374)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(130, 16)
        Me.Label25.TabIndex = 63
        Me.Label25.Text = "Employment Status"
        '
        'OpenFD
        '
        Me.OpenFD.FileName = "OpenFileDialog1"
        '
        'TblFileMaintenanceTableAdapter
        '
        Me.TblFileMaintenanceTableAdapter.ClearBeforeFill = True
        '
        'FileMaintenanceMod
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightGreen
        Me.ClientSize = New System.Drawing.Size(1184, 547)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.lblDate)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label1)
        Me.Name = "FileMaintenanceMod"
        Me.Text = "FileMaintenanceMod"
        CType(Me.TblFileMaintenanceBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.POS_databaseDataSet3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        CType(Me.pbEmployee, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label3 As Label
    Friend WithEvents txtAddress As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtFirstName As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents btnSearch As Button
    Friend WithEvents btnAdd As Button
    Friend WithEvents btnDelete As Button
    Friend WithEvents txtSearch As TextBox
    Friend WithEvents btnEdit As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents cmbOutlet As ComboBox
    Friend WithEvents cmbPosition As ComboBox
    Friend WithEvents cmbEmploymentStat As ComboBox
    Friend WithEvents btnClear As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents cmbGender As ComboBox
    Friend WithEvents lblDate As Label
    Friend WithEvents dtpBirthday As DateTimePicker
    Friend WithEvents Label8 As Label
    Friend WithEvents txtMiddleName As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents txtLastName As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents txtContact As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents cmbMaritalStat As ComboBox
    Friend WithEvents Label13 As Label
    Friend WithEvents txtAcctPass As TextBox
    Friend WithEvents Label15 As Label
    Friend WithEvents txtAcctUser As TextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Panel3 As Panel
    Friend WithEvents lblLName As Label
    Friend WithEvents lblMName As Label
    Friend WithEvents lblFName As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents Label23 As Label
    Friend WithEvents pbEmployee As PictureBox
    Friend WithEvents Label27 As Label
    Friend WithEvents Label28 As Label
    Friend WithEvents txtIDNum As TextBox
    Friend WithEvents Label29 As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents Label20 As Label
    Friend WithEvents Label24 As Label
    Friend WithEvents Label26 As Label
    Friend WithEvents Label25 As Label
    Friend WithEvents lblEmpStat As Label
    Friend WithEvents lblMaritStat As Label
    Friend WithEvents lblPosition As Label
    Friend WithEvents lblOutlet As Label
    Friend WithEvents lblGender As Label
    Friend WithEvents lblBirthday As Label
    Friend WithEvents lblContact As Label
    Friend WithEvents lblAddress As Label
    Friend WithEvents btnUpload As Button
    Friend WithEvents txtuserappear As TextBox
    Friend WithEvents txtpassappear As TextBox
    Friend WithEvents btnAll As Button
    Friend WithEvents OpenFD As OpenFileDialog
    Friend WithEvents POS_databaseDataSet3 As POS_databaseDataSet3
    Friend WithEvents TblFileMaintenanceBindingSource As BindingSource
    Friend WithEvents TblFileMaintenanceTableAdapter As POS_databaseDataSet3TableAdapters.tblFileMaintenanceTableAdapter
    Friend WithEvents EmployeeIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FirstNameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents LastNameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents MiddleNameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents AddressDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ContactDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents BirthdayDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents GenderDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents OutletDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PositionDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents MaritalStatusDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents EmploymentStatusDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents AcctUsernameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents AcctPasswordDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PhotoDirectoryDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
