<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class VendorForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(VendorForm))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TblVendorBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.POS_databaseDataSet8 = New POS_Project.POS_databaseDataSet8()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.btnAll = New System.Windows.Forms.Button()
        Me.txtSearch = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnEdit = New System.Windows.Forms.Button()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.txtComAddress = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.txtContactNo = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.txtContactPersPos = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtCompanyName = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cmbSupTitle = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtContactPerson = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtVendorID = New System.Windows.Forms.TextBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.TblVendorTableAdapter = New POS_Project.POS_databaseDataSet8TableAdapters.tblVendorTableAdapter()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblVendorBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.POS_databaseDataSet8, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(5, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(152, 44)
        Me.Label1.TabIndex = 42
        Me.Label1.Text = "Vendor"
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(117, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(125, Byte), Integer))
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7})
        Me.DataGridView1.DataSource = Me.TblVendorBindingSource
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.MintCream
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridView1.DefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridView1.Location = New System.Drawing.Point(12, 195)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(500, 229)
        Me.DataGridView1.TabIndex = 44
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "VendorID"
        Me.DataGridViewTextBoxColumn1.HeaderText = "VendorID"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "CompanyName"
        Me.DataGridViewTextBoxColumn2.HeaderText = "CompanyName"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "ContactPerson"
        Me.DataGridViewTextBoxColumn3.HeaderText = "ContactPerson"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "ContactPersonPosition"
        Me.DataGridViewTextBoxColumn4.HeaderText = "ContactPersonPosition"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "SupplierTitle"
        Me.DataGridViewTextBoxColumn5.HeaderText = "SupplierTitle"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "ContactNumber"
        Me.DataGridViewTextBoxColumn6.HeaderText = "ContactNumber"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "CompanyAddress"
        Me.DataGridViewTextBoxColumn7.HeaderText = "CompanyAddress"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        '
        'TblVendorBindingSource
        '
        Me.TblVendorBindingSource.DataMember = "tblVendor"
        Me.TblVendorBindingSource.DataSource = Me.POS_databaseDataSet8
        '
        'POS_databaseDataSet8
        '
        Me.POS_databaseDataSet8.DataSetName = "POS_databaseDataSet8"
        Me.POS_databaseDataSet8.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.SpringGreen
        Me.Panel2.Controls.Add(Me.btnAll)
        Me.Panel2.Controls.Add(Me.txtSearch)
        Me.Panel2.Controls.Add(Me.Label11)
        Me.Panel2.Controls.Add(Me.btnSearch)
        Me.Panel2.Controls.Add(Me.btnClear)
        Me.Panel2.Controls.Add(Me.btnEdit)
        Me.Panel2.Controls.Add(Me.btnAdd)
        Me.Panel2.Controls.Add(Me.btnDelete)
        Me.Panel2.Location = New System.Drawing.Point(518, 61)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(127, 363)
        Me.Panel2.TabIndex = 46
        '
        'btnAll
        '
        Me.btnAll.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(145, Byte), Integer), CType(CType(132, Byte), Integer))
        Me.btnAll.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAll.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnAll.Location = New System.Drawing.Point(9, 309)
        Me.btnAll.Name = "btnAll"
        Me.btnAll.Size = New System.Drawing.Size(110, 41)
        Me.btnAll.TabIndex = 59
        Me.btnAll.Text = "Show All Item(s)"
        Me.btnAll.UseVisualStyleBackColor = False
        '
        'txtSearch
        '
        Me.txtSearch.Location = New System.Drawing.Point(9, 272)
        Me.txtSearch.Multiline = True
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(110, 20)
        Me.txtSearch.TabIndex = 5
        Me.txtSearch.Tag = ""
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
        'btnSearch
        '
        Me.btnSearch.BackColor = System.Drawing.Color.MediumAquamarine
        Me.btnSearch.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSearch.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSearch.Image = CType(resources.GetObject("btnSearch.Image"), System.Drawing.Image)
        Me.btnSearch.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnSearch.Location = New System.Drawing.Point(9, 235)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(110, 31)
        Me.btnSearch.TabIndex = 4
        Me.btnSearch.Text = "Search"
        Me.btnSearch.UseVisualStyleBackColor = False
        '
        'btnClear
        '
        Me.btnClear.BackColor = System.Drawing.Color.MintCream
        Me.btnClear.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnClear.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.Image = CType(resources.GetObject("btnClear.Image"), System.Drawing.Image)
        Me.btnClear.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnClear.Location = New System.Drawing.Point(9, 198)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(110, 31)
        Me.btnClear.TabIndex = 6
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = False
        '
        'btnEdit
        '
        Me.btnEdit.BackColor = System.Drawing.Color.PaleGreen
        Me.btnEdit.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnEdit.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEdit.Image = CType(resources.GetObject("btnEdit.Image"), System.Drawing.Image)
        Me.btnEdit.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnEdit.Location = New System.Drawing.Point(9, 124)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(110, 31)
        Me.btnEdit.TabIndex = 2
        Me.btnEdit.Text = "Edit"
        Me.btnEdit.UseVisualStyleBackColor = False
        '
        'btnAdd
        '
        Me.btnAdd.BackColor = System.Drawing.Color.ForestGreen
        Me.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAdd.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdd.Image = CType(resources.GetObject("btnAdd.Image"), System.Drawing.Image)
        Me.btnAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnAdd.Location = New System.Drawing.Point(9, 87)
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
        Me.btnDelete.Image = CType(resources.GetObject("btnDelete.Image"), System.Drawing.Image)
        Me.btnDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnDelete.Location = New System.Drawing.Point(9, 161)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(110, 31)
        Me.btnDelete.TabIndex = 1
        Me.btnDelete.Text = "Delete"
        Me.btnDelete.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(203, Byte), Integer), CType(CType(217, Byte), Integer), CType(CType(166, Byte), Integer))
        Me.Panel1.Controls.Add(Me.txtComAddress)
        Me.Panel1.Controls.Add(Me.Label15)
        Me.Panel1.Controls.Add(Me.txtContactNo)
        Me.Panel1.Controls.Add(Me.Label14)
        Me.Panel1.Controls.Add(Me.txtContactPersPos)
        Me.Panel1.Controls.Add(Me.Label12)
        Me.Panel1.Controls.Add(Me.txtCompanyName)
        Me.Panel1.Controls.Add(Me.Label9)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.cmbSupTitle)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.txtContactPerson)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.txtVendorID)
        Me.Panel1.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel1.Location = New System.Drawing.Point(12, 61)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(500, 128)
        Me.Panel1.TabIndex = 45
        '
        'txtComAddress
        '
        Me.txtComAddress.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblVendorBindingSource, "CompanyAddress", True))
        Me.txtComAddress.Location = New System.Drawing.Point(123, 92)
        Me.txtComAddress.Name = "txtComAddress"
        Me.txtComAddress.Size = New System.Drawing.Size(363, 21)
        Me.txtComAddress.TabIndex = 55
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label15.Location = New System.Drawing.Point(10, 95)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(107, 16)
        Me.Label15.TabIndex = 54
        Me.Label15.Text = "Company Address"
        '
        'txtContactNo
        '
        Me.txtContactNo.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblVendorBindingSource, "ContactNumber", True))
        Me.txtContactNo.Location = New System.Drawing.Point(325, 66)
        Me.txtContactNo.Name = "txtContactNo"
        Me.txtContactNo.Size = New System.Drawing.Size(138, 21)
        Me.txtContactNo.TabIndex = 53
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label14.Location = New System.Drawing.Point(219, 69)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(100, 16)
        Me.Label14.TabIndex = 45
        Me.Label14.Text = "Contact Number"
        '
        'txtContactPersPos
        '
        Me.txtContactPersPos.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblVendorBindingSource, "ContactPersonPosition", True))
        Me.txtContactPersPos.Location = New System.Drawing.Point(384, 40)
        Me.txtContactPersPos.Name = "txtContactPersPos"
        Me.txtContactPersPos.Size = New System.Drawing.Size(102, 21)
        Me.txtContactPersPos.TabIndex = 45
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label12.Location = New System.Drawing.Point(243, 43)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(135, 16)
        Me.Label12.TabIndex = 8
        Me.Label12.Text = "Contact Person Position"
        '
        'txtCompanyName
        '
        Me.txtCompanyName.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblVendorBindingSource, "CompanyName", True))
        Me.txtCompanyName.Location = New System.Drawing.Point(279, 15)
        Me.txtCompanyName.Name = "txtCompanyName"
        Me.txtCompanyName.Size = New System.Drawing.Size(207, 21)
        Me.txtCompanyName.TabIndex = 47
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label9.Location = New System.Drawing.Point(174, 18)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(99, 16)
        Me.Label9.TabIndex = 46
        Me.Label9.Text = "Company Name"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(8, 69)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(74, 16)
        Me.Label2.TabIndex = 42
        Me.Label2.Text = "Supplier Title"
        '
        'cmbSupTitle
        '
        Me.cmbSupTitle.FormattingEnabled = True
        Me.cmbSupTitle.Items.AddRange(New Object() {"Milk Supplier", "Straw, Cups and Paper Towel Supplier", "Water Supplier", "Fruits Supplier", "Boba & Tea Mix Supplier"})
        Me.cmbSupTitle.Location = New System.Drawing.Point(88, 65)
        Me.cmbSupTitle.Name = "cmbSupTitle"
        Me.cmbSupTitle.Size = New System.Drawing.Size(125, 24)
        Me.cmbSupTitle.TabIndex = 41
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(8, 18)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(61, 16)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "Vendor ID"
        '
        'txtContactPerson
        '
        Me.txtContactPerson.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblVendorBindingSource, "ContactPerson", True))
        Me.txtContactPerson.Location = New System.Drawing.Point(106, 40)
        Me.txtContactPerson.Name = "txtContactPerson"
        Me.txtContactPerson.Size = New System.Drawing.Size(131, 21)
        Me.txtContactPerson.TabIndex = 17
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(8, 42)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(92, 16)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "Contact Person"
        '
        'txtVendorID
        '
        Me.txtVendorID.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblVendorBindingSource, "VendorID", True))
        Me.txtVendorID.Location = New System.Drawing.Point(71, 14)
        Me.txtVendorID.Name = "txtVendorID"
        Me.txtVendorID.Size = New System.Drawing.Size(97, 21)
        Me.txtVendorID.TabIndex = 16
        Me.txtVendorID.Text = "VD-"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(149, 2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(73, 58)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 47
        Me.PictureBox1.TabStop = False
        '
        'TblVendorTableAdapter
        '
        Me.TblVendorTableAdapter.ClearBeforeFill = True
        '
        'VendorForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightGreen
        Me.ClientSize = New System.Drawing.Size(654, 433)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "VendorForm"
        Me.Text = " "
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblVendorBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.POS_databaseDataSet8, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Panel2 As Panel
    Friend WithEvents txtSearch As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents btnSearch As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents btnEdit As Button
    Friend WithEvents btnAdd As Button
    Friend WithEvents btnDelete As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents txtComAddress As TextBox
    Friend WithEvents Label15 As Label
    Friend WithEvents txtContactNo As TextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents txtContactPersPos As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents txtCompanyName As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents cmbSupTitle As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtContactPerson As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtVendorID As TextBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents VendorIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CompanyNameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ContactPersonDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ContactPersonPositionDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SupplierTitleDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ContactNumberDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CompanyAddressDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents POS_databaseDataSet8 As POS_databaseDataSet8
    Friend WithEvents TblVendorBindingSource As BindingSource
    Friend WithEvents TblVendorTableAdapter As POS_databaseDataSet8TableAdapters.tblVendorTableAdapter
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As DataGridViewTextBoxColumn
    Friend WithEvents btnAll As Button
End Class
