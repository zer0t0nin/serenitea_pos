<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PurchaseOrderForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PurchaseOrderForm))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnRefresh = New System.Windows.Forms.Button()
        Me.cmbSupplier = New System.Windows.Forms.ComboBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtRawMatID = New System.Windows.Forms.TextBox()
        Me.txtPrice = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.cmbUnit = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtQty = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.dtpDateBought = New System.Windows.Forms.DateTimePicker()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtItemName = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.POS_databaseDataSet5 = New POS_Project.POS_databaseDataSet5()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Recieved = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RawMatID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnEdit = New System.Windows.Forms.Button()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.ListView1 = New System.Windows.Forms.ListView()
        Me.OrderID = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.SupplierName = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ItemName = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Quantity = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Unit = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Price = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Recieveds = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.DateBought = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.rmiD = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Returnings = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.txtoid = New System.Windows.Forms.TextBox()
        Me.Panel1.SuspendLayout()
        CType(Me.POS_databaseDataSet5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(203, Byte), Integer), CType(CType(217, Byte), Integer), CType(CType(166, Byte), Integer))
        Me.Panel1.Controls.Add(Me.btnRefresh)
        Me.Panel1.Controls.Add(Me.cmbSupplier)
        Me.Panel1.Controls.Add(Me.Label9)
        Me.Panel1.Controls.Add(Me.txtRawMatID)
        Me.Panel1.Controls.Add(Me.txtPrice)
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.Controls.Add(Me.cmbUnit)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.txtQty)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.dtpDateBought)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.txtItemName)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel1.Location = New System.Drawing.Point(12, 57)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(552, 89)
        Me.Panel1.TabIndex = 32
        '
        'btnRefresh
        '
        Me.btnRefresh.BackColor = System.Drawing.Color.FromArgb(CType(CType(185, Byte), Integer), CType(CType(220, Byte), Integer), CType(CType(180, Byte), Integer))
        Me.btnRefresh.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnRefresh.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnRefresh.Location = New System.Drawing.Point(462, 46)
        Me.btnRefresh.Name = "btnRefresh"
        Me.btnRefresh.Size = New System.Drawing.Size(77, 38)
        Me.btnRefresh.TabIndex = 8
        Me.btnRefresh.Text = "Refresh"
        Me.btnRefresh.UseVisualStyleBackColor = False
        '
        'cmbSupplier
        '
        Me.cmbSupplier.FormattingEnabled = True
        Me.cmbSupplier.Location = New System.Drawing.Point(100, 9)
        Me.cmbSupplier.Name = "cmbSupplier"
        Me.cmbSupplier.Size = New System.Drawing.Size(160, 24)
        Me.cmbSupplier.TabIndex = 44
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label9.Location = New System.Drawing.Point(317, 39)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(67, 16)
        Me.Label9.TabIndex = 43
        Me.Label9.Text = "RawMatID"
        '
        'txtRawMatID
        '
        Me.txtRawMatID.Location = New System.Drawing.Point(390, 36)
        Me.txtRawMatID.Name = "txtRawMatID"
        Me.txtRawMatID.Size = New System.Drawing.Size(52, 21)
        Me.txtRawMatID.TabIndex = 8
        '
        'txtPrice
        '
        Me.txtPrice.Location = New System.Drawing.Point(357, 61)
        Me.txtPrice.Name = "txtPrice"
        Me.txtPrice.Size = New System.Drawing.Size(71, 21)
        Me.txtPrice.TabIndex = 42
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label8.Location = New System.Drawing.Point(317, 64)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(34, 16)
        Me.Label8.TabIndex = 41
        Me.Label8.Text = "Price"
        '
        'cmbUnit
        '
        Me.cmbUnit.FormattingEnabled = True
        Me.cmbUnit.Items.AddRange(New Object() {"grams", "mL", "pieces"})
        Me.cmbUnit.Location = New System.Drawing.Point(390, 7)
        Me.cmbUnit.Name = "cmbUnit"
        Me.cmbUnit.Size = New System.Drawing.Size(68, 24)
        Me.cmbUnit.TabIndex = 40
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label6.Location = New System.Drawing.Point(355, 12)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(29, 16)
        Me.Label6.TabIndex = 39
        Me.Label6.Text = "Unit"
        '
        'txtQty
        '
        Me.txtQty.Location = New System.Drawing.Point(300, 10)
        Me.txtQty.Name = "txtQty"
        Me.txtQty.Size = New System.Drawing.Size(48, 21)
        Me.txtQty.TabIndex = 27
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(266, 13)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(28, 16)
        Me.Label3.TabIndex = 26
        Me.Label3.Text = "Qty"
        '
        'dtpDateBought
        '
        Me.dtpDateBought.Location = New System.Drawing.Point(89, 62)
        Me.dtpDateBought.Name = "dtpDateBought"
        Me.dtpDateBought.Size = New System.Drawing.Size(222, 21)
        Me.dtpDateBought.TabIndex = 24
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(7, 67)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(76, 16)
        Me.Label5.TabIndex = 23
        Me.Label5.Text = "Date Bought"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(7, 13)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(87, 16)
        Me.Label4.TabIndex = 21
        Me.Label4.Text = "Supplier Name"
        '
        'txtItemName
        '
        Me.txtItemName.Location = New System.Drawing.Point(81, 36)
        Me.txtItemName.Name = "txtItemName"
        Me.txtItemName.Size = New System.Drawing.Size(230, 21)
        Me.txtItemName.TabIndex = 20
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label7.Location = New System.Drawing.Point(7, 39)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(68, 16)
        Me.Label7.TabIndex = 13
        Me.Label7.Text = "Item Name"
        '
        'POS_databaseDataSet5
        '
        Me.POS_databaseDataSet5.DataSetName = "POS_databaseDataSet5"
        Me.POS_databaseDataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(11, 12)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(285, 42)
        Me.Label1.TabIndex = 31
        Me.Label1.Text = "Purchase Order"
        '
        'DataGridView1
        '
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.LimeGreen
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Recieved, Me.RawMatID})
        Me.DataGridView1.Location = New System.Drawing.Point(-3, 453)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(552, 247)
        Me.DataGridView1.TabIndex = 33
        '
        'Recieved
        '
        Me.Recieved.HeaderText = "Recieved"
        Me.Recieved.Name = "Recieved"
        '
        'RawMatID
        '
        Me.RawMatID.HeaderText = "RawMatID"
        Me.RawMatID.Name = "RawMatID"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(145, Byte), Integer), CType(CType(132, Byte), Integer))
        Me.Panel2.Controls.Add(Me.Label11)
        Me.Panel2.Controls.Add(Me.btnClear)
        Me.Panel2.Controls.Add(Me.btnEdit)
        Me.Panel2.Controls.Add(Me.btnAdd)
        Me.Panel2.Controls.Add(Me.btnDelete)
        Me.Panel2.Location = New System.Drawing.Point(570, 24)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(127, 368)
        Me.Panel2.TabIndex = 37
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
        Me.btnClear.Image = CType(resources.GetObject("btnClear.Image"), System.Drawing.Image)
        Me.btnClear.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnClear.Location = New System.Drawing.Point(10, 251)
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
        Me.btnEdit.Location = New System.Drawing.Point(10, 145)
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
        Me.btnAdd.Location = New System.Drawing.Point(10, 92)
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
        Me.btnDelete.Location = New System.Drawing.Point(10, 198)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(110, 31)
        Me.btnDelete.TabIndex = 1
        Me.btnDelete.Text = "Delete"
        Me.btnDelete.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(290, 4)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(66, 50)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 38
        Me.PictureBox1.TabStop = False
        '
        'ListView1
        '
        Me.ListView1.BackColor = System.Drawing.Color.MintCream
        Me.ListView1.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.OrderID, Me.SupplierName, Me.ItemName, Me.Quantity, Me.Unit, Me.Price, Me.Recieveds, Me.DateBought, Me.rmiD, Me.Returnings})
        Me.ListView1.FullRowSelect = True
        Me.ListView1.HideSelection = False
        Me.ListView1.Location = New System.Drawing.Point(12, 155)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(552, 237)
        Me.ListView1.TabIndex = 39
        Me.ListView1.UseCompatibleStateImageBehavior = False
        Me.ListView1.View = System.Windows.Forms.View.Details
        '
        'OrderID
        '
        Me.OrderID.Text = "OrderID"
        '
        'SupplierName
        '
        Me.SupplierName.Text = "Supplier Name"
        Me.SupplierName.Width = 99
        '
        'ItemName
        '
        Me.ItemName.Text = "Item Name"
        Me.ItemName.Width = 92
        '
        'Quantity
        '
        Me.Quantity.Text = "Quantity"
        Me.Quantity.Width = 61
        '
        'Unit
        '
        Me.Unit.Text = "Unit"
        '
        'Price
        '
        Me.Price.Text = "Price"
        Me.Price.Width = 63
        '
        'Recieveds
        '
        Me.Recieveds.Text = "Recieved"
        Me.Recieveds.Width = 59
        '
        'DateBought
        '
        Me.DateBought.Text = "DateBought"
        Me.DateBought.Width = 104
        '
        'rmiD
        '
        Me.rmiD.Text = "RawMatID"
        Me.rmiD.Width = 98
        '
        'Returnings
        '
        Me.Returnings.Text = "Returned"
        '
        'txtoid
        '
        Me.txtoid.Location = New System.Drawing.Point(530, 34)
        Me.txtoid.Name = "txtoid"
        Me.txtoid.Size = New System.Drawing.Size(34, 20)
        Me.txtoid.TabIndex = 63
        Me.txtoid.Visible = False
        '
        'PurchaseOrderForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightGreen
        Me.ClientSize = New System.Drawing.Size(705, 403)
        Me.Controls.Add(Me.txtoid)
        Me.Controls.Add(Me.ListView1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "PurchaseOrderForm"
        Me.Text = "PurchaseOrderForm"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.POS_databaseDataSet5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel1 As Panel
    Friend WithEvents txtItemName As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents dtpDateBought As DateTimePicker
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label11 As Label
    Friend WithEvents btnClear As Button
    Friend WithEvents btnEdit As Button
    Friend WithEvents btnAdd As Button
    Friend WithEvents btnDelete As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtQty As TextBox
    Friend WithEvents cmbUnit As ComboBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txtPrice As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents POS_databaseDataSet5 As POS_databaseDataSet5
    Friend WithEvents Label9 As Label
    Friend WithEvents txtRawMatID As TextBox
    Friend WithEvents cmbSupplier As ComboBox
    Friend WithEvents Recieved As DataGridViewTextBoxColumn
    Friend WithEvents RawMatID As DataGridViewTextBoxColumn
    Friend WithEvents ListView1 As ListView
    Friend WithEvents OrderID As ColumnHeader
    Friend WithEvents SupplierName As ColumnHeader
    Friend WithEvents ItemName As ColumnHeader
    Friend WithEvents Quantity As ColumnHeader
    Friend WithEvents Unit As ColumnHeader
    Friend WithEvents Price As ColumnHeader
    Friend WithEvents Recieveds As ColumnHeader
    Friend WithEvents DateBought As ColumnHeader
    Friend WithEvents rmiD As ColumnHeader
    Friend WithEvents Returnings As ColumnHeader
    Friend WithEvents txtoid As TextBox
    Friend WithEvents btnRefresh As Button
End Class
