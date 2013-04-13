Public Class Form1

    Dim AccountsLocation As String = Application.StartupPath + "\Accounts\"

    Public Sub GeneratePassword()
        ' Clears previous passwords
        TxtPassword.Clear()

        ' Randomizes
        Randomize()

        ' Variable to store random numbers
        Dim RandomNumber As Integer

        ' Variable to store random letters
        Dim RandomLetter As Char

        ''''' Numbers Only '''''
        If (ChkNumbers.Checked) And (ChkLower.Checked = False) And (ChkUpper.Checked = False) Then
            ' Loop to build password
            For counter As Integer = 0 To NumLength.Value - 1
                RandomNumber = Int((10 - 0) * Rnd() + 0)
                TxtPassword.Text += RandomNumber.ToString
            Next

            ''''' Lowercase Only '''''
        ElseIf (ChkNumbers.Checked = False) And (ChkLower.Checked) And (ChkUpper.Checked = False) Then
            ' Loop to build password
            For counter As Integer = 0 To NumLength.Value - 1
                RandomNumber = Int((122 - 97) * Rnd() + 97)

                ' Changes number to letter
                RandomLetter = ChrW(RandomNumber)

                TxtPassword.Text += RandomLetter.ToString
            Next

            ''''' Uppercase Only '''''
        ElseIf (ChkNumbers.Checked = False) And (ChkLower.Checked = False) And (ChkUpper.Checked) Then
            ' Loop to build password
            For counter As Integer = 0 To NumLength.Value - 1
                RandomNumber = Int((90 - 65) * Rnd() + 65)

                ' Changes number to letter
                RandomLetter = ChrW(RandomNumber)

                TxtPassword.Text += RandomLetter.ToString
            Next

            ''''' Numbers and Lowercase '''''
        ElseIf (ChkNumbers.Checked) And (ChkLower.Checked) And (ChkUpper.Checked = False) Then
            ' Start a loop to create password
            For counter As Integer = 0 To NumLength.Value - 1
                RandomNumber = Int((122 - 48) * Rnd() + 48)

                While (RandomNumber > 57) And (RandomNumber < 97)
                    RandomNumber = Int((122 - 48) * Rnd() + 48)
                End While

                ' changes number to letter
                RandomLetter = ChrW(RandomNumber)

                TxtPassword.Text += RandomLetter.ToString
            Next

            ''''' Numbers and Uppercase '''''
        ElseIf (ChkNumbers.Checked) And (ChkLower.Checked = False) And (ChkUpper.Checked) Then
            For counter As Integer = 0 To NumLength.Value - 1
                RandomNumber = Int((90 - 48) * Rnd() + 48)

                While (RandomNumber > 57) And (RandomNumber < 65)
                    RandomNumber = Int((90 - 48) * Rnd() + 48)
                End While

                ' changes number to letter
                RandomLetter = ChrW(RandomNumber)

                TxtPassword.Text += RandomLetter.ToString
            Next

            ''''' Lowercase and Uppercase '''''
        ElseIf (ChkNumbers.Checked = False) And (ChkLower.Checked) And (ChkUpper.Checked) Then
            For counter As Integer = 0 To NumLength.Value - 1
                RandomNumber = Int((122 - 65) * Rnd() + 65)

                While (RandomNumber > 90) And (RandomNumber < 97)
                    RandomNumber = Int((122 - 65) * Rnd() + 65)
                End While

                ' changes number to letter
                RandomLetter = ChrW(RandomNumber)

                TxtPassword.Text += RandomLetter.ToString
            Next

            ''''' All 3 '''''
        ElseIf (ChkNumbers.Checked) And (ChkLower.Checked) And (ChkUpper.Checked) Then
            For counter As Integer = 0 To NumLength.Value - 1
                RandomNumber = Int((122 - 48) * Rnd() + 48)

                While (RandomNumber > 57) And (RandomNumber < 65) Or (RandomNumber > 90) And (RandomNumber < 97)
                    RandomNumber = Int((122 - 48) * Rnd() + 48)
                End While

                ' changes number to letter
                RandomLetter = ChrW(RandomNumber)

                TxtPassword.Text += RandomLetter.ToString
            Next

        Else
            MessageBox.Show("You must select an option!", "RPG - Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    ' Controls
    Private Sub BtnGenerate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnGenerate.Click
        GeneratePassword()
    End Sub

    Private Sub LinkCopy_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkCopy.LinkClicked
        If (TxtPassword.Text <> Nothing) Then
            My.Computer.Clipboard.SetText(TxtPassword.Text)
        End If
    End Sub

    Private Sub TabControl1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TabControl1.SelectedIndexChanged
        ' Checks what page it's on
        If (TabControl1.SelectedIndex <> 1) Or (LblLogedIn.Text = "True") Then
            Exit Sub
        End If

        FrmLogin.ShowDialog()
    End Sub

    Private Sub BtnNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnNew.Click
        Form2.Text = "Account Information - New Account"
        Form2.BtnSave.Enabled = True
        Form2.ShowDialog()
    End Sub

    Private Sub BtnRemove_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnRemove.Click
        If (ListAccounts.SelectedItems.Count = 0) Then
            Exit Sub
        End If

        Dim accountLoc As String = AccountsLocation + ListAccounts.SelectedItems(0).SubItems(0).Text + ".txt"

        My.Computer.FileSystem.DeleteFile(accountLoc)
        ListAccounts.Items.Remove(ListAccounts.SelectedItems(0))

        ListAccounts.SelectedItems.Clear()
    End Sub

    Private Sub BtnView_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnView.Click
        If (ListAccounts.SelectedItems.Count = 0) Then
            Exit Sub
        End If

        ' Declares encryption module
        Dim AccountEncryption As New Encryption(LblMasterPass.Text)

        ' Reads info
        Dim FileName As String = ListAccounts.SelectedItems(0).SubItems(0).Text
        Dim EncryptedData As String = My.Computer.FileSystem.ReadAllText(AccountsLocation + FileName + ".txt")

        ' Decrypts data
        Dim splitData As String() = Split(AccountEncryption.DecryptData(EncryptedData), ";")

        ' Displays data
        Form2.TxtName.Text = FileName
        Form2.TxtAccount.Text = splitData(0)
        Form2.TxtPass.Text = splitData(1)
        Form2.TxtWebsite.Text = splitData(2)
        Form2.ComboType.Text = splitData(3)
        Form2.RichNotes.Text = splitData(4)

        ' Shows form
        Form2.Text = "Account Information - Viewing Account"
        Form2.BtnSave.Enabled = False
        Form2.ShowDialog()
    End Sub

    Private Sub BtnShowHide_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnShowHide.Click
        If (BtnShowHide.Text = "Show Passwords") Then
            ListAccounts.Columns.Item(2).Width = 100
            BtnShowHide.Text = "Hide Passwords"
        Else
            ListAccounts.Columns.Item(2).Width = 0
            BtnShowHide.Text = "Show Passwords"
        End If
    End Sub

    Private Sub BtnAbout_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnAbout.Click
        FrmAbout.ShowDialog()
    End Sub
End Class
