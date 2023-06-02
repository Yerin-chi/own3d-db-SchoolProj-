Imports MySql.Data.MySqlClient

Public Class Discount_Code
    Dim conn As New MySqlConnection("server=localhost;port=3306;username=root;password=;database=own3d_db;Convert Zero Datetime=True")
    Dim reader As MySqlDataReader
    Dim i As Integer
    Private Sub Discount_Code_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DisplayGridTable_load()
    End Sub

    Private Sub btn_calculate_Click(sender As Object, e As EventArgs) Handles btn_calculate.Click 'Calculate Button
        Dim no_of_days As Integer
        Dim hours As Integer = 24
        discount_save.Enabled = True
        If valid_from.Value = valid_until.Value Then
            discount_expiration.Text = 0
        ElseIf valid_from.Value.Year = valid_until.Value.Year Then
            If valid_until.Value.Month = valid_until.Value.Month Then
                If valid_until.Value.Day > valid_from.Value.Day Then
                    no_of_days = (valid_until.Value.Day - valid_from.Value.Day)
                    discount_expiration.Text = hours * no_of_days
                End If
            End If
        End If
    End Sub

    Private Sub valid_from_ValueChanged(sender As Object, e As EventArgs) Handles valid_from.ValueChanged
        valid_until.Enabled = True
        btn_calculate.Enabled = True
    End Sub

    Public Sub DisplayGridTable_load() 'Display Data in the TableGridView
        discount_grid.Rows.Clear()
        discount_grid.Columns(3).DefaultCellStyle.Format = "MM-dd-yyyy"
        discount_grid.Columns(4).DefaultCellStyle.Format = "MM-dd-yyyy"
        discount_grid.Rows.Clear()
        Try
            conn.Open()
            Dim cmd As New MySqlCommand("SELECT * FROM discount_code ", conn)
            reader = cmd.ExecuteReader
            While reader.Read
                discount_grid.Rows.Add(reader.Item("Discount_Code_ID"), reader.Item("Discount_Value"), reader.Item("Discount_Expiration"), reader.Item("valid_from"), reader.Item("valid_until"))

            End While
            reader.Dispose()

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            conn.Close()

        End Try
    End Sub
    Private Sub discount_grid_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles discount_grid.CellClick 'Display Data in the Textbox
        discountid.Text = discount_grid.CurrentRow.Cells(0).Value
        discount_value.Text = discount_grid.CurrentRow.Cells(1).Value
        discount_expiration.Text = discount_grid.CurrentRow.Cells(2).Value
        valid_from.Value = CDate(discount_grid.CurrentRow.Cells(3).Value)
        valid_until.Value = CDate(discount_grid.CurrentRow.Cells(4).Value)

        discountid.ReadOnly = True
    End Sub

    Private Sub discount_save_Click(sender As Object, e As EventArgs) Handles discount_save.Click
        If String.IsNullOrEmpty(discount_value.Text) OrElse String.IsNullOrEmpty(discount_expiration.Text) Then
            MessageBox.Show("Please fill in all required fields.")
            Return
        End If

        Dim command As New MySqlCommand("INSERT INTO discount_code (`Discount_Code_ID`,`Discount_Value`,`Discount_Expiration`,`valid_from`, `valid_until`) VALUES (@Discount_Code_ID,@Discount_Value,@Discount_Expiration,@valid_from,@valid_until)", conn)
        ' add Parameters to the command

        command.Parameters.Add("@Discount_Code_ID", MySqlDbType.VarChar).Value = discountid.Text
        command.Parameters.Add("@Discount_Value", MySqlDbType.VarChar).Value = discount_value.Text
        command.Parameters.Add("@Discount_Expiration", MySqlDbType.VarChar).Value = discount_expiration.Text
        command.Parameters.Add("@valid_from", MySqlDbType.Date).Value = valid_from.Value
        command.Parameters.Add("@valid_until", MySqlDbType.Date).Value = valid_until.Value


        conn.Open()
        i = command.ExecuteNonQuery
        If i > 0 Then
            MessageBox.Show("Record Updated", "CRUD", MessageBoxButtons.OK, MessageBoxIcon.Information)
            clear()
        Else
            MessageBox.Show("Record Update Failed", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
        End If
        conn.Close()
        clear()
        DisplayGridTable_load()

    End Sub

    Private Sub clear() 'Clear textbox
        discountid.Clear()
        discount_value.Clear()
        discount_expiration.Clear()
    End Sub

    Private Sub discount_delete_Click(sender As Object, e As EventArgs) Handles discount_delete.Click 'Delete Discount Button
        If String.IsNullOrEmpty(discount_value.Text) OrElse String.IsNullOrEmpty(discount_expiration.Text) Then
            MessageBox.Show("Please fill in all required fields.")
            Return
        End If
        Dim str As String
        str = "Delete from discount_code where Discount_Code_ID = '" & discountid.Text & "'"
        Try
            readquery(str)
            MsgBox("Delete Discount Code Record")
            clear()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try
        DisplayGridTable_load()
    End Sub

    Private Sub discount_update_Click(sender As Object, e As EventArgs) Handles discount_update.Click
        update_content()
        DisplayGridTable_load()
        clear()
    End Sub

    Sub update_content() 'Update Customer Data
        If String.IsNullOrEmpty(discount_value.Text) OrElse String.IsNullOrEmpty(discount_expiration.Text) Then
            MessageBox.Show("Please fill in all required fields.")
            Return
        End If
        Try
            conn.Open()
            Dim cmd As New MySqlCommand("UPDATE `discount_code` SET `Discount_Value`=@Discount_Value, `Discount_Expiration`=@Discount_Expiration, `valid_from`=@valid_from, `valid_until`=@valid_until WHERE `Discount_Code_ID`=@Discount_Code_ID", conn)
            cmd.Parameters.Clear()
            cmd.Parameters.AddWithValue("Discount_Code_ID", discountid.Text)
            cmd.Parameters.AddWithValue("Discount_Value", discount_value.Text)
            cmd.Parameters.AddWithValue("Discount_Expiration", discount_expiration.Text)
            cmd.Parameters.AddWithValue("valid_from", valid_from.Value)
            cmd.Parameters.AddWithValue("valid_until", valid_until.Value)

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

    Private Sub discount_search_TextChanged(sender As Object, e As EventArgs) Handles discount_search.TextChanged
        discount_grid.Rows.Clear()
        Try
            conn.Open()
            Dim cmd As New MySqlCommand("SELECT * FROM discount_code WHERE Discount_Code_ID like '%" & discount_search.Text & "%'", conn)
            reader = cmd.ExecuteReader
            While reader.Read
                discount_grid.Rows.Add(reader.Item("Discount_Code_ID"), reader.Item("Discount_Value"), reader.Item("Discount_Expiration"), reader.Item("valid_from"), reader.Item("valid_until"))
            End While
            reader.Dispose()
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub
End Class