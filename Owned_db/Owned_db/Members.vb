Imports MySql.Data.MySqlClient
Public Class Members
    Dim conn As New MySqlConnection("server=localhost;port=3306;username=root;password=;database=own3d_db;Convert Zero Datetime=True")
    Dim reader As MySqlDataReader
    Dim i As Integer

    Private Sub Customer_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DisplayGridTable_load()

    End Sub
    Private Sub mem_save_Click(sender As Object, e As EventArgs) Handles mem_save.Click 'Add Customer Data
        If String.IsNullOrEmpty(mem_fname.Text) OrElse String.IsNullOrEmpty(mem_lname.Text) OrElse String.IsNullOrEmpty(mem_email.Text) Then
            MessageBox.Show("Please fill in all required fields.")
            Return
        End If
        ' create a command to insert
        Dim command As New MySqlCommand("INSERT INTO `members`(`Member_ID`, `Member_Fname`, `Member_Lname`, `Member_Email`) VALUES (@Member_ID,@Member_Fname,@Member_Lname,@Member_Email)", conn)
        ' add Parameters to the command
        command.Parameters.Add("@Member_ID", MySqlDbType.VarChar).Value = memberid.Text
        command.Parameters.Add("@Member_Fname", MySqlDbType.VarChar).Value = mem_fname.Text
        command.Parameters.Add("@Member_Lname", MySqlDbType.VarChar).Value = mem_lname.Text
        command.Parameters.Add("@Member_Email", MySqlDbType.VarChar).Value = mem_email.Text

        conn.Open()
        If command.ExecuteNonQuery() = 1 Then
            MessageBox.Show("New Member Data Added")
        Else
            MessageBox.Show("ERROR")
        End If
        conn.Close()
        clear()
        DisplayGridTable_load()
    End Sub


    Private Sub clear() 'Clear textbox
        memberid.Clear()
        mem_fname.Clear()
        mem_lname.Clear()
        mem_email.Clear()
    End Sub
    Private Sub Clear_btn_Click(sender As Object, e As EventArgs) Handles Clear_btn.Click 'Clear Textbox Button
        clear()
    End Sub

    Public Sub DisplayGridTable_load() 'Display Data in the TableGridView
        mem_grid.Rows.Clear()
        Try
            conn.Open()
            Dim cmd As New MySqlCommand("SELECT * FROM members ", conn)
            reader = cmd.ExecuteReader
            While reader.Read
                mem_grid.Rows.Add(reader.Item("Member_ID"), reader.Item("Member_Fname"), reader.Item("Member_Lname"), reader.Item("Member_Email"))
            End While
            reader.Dispose()
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub
    Private Sub mem_grid_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles mem_grid.CellClick 'Display Data in the Textbox
        memberid.Text = mem_grid.CurrentRow.Cells(0).Value
        mem_fname.Text = mem_grid.CurrentRow.Cells(1).Value
        mem_lname.Text = mem_grid.CurrentRow.Cells(2).Value
        mem_email.Text = mem_grid.CurrentRow.Cells(3).Value

        memberid.ReadOnly = True
    End Sub


    Private Sub mem_delete_Click(sender As Object, e As EventArgs) Handles mem_delete.Click 'Delete Customer Data
        If String.IsNullOrEmpty(mem_fname.Text) OrElse String.IsNullOrEmpty(mem_lname.Text) OrElse String.IsNullOrEmpty(mem_email.Text) Then
            MessageBox.Show("Please fill in all required fields.")
            Return
        End If

        Dim str As String
        str = "DELETE FROM members WHERE Member_ID = '" & memberid.Text & "' and Member_Fname = '" & mem_fname.Text & "' and Member_Lname = '" & mem_lname.Text & "' and Member_Email = '" & mem_email.Text & "'"
        Try
            readquery(str)
            MsgBox("Delete Member Record")
            clear()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try
        DisplayGridTable_load()
    End Sub

    Sub update_content() 'Update Customer Data
        If String.IsNullOrEmpty(mem_fname.Text) OrElse String.IsNullOrEmpty(mem_lname.Text) OrElse String.IsNullOrEmpty(mem_email.Text) Then
            MessageBox.Show("Please fill in all required fields.")
            Return
        End If
        Try
            conn.Open()
            Dim cmd As New MySqlCommand("UPDATE `members` SET `Member_Fname`=@Member_Fname, `Member_Lname`=@Member_Lname, `Member_Email`=@Member_Email WHERE `Member_ID`=@Member_ID", conn)
            cmd.Parameters.Clear()
            cmd.Parameters.AddWithValue("Member_ID", memberid.Text)
            cmd.Parameters.AddWithValue("Member_Fname", mem_fname.Text)
            cmd.Parameters.AddWithValue("Member_Lname", mem_lname.Text)
            cmd.Parameters.AddWithValue("Member_Email", mem_email.Text)

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

    Private Sub mem_update_Click(sender As Object, e As EventArgs) Handles mem_update.Click 'Update Customer Button
        update_content()
        DisplayGridTable_load()
        clear()
    End Sub

    Private Sub mem_search_TextChanged(sender As Object, e As EventArgs) Handles mem_search.TextChanged 'Search Customer Data Textbox
        mem_grid.Rows.Clear()
        Try
            conn.Open()
            Dim cmd As New MySqlCommand("SELECT * FROM members WHERE Member_ID like '%" & mem_search.Text & "%'", conn)
            reader = cmd.ExecuteReader
            While reader.Read
                mem_grid.Rows.Add(reader.Item("Member_ID"), reader.Item("Member_Fname"), reader.Item("Member_Lname"), reader.Item("Member_Email"))
            End While
            reader.Dispose()
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            conn.Close()
        End Try

    End Sub
End Class