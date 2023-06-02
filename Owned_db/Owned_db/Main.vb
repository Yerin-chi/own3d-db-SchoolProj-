Public Class Main
    Private Sub ShowNewForm(ByVal sender As Object, ByVal e As EventArgs)
        ' Create a new instance of the child form.
        Dim ChildForm As New System.Windows.Forms.Form
        ' Make it a child of this MDI form before showing it.
        ChildForm.MdiParent = Me

        m_ChildFormNumber += 1
        ChildForm.Text = "Window " & m_ChildFormNumber

        ChildForm.Show()
    End Sub

    Private Sub OpenFile(ByVal sender As Object, ByVal e As EventArgs)
        Dim OpenFileDialog As New OpenFileDialog
        OpenFileDialog.InitialDirectory = My.Computer.FileSystem.SpecialDirectories.MyDocuments
        OpenFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*"
        If (OpenFileDialog.ShowDialog(Me) = System.Windows.Forms.DialogResult.OK) Then
            Dim FileName As String = OpenFileDialog.FileName
            ' TODO: Add code here to open the file.
        End If
    End Sub

    Private Sub SaveAsToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        Dim SaveFileDialog As New SaveFileDialog
        SaveFileDialog.InitialDirectory = My.Computer.FileSystem.SpecialDirectories.MyDocuments
        SaveFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*"

        If (SaveFileDialog.ShowDialog(Me) = System.Windows.Forms.DialogResult.OK) Then
            Dim FileName As String = SaveFileDialog.FileName
            ' TODO: Add code here to save the current contents of the form to a file.
        End If
    End Sub


    Private Sub ExitToolsStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        Me.Close()
    End Sub

    Private Sub CutToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        ' Use My.Computer.Clipboard to insert the selected text or images into the clipboard
    End Sub

    Private Sub CopyToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        ' Use My.Computer.Clipboard to insert the selected text or images into the clipboard
    End Sub

    Private Sub PasteToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        'Use My.Computer.Clipboard.GetText() or My.Computer.Clipboard.GetData to retrieve information from the clipboard.
    End Sub

    Private Sub CascadeToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        Me.LayoutMdi(MdiLayout.Cascade)
    End Sub

    Private Sub TileVerticalToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        Me.LayoutMdi(MdiLayout.TileVertical)
    End Sub

    Private Sub TileHorizontalToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        Me.LayoutMdi(MdiLayout.TileHorizontal)
    End Sub

    Private Sub ArrangeIconsToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        Me.LayoutMdi(MdiLayout.ArrangeIcons)
    End Sub

    Private Sub CloseAllToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        ' Close all child forms of the parent.
        For Each ChildForm As Form In Me.MdiChildren
            ChildForm.Close()
        Next
    End Sub

    Private m_ChildFormNumber As Integer


    Private Sub Main_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub


    Private Sub CustomersToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CustomersToolStripMenuItem.Click 'Direct to Customer Form
        Dim customer As New Customer

        customer.MdiParent = Me
        customer.StartPosition = FormStartPosition.Manual
        customer.Top = 0
        customer.Left = 0

        customer.Show()
    End Sub

    Private Sub MembersToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MembersToolStripMenuItem.Click 'Direct to Member Form
        Dim member As New Members

        member.MdiParent = Me
        member.StartPosition = FormStartPosition.Manual
        member.Top = 0
        member.Left = 0

        member.Show()
    End Sub

    Private Sub ProductsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ProductsToolStripMenuItem.Click
        Dim product As New Product

        product.MdiParent = Me
        product.StartPosition = FormStartPosition.Manual
        product.Top = 0
        product.Left = 0

        product.Show()
    End Sub

    Private Sub DiscountsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DiscountsToolStripMenuItem.Click
        Dim discount As New Discount_Code

        discount.MdiParent = Me
        discount.StartPosition = FormStartPosition.Manual
        discount.Top = 0
        discount.Left = 0

        discount.Show()
    End Sub

    Private Sub OrdersToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OrdersToolStripMenuItem.Click
        Dim order As New order

        order.MdiParent = Me
        order.StartPosition = FormStartPosition.Manual
        order.Top = 0
        order.Left = 0

        order.Show()
    End Sub

    Private Sub PaymentsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PaymentsToolStripMenuItem.Click
        Dim payment As New Payment

        payment.MdiParent = Me
        payment.StartPosition = FormStartPosition.Manual
        payment.Top = 0
        payment.Left = 0

        payment.Show()
    End Sub

    Private Sub BankToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BankToolStripMenuItem.Click
        Dim bank As New Bank

        bank.MdiParent = Me
        bank.StartPosition = FormStartPosition.Manual
        bank.Top = 0
        bank.Left = 0

        bank.Show()
    End Sub

    Private Sub ViewTransactionToolStripMenuItem_Click_1(sender As Object, e As EventArgs) Handles ViewTransactionToolStripMenuItem.Click
        Dim paygrid As New Payment_GridView
        paygrid.MdiParent = Me
        paygrid.StartPosition = FormStartPosition.Manual
        paygrid.Top = 0
        paygrid.Left = 0
        paygrid.Show()
    End Sub
End Class
