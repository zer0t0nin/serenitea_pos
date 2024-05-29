<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class SalesInvoiceForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SalesInvoiceForm))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtInvoiceNo = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.dtpSaleDate = New System.Windows.Forms.DateTimePicker()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.btnAll = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.POS_databaseDataSet2 = New POS_Project.POS_databaseDataSet2()
        Me.SalesInvoiceQueryBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SalesInvoiceQueryTableAdapter = New POS_Project.POS_databaseDataSet2TableAdapters.SalesInvoiceQueryTableAdapter()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DateBoughtDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.VendorDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.POS_databaseDataSet2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SalesInvoiceQueryBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(3, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(238, 42)
        Me.Label1.TabIndex = 37
        Me.Label1.Text = "Sales Invoice"
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(117, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(125, Byte), Integer))
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DateBoughtDataGridViewTextBoxColumn, Me.VendorDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.SalesInvoiceQueryBindingSource
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.MintCream
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridView1.DefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridView1.Location = New System.Drawing.Point(12, 126)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(644, 295)
        Me.DataGridView1.TabIndex = 39
        '
        'btnSearch
        '
        Me.btnSearch.BackColor = System.Drawing.Color.MediumAquamarine
        Me.btnSearch.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSearch.Image = CType(resources.GetObject("btnSearch.Image"), System.Drawing.Image)
        Me.btnSearch.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnSearch.Location = New System.Drawing.Point(286, 9)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(136, 45)
        Me.btnSearch.TabIndex = 4
        Me.btnSearch.Text = "Search"
        Me.btnSearch.UseVisualStyleBackColor = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label7.Location = New System.Drawing.Point(36, 35)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(35, 16)
        Me.Label7.TabIndex = 13
        Me.Label7.Text = "Date"
        '
        'txtInvoiceNo
        '
        Me.txtInvoiceNo.Location = New System.Drawing.Point(80, 7)
        Me.txtInvoiceNo.Name = "txtInvoiceNo"
        Me.txtInvoiceNo.Size = New System.Drawing.Size(182, 20)
        Me.txtInvoiceNo.TabIndex = 16
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(4, 9)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(70, 16)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "Invoice No."
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(203, Byte), Integer), CType(CType(217, Byte), Integer), CType(CType(166, Byte), Integer))
        Me.Panel1.Controls.Add(Me.dtpSaleDate)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.btnSearch)
        Me.Panel1.Controls.Add(Me.txtInvoiceNo)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Location = New System.Drawing.Point(12, 55)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(435, 61)
        Me.Panel1.TabIndex = 38
        '
        'dtpSaleDate
        '
        Me.dtpSaleDate.Location = New System.Drawing.Point(74, 33)
        Me.dtpSaleDate.Name = "dtpSaleDate"
        Me.dtpSaleDate.Size = New System.Drawing.Size(188, 20)
        Me.dtpSaleDate.TabIndex = 17
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(91, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.Panel3.Controls.Add(Me.btnAll)
        Me.Panel3.Location = New System.Drawing.Point(453, 55)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(180, 61)
        Me.Panel3.TabIndex = 43
        '
        'btnAll
        '
        Me.btnAll.BackColor = System.Drawing.Color.FromArgb(CType(CType(185, Byte), Integer), CType(CType(220, Byte), Integer), CType(CType(180, Byte), Integer))
        Me.btnAll.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAll.Location = New System.Drawing.Point(12, 7)
        Me.btnAll.Name = "btnAll"
        Me.btnAll.Size = New System.Drawing.Size(155, 48)
        Me.btnAll.TabIndex = 21
        Me.btnAll.Text = "Show All Item(s)"
        Me.btnAll.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(231, -4)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(63, 59)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 44
        Me.PictureBox1.TabStop = False
        '
        'POS_databaseDataSet2
        '
        Me.POS_databaseDataSet2.DataSetName = "POS_databaseDataSet2"
        Me.POS_databaseDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'SalesInvoiceQueryBindingSource
        '
        Me.SalesInvoiceQueryBindingSource.DataMember = "SalesInvoiceQuery"
        Me.SalesInvoiceQueryBindingSource.DataSource = Me.POS_databaseDataSet2
        '
        'SalesInvoiceQueryTableAdapter
        '
        Me.SalesInvoiceQueryTableAdapter.ClearBeforeFill = True
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "ID"
        Me.DataGridViewTextBoxColumn1.HeaderText = "ID"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "ItemName"
        Me.DataGridViewTextBoxColumn2.HeaderText = "ItemName"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "Quantity"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Quantity"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "Total"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Total"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'DateBoughtDataGridViewTextBoxColumn
        '
        Me.DateBoughtDataGridViewTextBoxColumn.DataPropertyName = "DateBought"
        Me.DateBoughtDataGridViewTextBoxColumn.HeaderText = "DateBought"
        Me.DateBoughtDataGridViewTextBoxColumn.Name = "DateBoughtDataGridViewTextBoxColumn"
        '
        'VendorDataGridViewTextBoxColumn
        '
        Me.VendorDataGridViewTextBoxColumn.DataPropertyName = "Vendor"
        Me.VendorDataGridViewTextBoxColumn.HeaderText = "Vendor"
        Me.VendorDataGridViewTextBoxColumn.Name = "VendorDataGridViewTextBoxColumn"
        '
        'SalesInvoiceForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightGreen
        Me.ClientSize = New System.Drawing.Size(665, 433)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "SalesInvoiceForm"
        Me.Text = "SalesInvoiceForm"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.POS_databaseDataSet2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SalesInvoiceQueryBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents btnSearch As Button
    Friend WithEvents Label7 As Label
    Friend WithEvents txtInvoiceNo As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents dtpSaleDate As DateTimePicker
    Friend WithEvents IDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ItemNameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents QuantityDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TotalDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Panel3 As Panel
    Friend WithEvents btnAll As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents POS_databaseDataSet2 As POS_databaseDataSet2
    Friend WithEvents SalesInvoiceQueryBindingSource As BindingSource
    Friend WithEvents SalesInvoiceQueryTableAdapter As POS_databaseDataSet2TableAdapters.SalesInvoiceQueryTableAdapter
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DateBoughtDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents VendorDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
