<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class calculateDiscount
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
        Me.btn_calculate = New System.Windows.Forms.Button()
        Me.total_price = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.discount_value = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.product_price = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.converted_value = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'btn_calculate
        '
        Me.btn_calculate.Font = New System.Drawing.Font("Arial Narrow", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_calculate.Location = New System.Drawing.Point(645, 303)
        Me.btn_calculate.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btn_calculate.Name = "btn_calculate"
        Me.btn_calculate.Size = New System.Drawing.Size(120, 27)
        Me.btn_calculate.TabIndex = 116
        Me.btn_calculate.Text = "Calculate"
        Me.btn_calculate.UseVisualStyleBackColor = True
        '
        'total_price
        '
        Me.total_price.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.total_price.Location = New System.Drawing.Point(316, 338)
        Me.total_price.Margin = New System.Windows.Forms.Padding(4)
        Me.total_price.Name = "total_price"
        Me.total_price.Size = New System.Drawing.Size(449, 30)
        Me.total_price.TabIndex = 115
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.Color.Transparent
        Me.Label12.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(153, 339)
        Me.Label12.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(147, 24)
        Me.Label12.TabIndex = 114
        Me.Label12.Text = "Discounted Price:"
        '
        'discount_value
        '
        Me.discount_value.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.discount_value.Location = New System.Drawing.Point(316, 267)
        Me.discount_value.Margin = New System.Windows.Forms.Padding(4)
        Me.discount_value.Name = "discount_value"
        Me.discount_value.Size = New System.Drawing.Size(217, 30)
        Me.discount_value.TabIndex = 113
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(155, 267)
        Me.Label11.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(132, 24)
        Me.Label11.TabIndex = 112
        Me.Label11.Text = "Discount Value:"
        '
        'product_price
        '
        Me.product_price.BackColor = System.Drawing.SystemColors.HighlightText
        Me.product_price.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.product_price.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.product_price.Location = New System.Drawing.Point(317, 155)
        Me.product_price.Margin = New System.Windows.Forms.Padding(4)
        Me.product_price.Name = "product_price"
        Me.product_price.Size = New System.Drawing.Size(449, 30)
        Me.product_price.TabIndex = 111
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(155, 158)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(120, 24)
        Me.Label4.TabIndex = 110
        Me.Label4.Text = "Product Price:"
        '
        'converted_value
        '
        Me.converted_value.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.converted_value.Location = New System.Drawing.Point(549, 267)
        Me.converted_value.Margin = New System.Windows.Forms.Padding(4)
        Me.converted_value.Name = "converted_value"
        Me.converted_value.Size = New System.Drawing.Size(217, 30)
        Me.converted_value.TabIndex = 118
        '
        'calculateDiscount
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(918, 522)
        Me.Controls.Add(Me.converted_value)
        Me.Controls.Add(Me.btn_calculate)
        Me.Controls.Add(Me.total_price)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.discount_value)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.product_price)
        Me.Controls.Add(Me.Label4)
        Me.Name = "calculateDiscount"
        Me.Text = "calculateDiscount"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btn_calculate As System.Windows.Forms.Button
    Friend WithEvents total_price As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents discount_value As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents product_price As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents converted_value As System.Windows.Forms.TextBox
End Class
