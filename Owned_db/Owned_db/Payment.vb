Imports MySql.Data.MySqlClient
Public Class Payment
    Dim conn As New MySqlConnection("server=localhost;port=3306;username=root;password=;database=own3d_db;Convert Zero Datetime=True")
    Dim reader As MySqlDataReader
    Dim i As Integer
    Private Sub Payment_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        OrderGridTable_load()
        PayGridTable_load()
        DiscountGridTable_load()
        Dim get_order As String
        get_order = "SELECT Order_ID FROM `order_transac` order by Order_ID" 'Get Order Details
        Try
            readquery(get_order)
            With cmdread
                While .Read
                    orderid.Items.Add(.GetValue(0))
                End While
            End With
        Catch ex As Exception
        End Try

        Dim get_payment As String
        get_payment = "SELECT ID FROM `select_Bank` order by ID" 'Get Payments Details
        Try
            readquery(get_payment)
            With cmdread
                While .Read
                    bankid.Items.Add(.GetValue(0))
                End While
            End With
        Catch ex As Exception
        End Try

        Dim get_discount As String
        get_discount = "SELECT Discount_Code_ID FROM `discount_code` order by Discount_Code_ID" 'Get Discount Details
        Try
            readquery(get_discount)
            With cmdread
                While .Read
                    discountid.Items.Add(.GetValue(0))
                End While
            End With
        Catch ex As Exception
        End Try
    End Sub
    Private Sub orderid_SelectedIndexChanged(sender As Object, e As EventArgs) Handles orderid.SelectedIndexChanged 'Get Order Details - Combo Box
        Dim str As String
        str = "SELECT Order_ID, Customer_Fname, Customer_Lname,  Order_Date, Product_Name, Product_Quantity, Product_Price  FROM `order_transac` WHERE Order_ID = '" & orderid.Text & "' order by Order_ID"
        Try
            readquery(str)
            With cmdread
                While .Read
                    order_fname.Text = .GetValue(1)
                    order_lname.Text = .GetValue(2)
                    order_date.Value = .GetValue(3)
                    order_product.Text = .GetValue(4)
                    order_quantity.Text = .GetValue(5)
                    order_price.Text = .GetValue(6)

                End While
            End With
        Catch ex As Exception

        End Try
    End Sub
    Private Sub bankid_SelectedIndexChanged(sender As Object, e As EventArgs) Handles bankid.SelectedIndexChanged 'Get Payment Details - Combo Box
        Dim str As String
        str = "SELECT ID, Account_Fname, Account_Lname,  Bank_Type, Account_ID FROM `select_Bank` WHERE ID = '" & bankid.Text & "' order by ID"
        Try
            readquery(str)
            With cmdread
                While .Read
                    pay_fname.Text = .GetValue(1)
                    pay_lname.Text = .GetValue(2)
                    banktype.Text = .GetValue(3)
                    accountid.Text = .GetValue(4)
                End While
            End With
        Catch ex As Exception

        End Try
    End Sub

    Private Sub discountid_SelectedIndexChanged(sender As Object, e As EventArgs) Handles discountid.SelectedIndexChanged 'Get Discount Details - Combo Box
        Dim str As String
        str = "SELECT Discount_Code_ID, Discount_Value FROM `discount_code` WHERE Discount_Code_ID = '" & discountid.Text & "' order by Discount_Code_ID"
        Try
            readquery(str)
            With cmdread
                While .Read
                    discount_value.Text = .GetValue(1)
                End While
            End With
        Catch ex As Exception

        End Try

        Dim initial_price As Double = CDbl(order_price.Text)
        Dim discountPercent As Double = CDbl(discount_value.Text)
        Dim discountAmount As Double = (discountPercent / 100) * initial_price
        Dim discountedPrice As Double = initial_price - discountAmount

        'discount_value.Text = discountAmount.ToString
        discounted_price.Text = discountedPrice.ToString
    End Sub

    Private Sub pay_save_Click(sender As Object, e As EventArgs) Handles pay_save.Click ' Add Payment Data Button
        If String.IsNullOrEmpty(orderid.Text) OrElse String.IsNullOrEmpty(bankid.Text) Then
            MessageBox.Show("Please fill in all required fields.")
            Return
        End If

        ' create a command to insert
        Dim command As New MySqlCommand("INSERT INTO `Payment`(`Payment_ID`, `Bank_ID`, `Account_ID`, `Pay_Fname`, `Pay_Lname`, `Bank_Type`, `Method`, `Order_Date`, `Product`,`Quantity`,`Price`,`Discount_Value`,`Discounted_Price`) VALUES (@Payment_ID,@Bank_ID,@Account_ID,@Pay_Fname,@Pay_Lname,@Bank_Type,@Method,@Order_Date,@Product,@Quantity,@Price,@Discount_Value,@Discounted_Price)", conn)
        ' add Parameters to the command
        command.Parameters.Add("@Payment_ID", MySqlDbType.VarChar).Value = paymentid.Text
        command.Parameters.Add("@Bank_ID", MySqlDbType.VarChar).Value = bankid.Text
        command.Parameters.Add("@Account_ID", MySqlDbType.VarChar).Value = accountid.Text
        command.Parameters.Add("@Pay_Fname", MySqlDbType.VarChar).Value = pay_fname.Text
        command.Parameters.Add("@Pay_Lname", MySqlDbType.VarChar).Value = pay_lname.Text
        command.Parameters.Add("@Bank_Type", MySqlDbType.VarChar).Value = banktype.Text
        command.Parameters.Add("@Method", MySqlDbType.VarChar).Value = pay_method.Text
        command.Parameters.Add("@Order_Date", MySqlDbType.Date).Value = order_date.Value

        command.Parameters.Add("@Product", MySqlDbType.VarChar).Value = order_product.Text
        command.Parameters.Add("@Quantity", MySqlDbType.VarChar).Value = order_quantity.Text
        command.Parameters.Add("@Price", MySqlDbType.VarChar).Value = order_price.Text

        command.Parameters.Add("@Discount_Value", MySqlDbType.VarChar).Value = discount_value.Text
        command.Parameters.Add("@Discounted_Price", MySqlDbType.VarChar).Value = discounted_price.Text

        conn.Open()
        If command.ExecuteNonQuery() = 1 Then
            MessageBox.Show("New Payment Data Added")
        Else
            MessageBox.Show("ERROR")
        End If
        conn.Close()
        clear()
        OrderGridTable_load()
        PayGridTable_load()
        DiscountGridTable_load()
    End Sub

    Private Sub pay_gridview_Click(sender As Object, e As EventArgs) Handles pay_gridview.Click
        Dim paygrid As New Payment_GridView
        paygrid.MdiParent = Me.MdiParent
        paygrid.Show()
        Me.Hide()

    End Sub

    Private Sub order_search_TextChanged(sender As Object, e As EventArgs) Handles order_search.TextChanged 'Search in Order Datails
        order_grid.Rows.Clear()
        Try
            conn.Open()
            Dim cmd As New MySqlCommand("SELECT * FROM `order_transac` WHERE Order_ID like '%" & order_search.Text & "%' OR Customer_Fname like '%" & order_search.Text & "%'", conn)
            reader = cmd.ExecuteReader
            While reader.Read
                order_grid.Rows.Add(reader.Item("Order_ID"), reader.Item("Customer_Fname"), reader.Item("Customer_Lname"))
            End While
            reader.Dispose()
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub

    Public Sub OrderGridTable_load() 'Display Data in the TableGridView
        order_grid.Rows.Clear()
        Try
            conn.Open()
            Dim cmd As New MySqlCommand("SELECT * FROM `order_transac` ", conn)
            reader = cmd.ExecuteReader
            While reader.Read
                order_grid.Rows.Add(reader.Item("Order_ID"), reader.Item("Customer_Fname"), reader.Item("Customer_Lname"))
            End While
            reader.Dispose()
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub

    Private Sub pay_search_TextChanged(sender As Object, e As EventArgs) Handles pay_search.TextChanged 'Search in Payment Details
        pay_grid.Rows.Clear()
        Try
            conn.Open()
            Dim cmd As New MySqlCommand("SELECT * FROM `select_Bank` WHERE ID like '%" & pay_search.Text & "%' OR Account_Fname like '%" & pay_search.Text & "%'", conn)
            reader = cmd.ExecuteReader
            While reader.Read
                pay_grid.Rows.Add(reader.Item("ID"), reader.Item("Account_Fname"), reader.Item("Account_Lname"))
            End While
            reader.Dispose()
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub
    Public Sub PayGridTable_load() 'Display Data in the TableGridView
        pay_grid.Rows.Clear()
        Try
            conn.Open()
            Dim cmd As New MySqlCommand("SELECT * FROM `select_Bank` ", conn)
            reader = cmd.ExecuteReader
            While reader.Read
                pay_grid.Rows.Add(reader.Item("ID"), reader.Item("Account_Fname"), reader.Item("Account_Lname"))
            End While
            reader.Dispose()
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub

    Private Sub discount_search_TextChanged(sender As Object, e As EventArgs) Handles discount_search.TextChanged
        discount_grid.Rows.Clear()
        Try
            conn.Open()
            Dim cmd As New MySqlCommand("SELECT * FROM `discount_code` WHERE Discount_Code_ID like '%" & discount_search.Text & "%' OR Discount_Value like '%" & discount_search.Text & "%'", conn)
            reader = cmd.ExecuteReader
            While reader.Read
                discount_grid.Rows.Add(reader.Item("Discount_Code_ID"), reader.Item("Discount_Value"))
            End While
            reader.Dispose()
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub
    Public Sub DiscountGridTable_load() 'Display Data in the TableGridView
        discount_grid.Rows.Clear()
        Try
            conn.Open()
            Dim cmd As New MySqlCommand("SELECT * FROM `discount_code` ", conn)
            reader = cmd.ExecuteReader
            While reader.Read
                discount_grid.Rows.Add(reader.Item("Discount_Code_ID"), reader.Item("Discount_Value"))
            End While
            reader.Dispose()
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub
    Private Sub clear() 'Clear textbox
        orderid.SelectedIndex = -1
        order_fname.Clear()
        order_lname.Clear()
        discountid.SelectedIndex = -1

        paymentid.Clear()
        bankid.SelectedIndex = -1
        accountid.Clear()
        pay_fname.Clear()
        pay_lname.Clear()
        banktype.Clear()
        pay_method.SelectedIndex = -1
        order_date.Value = Now
        order_product.Clear()
        order_quantity.Clear()
        order_price.Clear()
        discount_value.Clear()
        discounted_price.Clear()
    End Sub
    Private Sub Clear_btn_Click(sender As Object, e As EventArgs) Handles Clear_btn.Click
        clear()

    End Sub
End Class