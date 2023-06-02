Imports MySql.Data.MySqlClient
Public Class Bank
    Dim conn As New MySqlConnection("server=localhost;port=3306;username=root;password=;database=own3d_db;Convert Zero Datetime=True")
    Dim reader As MySqlDataReader
    Dim i As Integer

    Private Sub Bank_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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

        DisplayGridTable_load()
    End Sub

    Private Sub customerid_SelectedIndexChanged(sender As Object, e As EventArgs) Handles customerid.SelectedIndexChanged 'Get Customer Detail - Combo Box
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
    Public Sub DisplayGridTable_load() 'Display Data in the TableGridView
        bank_grid.Rows.Clear()
        Try
            conn.Open()
            Dim cmd As New MySqlCommand("SELECT * FROM `select_Bank` ", conn)
            reader = cmd.ExecuteReader
            While reader.Read
                bank_grid.Rows.Add(reader.Item("ID"), reader.Item("Customer_ID"), reader.Item("Account_Fname"), reader.Item("Account_Lname"), reader.Item("Bank_Type"), reader.Item("Account_ID"), reader.Item("Currency"))
            End While
            reader.Dispose()
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub
    Private Sub bank_grid_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles bank_grid.CellClick  'Display Data in the Textbox
        id.Text = bank_grid.CurrentRow.Cells(0).Value
        customerid.Text = bank_grid.CurrentRow.Cells(1).Value
        firstname.Text = bank_grid.CurrentRow.Cells(2).Value
        lastname.Text = bank_grid.CurrentRow.Cells(3).Value
        banktype.Text = bank_grid.CurrentRow.Cells(4).Value
        accountid.Text = bank_grid.CurrentRow.Cells(5).Value
        currency.Text = bank_grid.CurrentRow.Cells(6).Value

        accountid.ReadOnly = True
    End Sub

    Private Sub clear() 'Clear textbox
        id.Clear()
        customerid.SelectedIndex = -1
        firstname.Clear()
        lastname.Clear()
        banktype.SelectedIndex = -1
        accountid.Clear()
        currency.SelectedIndex = -1


    End Sub
    Private Sub Clear_btn_Click(sender As Object, e As EventArgs) Handles Clear_btn.Click 'Clear Input Button
        clear()
    End Sub
    Private Sub bank_save_Click(sender As Object, e As EventArgs) Handles bank_save.Click 'Add Data Button
        If String.IsNullOrEmpty(firstname.Text) OrElse String.IsNullOrEmpty(lastname.Text) OrElse String.IsNullOrEmpty(banktype.Text) OrElse String.IsNullOrEmpty(accountid.Text) OrElse String.IsNullOrEmpty(currency.Text) Then
            MessageBox.Show("Please fill in all required fields.")
            Return
        End If
        ' create a command to insert
        Dim command As New MySqlCommand("INSERT INTO `select_Bank`(`ID`,`Customer_ID`, `Account_Fname`, `Account_Lname`, `Bank_Type`, `Account_ID`,`Currency`) VALUES (@ID,@Customer_ID,@Account_Fname,@Account_Lname,@Bank_Type,@Account_ID,@Currency)", conn)
        ' add Parameters to the command
        command.Parameters.Add("@ID", MySqlDbType.VarChar).Value = id.Text
        command.Parameters.Add("@Customer_ID", MySqlDbType.VarChar).Value = customerid.Text
        command.Parameters.Add("@Account_Fname", MySqlDbType.VarChar).Value = firstname.Text
        command.Parameters.Add("@Account_Lname", MySqlDbType.VarChar).Value = lastname.Text
        command.Parameters.Add("@Bank_Type", MySqlDbType.VarChar).Value = banktype.Text
        command.Parameters.Add("@Account_ID", MySqlDbType.VarChar).Value = accountid.Text
        command.Parameters.Add("@Currency", MySqlDbType.VarChar).Value = currency.Text
        conn.Open()
        If command.ExecuteNonQuery() = 1 Then
            MessageBox.Show("New Data Added")
        Else
            MessageBox.Show("ERROR")
        End If
        conn.Close()
        clear()
        DisplayGridTable_load()
    End Sub

    Private Sub bank_delete_Click(sender As Object, e As EventArgs) Handles bank_delete.Click
        If String.IsNullOrEmpty(firstname.Text) OrElse String.IsNullOrEmpty(lastname.Text) OrElse String.IsNullOrEmpty(banktype.Text) OrElse String.IsNullOrEmpty(accountid.Text) OrElse String.IsNullOrEmpty(currency.Text) Then
            MessageBox.Show("Please fill in all required fields.")
            Return
        End If

        Dim str As String
        str = "DELETE FROM `select_Bank` WHERE ID = '" & id.Text & "'"
        Try
            readquery(str)
            MsgBox("Delete Data Record")
            clear()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try
        DisplayGridTable_load()
    End Sub
    Private Sub bank_update_Click(sender As Object, e As EventArgs) Handles bank_update.Click
        update_content()
        DisplayGridTable_load()
        clear()
    End Sub
    Sub update_content() 'Update Order Data
        If String.IsNullOrEmpty(firstname.Text) OrElse String.IsNullOrEmpty(lastname.Text) OrElse String.IsNullOrEmpty(banktype.Text) OrElse String.IsNullOrEmpty(accountid.Text) OrElse String.IsNullOrEmpty(currency.Text) Then
            MessageBox.Show("Please fill in all required fields.")
            Return
        End If
        Try
            conn.Open()
            Dim cmd As New MySqlCommand("UPDATE `select_Bank` SET `ID`=@ID, `Customer_ID`=@Customer_ID, `Account_Fname`=@Account_Fname, `Account_Lname`=@Account_Lname, `Bank_Type`=@Bank_Type, `Account_ID`=@Account_ID, `Currency`=@Currency WHERE `ID`=@ID", conn)
            cmd.Parameters.Clear()
            cmd.Parameters.AddWithValue("ID", id.Text)
            cmd.Parameters.AddWithValue("Customer_ID", customerid.Text)
            cmd.Parameters.AddWithValue("Account_Fname", firstname.Text)
            cmd.Parameters.AddWithValue("Account_Lname", lastname.Text)
            cmd.Parameters.AddWithValue("Bank_Type", banktype.Text)
            cmd.Parameters.AddWithValue("Account_ID", accountid.Text)
            cmd.Parameters.AddWithValue("Currency", currency.Text)
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

    Private Sub bank_search_TextChanged(sender As Object, e As EventArgs) Handles bank_search.TextChanged
        bank_grid.Rows.Clear()
        Try
            conn.Open()
            Dim cmd As New MySqlCommand("SELECT * FROM `select_Bank` WHERE ID like '%" & bank_search.Text & "%'", conn)
            reader = cmd.ExecuteReader
            While reader.Read
                bank_grid.Rows.Add(reader.Item("ID"), reader.Item("Customer_ID"), reader.Item("Account_Fname"), reader.Item("Account_Lname"), reader.Item("Bank_Type"), reader.Item("Account_ID"), reader.Item("Currency"))
            End While
            reader.Dispose()
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub
End Class