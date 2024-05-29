<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ReturnForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ReturnForm))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.ListView1 = New System.Windows.Forms.ListView()
        Me.OrderID = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.SupplierName = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ItemName = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Quantity = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Unit = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.txtoid = New System.Windows.Forms.TextBox()
        Me.btnReturn = New System.Windows.Forms.Button()
        Me.cmbSupplier = New System.Windows.Forms.ComboBox()
        Me.cmbUnit = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtQty = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtItemName = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtqty1 = New System.Windows.Forms.TextBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(5, 27)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(141, 42)
        Me.Label1.TabIndex = 47
        Me.Label1.Text = "Returns"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(135, 6)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(73, 63)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 51
        Me.PictureBox1.TabStop = False
        '
        'ListView1
        '
        Me.ListView1.BackColor = System.Drawing.Color.MintCream
        Me.ListView1.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.OrderID, Me.SupplierName, Me.ItemName, Me.Quantity, Me.Unit})
        Me.ListView1.FullRowSelect = True
        Me.ListView1.HideSelection = False
        Me.ListView1.Location = New System.Drawing.Point(12, 154)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(577, 191)
        Me.ListView1.TabIndex = 53
        Me.ListView1.UseCompatibleStateImageBehavior = False
        Me.ListView1.View = System.Windows.Forms.View.Details
        '
        'OrderID
        '
        Me.OrderID.Text = "OrderID"
        Me.OrderID.Width = 75
        '
        'SupplierName
        '
        Me.SupplierName.Text = "Supplier Name"
        Me.SupplierName.Width = 168
        '
        'ItemName
        '
        Me.ItemName.Text = "Item Name"
        Me.ItemName.Width = 202
        '
        'Quantity
        '
        Me.Quantity.Text = "Quantity"
        Me.Quantity.Width = 80
        '
        'Unit
        '
        Me.Unit.Text = "Unit"
        Me.Unit.Width = 67
        '
        'txtoid
        '
        Me.txtoid.BackColor = System.Drawing.Color.Honeydew
        Me.txtoid.Enabled = False
        Me.txtoid.Location = New System.Drawing.Point(431, 15)
        Me.txtoid.Name = "txtoid"
        Me.txtoid.Size = New System.Drawing.Size(45, 21)
        Me.txtoid.TabIndex = 62
        '
        'btnReturn
        '
        Me.btnReturn.BackColor = System.Drawing.Color.FromArgb(CType(CType(185, Byte), Integer), CType(CType(220, Byte), Integer), CType(CType(180, Byte), Integer))
        Me.btnReturn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnReturn.ForeColor = System.Drawing.Color.Black
        Me.btnReturn.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnReturn.Location = New System.Drawing.Point(482, 16)
        Me.btnReturn.Name = "btnReturn"
        Me.btnReturn.Size = New System.Drawing.Size(74, 50)
        Me.btnReturn.TabIndex = 63
        Me.btnReturn.Text = "Return"
        Me.btnReturn.UseVisualStyleBackColor = False
        '
        'cmbSupplier
        '
        Me.cmbSupplier.BackColor = System.Drawing.Color.Honeydew
        Me.cmbSupplier.Enabled = False
        Me.cmbSupplier.FormattingEnabled = True
        Me.cmbSupplier.Location = New System.Drawing.Point(107, 16)
        Me.cmbSupplier.Name = "cmbSupplier"
        Me.cmbSupplier.Size = New System.Drawing.Size(158, 24)
        Me.cmbSupplier.TabIndex = 71
        '
        'cmbUnit
        '
        Me.cmbUnit.BackColor = System.Drawing.Color.Honeydew
        Me.cmbUnit.Enabled = False
        Me.cmbUnit.FormattingEnabled = True
        Me.cmbUnit.Items.AddRange(New Object() {"grams", "mL", "pieces"})
        Me.cmbUnit.Location = New System.Drawing.Point(306, 46)
        Me.cmbUnit.Name = "cmbUnit"
        Me.cmbUnit.Size = New System.Drawing.Size(68, 24)
        Me.cmbUnit.TabIndex = 70
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label6.Location = New System.Drawing.Point(271, 50)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(29, 16)
        Me.Label6.TabIndex = 69
        Me.Label6.Text = "Unit"
        '
        'txtQty
        '
        Me.txtQty.Location = New System.Drawing.Point(305, 17)
        Me.txtQty.Name = "txtQty"
        Me.txtQty.Size = New System.Drawing.Size(61, 21)
        Me.txtQty.TabIndex = 68
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(271, 20)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(28, 16)
        Me.Label3.TabIndex = 67
        Me.Label3.Text = "Qty"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(14, 20)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(87, 16)
        Me.Label4.TabIndex = 66
        Me.Label4.Text = "Supplier Name"
        '
        'txtItemName
        '
        Me.txtItemName.BackColor = System.Drawing.Color.Honeydew
        Me.txtItemName.Enabled = False
        Me.txtItemName.Location = New System.Drawing.Point(88, 47)
        Me.txtItemName.Name = "txtItemName"
        Me.txtItemName.Size = New System.Drawing.Size(177, 21)
        Me.txtItemName.TabIndex = 65
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label7.Location = New System.Drawing.Point(14, 50)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(68, 16)
        Me.Label7.TabIndex = 64
        Me.Label7.Text = "Item Name"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(203, Byte), Integer), CType(CType(217, Byte), Integer), CType(CType(166, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.btnReturn)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.cmbSupplier)
        Me.Panel1.Controls.Add(Me.txtItemName)
        Me.Panel1.Controls.Add(Me.txtoid)
        Me.Panel1.Controls.Add(Me.cmbUnit)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.txtQty)
        Me.Panel1.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel1.Location = New System.Drawing.Point(12, 72)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(577, 79)
        Me.Panel1.TabIndex = 73
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(372, 17)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(53, 16)
        Me.Label2.TabIndex = 72
        Me.Label2.Text = "Order ID"
        '
        'txtqty1
        '
        Me.txtqty1.Location = New System.Drawing.Point(548, 46)
        Me.txtqty1.Name = "txtqty1"
        Me.txtqty1.Size = New System.Drawing.Size(41, 20)
        Me.txtqty1.TabIndex = 76
        Me.txtqty1.Visible = False
        '
        'ReturnForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightGreen
        Me.ClientSize = New System.Drawing.Size(601, 356)
        Me.Controls.Add(Me.txtqty1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.ListView1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label1)
        Me.Name = "ReturnForm"
        Me.Text = "ReturnForm"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents ListView1 As ListView
    Friend WithEvents OrderID As ColumnHeader
    Friend WithEvents SupplierName As ColumnHeader
    Friend WithEvents ItemName As ColumnHeader
    Friend WithEvents Quantity As ColumnHeader
    Friend WithEvents Unit As ColumnHeader
    Friend WithEvents txtoid As TextBox
    Friend WithEvents btnReturn As Button
    Friend WithEvents cmbSupplier As ComboBox
    Friend WithEvents cmbUnit As ComboBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txtQty As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtItemName As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents txtqty1 As TextBox
End Class
