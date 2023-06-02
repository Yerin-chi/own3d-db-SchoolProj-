Imports MySql.Data.MySqlClient
Public Class Payment_GridVIew
    Dim conn As New MySqlConnection("server=localhost;port=3306;username=root;password=;database=own3d_db;Convert Zero Datetime=True")
    Dim reader As MySqlDataReader
    Dim i As Integer

    Private Sub Payment_GridVIew_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DisplayGridTable_load()
    End Sub
    Public Sub DisplayGridTable_load() 'Display Data in the TableGridView
        pay_gridview.Rows.Clear()
        pay_gridview.Columns(7).DefaultCellStyle.Format = "MM-dd-yyyy"
        Try
            conn.Open()
            Dim cmd As New MySqlCommand("SELECT * FROM `Payment` ", conn)
            reader = cmd.ExecuteReader
            While reader.Read
                pay_gridview.Rows.Add(reader.Item("Payment_ID"), reader.Item("Bank_ID"), reader.Item("Account_ID"), reader.Item("Pay_Fname"), reader.Item("Pay_Lname"), reader.Item("Bank_Type"), reader.Item("Method"), reader.Item("Order_Date"), reader.Item("Product"), reader.Item("Quantity"), reader.Item("Price"), reader.Item("Discount_Value"), reader.Item("Discounted_Price"))
            End While
            reader.Dispose()
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub


    Private Sub paygrid_search_TextChanged(sender As Object, e As EventArgs) Handles paygrid_search.TextChanged
        pay_gridview.Rows.Clear()
        Try
            conn.Open()
            Dim cmd As New MySqlCommand("SELECT * FROM `Payment` WHERE Payment_ID like '%" & paygrid_search.Text & "%' OR Pay_Fname like '%" & paygrid_search.Text & "%'", conn)
            reader = cmd.ExecuteReader
            While reader.Read
                pay_gridview.Rows.Add(reader.Item("Payment_ID"), reader.Item("Bank_ID"), reader.Item("Account_ID"), reader.Item("Pay_Fname"), reader.Item("Pay_Lname"), reader.Item("Bank_Type"), reader.Item("Method"), reader.Item("Order_Date"), reader.Item("Product"), reader.Item("Quantity"), reader.Item("Price"), reader.Item("Discount_Value"), reader.Item("Discounted_Price"))
            End While
            reader.Dispose()
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub

    Private Sub paygrid_delete_Click(sender As Object, e As EventArgs) Handles paygrid_delete.Click
        If String.IsNullOrEmpty(paymentid.Text) Then
            MessageBox.Show("Please select a row to delete")
            Return
        End If

        Dim str As String
        str = "DELETE FROM `Payment` WHERE Payment_ID = '" & paymentid.Text & "'"
        Try
            readquery(str)
            MsgBox("Delete Payment Record")
            clear()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try
        DisplayGridTable_load()
    End Sub

    Private Sub pay_gridview_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles pay_gridview.CellClick  'Display Data in the Textbox
        paymentid.Text = pay_gridview.CurrentRow.Cells(0).Value
        paymentid.ReadOnly = True
    End Sub
    Private Sub clear() 'Clear textbox
        paymentid.Clear()
    End Sub


End Class