<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class StocksMod
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(StocksMod))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.txtProdSearch = New System.Windows.Forms.TextBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.btnAll = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.ProductNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.StockQuantityDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.StockQueryBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.POS_databaseDataSet4 = New POS_Project.POS_databaseDataSet4()
        Me.StockQueryTableAdapter = New POS_Project.POS_databaseDataSet4TableAdapters.StockQueryTableAdapter()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StockQueryBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.POS_databaseDataSet4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(9, 12)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(184, 42)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "Stocks List"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(203, Byte), Integer), CType(CType(217, Byte), Integer), CType(CType(166, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.btnSearch)
        Me.Panel1.Controls.Add(Me.txtProdSearch)
        Me.Panel1.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel1.Location = New System.Drawing.Point(12, 60)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(424, 55)
        Me.Panel1.TabIndex = 24
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(11, 23)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(87, 16)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "Product Name"
        '
        'btnSearch
        '
        Me.btnSearch.BackColor = System.Drawing.Color.MediumAquamarine
        Me.btnSearch.Image = CType(resources.GetObject("btnSearch.Image"), System.Drawing.Image)
        Me.btnSearch.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnSearch.Location = New System.Drawing.Point(296, 8)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(110, 41)
        Me.btnSearch.TabIndex = 4
        Me.btnSearch.Text = "Search"
        Me.btnSearch.UseVisualStyleBackColor = False
        '
        'txtProdSearch
        '
        Me.txtProdSearch.Location = New System.Drawing.Point(104, 21)
        Me.txtProdSearch.Name = "txtProdSearch"
        Me.txtProdSearch.Size = New System.Drawing.Size(170, 21)
        Me.txtProdSearch.TabIndex = 16
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(91, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.Panel2.Controls.Add(Me.btnAll)
        Me.Panel2.Location = New System.Drawing.Point(261, 121)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(175, 61)
        Me.Panel2.TabIndex = 26
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
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(117, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(125, Byte), Integer))
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ProductNameDataGridViewTextBoxColumn, Me.StockQuantityDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.StockQueryBindingSource
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.MintCream
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridView1.DefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridView1.Location = New System.Drawing.Point(12, 121)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(245, 300)
        Me.DataGridView1.TabIndex = 25
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
        'StockQueryBindingSource
        '
        Me.StockQueryBindingSource.DataMember = "StockQuery"
        Me.StockQueryBindingSource.DataSource = Me.POS_databaseDataSet4
        '
        'POS_databaseDataSet4
        '
        Me.POS_databaseDataSet4.DataSetName = "POS_databaseDataSet4"
        Me.POS_databaseDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'StockQueryTableAdapter
        '
        Me.StockQueryTableAdapter.ClearBeforeFill = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(184, 4)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(71, 50)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 27
        Me.PictureBox1.TabStop = False
        '
        'StocksMod
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightGreen
        Me.ClientSize = New System.Drawing.Size(452, 434)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label1)
        Me.Name = "StocksMod"
        Me.Text = "StocksMod"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StockQueryBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.POS_databaseDataSet4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents txtProdSearch As TextBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents btnSearch As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents btnAll As Button
    Friend WithEvents POS_databaseDataSet4 As POS_databaseDataSet4
    Friend WithEvents StockQueryBindingSource As BindingSource
    Friend WithEvents StockQueryTableAdapter As POS_databaseDataSet4TableAdapters.StockQueryTableAdapter
    Friend WithEvents ProductNameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents StockQuantityDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PictureBox1 As PictureBox
End Class
