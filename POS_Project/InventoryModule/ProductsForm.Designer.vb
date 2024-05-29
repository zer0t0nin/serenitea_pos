<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ProductsMod
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ProductsMod))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.ProductIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ProductNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.StockQuantityDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PriceDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TblProductBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.POS_databaseDataSet1 = New POS_Project.POS_databaseDataSet1()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.txtPrice = New System.Windows.Forms.TextBox()
        Me.txtQty = New System.Windows.Forms.TextBox()
        Me.txtProdName = New System.Windows.Forms.TextBox()
        Me.txtProdID = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.btnAll = New System.Windows.Forms.Button()
        Me.btnCreate = New System.Windows.Forms.Button()
        Me.txtSearch = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.TblProductTableAdapter = New POS_Project.POS_databaseDataSet1TableAdapters.tblProductTableAdapter()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblProductBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.POS_databaseDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(9, 12)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(226, 42)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "Products List"
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(117, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(125, Byte), Integer))
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ProductIDDataGridViewTextBoxColumn, Me.ProductNameDataGridViewTextBoxColumn, Me.StockQuantityDataGridViewTextBoxColumn, Me.PriceDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.TblProductBindingSource
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.MintCream
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridView1.DefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridView1.Location = New System.Drawing.Point(16, 132)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(443, 277)
        Me.DataGridView1.TabIndex = 28
        '
        'ProductIDDataGridViewTextBoxColumn
        '
        Me.ProductIDDataGridViewTextBoxColumn.DataPropertyName = "ProductID"
        Me.ProductIDDataGridViewTextBoxColumn.HeaderText = "ProductID"
        Me.ProductIDDataGridViewTextBoxColumn.Name = "ProductIDDataGridViewTextBoxColumn"
        '
        'ProductNameDataGridViewTextBoxColumn
        '
        Me.ProductNameDataGridViewTextBoxColumn.DataPropertyName = "ProductName"
        Me.ProductNameDataGridViewTextBoxColumn.HeaderText = "ProductName"
        Me.ProductNameDataGridViewTextBoxColumn.Name = "ProductNameDataGridViewTextBoxColumn"
        '
        'StockQuantityDataGridViewTextBoxColumn
        '
        Me.StockQuantityDataGridViewTextBoxColumn.DataPropertyName = "StockQuantity"
        Me.StockQuantityDataGridViewTextBoxColumn.HeaderText = "StockQuantity"
        Me.StockQuantityDataGridViewTextBoxColumn.Name = "StockQuantityDataGridViewTextBoxColumn"
        '
        'PriceDataGridViewTextBoxColumn
        '
        Me.PriceDataGridViewTextBoxColumn.DataPropertyName = "Price"
        Me.PriceDataGridViewTextBoxColumn.HeaderText = "Price"
        Me.PriceDataGridViewTextBoxColumn.Name = "PriceDataGridViewTextBoxColumn"
        '
        'TblProductBindingSource
        '
        Me.TblProductBindingSource.DataMember = "tblProduct"
        Me.TblProductBindingSource.DataSource = Me.POS_databaseDataSet1
        '
        'POS_databaseDataSet1
        '
        Me.POS_databaseDataSet1.DataSetName = "POS_databaseDataSet1"
        Me.POS_databaseDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(203, Byte), Integer), CType(CType(217, Byte), Integer), CType(CType(166, Byte), Integer))
        Me.Panel1.Controls.Add(Me.txtPrice)
        Me.Panel1.Controls.Add(Me.txtQty)
        Me.Panel1.Controls.Add(Me.txtProdName)
        Me.Panel1.Controls.Add(Me.txtProdID)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Panel1.Location = New System.Drawing.Point(16, 57)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(443, 69)
        Me.Panel1.TabIndex = 27
        '
        'txtPrice
        '
        Me.txtPrice.BackColor = System.Drawing.Color.Honeydew
        Me.txtPrice.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblProductBindingSource, "Price", True))
        Me.txtPrice.Location = New System.Drawing.Point(299, 41)
        Me.txtPrice.Name = "txtPrice"
        Me.txtPrice.ReadOnly = True
        Me.txtPrice.Size = New System.Drawing.Size(79, 21)
        Me.txtPrice.TabIndex = 7
        '
        'txtQty
        '
        Me.txtQty.BackColor = System.Drawing.Color.Honeydew
        Me.txtQty.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblProductBindingSource, "StockQuantity", True))
        Me.txtQty.Location = New System.Drawing.Point(211, 8)
        Me.txtQty.Name = "txtQty"
        Me.txtQty.ReadOnly = True
        Me.txtQty.Size = New System.Drawing.Size(72, 21)
        Me.txtQty.TabIndex = 6
        '
        'txtProdName
        '
        Me.txtProdName.BackColor = System.Drawing.Color.Honeydew
        Me.txtProdName.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblProductBindingSource, "ProductName", True))
        Me.txtProdName.Location = New System.Drawing.Point(96, 41)
        Me.txtProdName.Name = "txtProdName"
        Me.txtProdName.ReadOnly = True
        Me.txtProdName.Size = New System.Drawing.Size(160, 21)
        Me.txtProdName.TabIndex = 5
        '
        'txtProdID
        '
        Me.txtProdID.BackColor = System.Drawing.Color.Honeydew
        Me.txtProdID.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblProductBindingSource, "ProductID", True))
        Me.txtProdID.Location = New System.Drawing.Point(74, 8)
        Me.txtProdID.Name = "txtProdID"
        Me.txtProdID.ReadOnly = True
        Me.txtProdID.Size = New System.Drawing.Size(72, 21)
        Me.txtProdID.TabIndex = 4
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(262, 44)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(34, 16)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Price"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(152, 11)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(56, 16)
        Me.Label5.TabIndex = 2
        Me.Label5.Text = "Quantity"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(3, 44)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(87, 16)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Product Name"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(3, 11)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(65, 16)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Product ID"
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(145, Byte), Integer), CType(CType(132, Byte), Integer))
        Me.Panel3.Controls.Add(Me.btnAll)
        Me.Panel3.Controls.Add(Me.btnCreate)
        Me.Panel3.Controls.Add(Me.txtSearch)
        Me.Panel3.Controls.Add(Me.Label11)
        Me.Panel3.Controls.Add(Me.btnSearch)
        Me.Panel3.Location = New System.Drawing.Point(470, 57)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(127, 352)
        Me.Panel3.TabIndex = 35
        '
        'btnAll
        '
        Me.btnAll.BackColor = System.Drawing.Color.FromArgb(CType(CType(185, Byte), Integer), CType(CType(220, Byte), Integer), CType(CType(180, Byte), Integer))
        Me.btnAll.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAll.Location = New System.Drawing.Point(9, 152)
        Me.btnAll.Name = "btnAll"
        Me.btnAll.Size = New System.Drawing.Size(110, 51)
        Me.btnAll.TabIndex = 21
        Me.btnAll.Text = "Show All Item(s)"
        Me.btnAll.UseVisualStyleBackColor = False
        '
        'btnCreate
        '
        Me.btnCreate.BackColor = System.Drawing.Color.FromArgb(CType(CType(203, Byte), Integer), CType(CType(217, Byte), Integer), CType(CType(166, Byte), Integer))
        Me.btnCreate.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCreate.Location = New System.Drawing.Point(9, 94)
        Me.btnCreate.Name = "btnCreate"
        Me.btnCreate.Size = New System.Drawing.Size(110, 52)
        Me.btnCreate.TabIndex = 8
        Me.btnCreate.Text = "Create A Product"
        Me.btnCreate.UseVisualStyleBackColor = False
        '
        'txtSearch
        '
        Me.txtSearch.Location = New System.Drawing.Point(9, 318)
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
        Me.btnSearch.Location = New System.Drawing.Point(9, 281)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(110, 31)
        Me.btnSearch.TabIndex = 4
        Me.btnSearch.Text = "Search"
        Me.btnSearch.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(227, 4)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(68, 50)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 36
        Me.PictureBox1.TabStop = False
        '
        'TblProductTableAdapter
        '
        Me.TblProductTableAdapter.ClearBeforeFill = True
        '
        'ProductsMod
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightGreen
        Me.ClientSize = New System.Drawing.Size(613, 423)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label1)
        Me.Name = "ProductsMod"
        Me.Text = "Form5"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblProductBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.POS_databaseDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents txtSearch As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents btnSearch As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents btnCreate As Button
    Friend WithEvents txtPrice As TextBox
    Friend WithEvents txtQty As TextBox
    Friend WithEvents txtProdName As TextBox
    Friend WithEvents txtProdID As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents btnAll As Button
    Friend WithEvents POS_databaseDataSet1 As POS_databaseDataSet1
    Friend WithEvents TblProductBindingSource As BindingSource
    Friend WithEvents TblProductTableAdapter As POS_databaseDataSet1TableAdapters.tblProductTableAdapter
    Friend WithEvents ProductIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ProductNameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents StockQuantityDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PriceDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
