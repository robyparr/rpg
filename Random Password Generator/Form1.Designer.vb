<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.TabControl1 = New System.Windows.Forms.TabControl
        Me.TabPage1 = New System.Windows.Forms.TabPage
        Me.LinkCopy = New System.Windows.Forms.LinkLabel
        Me.BtnGenerate = New System.Windows.Forms.Button
        Me.Label2 = New System.Windows.Forms.Label
        Me.TxtPassword = New System.Windows.Forms.TextBox
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.NumLength = New System.Windows.Forms.NumericUpDown
        Me.Label1 = New System.Windows.Forms.Label
        Me.ChkUpper = New System.Windows.Forms.CheckBox
        Me.ChkLower = New System.Windows.Forms.CheckBox
        Me.ChkNumbers = New System.Windows.Forms.CheckBox
        Me.TabPage2 = New System.Windows.Forms.TabPage
        Me.LblLogedIn = New System.Windows.Forms.Label
        Me.LblMasterPass = New System.Windows.Forms.Label
        Me.BtnView = New System.Windows.Forms.Button
        Me.BtnRemove = New System.Windows.Forms.Button
        Me.BtnNew = New System.Windows.Forms.Button
        Me.ListAccounts = New System.Windows.Forms.ListView
        Me.ColumnHeader1 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader2 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader3 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader5 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader6 = New System.Windows.Forms.ColumnHeader
        Me.BtnShowHide = New System.Windows.Forms.Button
        Me.BtnAbout = New System.Windows.Forms.Button
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.NumLength, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage2.SuspendLayout()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Top
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(404, 62)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.TabControl1.Location = New System.Drawing.Point(0, 63)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(404, 178)
        Me.TabControl1.TabIndex = 1
        '
        'TabPage1
        '
        Me.TabPage1.BackColor = System.Drawing.SystemColors.Control
        Me.TabPage1.Controls.Add(Me.BtnAbout)
        Me.TabPage1.Controls.Add(Me.LinkCopy)
        Me.TabPage1.Controls.Add(Me.BtnGenerate)
        Me.TabPage1.Controls.Add(Me.Label2)
        Me.TabPage1.Controls.Add(Me.TxtPassword)
        Me.TabPage1.Controls.Add(Me.GroupBox1)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(396, 152)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Generator"
        '
        'LinkCopy
        '
        Me.LinkCopy.AutoSize = True
        Me.LinkCopy.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
        Me.LinkCopy.Location = New System.Drawing.Point(309, 85)
        Me.LinkCopy.Name = "LinkCopy"
        Me.LinkCopy.Size = New System.Drawing.Size(80, 13)
        Me.LinkCopy.TabIndex = 4
        Me.LinkCopy.TabStop = True
        Me.LinkCopy.Text = "Copy Password"
        Me.LinkCopy.VisitedLinkColor = System.Drawing.Color.Blue
        '
        'BtnGenerate
        '
        Me.BtnGenerate.Location = New System.Drawing.Point(312, 111)
        Me.BtnGenerate.Name = "BtnGenerate"
        Me.BtnGenerate.Size = New System.Drawing.Size(75, 38)
        Me.BtnGenerate.TabIndex = 3
        Me.BtnGenerate.Text = "Generate Password"
        Me.BtnGenerate.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(8, 105)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(56, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Password:"
        '
        'TxtPassword
        '
        Me.TxtPassword.Location = New System.Drawing.Point(11, 121)
        Me.TxtPassword.Name = "TxtPassword"
        Me.TxtPassword.Size = New System.Drawing.Size(295, 20)
        Me.TxtPassword.TabIndex = 1
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.NumLength)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.ChkUpper)
        Me.GroupBox1.Controls.Add(Me.ChkLower)
        Me.GroupBox1.Controls.Add(Me.ChkNumbers)
        Me.GroupBox1.Location = New System.Drawing.Point(8, 6)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(298, 92)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'NumLength
        '
        Me.NumLength.Location = New System.Drawing.Point(175, 38)
        Me.NumLength.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.NumLength.Name = "NumLength"
        Me.NumLength.Size = New System.Drawing.Size(111, 20)
        Me.NumLength.TabIndex = 4
        Me.NumLength.Value = New Decimal(New Integer() {8, 0, 0, 0})
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(172, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(43, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Length:"
        '
        'ChkUpper
        '
        Me.ChkUpper.AutoSize = True
        Me.ChkUpper.Location = New System.Drawing.Point(7, 68)
        Me.ChkUpper.Name = "ChkUpper"
        Me.ChkUpper.Size = New System.Drawing.Size(113, 17)
        Me.ChkUpper.TabIndex = 2
        Me.ChkUpper.Text = "Uppercase Letters"
        Me.ChkUpper.UseVisualStyleBackColor = True
        '
        'ChkLower
        '
        Me.ChkLower.AutoSize = True
        Me.ChkLower.Location = New System.Drawing.Point(7, 44)
        Me.ChkLower.Name = "ChkLower"
        Me.ChkLower.Size = New System.Drawing.Size(113, 17)
        Me.ChkLower.TabIndex = 1
        Me.ChkLower.Text = "Lowercase Letters"
        Me.ChkLower.UseVisualStyleBackColor = True
        '
        'ChkNumbers
        '
        Me.ChkNumbers.AutoSize = True
        Me.ChkNumbers.Location = New System.Drawing.Point(7, 20)
        Me.ChkNumbers.Name = "ChkNumbers"
        Me.ChkNumbers.Size = New System.Drawing.Size(68, 17)
        Me.ChkNumbers.TabIndex = 0
        Me.ChkNumbers.Text = "Numbers"
        Me.ChkNumbers.UseVisualStyleBackColor = True
        '
        'TabPage2
        '
        Me.TabPage2.BackColor = System.Drawing.SystemColors.Control
        Me.TabPage2.Controls.Add(Me.BtnShowHide)
        Me.TabPage2.Controls.Add(Me.LblLogedIn)
        Me.TabPage2.Controls.Add(Me.LblMasterPass)
        Me.TabPage2.Controls.Add(Me.BtnView)
        Me.TabPage2.Controls.Add(Me.BtnRemove)
        Me.TabPage2.Controls.Add(Me.BtnNew)
        Me.TabPage2.Controls.Add(Me.ListAccounts)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(396, 152)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Vault"
        '
        'LblLogedIn
        '
        Me.LblLogedIn.AutoSize = True
        Me.LblLogedIn.Location = New System.Drawing.Point(165, 118)
        Me.LblLogedIn.Name = "LblLogedIn"
        Me.LblLogedIn.Size = New System.Drawing.Size(32, 13)
        Me.LblLogedIn.TabIndex = 4
        Me.LblLogedIn.Text = "False"
        Me.LblLogedIn.Visible = False
        '
        'LblMasterPass
        '
        Me.LblMasterPass.AutoSize = True
        Me.LblMasterPass.Location = New System.Drawing.Point(165, 134)
        Me.LblMasterPass.Name = "LblMasterPass"
        Me.LblMasterPass.Size = New System.Drawing.Size(62, 13)
        Me.LblMasterPass.TabIndex = 3
        Me.LblMasterPass.Text = "MasterPass"
        Me.LblMasterPass.Visible = False
        '
        'BtnView
        '
        Me.BtnView.Location = New System.Drawing.Point(310, 121)
        Me.BtnView.Name = "BtnView"
        Me.BtnView.Size = New System.Drawing.Size(75, 23)
        Me.BtnView.TabIndex = 2
        Me.BtnView.Text = "View"
        Me.BtnView.UseVisualStyleBackColor = True
        '
        'BtnRemove
        '
        Me.BtnRemove.Location = New System.Drawing.Point(84, 121)
        Me.BtnRemove.Name = "BtnRemove"
        Me.BtnRemove.Size = New System.Drawing.Size(75, 23)
        Me.BtnRemove.TabIndex = 1
        Me.BtnRemove.Text = "Remove"
        Me.BtnRemove.UseVisualStyleBackColor = True
        '
        'BtnNew
        '
        Me.BtnNew.Location = New System.Drawing.Point(3, 121)
        Me.BtnNew.Name = "BtnNew"
        Me.BtnNew.Size = New System.Drawing.Size(75, 23)
        Me.BtnNew.TabIndex = 1
        Me.BtnNew.Text = "New"
        Me.BtnNew.UseVisualStyleBackColor = True
        '
        'ListAccounts
        '
        Me.ListAccounts.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader5, Me.ColumnHeader6})
        Me.ListAccounts.Dock = System.Windows.Forms.DockStyle.Top
        Me.ListAccounts.FullRowSelect = True
        Me.ListAccounts.GridLines = True
        Me.ListAccounts.Location = New System.Drawing.Point(3, 3)
        Me.ListAccounts.Name = "ListAccounts"
        Me.ListAccounts.Size = New System.Drawing.Size(390, 112)
        Me.ListAccounts.TabIndex = 0
        Me.ListAccounts.UseCompatibleStateImageBehavior = False
        Me.ListAccounts.View = System.Windows.Forms.View.Details
        Me.ListAccounts.Visible = False
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Name"
        Me.ColumnHeader1.Width = 100
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Account"
        Me.ColumnHeader2.Width = 100
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Password"
        Me.ColumnHeader3.Width = 0
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "Type"
        '
        'ColumnHeader6
        '
        Me.ColumnHeader6.Text = "Website"
        Me.ColumnHeader6.Width = 125
        '
        'BtnShowHide
        '
        Me.BtnShowHide.Location = New System.Drawing.Point(203, 121)
        Me.BtnShowHide.Name = "BtnShowHide"
        Me.BtnShowHide.Size = New System.Drawing.Size(101, 23)
        Me.BtnShowHide.TabIndex = 5
        Me.BtnShowHide.Text = "Show Passwords"
        Me.BtnShowHide.UseVisualStyleBackColor = True
        '
        'BtnAbout
        '
        Me.BtnAbout.Location = New System.Drawing.Point(312, 6)
        Me.BtnAbout.Name = "BtnAbout"
        Me.BtnAbout.Size = New System.Drawing.Size(75, 23)
        Me.BtnAbout.TabIndex = 5
        Me.BtnAbout.Text = "About"
        Me.BtnAbout.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(404, 241)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.PictureBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Random Password Generator"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.NumLength, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents NumLength As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ChkUpper As System.Windows.Forms.CheckBox
    Friend WithEvents ChkLower As System.Windows.Forms.CheckBox
    Friend WithEvents ChkNumbers As System.Windows.Forms.CheckBox
    Friend WithEvents BtnGenerate As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TxtPassword As System.Windows.Forms.TextBox
    Friend WithEvents LinkCopy As System.Windows.Forms.LinkLabel
    Friend WithEvents ListAccounts As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader5 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader6 As System.Windows.Forms.ColumnHeader
    Friend WithEvents BtnView As System.Windows.Forms.Button
    Friend WithEvents BtnRemove As System.Windows.Forms.Button
    Friend WithEvents BtnNew As System.Windows.Forms.Button
    Friend WithEvents LblMasterPass As System.Windows.Forms.Label
    Friend WithEvents LblLogedIn As System.Windows.Forms.Label
    Friend WithEvents BtnShowHide As System.Windows.Forms.Button
    Friend WithEvents BtnAbout As System.Windows.Forms.Button

End Class
