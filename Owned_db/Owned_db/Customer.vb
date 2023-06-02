Imports MySql.Data.MySqlClient
Public Class Customer
    Dim conn As New MySqlConnection("server=localhost;port=3306;username=root;password=;database=own3d_db;Convert Zero Datetime=True")
    Dim reader As MySqlDataReader
    Dim i As Integer

    Private Sub Customer_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DisplayGridTable_load()

    End Sub
    Private Sub customer_save_Click(sender As Object, e As EventArgs) Handles customer_save.Click 'Add Customer Data
        If String.IsNullOrEmpty(customer_fname.Text) OrElse String.IsNullOrEmpty(customer_lname.Text) OrElse String.IsNullOrEmpty(customer_email.Text) Then
            MessageBox.Show("Please fill in all required fields.")
            Return
        End If

        ' create a command to insert
        Dim command As New MySqlCommand("INSERT INTO `customer`(`Customer_ID`, `Customer_Fname`, `Customer_Lname`, `Customer_Email`) VALUES (@Customer_ID,@Customer_Fname,@Customer_Lname,@Customer_Email)", conn)
        ' add Parameters to the command
        command.Parameters.Add("@Customer_ID", MySqlDbType.VarChar).Value = customerid.Text
        command.Parameters.Add("@Customer_Fname", MySqlDbType.VarChar).Value = customer_fname.Text
        command.Parameters.Add("@Customer_Lname", MySqlDbType.VarChar).Value = customer_lname.Text
        command.Parameters.Add("@Customer_Email", MySqlDbType.VarChar).Value = customer_email.Text

        conn.Open()
        If command.ExecuteNonQuery() = 1 Then
            MessageBox.Show("New Customer Data Added")
        Else
            MessageBox.Show("ERROR")
        End If
        conn.Close()
        clear()
        DisplayGridTable_load()
    End Sub


    Private Sub clear() 'Clear textbox
        customerid.Clear()
        customer_fname.Clear()
        customer_lname.Clear()
        customer_email.Clear()
    End Sub
    Private Sub Clear_btn_Click(sender As Object, e As EventArgs) Handles Clear_btn.Click 'Clear Textbox Button
        clear()
    End Sub

    Public Sub DisplayGridTable_load() 'Display Data in the TableGridView
        customer_grid.Rows.Clear()

        Try
            conn.Open()
            Dim cmd As New MySqlCommand("SELECT * FROM customer ", conn)
            reader = cmd.ExecuteReader
            While reader.Read
                customer_grid.Rows.Add(reader.Item("Customer_ID"), reader.Item("Customer_Fname"), reader.Item("Customer_Lname"), reader.Item("Customer_Email"))

            End While
            reader.Dispose()

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            conn.Close()

        End Try
    End Sub
    Private Sub customer_grid_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles customer_grid.CellClick 'Display Data in the Textbox
        customerid.Text = customer_grid.CurrentRow.Cells(0).Value
        customer_fname.Text = customer_grid.CurrentRow.Cells(1).Value
        customer_lname.Text = customer_grid.CurrentRow.Cells(2).Value
        customer_email.Text = customer_grid.CurrentRow.Cells(3).Value

        customerid.ReadOnly = True
    End Sub


    Private Sub customer_delete_Click(sender As Object, e As EventArgs) Handles customer_delete.Click 'Delete Customer Data
        If String.IsNullOrEmpty(customer_fname.Text) OrElse String.IsNullOrEmpty(customer_lname.Text) OrElse String.IsNullOrEmpty(customer_email.Text) Then
            MessageBox.Show("Please fill in all required fields.")
            Return
        End If
        Dim str As String
        str = "Delete from customer where Customer_ID = '" & customerid.Text & "' and Customer_Fname = '" & customer_fname.Text & "' and Customer_Lname = '" & customer_lname.Text & "' and Customer_Email = '" & customer_email.Text & "'"
        Try
            readquery(str)
            MsgBox("Delete Customer Record")
            clear()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try
        DisplayGridTable_load()
    End Sub

    Sub update_content() 'Update Customer Data
        If String.IsNullOrEmpty(customer_fname.Text) OrElse String.IsNullOrEmpty(customer_lname.Text) OrElse String.IsNullOrEmpty(customer_email.Text) Then
            MessageBox.Show("Please fill in all required fields.")
            Return
        End If
        Try
            conn.Open()
            Dim cmd As New MySqlCommand("UPDATE `customer` SET `Customer_Fname`=@Customer_Fname, `Customer_Lname`=@Customer_Lname, `Customer_Email`=@Customer_Email WHERE `Customer_ID`=@Customer_ID", conn)
            cmd.Parameters.Clear()
            cmd.Parameters.AddWithValue("Customer_ID", customerid.Text)
            cmd.Parameters.AddWithValue("Customer_Fname", customer_fname.Text)
            cmd.Parameters.AddWithValue("Customer_Lname", customer_lname.Text)
            cmd.Parameters.AddWithValue("Customer_Email", customer_email.Text)

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

    Private Sub customer_update_Click(sender As Object, e As EventArgs) Handles customer_update.Click 'Update Customer Button
        update_content()
        DisplayGridTable_load()
        clear()
    End Sub

    Private Sub customer_search_TextChanged(sender As Object, e As EventArgs) Handles customer_search.TextChanged 'Search Customer Data Textbox
        customer_grid.Rows.Clear()
        Try
            conn.Open()
            Dim cmd As New MySqlCommand("SELECT * FROM customer WHERE Customer_ID like '%" & customer_search.Text & "%'", conn)
            reader = cmd.ExecuteReader
            While reader.Read
                customer_grid.Rows.Add(reader.Item("Customer_ID"), reader.Item("Customer_Fname"), reader.Item("Customer_Lname"), reader.Item("Customer_Email"))
            End While
            reader.Dispose()
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub
End Class