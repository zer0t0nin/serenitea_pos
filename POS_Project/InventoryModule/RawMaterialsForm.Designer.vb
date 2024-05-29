<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class RawMaterialsForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(RawMaterialsForm))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.txtRawMatID = New System.Windows.Forms.TextBox()
        Me.TblRawMatBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.POS_databaseDataSet6 = New POS_Project.POS_databaseDataSet6()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtUnit = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtPrice = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtQuantity = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtItemName = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.RawMatIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ItemNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.QuantityDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UnitDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PriceDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.btnReceiving = New System.Windows.Forms.Button()
        Me.btnAll = New System.Windows.Forms.Button()
        Me.txtSearch = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.TblRawMatTableAdapter = New POS_Project.POS_databaseDataSet6TableAdapters.tblRawMatTableAdapter()
        Me.Panel1.SuspendLayout()
        CType(Me.TblRawMatBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.POS_databaseDataSet6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(203, Byte), Integer), CType(CType(217, Byte), Integer), CType(CType(166, Byte), Integer))
        Me.Panel1.Controls.Add(Me.txtRawMatID)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.txtUnit)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.txtPrice)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.txtQuantity)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.txtItemName)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Panel1.Location = New System.Drawing.Point(9, 68)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(343, 136)
        Me.Panel1.TabIndex = 28
        '
        'txtRawMatID
        '
        Me.txtRawMatID.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblRawMatBindingSource, "RawMatID", True))
        Me.txtRawMatID.Location = New System.Drawing.Point(104, 8)
        Me.txtRawMatID.Name = "txtRawMatID"
        Me.txtRawMatID.ReadOnly = True
        Me.txtRawMatID.Size = New System.Drawing.Size(67, 21)
        Me.txtRawMatID.TabIndex = 38
        '
        'TblRawMatBindingSource
        '
        Me.TblRawMatBindingSource.DataMember = "tblRawMat"
        Me.TblRawMatBindingSource.DataSource = Me.POS_databaseDataSet6
        '
        'POS_databaseDataSet6
        '
        Me.POS_databaseDataSet6.DataSetName = "POS_databaseDataSet6"
        Me.POS_databaseDataSet6.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(3, 11)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(95, 16)
        Me.Label5.TabIndex = 37
        Me.Label5.Text = "Raw Material ID"
        '
        'txtUnit
        '
        Me.txtUnit.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblRawMatBindingSource, "Unit", True))
        Me.txtUnit.Location = New System.Drawing.Point(70, 83)
        Me.txtUnit.Name = "txtUnit"
        Me.txtUnit.ReadOnly = True
        Me.txtUnit.Size = New System.Drawing.Size(75, 21)
        Me.txtUnit.TabIndex = 36
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(35, 86)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(29, 16)
        Me.Label2.TabIndex = 35
        Me.Label2.Text = "Unit"
        '
        'txtPrice
        '
        Me.txtPrice.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblRawMatBindingSource, "Price", True))
        Me.txtPrice.Location = New System.Drawing.Point(70, 108)
        Me.txtPrice.Name = "txtPrice"
        Me.txtPrice.ReadOnly = True
        Me.txtPrice.Size = New System.Drawing.Size(101, 21)
        Me.txtPrice.TabIndex = 33
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(30, 111)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(34, 16)
        Me.Label4.TabIndex = 32
        Me.Label4.Text = "Price"
        '
        'txtQuantity
        '
        Me.txtQuantity.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblRawMatBindingSource, "Quantity", True))
        Me.txtQuantity.Location = New System.Drawing.Point(77, 58)
        Me.txtQuantity.Name = "txtQuantity"
        Me.txtQuantity.ReadOnly = True
        Me.txtQuantity.Size = New System.Drawing.Size(47, 21)
        Me.txtQuantity.TabIndex = 20
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(3, 36)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(68, 16)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "Item Name"
        '
        'txtItemName
        '
        Me.txtItemName.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblRawMatBindingSource, "Item Name", True))
        Me.txtItemName.Location = New System.Drawing.Point(77, 33)
        Me.txtItemName.Name = "txtItemName"
        Me.txtItemName.ReadOnly = True
        Me.txtItemName.Size = New System.Drawing.Size(193, 21)
        Me.txtItemName.TabIndex = 16
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(15, 61)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(56, 16)
        Me.Label7.TabIndex = 13
        Me.Label7.Text = "Quantity"
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(117, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(125, Byte), Integer))
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.RawMatIDDataGridViewTextBoxColumn, Me.ItemNameDataGridViewTextBoxColumn, Me.QuantityDataGridViewTextBoxColumn, Me.UnitDataGridViewTextBoxColumn, Me.PriceDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.TblRawMatBindingSource
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.MintCream
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridView1.DefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridView1.Location = New System.Drawing.Point(9, 210)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(343, 248)
        Me.DataGridView1.TabIndex = 29
        '
        'RawMatIDDataGridViewTextBoxColumn
        '
        Me.RawMatIDDataGridViewTextBoxColumn.DataPropertyName = "RawMatID"
        Me.RawMatIDDataGridViewTextBoxColumn.HeaderText = "RawMatID"
        Me.RawMatIDDataGridViewTextBoxColumn.Name = "RawMatIDDataGridViewTextBoxColumn"
        '
        'ItemNameDataGridViewTextBoxColumn
        '
        Me.ItemNameDataGridViewTextBoxColumn.DataPropertyName = "Item Name"
        Me.ItemNameDataGridViewTextBoxColumn.HeaderText = "Item Name"
        Me.ItemNameDataGridViewTextBoxColumn.Name = "ItemNameDataGridViewTextBoxColumn"
        '
        'QuantityDataGridViewTextBoxColumn
        '
        Me.QuantityDataGridViewTextBoxColumn.DataPropertyName = "Quantity"
        Me.QuantityDataGridViewTextBoxColumn.HeaderText = "Quantity"
        Me.QuantityDataGridViewTextBoxColumn.Name = "QuantityDataGridViewTextBoxColumn"
        '
        'UnitDataGridViewTextBoxColumn
        '
        Me.UnitDataGridViewTextBoxColumn.DataPropertyName = "Unit"
        Me.UnitDataGridViewTextBoxColumn.HeaderText = "Unit"
        Me.UnitDataGridViewTextBoxColumn.Name = "UnitDataGridViewTextBoxColumn"
        '
        'PriceDataGridViewTextBoxColumn
        '
        Me.PriceDataGridViewTextBoxColumn.DataPropertyName = "Price"
        Me.PriceDataGridViewTextBoxColumn.HeaderText = "Price"
        Me.PriceDataGridViewTextBoxColumn.Name = "PriceDataGridViewTextBoxColumn"
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(145, Byte), Integer), CType(CType(132, Byte), Integer))
        Me.Panel3.Controls.Add(Me.btnReceiving)
        Me.Panel3.Controls.Add(Me.btnAll)
        Me.Panel3.Controls.Add(Me.txtSearch)
        Me.Panel3.Controls.Add(Me.Label11)
        Me.Panel3.Controls.Add(Me.btnSearch)
        Me.Panel3.Location = New System.Drawing.Point(363, 59)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(127, 399)
        Me.Panel3.TabIndex = 34
        '
        'btnReceiving
        '
        Me.btnReceiving.BackColor = System.Drawing.Color.FromArgb(CType(CType(203, Byte), Integer), CType(CType(217, Byte), Integer), CType(CType(166, Byte), Integer))
        Me.btnReceiving.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReceiving.Location = New System.Drawing.Point(9, 110)
        Me.btnReceiving.Name = "btnReceiving"
        Me.btnReceiving.Size = New System.Drawing.Size(110, 51)
        Me.btnReceiving.TabIndex = 61
        Me.btnReceiving.Text = "Items to Receive"
        Me.btnReceiving.UseVisualStyleBackColor = False
        '
        'btnAll
        '
        Me.btnAll.BackColor = System.Drawing.Color.FromArgb(CType(CType(185, Byte), Integer), CType(CType(220, Byte), Integer), CType(CType(180, Byte), Integer))
        Me.btnAll.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAll.Location = New System.Drawing.Point(9, 167)
        Me.btnAll.Name = "btnAll"
        Me.btnAll.Size = New System.Drawing.Size(110, 51)
        Me.btnAll.TabIndex = 60
        Me.btnAll.Text = "Show All Item(s)"
        Me.btnAll.UseVisualStyleBackColor = False
        '
        'txtSearch
        '
        Me.txtSearch.Location = New System.Drawing.Point(9, 360)
        Me.txtSearch.Multiline = True
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(110, 20)
        Me.txtSearch.TabIndex = 5
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
        Me.btnSearch.Location = New System.Drawing.Point(9, 323)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(110, 31)
        Me.btnSearch.TabIndex = 4
        Me.btnSearch.Text = "Search"
        Me.btnSearch.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(2, 23)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(253, 42)
        Me.Label1.TabIndex = 27
        Me.Label1.Text = "Raw Materials"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(243, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(65, 65)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 35
        Me.PictureBox1.TabStop = False
        '
        'TblRawMatTableAdapter
        '
        Me.TblRawMatTableAdapter.ClearBeforeFill = True
        '
        'RawMaterialsForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightGreen
        Me.ClientSize = New System.Drawing.Size(503, 471)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Label1)
        Me.Name = "RawMaterialsForm"
        Me.Text = "RawMaterialsForm"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.TblRawMatBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.POS_databaseDataSet6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents txtQuantity As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtItemName As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Panel3 As Panel
    Friend WithEvents txtSearch As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents btnSearch As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents txtPrice As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label2 As Label
    Friend WithEvents POS_databaseDataSet6 As POS_databaseDataSet6
    Friend WithEvents TblRawMatBindingSource As BindingSource
    Friend WithEvents TblRawMatTableAdapter As POS_databaseDataSet6TableAdapters.tblRawMatTableAdapter
    Friend WithEvents RawMatIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ItemNameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents QuantityDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents UnitDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PriceDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents btnAll As Button
    Friend WithEvents txtRawMatID As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtUnit As TextBox
    Friend WithEvents btnReceiving As Button
End Class
