<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Customer
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Customer))
        Me.customer_delete = New System.Windows.Forms.Button()
        Me.customer_save = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.customerid = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.customer_update = New System.Windows.Forms.Button()
        Me.customer_email = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.customer_lname = New System.Windows.Forms.TextBox()
        Me.customer_fname = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.customer_grid = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.customer_search = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Clear_btn = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.GroupBox1.SuspendLayout()
        CType(Me.customer_grid, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'customer_delete
        '
        Me.customer_delete.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.customer_delete.Location = New System.Drawing.Point(462, 556)
        Me.customer_delete.Margin = New System.Windows.Forms.Padding(4)
        Me.customer_delete.Name = "customer_delete"
        Me.customer_delete.Size = New System.Drawing.Size(104, 44)
        Me.customer_delete.TabIndex = 64
        Me.customer_delete.Text = "Delete"
        Me.customer_delete.UseVisualStyleBackColor = True
        '
        'customer_save
        '
        Me.customer_save.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.customer_save.Location = New System.Drawing.Point(350, 556)
        Me.customer_save.Margin = New System.Windows.Forms.Padding(4)
        Me.customer_save.Name = "customer_save"
        Me.customer_save.Size = New System.Drawing.Size(104, 44)
        Me.customer_save.TabIndex = 63
        Me.customer_save.Text = "Save"
        Me.customer_save.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(24, 170)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(97, 24)
        Me.Label1.TabIndex = 62
        Me.Label1.Text = "Last Name:"
        '
        'customerid
        '
        Me.customerid.Enabled = False
        Me.customerid.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.customerid.Location = New System.Drawing.Point(186, 35)
        Me.customerid.Margin = New System.Windows.Forms.Padding(4)
        Me.customerid.Name = "customerid"
        Me.customerid.Size = New System.Drawing.Size(449, 30)
        Me.customerid.TabIndex = 61
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(24, 38)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(111, 24)
        Me.Label6.TabIndex = 60
        Me.Label6.Text = "Customer ID:"
        '
        'customer_update
        '
        Me.customer_update.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.customer_update.Location = New System.Drawing.Point(574, 556)
        Me.customer_update.Margin = New System.Windows.Forms.Padding(4)
        Me.customer_update.Name = "customer_update"
        Me.customer_update.Size = New System.Drawing.Size(104, 44)
        Me.customer_update.TabIndex = 59
        Me.customer_update.Text = "Update"
        Me.customer_update.UseVisualStyleBackColor = True
        '
        'customer_email
        '
        Me.customer_email.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.customer_email.Location = New System.Drawing.Point(186, 238)
        Me.customer_email.Margin = New System.Windows.Forms.Padding(4)
        Me.customer_email.Name = "customer_email"
        Me.customer_email.Size = New System.Drawing.Size(449, 30)
        Me.customer_email.TabIndex = 58
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(23, 241)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(57, 24)
        Me.Label5.TabIndex = 57
        Me.Label5.Text = "Email:"
        '
        'customer_lname
        '
        Me.customer_lname.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.customer_lname.Location = New System.Drawing.Point(186, 169)
        Me.customer_lname.Margin = New System.Windows.Forms.Padding(4)
        Me.customer_lname.Name = "customer_lname"
        Me.customer_lname.Size = New System.Drawing.Size(449, 30)
        Me.customer_lname.TabIndex = 56
        '
        'customer_fname
        '
        Me.customer_fname.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.customer_fname.Location = New System.Drawing.Point(186, 105)
        Me.customer_fname.Margin = New System.Windows.Forms.Padding(4)
        Me.customer_fname.Name = "customer_fname"
        Me.customer_fname.Size = New System.Drawing.Size(449, 30)
        Me.customer_fname.TabIndex = 55
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(23, 106)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(98, 24)
        Me.Label2.TabIndex = 54
        Me.Label2.Text = "First Name:"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.customerid)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.customer_email)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.customer_lname)
        Me.GroupBox1.Controls.Add(Me.customer_fname)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(43, 221)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(676, 311)
        Me.GroupBox1.TabIndex = 65
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Customer Form"
        '
        'customer_grid
        '
        Me.customer_grid.AllowUserToAddRows = False
        Me.customer_grid.AllowUserToDeleteRows = False
        Me.customer_grid.BackgroundColor = System.Drawing.SystemColors.Control
        Me.customer_grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.customer_grid.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4})
        Me.customer_grid.Location = New System.Drawing.Point(747, 221)
        Me.customer_grid.Margin = New System.Windows.Forms.Padding(4)
        Me.customer_grid.Name = "customer_grid"
        Me.customer_grid.ReadOnly = True
        Me.customer_grid.RowHeadersVisible = False
        Me.customer_grid.Size = New System.Drawing.Size(875, 406)
        Me.customer_grid.TabIndex = 67
        '
        'Column1
        '
        Me.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        Me.Column1.HeaderText = "Customer ID"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        Me.Column1.Width = 114
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
        Me.Column4.HeaderText = "Email"
        Me.Column4.Name = "Column4"
        Me.Column4.ReadOnly = True
        '
        'customer_search
        '
        Me.customer_search.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.customer_search.Location = New System.Drawing.Point(747, 183)
        Me.customer_search.Margin = New System.Windows.Forms.Padding(4)
        Me.customer_search.Name = "customer_search"
        Me.customer_search.Size = New System.Drawing.Size(449, 30)
        Me.customer_search.TabIndex = 64
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(743, 155)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(199, 24)
        Me.Label3.TabIndex = 63
        Me.Label3.Text = "Search Customer by ID::"
        '
        'Clear_btn
        '
        Me.Clear_btn.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Clear_btn.Location = New System.Drawing.Point(70, 556)
        Me.Clear_btn.Margin = New System.Windows.Forms.Padding(4)
        Me.Clear_btn.Name = "Clear_btn"
        Me.Clear_btn.Size = New System.Drawing.Size(104, 44)
        Me.Clear_btn.TabIndex = 68
        Me.Clear_btn.Text = "Clear"
        Me.Clear_btn.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = Global.Owned_db.My.Resources.Resources.OWN3D_LOGO_Dark_1024
        Me.PictureBox1.Location = New System.Drawing.Point(43, 24)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(546, 108)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 66
        Me.PictureBox1.TabStop = False
        '
        'Customer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Owned_db.My.Resources.Resources._5c2642f7cc49c2f1469a7cc03bc43986
        Me.ClientSize = New System.Drawing.Size(1809, 805)
        Me.Controls.Add(Me.Clear_btn)
        Me.Controls.Add(Me.customer_search)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.customer_grid)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.customer_delete)
        Me.Controls.Add(Me.customer_save)
        Me.Controls.Add(Me.customer_update)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Customer"
        Me.Text = "Customer"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.customer_grid, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents customer_delete As System.Windows.Forms.Button
    Friend WithEvents customer_save As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents customerid As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents customer_update As System.Windows.Forms.Button
    Friend WithEvents customer_email As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents customer_lname As System.Windows.Forms.TextBox
    Friend WithEvents customer_fname As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents customer_grid As System.Windows.Forms.DataGridView
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents customer_search As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Clear_btn As System.Windows.Forms.Button
End Class
