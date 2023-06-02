<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Payment
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.discount_grid = New System.Windows.Forms.DataGridView()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Discou = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.discount_search = New System.Windows.Forms.TextBox()
        Me.discount_value = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.discountid = New System.Windows.Forms.ComboBox()
        Me.discounted_price = New System.Windows.Forms.TextBox()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.order_grid = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.order_search = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.order_date = New System.Windows.Forms.DateTimePicker()
        Me.order_quantity = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.order_price = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.order_lname = New System.Windows.Forms.TextBox()
        Me.order_fname = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.order_product = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.orderid = New System.Windows.Forms.ComboBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.pay_grid = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.pay_search = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.banktype = New System.Windows.Forms.TextBox()
        Me.bankid = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.pay_method = New System.Windows.Forms.ComboBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.pay_lname = New System.Windows.Forms.TextBox()
        Me.pay_fname = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.accountid = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.paymentid = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Clear_btn = New System.Windows.Forms.Button()
        Me.pay_save = New System.Windows.Forms.Button()
        Me.pay_gridview = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        CType(Me.discount_grid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        CType(Me.order_grid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        CType(Me.pay_grid, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.GroupBox4)
        Me.GroupBox1.Controls.Add(Me.GroupBox3)
        Me.GroupBox1.Controls.Add(Me.GroupBox2)
        Me.GroupBox1.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(43, 153)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1754, 528)
        Me.GroupBox1.TabIndex = 76
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Payment Transaction:"
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.discount_grid)
        Me.GroupBox4.Controls.Add(Me.discount_search)
        Me.GroupBox4.Controls.Add(Me.discount_value)
        Me.GroupBox4.Controls.Add(Me.Label12)
        Me.GroupBox4.Controls.Add(Me.discountid)
        Me.GroupBox4.Controls.Add(Me.discounted_price)
        Me.GroupBox4.Controls.Add(Me.Label22)
        Me.GroupBox4.Controls.Add(Me.Label23)
        Me.GroupBox4.Controls.Add(Me.Label24)
        Me.GroupBox4.Location = New System.Drawing.Point(1119, 39)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(588, 477)
        Me.GroupBox4.TabIndex = 78
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Payment ID:"
        '
        'discount_grid
        '
        Me.discount_grid.BackgroundColor = System.Drawing.SystemColors.Control
        Me.discount_grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.discount_grid.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column4, Me.Discou})
        Me.discount_grid.GridColor = System.Drawing.SystemColors.Control
        Me.discount_grid.Location = New System.Drawing.Point(24, 353)
        Me.discount_grid.Name = "discount_grid"
        Me.discount_grid.ReadOnly = True
        Me.discount_grid.RowTemplate.Height = 24
        Me.discount_grid.Size = New System.Drawing.Size(474, 103)
        Me.discount_grid.TabIndex = 130
        '
        'Column4
        '
        Me.Column4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Column4.HeaderText = "Discount ID"
        Me.Column4.Name = "Column4"
        Me.Column4.ReadOnly = True
        '
        'Discou
        '
        Me.Discou.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Discou.HeaderText = "Discount Value"
        Me.Discou.Name = "Discou"
        Me.Discou.ReadOnly = True
        '
        'discount_search
        '
        Me.discount_search.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.discount_search.Location = New System.Drawing.Point(24, 317)
        Me.discount_search.Margin = New System.Windows.Forms.Padding(4)
        Me.discount_search.Name = "discount_search"
        Me.discount_search.Size = New System.Drawing.Size(184, 30)
        Me.discount_search.TabIndex = 129
        '
        'discount_value
        '
        Me.discount_value.BackColor = System.Drawing.SystemColors.HighlightText
        Me.discount_value.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.discount_value.Enabled = False
        Me.discount_value.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.discount_value.Location = New System.Drawing.Point(200, 88)
        Me.discount_value.Margin = New System.Windows.Forms.Padding(4)
        Me.discount_value.Name = "discount_value"
        Me.discount_value.Size = New System.Drawing.Size(328, 30)
        Me.discount_value.TabIndex = 115
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.Color.Transparent
        Me.Label12.Font = New System.Drawing.Font("Arial Narrow", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(20, 289)
        Me.Label12.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(226, 22)
        Me.Label12.TabIndex = 128
        Me.Label12.Text = "Search by Payment ID or Name:"
        '
        'discountid
        '
        Me.discountid.BackColor = System.Drawing.SystemColors.HighlightText
        Me.discountid.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.discountid.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.discountid.FormattingEnabled = True
        Me.discountid.Location = New System.Drawing.Point(199, 50)
        Me.discountid.Name = "discountid"
        Me.discountid.Size = New System.Drawing.Size(329, 31)
        Me.discountid.TabIndex = 114
        '
        'discounted_price
        '
        Me.discounted_price.BackColor = System.Drawing.SystemColors.HighlightText
        Me.discounted_price.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.discounted_price.Enabled = False
        Me.discounted_price.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.discounted_price.Location = New System.Drawing.Point(200, 126)
        Me.discounted_price.Margin = New System.Windows.Forms.Padding(4)
        Me.discounted_price.Name = "discounted_price"
        Me.discounted_price.Size = New System.Drawing.Size(328, 30)
        Me.discounted_price.TabIndex = 94
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.BackColor = System.Drawing.Color.Transparent
        Me.Label22.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.Location = New System.Drawing.Point(20, 124)
        Me.Label22.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(147, 24)
        Me.Label22.TabIndex = 62
        Me.Label22.Text = "Discounted Price:"
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.BackColor = System.Drawing.Color.Transparent
        Me.Label23.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.Location = New System.Drawing.Point(20, 86)
        Me.Label23.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(132, 24)
        Me.Label23.TabIndex = 54
        Me.Label23.Text = "Discount Value:"
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.BackColor = System.Drawing.Color.Transparent
        Me.Label24.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label24.Location = New System.Drawing.Point(21, 50)
        Me.Label24.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(105, 24)
        Me.Label24.TabIndex = 60
        Me.Label24.Text = "Discount ID:"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.order_grid)
        Me.GroupBox3.Controls.Add(Me.order_search)
        Me.GroupBox3.Controls.Add(Me.Label8)
        Me.GroupBox3.Controls.Add(Me.Label4)
        Me.GroupBox3.Controls.Add(Me.order_date)
        Me.GroupBox3.Controls.Add(Me.order_quantity)
        Me.GroupBox3.Controls.Add(Me.Label7)
        Me.GroupBox3.Controls.Add(Me.order_price)
        Me.GroupBox3.Controls.Add(Me.Label13)
        Me.GroupBox3.Controls.Add(Me.order_lname)
        Me.GroupBox3.Controls.Add(Me.order_fname)
        Me.GroupBox3.Controls.Add(Me.Label9)
        Me.GroupBox3.Controls.Add(Me.order_product)
        Me.GroupBox3.Controls.Add(Me.Label11)
        Me.GroupBox3.Controls.Add(Me.orderid)
        Me.GroupBox3.Controls.Add(Me.Label16)
        Me.GroupBox3.Location = New System.Drawing.Point(19, 39)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(527, 477)
        Me.GroupBox3.TabIndex = 116
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Order Details"
        '
        'order_grid
        '
        Me.order_grid.BackgroundColor = System.Drawing.SystemColors.Control
        Me.order_grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.order_grid.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3})
        Me.order_grid.Location = New System.Drawing.Point(26, 353)
        Me.order_grid.Name = "order_grid"
        Me.order_grid.RowTemplate.Height = 24
        Me.order_grid.Size = New System.Drawing.Size(474, 103)
        Me.order_grid.TabIndex = 124
        '
        'Column1
        '
        Me.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Column1.HeaderText = "Order ID"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        '
        'Column2
        '
        Me.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Column2.HeaderText = "First Name"
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        '
        'Column3
        '
        Me.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Column3.HeaderText = "Last Name"
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        '
        'order_search
        '
        Me.order_search.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.order_search.Location = New System.Drawing.Point(26, 317)
        Me.order_search.Margin = New System.Windows.Forms.Padding(4)
        Me.order_search.Name = "order_search"
        Me.order_search.Size = New System.Drawing.Size(184, 30)
        Me.order_search.TabIndex = 123
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Arial Narrow", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(22, 289)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(226, 22)
        Me.Label8.TabIndex = 122
        Me.Label8.Text = "Search by Payment ID or Name:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(22, 129)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(50, 24)
        Me.Label4.TabIndex = 113
        Me.Label4.Text = "Date:"
        '
        'order_date
        '
        Me.order_date.CalendarMonthBackground = System.Drawing.SystemColors.HighlightText
        Me.order_date.CalendarTrailingForeColor = System.Drawing.SystemColors.Desktop
        Me.order_date.CustomFormat = "yyyy-MM-dd"
        Me.order_date.Enabled = False
        Me.order_date.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.order_date.Location = New System.Drawing.Point(124, 126)
        Me.order_date.Name = "order_date"
        Me.order_date.Size = New System.Drawing.Size(376, 30)
        Me.order_date.TabIndex = 112
        Me.order_date.Value = New Date(2023, 5, 17, 0, 0, 0, 0)
        '
        'order_quantity
        '
        Me.order_quantity.BackColor = System.Drawing.SystemColors.HighlightText
        Me.order_quantity.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.order_quantity.Enabled = False
        Me.order_quantity.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.order_quantity.Location = New System.Drawing.Point(124, 201)
        Me.order_quantity.Margin = New System.Windows.Forms.Padding(4)
        Me.order_quantity.Name = "order_quantity"
        Me.order_quantity.Size = New System.Drawing.Size(376, 30)
        Me.order_quantity.TabIndex = 111
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(22, 203)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(80, 24)
        Me.Label7.TabIndex = 110
        Me.Label7.Text = "Quantity:"
        '
        'order_price
        '
        Me.order_price.BackColor = System.Drawing.SystemColors.HighlightText
        Me.order_price.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.order_price.Enabled = False
        Me.order_price.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.order_price.Location = New System.Drawing.Point(124, 239)
        Me.order_price.Margin = New System.Windows.Forms.Padding(4)
        Me.order_price.Name = "order_price"
        Me.order_price.Size = New System.Drawing.Size(376, 30)
        Me.order_price.TabIndex = 111
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.BackColor = System.Drawing.Color.Transparent
        Me.Label13.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(22, 243)
        Me.Label13.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(54, 24)
        Me.Label13.TabIndex = 110
        Me.Label13.Text = "Price:"
        '
        'order_lname
        '
        Me.order_lname.BackColor = System.Drawing.SystemColors.HighlightText
        Me.order_lname.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.order_lname.Enabled = False
        Me.order_lname.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.order_lname.Location = New System.Drawing.Point(311, 89)
        Me.order_lname.Margin = New System.Windows.Forms.Padding(4)
        Me.order_lname.Name = "order_lname"
        Me.order_lname.Size = New System.Drawing.Size(189, 30)
        Me.order_lname.TabIndex = 102
        '
        'order_fname
        '
        Me.order_fname.BackColor = System.Drawing.SystemColors.HighlightText
        Me.order_fname.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.order_fname.Enabled = False
        Me.order_fname.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.order_fname.Location = New System.Drawing.Point(124, 89)
        Me.order_fname.Margin = New System.Windows.Forms.Padding(4)
        Me.order_fname.Name = "order_fname"
        Me.order_fname.Size = New System.Drawing.Size(179, 30)
        Me.order_fname.TabIndex = 101
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(22, 91)
        Me.Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(59, 24)
        Me.Label9.TabIndex = 100
        Me.Label9.Text = "Name:"
        '
        'order_product
        '
        Me.order_product.BackColor = System.Drawing.SystemColors.HighlightText
        Me.order_product.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.order_product.Enabled = False
        Me.order_product.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.order_product.Location = New System.Drawing.Point(124, 163)
        Me.order_product.Margin = New System.Windows.Forms.Padding(4)
        Me.order_product.Name = "order_product"
        Me.order_product.Size = New System.Drawing.Size(376, 30)
        Me.order_product.TabIndex = 94
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(22, 167)
        Me.Label11.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(76, 24)
        Me.Label11.TabIndex = 62
        Me.Label11.Text = "Product:"
        '
        'orderid
        '
        Me.orderid.BackColor = System.Drawing.SystemColors.HighlightText
        Me.orderid.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.orderid.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.orderid.FormattingEnabled = True
        Me.orderid.Location = New System.Drawing.Point(124, 50)
        Me.orderid.Name = "orderid"
        Me.orderid.Size = New System.Drawing.Size(376, 31)
        Me.orderid.TabIndex = 99
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.BackColor = System.Drawing.Color.Transparent
        Me.Label16.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(22, 53)
        Me.Label16.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(80, 24)
        Me.Label16.TabIndex = 60
        Me.Label16.Text = "Order ID:"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.pay_grid)
        Me.GroupBox2.Controls.Add(Me.pay_search)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Controls.Add(Me.banktype)
        Me.GroupBox2.Controls.Add(Me.bankid)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.pay_method)
        Me.GroupBox2.Controls.Add(Me.Label14)
        Me.GroupBox2.Controls.Add(Me.pay_lname)
        Me.GroupBox2.Controls.Add(Me.pay_fname)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.accountid)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.paymentid)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Location = New System.Drawing.Point(552, 39)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(561, 477)
        Me.GroupBox2.TabIndex = 0
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Payment Details"
        '
        'pay_grid
        '
        Me.pay_grid.BackgroundColor = System.Drawing.SystemColors.Control
        Me.pay_grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.pay_grid.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3})
        Me.pay_grid.Location = New System.Drawing.Point(20, 353)
        Me.pay_grid.Name = "pay_grid"
        Me.pay_grid.ReadOnly = True
        Me.pay_grid.RowTemplate.Height = 24
        Me.pay_grid.Size = New System.Drawing.Size(474, 103)
        Me.pay_grid.TabIndex = 127
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn1.HeaderText = "Bank ID"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn2.HeaderText = "First Name"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn3.HeaderText = "Last Name"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        '
        'pay_search
        '
        Me.pay_search.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pay_search.Location = New System.Drawing.Point(20, 317)
        Me.pay_search.Margin = New System.Windows.Forms.Padding(4)
        Me.pay_search.Name = "pay_search"
        Me.pay_search.Size = New System.Drawing.Size(184, 30)
        Me.pay_search.TabIndex = 126
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(15, 245)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(103, 24)
        Me.Label6.TabIndex = 117
        Me.Label6.Text = "Payment ID:"
        Me.Label6.Visible = False
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Font = New System.Drawing.Font("Arial Narrow", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(16, 289)
        Me.Label10.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(226, 22)
        Me.Label10.TabIndex = 125
        Me.Label10.Text = "Search by Payment ID or Name:"
        '
        'banktype
        '
        Me.banktype.BackColor = System.Drawing.SystemColors.HighlightText
        Me.banktype.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.banktype.Enabled = False
        Me.banktype.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.banktype.Location = New System.Drawing.Point(150, 165)
        Me.banktype.Margin = New System.Windows.Forms.Padding(4)
        Me.banktype.Name = "banktype"
        Me.banktype.Size = New System.Drawing.Size(376, 30)
        Me.banktype.TabIndex = 116
        '
        'bankid
        '
        Me.bankid.BackColor = System.Drawing.SystemColors.HighlightText
        Me.bankid.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.bankid.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bankid.FormattingEnabled = True
        Me.bankid.Location = New System.Drawing.Point(150, 50)
        Me.bankid.Name = "bankid"
        Me.bankid.Size = New System.Drawing.Size(376, 31)
        Me.bankid.TabIndex = 115
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(15, 53)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(76, 24)
        Me.Label5.TabIndex = 114
        Me.Label5.Text = "Bank ID:"
        '
        'pay_method
        '
        Me.pay_method.BackColor = System.Drawing.SystemColors.HighlightText
        Me.pay_method.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.pay_method.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pay_method.FormattingEnabled = True
        Me.pay_method.Items.AddRange(New Object() {"Digital Wallets"})
        Me.pay_method.Location = New System.Drawing.Point(150, 202)
        Me.pay_method.Name = "pay_method"
        Me.pay_method.Size = New System.Drawing.Size(376, 31)
        Me.pay_method.TabIndex = 113
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.BackColor = System.Drawing.Color.Transparent
        Me.Label14.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(15, 205)
        Me.Label14.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(73, 24)
        Me.Label14.TabIndex = 112
        Me.Label14.Text = "Method:"
        '
        'pay_lname
        '
        Me.pay_lname.BackColor = System.Drawing.SystemColors.HighlightText
        Me.pay_lname.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pay_lname.Enabled = False
        Me.pay_lname.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pay_lname.Location = New System.Drawing.Point(338, 126)
        Me.pay_lname.Margin = New System.Windows.Forms.Padding(4)
        Me.pay_lname.Name = "pay_lname"
        Me.pay_lname.Size = New System.Drawing.Size(188, 30)
        Me.pay_lname.TabIndex = 102
        '
        'pay_fname
        '
        Me.pay_fname.BackColor = System.Drawing.SystemColors.HighlightText
        Me.pay_fname.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pay_fname.Enabled = False
        Me.pay_fname.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pay_fname.Location = New System.Drawing.Point(150, 126)
        Me.pay_fname.Margin = New System.Windows.Forms.Padding(4)
        Me.pay_fname.Name = "pay_fname"
        Me.pay_fname.Size = New System.Drawing.Size(180, 30)
        Me.pay_fname.TabIndex = 101
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(15, 128)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(59, 24)
        Me.Label3.TabIndex = 100
        Me.Label3.Text = "Name:"
        '
        'accountid
        '
        Me.accountid.BackColor = System.Drawing.SystemColors.HighlightText
        Me.accountid.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.accountid.Enabled = False
        Me.accountid.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.accountid.Location = New System.Drawing.Point(150, 88)
        Me.accountid.Margin = New System.Windows.Forms.Padding(4)
        Me.accountid.Name = "accountid"
        Me.accountid.Size = New System.Drawing.Size(376, 30)
        Me.accountid.TabIndex = 94
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(15, 90)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(109, 24)
        Me.Label1.TabIndex = 62
        Me.Label1.Text = "Acccount ID:"
        '
        'paymentid
        '
        Me.paymentid.BackColor = System.Drawing.SystemColors.HighlightText
        Me.paymentid.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.paymentid.Enabled = False
        Me.paymentid.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.paymentid.Location = New System.Drawing.Point(150, 243)
        Me.paymentid.Margin = New System.Windows.Forms.Padding(4)
        Me.paymentid.Name = "paymentid"
        Me.paymentid.Size = New System.Drawing.Size(376, 30)
        Me.paymentid.TabIndex = 61
        Me.paymentid.Visible = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(15, 165)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(98, 24)
        Me.Label2.TabIndex = 54
        Me.Label2.Text = "Bank Type:"
        '
        'Clear_btn
        '
        Me.Clear_btn.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Clear_btn.Location = New System.Drawing.Point(88, 688)
        Me.Clear_btn.Margin = New System.Windows.Forms.Padding(4)
        Me.Clear_btn.Name = "Clear_btn"
        Me.Clear_btn.Size = New System.Drawing.Size(104, 44)
        Me.Clear_btn.TabIndex = 117
        Me.Clear_btn.Text = "Clear"
        Me.Clear_btn.UseVisualStyleBackColor = True
        '
        'pay_save
        '
        Me.pay_save.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pay_save.Location = New System.Drawing.Point(677, 688)
        Me.pay_save.Margin = New System.Windows.Forms.Padding(4)
        Me.pay_save.Name = "pay_save"
        Me.pay_save.Size = New System.Drawing.Size(212, 44)
        Me.pay_save.TabIndex = 116
        Me.pay_save.Text = "Save"
        Me.pay_save.UseVisualStyleBackColor = True
        '
        'pay_gridview
        '
        Me.pay_gridview.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pay_gridview.Location = New System.Drawing.Point(909, 688)
        Me.pay_gridview.Margin = New System.Windows.Forms.Padding(4)
        Me.pay_gridview.Name = "pay_gridview"
        Me.pay_gridview.Size = New System.Drawing.Size(212, 44)
        Me.pay_gridview.TabIndex = 118
        Me.pay_gridview.Text = "View"
        Me.pay_gridview.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = Global.Owned_db.My.Resources.Resources.OWN3D_LOGO_Dark_1024
        Me.PictureBox1.Location = New System.Drawing.Point(43, 24)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(546, 108)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 77
        Me.PictureBox1.TabStop = False
        '
        'Payment
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Owned_db.My.Resources.Resources._5c2642f7cc49c2f1469a7cc03bc43986
        Me.ClientSize = New System.Drawing.Size(1809, 805)
        Me.Controls.Add(Me.pay_gridview)
        Me.Controls.Add(Me.Clear_btn)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.pay_save)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Payment"
        Me.Text = "6056"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        CType(Me.discount_grid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.order_grid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.pay_grid, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents pay_lname As System.Windows.Forms.TextBox
    Friend WithEvents pay_fname As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents pay_method As System.Windows.Forms.ComboBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents order_price As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents discounted_price As System.Windows.Forms.TextBox
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents order_quantity As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents order_lname As System.Windows.Forms.TextBox
    Friend WithEvents order_fname As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents order_product As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents orderid As System.Windows.Forms.ComboBox
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents order_date As System.Windows.Forms.DateTimePicker
    Friend WithEvents accountid As System.Windows.Forms.TextBox
    Friend WithEvents bankid As System.Windows.Forms.ComboBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents banktype As System.Windows.Forms.TextBox
    Friend WithEvents discount_value As System.Windows.Forms.TextBox
    Friend WithEvents discountid As System.Windows.Forms.ComboBox
    Friend WithEvents Clear_btn As System.Windows.Forms.Button
    Friend WithEvents pay_save As System.Windows.Forms.Button
    Friend WithEvents paymentid As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents pay_gridview As System.Windows.Forms.Button
    Friend WithEvents order_grid As System.Windows.Forms.DataGridView
    Friend WithEvents order_search As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents discount_grid As System.Windows.Forms.DataGridView
    Friend WithEvents Column4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Discou As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents discount_search As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents pay_grid As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents pay_search As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column3 As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
