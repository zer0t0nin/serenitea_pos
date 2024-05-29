<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class POSMod
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(POSMod))
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.btnCompute = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btnRefresh = New System.Windows.Forms.Button()
        Me.btnSend = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.txtqty = New System.Windows.Forms.Panel()
        Me.btnRelax = New System.Windows.Forms.Button()
        Me.btnEnergize = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.txtqtyy = New System.Windows.Forms.TextBox()
        Me.btnAddtoO = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cmbProductList = New System.Windows.Forms.ComboBox()
        Me.DataGridView2 = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txtChange = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtCash = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtTotal = New System.Windows.Forms.TextBox()
        Me.txtDiscount = New System.Windows.Forms.TextBox()
        Me.txtSubtotal = New System.Windows.Forms.TextBox()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.btnPrint = New System.Windows.Forms.Button()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.btnLogout = New System.Windows.Forms.Button()
        Me.txtEmployeeName = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.lblDate = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        Me.Panel4.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnCompute
        '
        Me.btnCompute.BackColor = System.Drawing.Color.FromArgb(CType(CType(203, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(201, Byte), Integer))
        Me.btnCompute.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCompute.Location = New System.Drawing.Point(14, 286)
        Me.btnCompute.Name = "btnCompute"
        Me.btnCompute.Size = New System.Drawing.Size(121, 23)
        Me.btnCompute.TabIndex = 9
        Me.btnCompute.Text = "Compute"
        Me.btnCompute.UseVisualStyleBackColor = False
        '
        'btnClear
        '
        Me.btnClear.BackColor = System.Drawing.Color.FromArgb(CType(CType(203, Byte), Integer), CType(CType(217, Byte), Integer), CType(CType(166, Byte), Integer))
        Me.btnClear.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.Location = New System.Drawing.Point(14, 310)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(121, 23)
        Me.btnClear.TabIndex = 8
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(159, 267)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(37, 15)
        Me.Label7.TabIndex = 5
        Me.Label7.Text = "Total:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(3, 264)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(58, 15)
        Me.Label6.TabIndex = 4
        Me.Label6.Text = "Discount:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(3, 239)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(58, 15)
        Me.Label5.TabIndex = 1
        Me.Label5.Text = "Subtotal: "
        '
        'btnRefresh
        '
        Me.btnRefresh.BackColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(91, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.btnRefresh.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRefresh.ForeColor = System.Drawing.Color.FromArgb(CType(CType(185, Byte), Integer), CType(CType(220, Byte), Integer), CType(CType(180, Byte), Integer))
        Me.btnRefresh.Location = New System.Drawing.Point(6, 7)
        Me.btnRefresh.Name = "btnRefresh"
        Me.btnRefresh.Size = New System.Drawing.Size(135, 29)
        Me.btnRefresh.TabIndex = 9
        Me.btnRefresh.Text = "Refresh"
        Me.btnRefresh.UseVisualStyleBackColor = False
        '
        'btnSend
        '
        Me.btnSend.BackColor = System.Drawing.Color.FromArgb(CType(CType(117, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(125, Byte), Integer))
        Me.btnSend.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSend.Location = New System.Drawing.Point(52, 9)
        Me.btnSend.Name = "btnSend"
        Me.btnSend.Size = New System.Drawing.Size(121, 27)
        Me.btnSend.TabIndex = 12
        Me.btnSend.Text = "Send"
        Me.btnSend.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(13, 9)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(208, 55)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 12
        Me.PictureBox1.TabStop = False
        '
        'txtqty
        '
        Me.txtqty.AutoScroll = True
        Me.txtqty.BackColor = System.Drawing.Color.LightGreen
        Me.txtqty.Location = New System.Drawing.Point(363, 113)
        Me.txtqty.Name = "txtqty"
        Me.txtqty.Size = New System.Drawing.Size(530, 337)
        Me.txtqty.TabIndex = 13
        '
        'btnRelax
        '
        Me.btnRelax.BackColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(91, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.btnRelax.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRelax.ForeColor = System.Drawing.Color.FromArgb(CType(CType(185, Byte), Integer), CType(CType(220, Byte), Integer), CType(CType(180, Byte), Integer))
        Me.btnRelax.Location = New System.Drawing.Point(389, 7)
        Me.btnRelax.Name = "btnRelax"
        Me.btnRelax.Size = New System.Drawing.Size(135, 29)
        Me.btnRelax.TabIndex = 11
        Me.btnRelax.Text = "Relax"
        Me.btnRelax.UseVisualStyleBackColor = False
        '
        'btnEnergize
        '
        Me.btnEnergize.BackColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(91, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.btnEnergize.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEnergize.ForeColor = System.Drawing.Color.FromArgb(CType(CType(185, Byte), Integer), CType(CType(220, Byte), Integer), CType(CType(180, Byte), Integer))
        Me.btnEnergize.Location = New System.Drawing.Point(198, 7)
        Me.btnEnergize.Name = "btnEnergize"
        Me.btnEnergize.Size = New System.Drawing.Size(135, 29)
        Me.btnEnergize.TabIndex = 10
        Me.btnEnergize.Text = "Energize"
        Me.btnEnergize.UseVisualStyleBackColor = False
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(145, Byte), Integer), CType(CType(132, Byte), Integer))
        Me.Panel2.Controls.Add(Me.btnDelete)
        Me.Panel2.Controls.Add(Me.Panel1)
        Me.Panel2.Controls.Add(Me.DataGridView2)
        Me.Panel2.Controls.Add(Me.txtChange)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Controls.Add(Me.txtCash)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Controls.Add(Me.btnCompute)
        Me.Panel2.Controls.Add(Me.txtTotal)
        Me.Panel2.Controls.Add(Me.txtDiscount)
        Me.Panel2.Controls.Add(Me.txtSubtotal)
        Me.Panel2.Controls.Add(Me.btnClear)
        Me.Panel2.Controls.Add(Me.Label5)
        Me.Panel2.Controls.Add(Me.Label7)
        Me.Panel2.Controls.Add(Me.Label6)
        Me.Panel2.Location = New System.Drawing.Point(13, 71)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(313, 336)
        Me.Panel2.TabIndex = 12
        '
        'btnDelete
        '
        Me.btnDelete.BackColor = System.Drawing.Color.IndianRed
        Me.btnDelete.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDelete.Location = New System.Drawing.Point(136, 310)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(71, 23)
        Me.btnDelete.TabIndex = 27
        Me.btnDelete.Text = "Delete"
        Me.btnDelete.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.txtqtyy)
        Me.Panel1.Controls.Add(Me.btnAddtoO)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.cmbProductList)
        Me.Panel1.Location = New System.Drawing.Point(0, 179)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(313, 51)
        Me.Panel1.TabIndex = 26
        '
        'txtqtyy
        '
        Me.txtqtyy.Location = New System.Drawing.Point(67, 28)
        Me.txtqtyy.Name = "txtqtyy"
        Me.txtqtyy.Size = New System.Drawing.Size(49, 20)
        Me.txtqtyy.TabIndex = 19
        '
        'btnAddtoO
        '
        Me.btnAddtoO.BackColor = System.Drawing.Color.FromArgb(CType(CType(117, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(125, Byte), Integer))
        Me.btnAddtoO.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddtoO.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAddtoO.Location = New System.Drawing.Point(124, 25)
        Me.btnAddtoO.Name = "btnAddtoO"
        Me.btnAddtoO.Size = New System.Drawing.Size(104, 23)
        Me.btnAddtoO.TabIndex = 15
        Me.btnAddtoO.Text = "Add to Order"
        Me.btnAddtoO.UseVisualStyleBackColor = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(3, 30)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(46, 13)
        Me.Label4.TabIndex = 18
        Me.Label4.Text = "Quantity"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(3, 7)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(86, 13)
        Me.Label3.TabIndex = 16
        Me.Label3.Text = "For Bulk Order(s)"
        '
        'cmbProductList
        '
        Me.cmbProductList.FormattingEnabled = True
        Me.cmbProductList.Items.AddRange(New Object() {"Toffee Latte Espresso", "Mocha Latte Espresso", "Coffee Frost Espresso", "Cafe Latte Espresso", "Americano Espresso", "Hokkaido Espresso Chaffee", "Okinawa Espresso Chaffee", "Matcha Espresso Chaffee", "Honey Calamansi", "Wintermelon Sweet", "Calamansi Fruitea", "Cranberry Fruitea", "Grapefruit Fruitea", "Green Apple Fruitea", "Lychee Fruitea", "Mango Fruitea", "Calamansi Yakult", "Green Apple Yakult", "Grapefruit Yakult", "Lychee Yakult", "Mango Yakult", "Assam Black Tea", "Earl Grey Black Tea", "Jasmine Green Tea", "Osmanthus Oolong Tea"})
        Me.cmbProductList.Location = New System.Drawing.Point(89, 4)
        Me.cmbProductList.Name = "cmbProductList"
        Me.cmbProductList.Size = New System.Drawing.Size(208, 21)
        Me.cmbProductList.TabIndex = 15
        '
        'DataGridView2
        '
        Me.DataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView2.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.DataGridView2.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(117, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(125, Byte), Integer))
        Me.DataGridView2.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable
        Me.DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView2.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3})
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.MintCream
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridView2.DefaultCellStyle = DataGridViewCellStyle3
        Me.DataGridView2.Location = New System.Drawing.Point(14, 17)
        Me.DataGridView2.MultiSelect = False
        Me.DataGridView2.Name = "DataGridView2"
        Me.DataGridView2.RowHeadersVisible = False
        Me.DataGridView2.Size = New System.Drawing.Size(283, 153)
        Me.DataGridView2.StandardTab = True
        Me.DataGridView2.TabIndex = 25
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "Name"
        Me.DataGridViewTextBoxColumn1.HeaderText = "Name"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "Qty"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Qty"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewTextBoxColumn2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "Total"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Total"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'txtChange
        '
        Me.txtChange.BackColor = System.Drawing.Color.Honeydew
        Me.txtChange.Location = New System.Drawing.Point(215, 291)
        Me.txtChange.Name = "txtChange"
        Me.txtChange.ReadOnly = True
        Me.txtChange.Size = New System.Drawing.Size(85, 20)
        Me.txtChange.TabIndex = 24
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(159, 294)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(53, 15)
        Me.Label2.TabIndex = 23
        Me.Label2.Text = "Change:"
        '
        'txtCash
        '
        Me.txtCash.Location = New System.Drawing.Point(215, 239)
        Me.txtCash.Name = "txtCash"
        Me.txtCash.Size = New System.Drawing.Size(85, 20)
        Me.txtCash.TabIndex = 22
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(158, 239)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(38, 15)
        Me.Label1.TabIndex = 21
        Me.Label1.Text = "Cash:"
        '
        'txtTotal
        '
        Me.txtTotal.BackColor = System.Drawing.Color.Honeydew
        Me.txtTotal.Location = New System.Drawing.Point(215, 264)
        Me.txtTotal.Name = "txtTotal"
        Me.txtTotal.ReadOnly = True
        Me.txtTotal.Size = New System.Drawing.Size(85, 20)
        Me.txtTotal.TabIndex = 12
        '
        'txtDiscount
        '
        Me.txtDiscount.Location = New System.Drawing.Point(67, 262)
        Me.txtDiscount.Name = "txtDiscount"
        Me.txtDiscount.Size = New System.Drawing.Size(85, 20)
        Me.txtDiscount.TabIndex = 11
        '
        'txtSubtotal
        '
        Me.txtSubtotal.BackColor = System.Drawing.Color.Honeydew
        Me.txtSubtotal.Location = New System.Drawing.Point(67, 236)
        Me.txtSubtotal.Name = "txtSubtotal"
        Me.txtSubtotal.ReadOnly = True
        Me.txtSubtotal.Size = New System.Drawing.Size(85, 20)
        Me.txtSubtotal.TabIndex = 10
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.SpringGreen
        Me.Panel3.Controls.Add(Me.btnPrint)
        Me.Panel3.Controls.Add(Me.btnSend)
        Me.Panel3.Location = New System.Drawing.Point(13, 413)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(313, 42)
        Me.Panel3.TabIndex = 14
        '
        'btnPrint
        '
        Me.btnPrint.BackColor = System.Drawing.Color.FromArgb(CType(CType(203, Byte), Integer), CType(CType(217, Byte), Integer), CType(CType(166, Byte), Integer))
        Me.btnPrint.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPrint.Location = New System.Drawing.Point(179, 9)
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.Size = New System.Drawing.Size(121, 27)
        Me.btnPrint.TabIndex = 15
        Me.btnPrint.Text = "Print Receipt"
        Me.btnPrint.UseVisualStyleBackColor = False
        Me.btnPrint.Visible = False
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.FromArgb(CType(CType(203, Byte), Integer), CType(CType(217, Byte), Integer), CType(CType(166, Byte), Integer))
        Me.Panel4.Controls.Add(Me.btnRelax)
        Me.Panel4.Controls.Add(Me.btnEnergize)
        Me.Panel4.Controls.Add(Me.btnRefresh)
        Me.Panel4.Location = New System.Drawing.Point(363, 71)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(530, 44)
        Me.Panel4.TabIndex = 12
        '
        'btnLogout
        '
        Me.btnLogout.BackColor = System.Drawing.Color.FromArgb(CType(CType(185, Byte), Integer), CType(CType(220, Byte), Integer), CType(CType(180, Byte), Integer))
        Me.btnLogout.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLogout.Location = New System.Drawing.Point(818, 18)
        Me.btnLogout.Name = "btnLogout"
        Me.btnLogout.Size = New System.Drawing.Size(75, 40)
        Me.btnLogout.TabIndex = 15
        Me.btnLogout.Text = "Log Out"
        Me.btnLogout.UseVisualStyleBackColor = False
        '
        'txtEmployeeName
        '
        Me.txtEmployeeName.BackColor = System.Drawing.Color.Honeydew
        Me.txtEmployeeName.Location = New System.Drawing.Point(550, 19)
        Me.txtEmployeeName.Name = "txtEmployeeName"
        Me.txtEmployeeName.ReadOnly = True
        Me.txtEmployeeName.Size = New System.Drawing.Size(263, 20)
        Me.txtEmployeeName.TabIndex = 16
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(457, 21)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(87, 16)
        Me.Label8.TabIndex = 17
        Me.Label8.Text = "Cashier Name:"
        '
        'lblDate
        '
        Me.lblDate.AutoSize = True
        Me.lblDate.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDate.Location = New System.Drawing.Point(547, 42)
        Me.lblDate.Name = "lblDate"
        Me.lblDate.Size = New System.Drawing.Size(35, 16)
        Me.lblDate.TabIndex = 18
        Me.lblDate.Text = "Date"
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(226, 9)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(68, 55)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 19
        Me.PictureBox2.TabStop = False
        '
        'Timer1
        '
        '
        'POSMod
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightGreen
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(925, 467)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.lblDate)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.txtEmployeeName)
        Me.Controls.Add(Me.btnLogout)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.txtqty)
        Me.Controls.Add(Me.PictureBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "POSMod"
        Me.Text = "POSMod"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.Panel4.ResumeLayout(False)
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents btnCompute As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents btnRefresh As Button
    Friend WithEvents btnSend As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents txtqty As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents btnRelax As Button
    Friend WithEvents btnEnergize As Button
    Friend WithEvents Panel4 As Panel
    Friend WithEvents txtTotal As TextBox
    Friend WithEvents txtDiscount As TextBox
    Friend WithEvents txtSubtotal As TextBox
    Friend WithEvents txtCash As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtChange As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents DataGridView2 As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents cmbProductList As ComboBox
    Friend WithEvents btnAddtoO As Button
    Friend WithEvents btnPrint As Button
    Friend WithEvents btnLogout As Button
    Friend WithEvents txtEmployeeName As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents lblDate As Label
    Friend WithEvents btnDelete As Button
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents txtqtyy As TextBox
    Friend WithEvents Timer1 As Timer
End Class
