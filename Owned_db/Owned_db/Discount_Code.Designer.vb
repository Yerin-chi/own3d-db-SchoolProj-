<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Discount_Code
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
        Me.discount_search = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.discount_grid = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.btn_calculate = New System.Windows.Forms.Button()
        Me.valid_until = New System.Windows.Forms.DateTimePicker()
        Me.valid_from = New System.Windows.Forms.DateTimePicker()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.discountid = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.discount_expiration = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.discount_value = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.discount_delete = New System.Windows.Forms.Button()
        Me.discount_save = New System.Windows.Forms.Button()
        Me.discount_update = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label8 = New System.Windows.Forms.Label()
        CType(Me.discount_grid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Clear_btn
        '
        Me.Clear_btn.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Clear_btn.Location = New System.Drawing.Point(70, 556)
        Me.Clear_btn.Margin = New System.Windows.Forms.Padding(4)
        Me.Clear_btn.Name = "Clear_btn"
        Me.Clear_btn.Size = New System.Drawing.Size(104, 44)
        Me.Clear_btn.TabIndex = 77
        Me.Clear_btn.Text = "Clear"
        Me.Clear_btn.UseVisualStyleBackColor = True
        '
        'discount_search
        '
        Me.discount_search.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.discount_search.Location = New System.Drawing.Point(747, 183)
        Me.discount_search.Margin = New System.Windows.Forms.Padding(4)
        Me.discount_search.Name = "discount_search"
        Me.discount_search.Size = New System.Drawing.Size(449, 30)
        Me.discount_search.TabIndex = 72
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(743, 155)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(193, 24)
        Me.Label3.TabIndex = 70
        Me.Label3.Text = "Search Discount by ID::"
        '
        'discount_grid
        '
        Me.discount_grid.AllowUserToAddRows = False
        Me.discount_grid.AllowUserToDeleteRows = False
        Me.discount_grid.BackgroundColor = System.Drawing.SystemColors.Control
        Me.discount_grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.discount_grid.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4, Me.Column5})
        Me.discount_grid.Location = New System.Drawing.Point(747, 221)
        Me.discount_grid.Margin = New System.Windows.Forms.Padding(4)
        Me.discount_grid.Name = "discount_grid"
        Me.discount_grid.ReadOnly = True
        Me.discount_grid.RowHeadersVisible = False
        Me.discount_grid.Size = New System.Drawing.Size(875, 406)
        Me.discount_grid.TabIndex = 76
        '
        'Column1
        '
        Me.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        Me.Column1.HeaderText = "Discount Code ID"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        Me.Column1.Width = 122
        '
        'Column2
        '
        Me.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Column2.HeaderText = "Discount Value"
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        '
        'Column3
        '
        Me.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Column3.HeaderText = "Discount Expiration"
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        '
        'Column4
        '
        Me.Column4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Column4.HeaderText = "Valid From"
        Me.Column4.Name = "Column4"
        Me.Column4.ReadOnly = True
        '
        'Column5
        '
        Me.Column5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Column5.HeaderText = "Valid Until"
        Me.Column5.Name = "Column5"
        Me.Column5.ReadOnly = True
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.btn_calculate)
        Me.GroupBox1.Controls.Add(Me.valid_until)
        Me.GroupBox1.Controls.Add(Me.valid_from)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.discountid)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.discount_expiration)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.discount_value)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(43, 221)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(676, 311)
        Me.GroupBox1.TabIndex = 74
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Discount Form"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label7.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.Label7.Location = New System.Drawing.Point(574, 263)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(61, 23)
        Me.Label7.TabIndex = 74
        Me.Label7.Text = "Hours"
        '
        'btn_calculate
        '
        Me.btn_calculate.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.btn_calculate.Font = New System.Drawing.Font("Arial Narrow", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_calculate.Location = New System.Drawing.Point(515, 208)
        Me.btn_calculate.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btn_calculate.Name = "btn_calculate"
        Me.btn_calculate.Size = New System.Drawing.Size(120, 27)
        Me.btn_calculate.TabIndex = 73
        Me.btn_calculate.Text = "Calculate"
        Me.btn_calculate.UseVisualStyleBackColor = False
        '
        'valid_until
        '
        Me.valid_until.CustomFormat = "MM-dd-yyyy"
        Me.valid_until.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.valid_until.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.valid_until.Location = New System.Drawing.Point(415, 174)
        Me.valid_until.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.valid_until.Name = "valid_until"
        Me.valid_until.Size = New System.Drawing.Size(220, 30)
        Me.valid_until.TabIndex = 72
        Me.valid_until.Value = New Date(2023, 5, 16, 0, 0, 0, 0)
        '
        'valid_from
        '
        Me.valid_from.CustomFormat = "MM-dd-yyyy"
        Me.valid_from.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.valid_from.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.valid_from.Location = New System.Drawing.Point(186, 174)
        Me.valid_from.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.valid_from.Name = "valid_from"
        Me.valid_from.Size = New System.Drawing.Size(220, 30)
        Me.valid_from.TabIndex = 71
        Me.valid_from.Value = New Date(2023, 5, 16, 0, 0, 0, 0)
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(413, 148)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(93, 24)
        Me.Label4.TabIndex = 63
        Me.Label4.Text = "Valid Until:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(183, 148)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(98, 24)
        Me.Label1.TabIndex = 62
        Me.Label1.Text = "Valid From:"
        '
        'discountid
        '
        Me.discountid.Enabled = False
        Me.discountid.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.discountid.Location = New System.Drawing.Point(186, 35)
        Me.discountid.Margin = New System.Windows.Forms.Padding(4)
        Me.discountid.Name = "discountid"
        Me.discountid.Size = New System.Drawing.Size(449, 30)
        Me.discountid.TabIndex = 61
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(24, 38)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(151, 24)
        Me.Label6.TabIndex = 60
        Me.Label6.Text = "Discount Code ID:"
        '
        'discount_expiration
        '
        Me.discount_expiration.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.discount_expiration.Location = New System.Drawing.Point(186, 260)
        Me.discount_expiration.Margin = New System.Windows.Forms.Padding(4)
        Me.discount_expiration.Name = "discount_expiration"
        Me.discount_expiration.Size = New System.Drawing.Size(380, 30)
        Me.discount_expiration.TabIndex = 58
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(23, 263)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(93, 24)
        Me.Label5.TabIndex = 57
        Me.Label5.Text = "Expiration:"
        '
        'discount_value
        '
        Me.discount_value.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.discount_value.Location = New System.Drawing.Point(186, 105)
        Me.discount_value.Margin = New System.Windows.Forms.Padding(4)
        Me.discount_value.Name = "discount_value"
        Me.discount_value.Size = New System.Drawing.Size(380, 30)
        Me.discount_value.TabIndex = 55
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(23, 106)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(132, 24)
        Me.Label2.TabIndex = 54
        Me.Label2.Text = "Discount Value:"
        '
        'discount_delete
        '
        Me.discount_delete.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.discount_delete.Location = New System.Drawing.Point(462, 556)
        Me.discount_delete.Margin = New System.Windows.Forms.Padding(4)
        Me.discount_delete.Name = "discount_delete"
        Me.discount_delete.Size = New System.Drawing.Size(104, 44)
        Me.discount_delete.TabIndex = 73
        Me.discount_delete.Text = "Delete"
        Me.discount_delete.UseVisualStyleBackColor = True
        '
        'discount_save
        '
        Me.discount_save.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.discount_save.Location = New System.Drawing.Point(350, 556)
        Me.discount_save.Margin = New System.Windows.Forms.Padding(4)
        Me.discount_save.Name = "discount_save"
        Me.discount_save.Size = New System.Drawing.Size(104, 44)
        Me.discount_save.TabIndex = 71
        Me.discount_save.Text = "Save"
        Me.discount_save.UseVisualStyleBackColor = True
        '
        'discount_update
        '
        Me.discount_update.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.discount_update.Location = New System.Drawing.Point(574, 556)
        Me.discount_update.Margin = New System.Windows.Forms.Padding(4)
        Me.discount_update.Name = "discount_update"
        Me.discount_update.Size = New System.Drawing.Size(104, 44)
        Me.discount_update.TabIndex = 69
        Me.discount_update.Text = "Update"
        Me.discount_update.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = Global.Owned_db.My.Resources.Resources.OWN3D_LOGO_Dark_1024
        Me.PictureBox1.Location = New System.Drawing.Point(43, 24)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(546, 108)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 75
        Me.PictureBox1.TabStop = False
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label8.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(574, 108)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(35, 24)
        Me.Label8.TabIndex = 75
        Me.Label8.Text = "(%)"
        '
        'Discount_Code
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Owned_db.My.Resources.Resources._5c2642f7cc49c2f1469a7cc03bc43986
        Me.ClientSize = New System.Drawing.Size(1809, 805)
        Me.Controls.Add(Me.Clear_btn)
        Me.Controls.Add(Me.discount_search)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.discount_grid)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.discount_delete)
        Me.Controls.Add(Me.discount_save)
        Me.Controls.Add(Me.discount_update)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Discount_Code"
        Me.Text = "Discount_Code"
        CType(Me.discount_grid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Clear_btn As System.Windows.Forms.Button
    Friend WithEvents discount_search As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents discount_grid As System.Windows.Forms.DataGridView
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents discountid As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents discount_expiration As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents discount_value As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents discount_delete As System.Windows.Forms.Button
    Friend WithEvents discount_save As System.Windows.Forms.Button
    Friend WithEvents discount_update As System.Windows.Forms.Button
    Friend WithEvents valid_until As System.Windows.Forms.DateTimePicker
    Friend WithEvents valid_from As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents btn_calculate As System.Windows.Forms.Button
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Label8 As System.Windows.Forms.Label
End Class
