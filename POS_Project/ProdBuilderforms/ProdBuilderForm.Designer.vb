<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ProdBuilderForm
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.cmbCategory = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cmbItemName = New System.Windows.Forms.ComboBox()
        Me.txtProdID = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btnCreate = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.nudProdQty = New System.Windows.Forms.NumericUpDown()
        Me.lvCompNeed = New System.Windows.Forms.ListView()
        Me.RawMatID = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.RawMaterialName = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Qty = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Unit = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.lvRawMatsStock = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.nudProdQty, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(145, Byte), Integer), CType(CType(132, Byte), Integer))
        Me.GroupBox1.Controls.Add(Me.cmbCategory)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.cmbItemName)
        Me.GroupBox1.Controls.Add(Me.txtProdID)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.PaleGreen
        Me.GroupBox1.Location = New System.Drawing.Point(10, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(458, 102)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "View Composition"
        '
        'cmbCategory
        '
        Me.cmbCategory.FormattingEnabled = True
        Me.cmbCategory.Location = New System.Drawing.Point(320, 31)
        Me.cmbCategory.Name = "cmbCategory"
        Me.cmbCategory.Size = New System.Drawing.Size(121, 25)
        Me.cmbCategory.TabIndex = 32
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(180, 36)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(134, 17)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Beverage Category"
        '
        'cmbItemName
        '
        Me.cmbItemName.FormattingEnabled = True
        Me.cmbItemName.Location = New System.Drawing.Point(136, 64)
        Me.cmbItemName.Name = "cmbItemName"
        Me.cmbItemName.Size = New System.Drawing.Size(134, 25)
        Me.cmbItemName.TabIndex = 31
        '
        'txtProdID
        '
        Me.txtProdID.Enabled = False
        Me.txtProdID.Location = New System.Drawing.Point(99, 31)
        Me.txtProdID.Name = "txtProdID"
        Me.txtProdID.ReadOnly = True
        Me.txtProdID.Size = New System.Drawing.Size(75, 23)
        Me.txtProdID.TabIndex = 30
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(17, 34)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(76, 17)
        Me.Label5.TabIndex = 21
        Me.Label5.Text = "Product ID"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(17, 67)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(113, 17)
        Me.Label6.TabIndex = 24
        Me.Label6.Text = "Beverage Name"
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.FromArgb(CType(CType(203, Byte), Integer), CType(CType(217, Byte), Integer), CType(CType(166, Byte), Integer))
        Me.GroupBox2.Controls.Add(Me.btnCreate)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.nudProdQty)
        Me.GroupBox2.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.GroupBox2.Location = New System.Drawing.Point(474, 12)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(458, 102)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Build A Product"
        '
        'btnCreate
        '
        Me.btnCreate.BackColor = System.Drawing.Color.FromArgb(CType(CType(185, Byte), Integer), CType(CType(220, Byte), Integer), CType(CType(180, Byte), Integer))
        Me.btnCreate.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnCreate.Location = New System.Drawing.Point(311, 36)
        Me.btnCreate.Name = "btnCreate"
        Me.btnCreate.Size = New System.Drawing.Size(75, 36)
        Me.btnCreate.TabIndex = 7
        Me.btnCreate.Text = "Create"
        Me.btnCreate.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(61, 46)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(118, 17)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Product Quantity"
        '
        'nudProdQty
        '
        Me.nudProdQty.Location = New System.Drawing.Point(185, 44)
        Me.nudProdQty.Name = "nudProdQty"
        Me.nudProdQty.Size = New System.Drawing.Size(120, 23)
        Me.nudProdQty.TabIndex = 5
        '
        'lvCompNeed
        '
        Me.lvCompNeed.BackColor = System.Drawing.Color.MintCream
        Me.lvCompNeed.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.RawMatID, Me.RawMaterialName, Me.Qty, Me.Unit})
        Me.lvCompNeed.HideSelection = False
        Me.lvCompNeed.Location = New System.Drawing.Point(10, 120)
        Me.lvCompNeed.Name = "lvCompNeed"
        Me.lvCompNeed.Size = New System.Drawing.Size(458, 236)
        Me.lvCompNeed.TabIndex = 3
        Me.lvCompNeed.UseCompatibleStateImageBehavior = False
        Me.lvCompNeed.View = System.Windows.Forms.View.Details
        '
        'RawMatID
        '
        Me.RawMatID.Text = "RawMatID"
        Me.RawMatID.Width = 86
        '
        'RawMaterialName
        '
        Me.RawMaterialName.Text = "Raw Material Name"
        Me.RawMaterialName.Width = 185
        '
        'Qty
        '
        Me.Qty.Text = "Qty"
        Me.Qty.Width = 64
        '
        'Unit
        '
        Me.Unit.Text = "Unit"
        Me.Unit.Width = 104
        '
        'lvRawMatsStock
        '
        Me.lvRawMatsStock.BackColor = System.Drawing.Color.Honeydew
        Me.lvRawMatsStock.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader4})
        Me.lvRawMatsStock.HideSelection = False
        Me.lvRawMatsStock.Location = New System.Drawing.Point(474, 120)
        Me.lvRawMatsStock.Name = "lvRawMatsStock"
        Me.lvRawMatsStock.Size = New System.Drawing.Size(458, 236)
        Me.lvRawMatsStock.TabIndex = 4
        Me.lvRawMatsStock.UseCompatibleStateImageBehavior = False
        Me.lvRawMatsStock.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "RawMatID"
        Me.ColumnHeader1.Width = 86
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Raw Material Name"
        Me.ColumnHeader2.Width = 185
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Qty"
        Me.ColumnHeader3.Width = 64
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "Unit"
        Me.ColumnHeader4.Width = 104
        '
        'ProdBuilderForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightGreen
        Me.ClientSize = New System.Drawing.Size(941, 367)
        Me.Controls.Add(Me.lvRawMatsStock)
        Me.Controls.Add(Me.lvCompNeed)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "ProdBuilderForm"
        Me.Text = "ProdBuilderForm"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.nudProdQty, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents cmbItemName As ComboBox
    Friend WithEvents txtProdID As TextBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents lvCompNeed As ListView
    Friend WithEvents RawMatID As ColumnHeader
    Friend WithEvents RawMaterialName As ColumnHeader
    Friend WithEvents Qty As ColumnHeader
    Friend WithEvents Unit As ColumnHeader
    Friend WithEvents lvRawMatsStock As ListView
    Friend WithEvents ColumnHeader1 As ColumnHeader
    Friend WithEvents ColumnHeader2 As ColumnHeader
    Friend WithEvents ColumnHeader3 As ColumnHeader
    Friend WithEvents ColumnHeader4 As ColumnHeader
    Friend WithEvents Label1 As Label
    Friend WithEvents nudProdQty As NumericUpDown
    Friend WithEvents btnCreate As Button
    Friend WithEvents cmbCategory As ComboBox
    Friend WithEvents Label2 As Label
End Class
