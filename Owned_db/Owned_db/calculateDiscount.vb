Imports MySql.Data.MySqlClient
Public Class calculateDiscount
    Dim conn As New MySqlConnection("server=localhost;port=3306;username=root;password=;database=own3d_db;Convert Zero Datetime=True")
    Dim reader As MySqlDataReader
    Dim i As Integer
    Private Sub btn_calculate_Click(sender As Object, e As EventArgs) Handles btn_calculate.Click
        'Dim subtotal As Double = CDbl(txtSubtotal.Text)
        'Dim discountPercent As Double = 0.0

        'If subtotal >= 500 Then
        '    discountPercent = 0.2
        'ElseIf subtotal >= 250 And subtotal < 500 Then
        '    discountPercent = 0.15
        'ElseIf subtotal >= 100 And subtotal < 250 Then
        '    discountPercent = 0.1
        'End If
        'Dim discountAmount As Double = subtotal * discountPercent
        'Dim invoiceAmount As Double = subtotal - discountAmount
        'txtDisper.Text = discountPercent.ToString("p1")
        'txtDisAmo.Text = discountAmount.ToString("c")
        'txtTotal.Text = invoiceAmount.ToString("c")
        'txtSubtotal.Focus()

        'Calculate Discounted Price
        Dim initial_price As Double = CDbl(product_price.Text)
        Dim discountPercent As Double = CDbl(discount_value.Text)
        Dim discountAmount As Double = (discountPercent / 100) * initial_price
        Dim discountedPrice As Double = initial_price - discountAmount

        converted_value.Text = discountAmount.ToString
        total_price.Text = discountedPrice.ToString
    End Sub


    Private Sub calculateDiscount_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class