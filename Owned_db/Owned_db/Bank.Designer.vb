<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Bank
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
        Me.Clear_btn = New System.Windows.Forms.Button()
        Me.bank_search = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.bank_grid = New System.Windows.Forms.DataGridView()
        Me.Column7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.id = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.currency = New System.Windows.Forms.ComboBox()
        Me.banktype = New System.Windows.Forms.ComboBox()
        Me.accountid = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.customerid = New System.Windows.Forms.ComboBox()
        Me.lastname = New System.Windows.Forms.TextBox()
        Me.firstname = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.bank_delete = New System.Windows.Forms.Button()
        Me.bank_save = New System.Windows.Forms.Button()
        Me.bank_update = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.bank_grid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Clear_btn
        '
        Me.Clear_btn.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Clear_btn.Location = New System.Drawing.Point(70, 583)
        Me.Clear_btn.Margin = New System.Windows.Forms.Padding(4)
        Me.Clear_btn.Name = "Clear_btn"
        Me.Clear_btn.Size = New System.Drawing.Size(104, 44)
        Me.Clear_btn.TabIndex = 86
        Me.Clear_btn.Text = "Clear"
        Me.Clear_btn.UseVisualStyleBackColor = True
        '
        'bank_search
        '
        Me.bank_search.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bank_search.Location = New System.Drawing.Point(726, 183)
        Me.bank_search.Margin = New System.Windows.Forms.Padding(4)
        Me.bank_search.Name = "bank_search"
        Me.bank_search.Size = New System.Drawing.Size(449, 30)
        Me.bank_search.TabIndex = 81
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(722, 155)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(119, 24)
        Me.Label3.TabIndex = 79
        Me.Label3.Text = "Search by ID::"
        '
        'bank_grid
        '
        Me.bank_grid.AllowUserToAddRows = False
        Me.bank_grid.AllowUserToDeleteRows = False
        Me.bank_grid.BackgroundColor = System.Drawing.SystemColors.Control
        Me.bank_grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.bank_grid.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column7, Me.Column1, Me.Column2, Me.Column3, Me.Column4, Me.Column5, Me.Column6})
        Me.bank_grid.Location = New System.Drawing.Point(726, 221)
        Me.bank_grid.Margin = New System.Windows.Forms.Padding(4)
        Me.bank_grid.Name = "bank_grid"
        Me.bank_grid.ReadOnly = True
        Me.bank_grid.RowHeadersVisible = False
        Me.bank_grid.Size = New System.Drawing.Size(848, 406)
        Me.bank_grid.TabIndex = 85
        '
        'Column7
        '
        Me.Column7.HeaderText = "ID"
        Me.Column7.Name = "Column7"
        Me.Column7.ReadOnly = True
        Me.Column7.Width = 50
        '
        'Column1
        '
        Me.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Column1.HeaderText = "Customer ID"
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
        'Column4
        '
        Me.Column4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Column4.HeaderText = "Bank Type"
        Me.Column4.Name = "Column4"
        Me.Column4.ReadOnly = True
        '
        'Column5
        '
        Me.Column5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Column5.HeaderText = "Account ID"
        Me.Column5.Name = "Column5"
        Me.Column5.ReadOnly = True
        '
        'Column6
        '
        Me.Column6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Column6.HeaderText = "Currency"
        Me.Column6.Name = "Column6"
        Me.Column6.ReadOnly = True
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.id)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.currency)
        Me.GroupBox1.Controls.Add(Me.banktype)
        Me.GroupBox1.Controls.Add(Me.accountid)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.customerid)
        Me.GroupBox1.Controls.Add(Me.lastname)
        Me.GroupBox1.Controls.Add(Me.firstname)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(43, 183)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(676, 376)
        Me.GroupBox1.TabIndex = 83
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Bank Details"
        '
        'id
        '
        Me.id.BackColor = System.Drawing.SystemColors.HighlightText
        Me.id.Enabled = False
        Me.id.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.id.Location = New System.Drawing.Point(186, 38)
        Me.id.Margin = New System.Windows.Forms.Padding(4)
        Me.id.Name = "id"
        Me.id.Size = New System.Drawing.Size(449, 30)
        Me.id.TabIndex = 111
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(24, 41)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(31, 24)
        Me.Label4.TabIndex = 110
        Me.Label4.Text = "ID:"
        '
        'currency
        '
        Me.currency.BackColor = System.Drawing.SystemColors.HighlightText
        Me.currency.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.currency.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.currency.FormattingEnabled = True
        Me.currency.Items.AddRange(New Object() {"USD"})
        Me.currency.Location = New System.Drawing.Point(186, 297)
        Me.currency.Name = "currency"
        Me.currency.Size = New System.Drawing.Size(449, 31)
        Me.currency.TabIndex = 109
        '
        'banktype
        '
        Me.banktype.BackColor = System.Drawing.SystemColors.HighlightText
        Me.banktype.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.banktype.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.banktype.FormattingEnabled = True
        Me.banktype.Items.AddRange(New Object() {"Paypal", "Skrill", "Google Play Send", "Apple Pay", "Amazon Pay", ""})
        Me.banktype.Location = New System.Drawing.Point(186, 188)
        Me.banktype.Name = "banktype"
        Me.banktype.Size = New System.Drawing.Size(449, 31)
        Me.banktype.TabIndex = 106
        '
        'accountid
        '
        Me.accountid.BackColor = System.Drawing.SystemColors.HighlightText
        Me.accountid.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.accountid.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.accountid.Location = New System.Drawing.Point(186, 245)
        Me.accountid.Margin = New System.Windows.Forms.Padding(4)
        Me.accountid.Name = "accountid"
        Me.accountid.Size = New System.Drawing.Size(449, 30)
        Me.accountid.TabIndex = 105
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(24, 300)
        Me.Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(86, 24)
        Me.Label9.TabIndex = 101
        Me.Label9.Text = "Currency:"
        '
        'customerid
        '
        Me.customerid.BackColor = System.Drawing.SystemColors.HighlightText
        Me.customerid.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.customerid.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.customerid.FormattingEnabled = True
        Me.customerid.Location = New System.Drawing.Point(186, 84)
        Me.customerid.Name = "customerid"
        Me.customerid.Size = New System.Drawing.Size(449, 31)
        Me.customerid.TabIndex = 99
        '
        'lastname
        '
        Me.lastname.BackColor = System.Drawing.SystemColors.HighlightText
        Me.lastname.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lastname.Enabled = False
        Me.lastname.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lastname.Location = New System.Drawing.Point(420, 137)
        Me.lastname.Margin = New System.Windows.Forms.Padding(4)
        Me.lastname.Name = "lastname"
        Me.lastname.Size = New System.Drawing.Size(215, 30)
        Me.lastname.TabIndex = 95
        '
        'firstname
        '
        Me.firstname.BackColor = System.Drawing.SystemColors.HighlightText
        Me.firstname.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.firstname.Enabled = False
        Me.firstname.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.firstname.Location = New System.Drawing.Point(186, 137)
        Me.firstname.Margin = New System.Windows.Forms.Padding(4)
        Me.firstname.Name = "firstname"
        Me.firstname.Size = New System.Drawing.Size(226, 30)
        Me.firstname.TabIndex = 94
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(24, 139)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(59, 24)
        Me.Label1.TabIndex = 62
        Me.Label1.Text = "Name:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(24, 248)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(100, 24)
        Me.Label6.TabIndex = 60
        Me.Label6.Text = "Account ID:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(24, 191)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(98, 24)
        Me.Label5.TabIndex = 57
        Me.Label5.Text = "Bank Type:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(24, 87)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(111, 24)
        Me.Label2.TabIndex = 54
        Me.Label2.Text = "Customer ID:"
        '
        'bank_delete
        '
        Me.bank_delete.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bank_delete.Location = New System.Drawing.Point(462, 583)
        Me.bank_delete.Margin = New System.Windows.Forms.Padding(4)
        Me.bank_delete.Name = "bank_delete"
        Me.bank_delete.Size = New System.Drawing.Size(104, 44)
        Me.bank_delete.TabIndex = 82
        Me.bank_delete.Text = "Delete"
        Me.bank_delete.UseVisualStyleBackColor = True
        '
        'bank_save
        '
        Me.bank_save.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bank_save.Location = New System.Drawing.Point(350, 583)
        Me.bank_save.Margin = New System.Windows.Forms.Padding(4)
        Me.bank_save.Name = "bank_save"
        Me.bank_save.Size = New System.Drawing.Size(104, 44)
        Me.bank_save.TabIndex = 80
        Me.bank_save.Text = "Save"
        Me.bank_save.UseVisualStyleBackColor = True
        '
        'bank_update
        '
        Me.bank_update.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bank_update.Location = New System.Drawing.Point(574, 583)
        Me.bank_update.Margin = New System.Windows.Forms.Padding(4)
        Me.bank_update.Name = "bank_update"
        Me.bank_update.Size = New System.Drawing.Size(104, 44)
        Me.bank_update.TabIndex = 78
        Me.bank_update.Text = "Update"
        Me.bank_update.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = Global.Owned_db.My.Resources.Resources.OWN3D_LOGO_Dark_1024_removebg_preview1
        Me.PictureBox1.Location = New System.Drawing.Point(43, 24)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(546, 108)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 84
        Me.PictureBox1.TabStop = False
        '
        'Bank
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Owned_db.My.Resources.Resources._5c2642f7cc49c2f1469a7cc03bc43986
        Me.ClientSize = New System.Drawing.Size(1809, 805)
        Me.Controls.Add(Me.Clear_btn)
        Me.Controls.Add(Me.bank_search)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.bank_grid)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.bank_delete)
        Me.Controls.Add(Me.bank_save)
        Me.Controls.Add(Me.bank_update)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Bank"
        Me.Text = "Bank"
        CType(Me.bank_grid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Clear_btn As System.Windows.Forms.Button
    Friend WithEvents bank_search As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents bank_grid As System.Windows.Forms.DataGridView
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents customerid As System.Windows.Forms.ComboBox
    Friend WithEvents lastname As System.Windows.Forms.TextBox
    Friend WithEvents firstname As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents bank_delete As System.Windows.Forms.Button
    Friend WithEvents bank_save As System.Windows.Forms.Button
    Friend WithEvents bank_update As System.Windows.Forms.Button
    Friend WithEvents banktype As System.Windows.Forms.ComboBox
    Friend WithEvents currency As System.Windows.Forms.ComboBox
    Friend WithEvents accountid As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents id As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Column7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column6 As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
