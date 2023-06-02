Imports MySql.Data.MySqlClient
Public Class Product
    Dim conn As New MySqlConnection("server=localhost;port=3306;username=root;password=;database=own3d_db;Convert Zero Datetime=True")
    Dim reader As MySqlDataReader
    Dim i As Integer

    Private Sub Product_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DisplayGridTable_load()

    End Sub
    Private Sub product_save_Click(sender As Object, e As EventArgs) Handles product_save.Click 'Add Customer Data
        If String.IsNullOrEmpty(product_name.Text) OrElse String.IsNullOrEmpty(product_description.Text) OrElse String.IsNullOrEmpty(product_category.Text) OrElse String.IsNullOrEmpty(product_quantity.Text) OrElse String.IsNullOrEmpty(product_category.Text) Then
            MessageBox.Show("Please fill in all required fields.")
            Return
        End If

        ' create a command to insert
        Dim command As New MySqlCommand("INSERT INTO `product`(`Product_ID`, `Product_Name`, `Product_Description`, `Product_Category`, `Product_Quantity`, `Product_Price`, `Publish_Date` ) VALUES (@Product_ID,@Product_Name,@Product_Description,@Product_Category,@Product_Quantity,@Product_Price,@Publish_Date)", conn)
        ' add Parameters to the command
        command.Parameters.Add("@Product_ID", MySqlDbType.VarChar).Value = productid.Text
        command.Parameters.Add("@Product_Name", MySqlDbType.VarChar).Value = product_name.Text
        command.Parameters.Add("@Product_Description", MySqlDbType.VarChar).Value = product_description.Text
        command.Parameters.Add("@Product_Category", MySqlDbType.VarChar).Value = product_category.Text
        command.Parameters.Add("@Product_Quantity", MySqlDbType.VarChar).Value = product_quantity.Text
        command.Parameters.Add("@Product_Price", MySqlDbType.VarChar).Value = product_price.Text
        command.Parameters.Add("@Publish_Date", MySqlDbType.Date).Value = publish_date.Value
        conn.Open()
        If command.ExecuteNonQuery() = 1 Then
            MessageBox.Show("New Product Data Added")
        Else
            MessageBox.Show("ERROR")
        End If
        conn.Close()
        clear()
        DisplayGridTable_load()
    End Sub


    Private Sub clear() 'Clear textbox
        productid.Clear()
        product_name.Clear()
        product_description.Clear()
        product_category.SelectedIndex = -1
        product_quantity.Clear()
        product_price.Clear()
        publish_date.Value = Now


    End Sub
    Private Sub Clear_btn_Click(sender As Object, e As EventArgs) Handles Clear_btn.Click 'Clear Textbox Button
        clear()
    End Sub

    Public Sub DisplayGridTable_load() 'Display Data in the TableGridView
        product_grid.Rows.Clear()
        product_grid.Columns(6).DefaultCellStyle.Format = "MM-dd-yyyy"
        Try
            conn.Open()
            Dim cmd As New MySqlCommand("SELECT * FROM product ", conn)
            reader = cmd.ExecuteReader
            While reader.Read
                product_grid.Rows.Add(reader.Item("Product_ID"), reader.Item("Product_Name"), reader.Item("Product_Description"), reader.Item("Product_Category"), reader.Item("Product_Quantity"), reader.Item("Product_Price"), reader.Item("Publish_Date"))
            End While
            reader.Dispose()
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            conn.Close()
        End Try


    End Sub
    Private Sub product_grid_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles product_grid.CellClick  'Display Data in the Textbox
        productid.Text = product_grid.CurrentRow.Cells(0).Value
        product_name.Text = product_grid.CurrentRow.Cells(1).Value
        product_description.Text = product_grid.CurrentRow.Cells(2).Value
        product_category.Text = product_grid.CurrentRow.Cells(3).Value
        product_quantity.Text = product_grid.CurrentRow.Cells(4).Value
        product_price.Text = product_grid.CurrentRow.Cells(5).Value
        publish_date.Value = CDate(product_grid.CurrentRow.Cells(6).Value)

        productid.ReadOnly = True
    End Sub


    Private Sub product_delete_Click(sender As Object, e As EventArgs) Handles product_delete.Click 'Delete Customer Data
        If String.IsNullOrEmpty(product_name.Text) OrElse String.IsNullOrEmpty(product_description.Text) OrElse String.IsNullOrEmpty(product_category.Text) OrElse String.IsNullOrEmpty(product_quantity.Text) OrElse String.IsNullOrEmpty(product_category.Text) Then
            MessageBox.Show("Please fill in all required fields.")
            Return
        End If
        Dim str As String
        str = "DELETE FROM product WHERE Product_ID = '" & productid.Text & "'"
        Try
            readquery(str)
            MsgBox("Delete Product Record")
            clear()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try
        DisplayGridTable_load()
    End Sub

    Sub update_content() 'Update Customer Data
        If String.IsNullOrEmpty(product_name.Text) OrElse String.IsNullOrEmpty(product_description.Text) OrElse String.IsNullOrEmpty(product_category.Text) OrElse String.IsNullOrEmpty(product_quantity.Text) OrElse String.IsNullOrEmpty(product_category.Text) Then
            MessageBox.Show("Please fill in all required fields.")
            Return
        End If
        Try
            conn.Open()
            Dim cmd As New MySqlCommand("UPDATE `product` SET `Product_Name`=@Product_Name, `Product_Description`=@Product_Description, `Product_Category`=@Product_Category, `Product_Quantity`=@Product_Quantity, `Product_Price`=@Product_Price, `Publish_Date`=@Publish_Date WHERE `Product_ID`=@Product_ID", conn)
            cmd.Parameters.Clear()
            cmd.Parameters.AddWithValue("Product_ID", productid.Text)
            cmd.Parameters.AddWithValue("Product_Name", product_name.Text)
            cmd.Parameters.AddWithValue("Product_Description", product_description.Text)
            cmd.Parameters.AddWithValue("Product_Category", product_category.Text)
            cmd.Parameters.AddWithValue("Product_Quantity", product_quantity.Text)
            cmd.Parameters.AddWithValue("Product_Price", product_price.Text)
            cmd.Parameters.AddWithValue("Publish_Date", publish_date.Value)
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

    Private Sub customer_update_Click(sender As Object, e As EventArgs) Handles product_update.Click 'Update Customer Button
        update_content()
        DisplayGridTable_load()
        clear()
    End Sub

    Private Sub product_search_TextChanged(sender As Object, e As EventArgs) Handles product_search.TextChanged 'Search Customer Data Textbox
        product_grid.Rows.Clear()
        Try
            conn.Open()
            Dim cmd As New MySqlCommand("SELECT * FROM product WHERE Product_ID like '%" & product_search.Text & "%'", conn)
            reader = cmd.ExecuteReader
            While reader.Read
                product_grid.Rows.Add(reader.Item("Product_ID"), reader.Item("Product_Name"), reader.Item("Product_Description"), reader.Item("Product_Category"), reader.Item("Product_Quantity"), reader.Item("Product_Price"), reader.Item("Publish_Date"))
            End While
            reader.Dispose()
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub

End Class