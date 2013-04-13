Public Class FrmLogin

    ' Location of accounts
    Dim AccountsLocation As String = Application.StartupPath + "\Accounts\"

    ' Location of master password
    Dim MasterPassLocation As String = Application.StartupPath + "\"

    Public Function HashData(ByVal InputData As String) As String
        ' Data to be Encrypted
        Dim TextToEncrypt As String = InputData

        ' Used to store the hashed data
        Dim byteHashedData As Byte()

        ' Used to convert the string to bytes
        Dim Encoder As New System.Text.UTF8Encoding()

        ' The hashing variable
        Dim md5Hasher As New Security.Cryptography.MD5CryptoServiceProvider

        ' Hashes the data
        byteHashedData = md5Hasher.ComputeHash(Encoder.GetBytes("Salt" + TextToEncrypt))

        ' Converts the hashed data from bytes to string
        Dim HashedValue As String = Convert.ToBase64String(byteHashedData)

        Return HashedValue
    End Function

    Function CheckNew() As Boolean
        Dim Exists As Boolean

        ' File info
        Dim FileInformation As New IO.FileInfo(MasterPassLocation + "RPG.txt")

        ' Checks to see if there is already a password
        If (FileInformation.Exists = False) Then
            Exists = False
        Else
            Exists = True
        End If

        Return Exists
    End Function

    Private Sub LoadAccounts()
        Form1.ListAccounts.Items.Clear()

        Dim AccountsDir As New IO.DirectoryInfo(AccountsLocation)
        Dim AccountInfo As IO.FileInfo

        Dim Decryptor As New Encryption(TxtMasterPass.Text)

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
    Private Sub FrmLogin_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ' Checks to see if there is already a password
        If (CheckNew() = False) Then
            Me.Text = "New Master Password"
            BtnLogin.Text = "Save"
        End If
    End Sub

    Private Sub BtnLogin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnLogin.Click
        ' Checks to see if there is already a password
        If (CheckNew() = False) Then
            If (My.Computer.FileSystem.DirectoryExists(AccountsLocation) = False) Then
                My.Computer.FileSystem.CreateDirectory(AccountsLocation)
            End If
            My.Computer.FileSystem.WriteAllText(MasterPassLocation + "RPG.txt", HashData(TxtMasterPass.Text), False)
            Form1.LblLogedIn.Text = "True"
            Form1.ListAccounts.Visible = True
            Form1.LblMasterPass.Text = TxtMasterPass.Text
            Me.Close()
        Else
            Dim Pass As String = HashData(TxtMasterPass.Text)
            Dim MasterPass As String = My.Computer.FileSystem.ReadAllText(MasterPassLocation + "RPG.txt")

            ' Checks to see if password is correct
            If (Pass <> MasterPass) Then
                Form1.TabControl1.SelectedIndex = 0
                Form1.LblLogedIn.Text = "False"
                Me.Close()
            Else
                Form1.LblLogedIn.Text = "True"
                Form1.ListAccounts.Visible = True
                Form1.LblMasterPass.Text = TxtMasterPass.Text
                LoadAccounts()
                Me.Close()
            End If
        End If
    End Sub
End Class