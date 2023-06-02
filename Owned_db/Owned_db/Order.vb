
Imports MySql.Data.MySqlClient
Public Class order
    Dim conn As New MySqlConnection("server=localhost;port=3306;username=root;password=;database=own3d_db;Convert Zero Datetime=True")
    Dim reader As MySqlDataReader
    Dim i As Integer
    Private Sub order_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim get_customer As String
        get_customer = "SELECT Customer_ID FROM customer order by Customer_ID"
        Try
            readquery(get_customer)
            With cmdread
                While .Read
                    customerid.Items.Add(.GetValue(0))
                End While
            End With
        Catch ex As Exception
        End Try

        Dim get_product As String
        get_product = "SELECT Product_ID FROM product order by Product_ID"
        Try
            readquery(get_product)
            With cmdread
                While .Read
                    productid.Items.Add(.GetValue(0))
                End While
            End With
        Catch ex As Exception
        End Try

        DisplayGridTable_load()
    End Sub
    Private Sub customerid_SelectedIndexChanged(sender As Object, e As EventArgs) Handles customerid.SelectedIndexChanged 'Get Customer Details in Combo Box
        Dim str As String
        str = "SELECT Customer_ID, Customer_Fname, Customer_Lname FROM customer WHERE Customer_ID = '" & customerid.Text & "' order by Customer_ID"
        Try
            readquery(str)
            With cmdread
                While .Read
                    firstname.Text = .GetValue(1)
                    lastname.Text = .GetValue(2)
                End While
            End With
        Catch ex As Exception

        End Try
    End Sub
    Private Sub productid_SelectedIndexChanged(sender As Object, e As EventArgs) Handles productid.SelectedIndexChanged 'Get Product Details in Combo Box
        Dim str As String
        str = "SELECT Product_ID, Product_Name, Product_Quantity, Product_Price FROM product WHERE Product_ID = '" & productid.Text & "' order by Product_ID"
        Try
            readquery(str)
            With cmdread
                While .Read
                    product_name.Text = .GetValue(1)
                    product_quantity.Text = .GetValue(2)
                    product_price.Text = .GetValue(3)
                End While
            End With
        Catch ex As Exception

        End Try
    End Sub
    Private Sub order_save_Click(sender As Object, e As EventArgs) Handles order_save.Click 'Add Order Button
        If String.IsNullOrEmpty(customerid.Text) OrElse String.IsNullOrEmpty(productid.Text) Then
            MessageBox.Show("Please fill in all required fields.")
            Return
        End If

        ' create a command to insert
        Dim command As New MySqlCommand("INSERT INTO `order_transac`(`Order_ID`, `Customer_ID`, `Customer_Fname`, `Customer_Lname`, `Order_Date`, `Product_ID`, `Product_Name`, `Product_Quantity`, `Product_Price`) VALUES (@Order_ID,@Customer_ID,@Customer_Fname,@Customer_Lname,@Order_Date,@Product_ID,@Product_Name,@Product_Quantity,@Product_Price)", conn)
        ' add Parameters to the command
        command.Parameters.Add("@Order_ID", MySqlDbType.VarChar).Value = orderid.Text
        command.Parameters.Add("@Customer_ID", MySqlDbType.VarChar).Value = customerid.Text
        command.Parameters.Add("@Customer_Fname", MySqlDbType.VarChar).Value = firstname.Text
        command.Parameters.Add("@Customer_Lname", MySqlDbType.VarChar).Value = lastname.Text
        command.Parameters.Add("@Order_Date", MySqlDbType.Date).Value = order_date.Value

        command.Parameters.Add("@Product_ID", MySqlDbType.VarChar).Value = productid.Text
        command.Parameters.Add("@Product_Name", MySqlDbType.VarChar).Value = product_name.Text
        command.Parameters.Add("@Product_Quantity", MySqlDbType.VarChar).Value = product_quantity.Text
        command.Parameters.Add("@Product_Price", MySqlDbType.VarChar).Value = product_price.Text

        conn.Open()
        If command.ExecuteNonQuery() = 1 Then
            MessageBox.Show("New Order Data Added")
        Else
            MessageBox.Show("ERROR")
        End If
        conn.Close()
        clear()
        DisplayGridTable_load()
    End Sub
    Public Sub DisplayGridTable_load() 'Display Data in the TableGridView
        order_grid.Rows.Clear()
        order_grid.Columns(4).DefaultCellStyle.Format = "MM-dd-yyyy"
        Try
            conn.Open()
            Dim cmd As New MySqlCommand("SELECT * FROM `order_transac` ", conn)
            reader = cmd.ExecuteReader
            While reader.Read
                order_grid.Rows.Add(reader.Item("Order_ID"), reader.Item("Customer_ID"), reader.Item("Customer_Fname"), reader.Item("Customer_Lname"), reader.Item("Order_Date"), reader.Item("Product_ID"), reader.Item("Product_Name"), reader.Item("Product_Quantity"), reader.Item("Product_Price"))
            End While
            reader.Dispose()
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            conn.Close()
        End Try


    End Sub
    Private Sub order_grid_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles order_grid.CellClick  'Display Data in the Textbox
        orderid.Text = order_grid.CurrentRow.Cells(0).Value
        customerid.Text = order_grid.CurrentRow.Cells(1).Value
        firstname.Text = order_grid.CurrentRow.Cells(2).Value
        lastname.Text = order_grid.CurrentRow.Cells(3).Value
        order_date.Value = CDate(order_grid.CurrentRow.Cells(4).Value)
        productid.Text = order_grid.CurrentRow.Cells(5).Value
        product_name.Text = order_grid.CurrentRow.Cells(6).Value
        product_quantity.Text = order_grid.CurrentRow.Cells(7).Value
        product_price.Text = order_grid.CurrentRow.Cells(8).Value

        orderid.ReadOnly = True
    End Sub
    Private Sub clear() 'Clear textbox
        orderid.Clear()
        customerid.SelectedIndex = -1
        firstname.Clear()
        lastname.Clear()
        productid.SelectedIndex = -1
        product_name.Clear()
        product_quantity.Clear()
        product_price.Clear()
        order_date.Value = Now


    End Sub
    Private Sub Clear_btn_Click(sender As Object, e As EventArgs) Handles Clear_btn.Click 'Clear Input Button
        clear()
    End Sub
    Private Sub order_delete_Click(sender As Object, e As EventArgs) Handles order_delete.Click 'Delete Existing Data in the Server
        Dim str As String
        str = "DELETE FROM `order_transac` WHERE Order_ID = '" & orderid.Text & "'"
        Try
            readquery(str)
            MsgBox("Delete Order Record")
            clear()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try
        DisplayGridTable_load()
    End Sub
    Private Sub order_search_TextChanged(sender As Object, e As EventArgs) Handles order_search.TextChanged 'Search by Order ID
        order_grid.Rows.Clear()
        Try
            conn.Open()
            Dim cmd As New MySqlCommand("SELECT * FROM `order_transac` WHERE Order_ID like '%" & order_search.Text & "%'", conn)
            reader = cmd.ExecuteReader
            While reader.Read
                order_grid.Rows.Add(reader.Item("Order_ID"), reader.Item("Customer_ID"), reader.Item("Customer_Fname"), reader.Item("Customer_Lname"), reader.Item("Order_Date"), reader.Item("Product_ID"), reader.Item("Product_Name"), reader.Item("Product_Quantity"), reader.Item("Product_Price"))
            End While
            reader.Dispose()
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub
    Private Sub order_update_Click(sender As Object, e As EventArgs) Handles order_update.Click 'Update Data Button
        update_content()
        DisplayGridTable_load()
        clear()
    End Sub
    Sub update_content() 'Update Order Data
        Try
            conn.Open()
            Dim cmd As New MySqlCommand("UPDATE `order_transac` SET `Order_ID`=@Order_ID, `Customer_ID`=@Customer_ID, `Customer_Fname`=@Customer_Fname, `Customer_Lname`=@Customer_Lname, `Order_Date`=@Order_Date, `Product_Name`=@Product_Name, `Product_Quantity`=@Product_Quantity, `Product_Price`=@Product_Price WHERE `Order_ID`=@Order_ID", conn)
            cmd.Parameters.Clear()
            cmd.Parameters.AddWithValue("Order_ID", orderid.Text)
            cmd.Parameters.AddWithValue("Customer_ID", customerid.Text)
            cmd.Parameters.AddWithValue("Customer_Fname", firstname.Text)
            cmd.Parameters.AddWithValue("Customer_Lname", lastname.Text)
            cmd.Parameters.AddWithValue("Product_ID", productid.Text)
            cmd.Parameters.AddWithValue("Product_Name", product_name.Text)
            cmd.Parameters.AddWithValue("Product_Quantity", product_quantity.Text)
            cmd.Parameters.AddWithValue("Product_Price", product_price.Text)
            cmd.Parameters.AddWithValue("Order_Date", order_date.Value)
            i = cmd.ExecuteNonQuery
            If i > 0 Then
                MessageBox.Show("Record Updated", "CRUD", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MessageBox.Show("Record Update Failed", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            conn.Close()
        End Try
        DisplayGridTable_load()

    End Sub
End Class