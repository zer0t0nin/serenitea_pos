<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ReceivingForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ReceivingForm))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.POS_databaseDataSet7 = New POS_Project.POS_databaseDataSet7()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.ListView1 = New System.Windows.Forms.ListView()
        Me.OrderID = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.SupplierName = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ItemName = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Quantity = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Unit = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Recieving = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtoid = New System.Windows.Forms.TextBox()
        Me.txtReceive = New System.Windows.Forms.Button()
        Me.cmbSupplier = New System.Windows.Forms.ComboBox()
        Me.cmbUnit = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtQty = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtItemName = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        CType(Me.POS_databaseDataSet7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(15, 17)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(188, 42)
        Me.Label1.TabIndex = 42
        Me.Label1.Text = "Receiving"
        '
        'POS_databaseDataSet7
        '
        Me.POS_databaseDataSet7.DataSetName = "POS_databaseDataSet7"
        Me.POS_databaseDataSet7.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(209, 2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(65, 57)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 47
        Me.PictureBox1.TabStop = False
        '
        'ListView1
        '
        Me.ListView1.BackColor = System.Drawing.Color.MintCream
        Me.ListView1.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.OrderID, Me.SupplierName, Me.ItemName, Me.Quantity, Me.Unit, Me.Recieving})
        Me.ListView1.FullRowSelect = True
        Me.ListView1.HideSelection = False
        Me.ListView1.Location = New System.Drawing.Point(12, 140)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(574, 177)
        Me.ListView1.TabIndex = 48
        Me.ListView1.UseCompatibleStateImageBehavior = False
        Me.ListView1.View = System.Windows.Forms.View.Details
        '
        'OrderID
        '
        Me.OrderID.Text = "OrderID"
        Me.OrderID.Width = 57
        '
        'SupplierName
        '
        Me.SupplierName.Text = "Supplier Name"
        Me.SupplierName.Width = 143
        '
        'ItemName
        '
        Me.ItemName.Text = "Item Name"
        Me.ItemName.Width = 152
        '
        'Quantity
        '
        Me.Quantity.Text = "Quantity"
        Me.Quantity.Width = 71
        '
        'Unit
        '
        Me.Unit.Text = "Unit"
        Me.Unit.Width = 86
        '
        'Recieving
        '
        Me.Recieving.Text = "Received"
        Me.Recieving.Width = 74
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(203, Byte), Integer), CType(CType(217, Byte), Integer), CType(CType(166, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.txtoid)
        Me.Panel1.Controls.Add(Me.txtReceive)
        Me.Panel1.Controls.Add(Me.cmbSupplier)
        Me.Panel1.Controls.Add(Me.cmbUnit)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.txtQty)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.txtItemName)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel1.Location = New System.Drawing.Point(12, 65)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(574, 69)
        Me.Panel1.TabIndex = 49
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(373, 12)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(53, 16)
        Me.Label2.TabIndex = 74
        Me.Label2.Text = "Order ID"
        '
        'txtoid
        '
        Me.txtoid.BackColor = System.Drawing.Color.Honeydew
        Me.txtoid.Location = New System.Drawing.Point(426, 10)
        Me.txtoid.Name = "txtoid"
        Me.txtoid.ReadOnly = True
        Me.txtoid.Size = New System.Drawing.Size(41, 21)
        Me.txtoid.TabIndex = 73
        '
        'txtReceive
        '
        Me.txtReceive.BackColor = System.Drawing.Color.FromArgb(CType(CType(185, Byte), Integer), CType(CType(220, Byte), Integer), CType(CType(180, Byte), Integer))
        Me.txtReceive.Cursor = System.Windows.Forms.Cursors.Hand
        Me.txtReceive.ForeColor = System.Drawing.Color.Black
        Me.txtReceive.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.txtReceive.Location = New System.Drawing.Point(488, 9)
        Me.txtReceive.Name = "txtReceive"
        Me.txtReceive.Size = New System.Drawing.Size(69, 50)
        Me.txtReceive.TabIndex = 62
        Me.txtReceive.Text = "Receive"
        Me.txtReceive.UseVisualStyleBackColor = False
        '
        'cmbSupplier
        '
        Me.cmbSupplier.BackColor = System.Drawing.Color.Honeydew
        Me.cmbSupplier.Enabled = False
        Me.cmbSupplier.FormattingEnabled = True
        Me.cmbSupplier.Location = New System.Drawing.Point(100, 9)
        Me.cmbSupplier.Name = "cmbSupplier"
        Me.cmbSupplier.Size = New System.Drawing.Size(180, 24)
        Me.cmbSupplier.TabIndex = 44
        '
        'cmbUnit
        '
        Me.cmbUnit.BackColor = System.Drawing.Color.Honeydew
        Me.cmbUnit.Enabled = False
        Me.cmbUnit.FormattingEnabled = True
        Me.cmbUnit.Items.AddRange(New Object() {"grams", "mL", "pieces"})
        Me.cmbUnit.Location = New System.Drawing.Point(325, 35)
        Me.cmbUnit.Name = "cmbUnit"
        Me.cmbUnit.Size = New System.Drawing.Size(75, 24)
        Me.cmbUnit.TabIndex = 40
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label6.Location = New System.Drawing.Point(293, 40)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(29, 16)
        Me.Label6.TabIndex = 39
        Me.Label6.Text = "Unit"
        '
        'txtQty
        '
        Me.txtQty.BackColor = System.Drawing.Color.Honeydew
        Me.txtQty.Location = New System.Drawing.Point(325, 10)
        Me.txtQty.Name = "txtQty"
        Me.txtQty.ReadOnly = True
        Me.txtQty.Size = New System.Drawing.Size(42, 21)
        Me.txtQty.TabIndex = 27
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(293, 13)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(28, 16)
        Me.Label3.TabIndex = 26
        Me.Label3.Text = "Qty"
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
        Me.txtItemName.BackColor = System.Drawing.Color.Honeydew
        Me.txtItemName.Location = New System.Drawing.Point(81, 36)
        Me.txtItemName.Name = "txtItemName"
        Me.txtItemName.ReadOnly = True
        Me.txtItemName.Size = New System.Drawing.Size(199, 21)
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
        'ReceivingForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightGreen
        Me.ClientSize = New System.Drawing.Size(598, 327)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.ListView1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label1)
        Me.Name = "ReceivingForm"
        Me.Text = "ReceivingForm"
        CType(Me.POS_databaseDataSet7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As Label
    Friend WithEvents POS_databaseDataSet7 As POS_databaseDataSet7
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents ListView1 As ListView
    Friend WithEvents OrderID As ColumnHeader
    Friend WithEvents SupplierName As ColumnHeader
    Friend WithEvents ItemName As ColumnHeader
    Friend WithEvents Quantity As ColumnHeader
    Friend WithEvents Unit As ColumnHeader
    Friend WithEvents Recieving As ColumnHeader
    Friend WithEvents Panel1 As Panel
    Friend WithEvents txtReceive As Button
    Friend WithEvents cmbSupplier As ComboBox
    Friend WithEvents cmbUnit As ComboBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txtQty As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtItemName As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtoid As TextBox
End Class
