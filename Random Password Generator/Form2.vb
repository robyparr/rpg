Public Class Form2

    Dim AccountsLocation As String = Application.StartupPath + "\Accounts\"

    Private Sub LoadAccounts()
        Form1.ListAccounts.Items.Clear()

        Dim AccountsDir As New IO.DirectoryInfo(AccountsLocation)
        Dim AccountInfo As IO.FileInfo

        Dim Decryptor As New Encryption(Form1.LblMasterPass.Text)

        For Each File In AccountsDir.GetFiles
            Dim EncryptedData As String = My.Computer.FileSystem.ReadAllText(File.FullName)

            Dim DecryptedData As String = Decryptor.DecryptData(EncryptedData)

            Dim splitData As String() = Split(DecryptedData, ";")
            Dim splitName As String() = Split(File.Name, ".")

            Dim AccountData As New ListViewItem(splitName(0))
            AccountData.SubItems.Add(splitData(0))
            AccountData.SubItems.Add(splitData(1))
            AccountData.SubItems.Add(splitData(3))
            AccountData.SubItems.Add(splitData(2))

            Form1.ListAccounts.Items.Add(AccountData)
        Next
    End Sub

    ' Controls
    Private Sub BtnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSave.Click
        Try
            ' Declares encryption module
            Dim AccountEncryption As New Encryption(Form1.LblMasterPass.Text)

            ' Condences info
            Dim AccountInto As String = TxtAccount.Text + ";" + TxtPass.Text + ";" + TxtWebsite.Text + ";" + ComboType.Text + ";" + RichNotes.Text

            ' Encrypts and saves info
            My.Computer.FileSystem.WriteAllText(AccountsLocation + TxtName.Text + ".txt", AccountEncryption.EncryptData(AccountInto), False)

            ' Reloads accounts
            LoadAccounts()

            Me.Close()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub BtnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnClose.Click
        Me.Close()
    End Sub

    Private Sub Form2_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        TxtName.Clear()
        TxtAccount.Clear()
        TxtPass.Clear()
        TxtWebsite.Clear()
        ComboType.Text = Nothing
        RichNotes.Clear()
    End Sub
End Class