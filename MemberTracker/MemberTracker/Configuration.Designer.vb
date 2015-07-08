<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Configuration
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Me.btnInput = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtInputPath = New System.Windows.Forms.TextBox()
        Me.btnBackup = New System.Windows.Forms.Button()
        Me.txtBackupPath = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnSaveConfig = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.chkSaveOnClose = New System.Windows.Forms.CheckBox()
        Me.chkBackupOnOpen = New System.Windows.Forms.CheckBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.txtSendFromName = New System.Windows.Forms.TextBox()
        Me.txtSendFromEmail = New System.Windows.Forms.TextBox()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.txtUsername = New System.Windows.Forms.TextBox()
        Me.txtSMTPPort = New System.Windows.Forms.TextBox()
        Me.txtSMTPServer = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnEmail = New System.Windows.Forms.Button()
        Me.txtEmailTemplate = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnInput
        '
        Me.btnInput.Location = New System.Drawing.Point(276, 22)
        Me.btnInput.Name = "btnInput"
        Me.btnInput.Size = New System.Drawing.Size(26, 23)
        Me.btnInput.TabIndex = 1
        Me.btnInput.Text = "..."
        Me.btnInput.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(55, 27)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(47, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "CSV File"
        '
        'txtInputPath
        '
        Me.txtInputPath.Enabled = False
        Me.txtInputPath.Location = New System.Drawing.Point(108, 19)
        Me.txtInputPath.Multiline = True
        Me.txtInputPath.Name = "txtInputPath"
        Me.txtInputPath.Size = New System.Drawing.Size(161, 34)
        Me.txtInputPath.TabIndex = 4
        Me.txtInputPath.Text = "Select File"
        Me.txtInputPath.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btnBackup
        '
        Me.btnBackup.Location = New System.Drawing.Point(276, 64)
        Me.btnBackup.Name = "btnBackup"
        Me.btnBackup.Size = New System.Drawing.Size(26, 23)
        Me.btnBackup.TabIndex = 9
        Me.btnBackup.Text = "..."
        Me.btnBackup.UseVisualStyleBackColor = True
        '
        'txtBackupPath
        '
        Me.txtBackupPath.Enabled = False
        Me.txtBackupPath.Location = New System.Drawing.Point(108, 59)
        Me.txtBackupPath.Multiline = True
        Me.txtBackupPath.Name = "txtBackupPath"
        Me.txtBackupPath.Size = New System.Drawing.Size(161, 34)
        Me.txtBackupPath.TabIndex = 8
        Me.txtBackupPath.Text = "Select File"
        Me.txtBackupPath.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(18, 69)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(84, 13)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "CSV Backup Dir"
        '
        'btnSaveConfig
        '
        Me.btnSaveConfig.Location = New System.Drawing.Point(97, 373)
        Me.btnSaveConfig.Name = "btnSaveConfig"
        Me.btnSaveConfig.Size = New System.Drawing.Size(112, 24)
        Me.btnSaveConfig.TabIndex = 10
        Me.btnSaveConfig.Text = "Save Configuration"
        Me.btnSaveConfig.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnEmail)
        Me.GroupBox1.Controls.Add(Me.txtEmailTemplate)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.chkSaveOnClose)
        Me.GroupBox1.Controls.Add(Me.chkBackupOnOpen)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.btnInput)
        Me.GroupBox1.Controls.Add(Me.btnBackup)
        Me.GroupBox1.Controls.Add(Me.txtBackupPath)
        Me.GroupBox1.Controls.Add(Me.txtInputPath)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Location = New System.Drawing.Point(3, 3)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(310, 170)
        Me.GroupBox1.TabIndex = 11
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "File Configuration"
        '
        'chkSaveOnClose
        '
        Me.chkSaveOnClose.AutoSize = True
        Me.chkSaveOnClose.Location = New System.Drawing.Point(175, 142)
        Me.chkSaveOnClose.Name = "chkSaveOnClose"
        Me.chkSaveOnClose.Size = New System.Drawing.Size(82, 17)
        Me.chkSaveOnClose.TabIndex = 11
        Me.chkSaveOnClose.Text = "Auto-Save?"
        Me.chkSaveOnClose.UseVisualStyleBackColor = True
        '
        'chkBackupOnOpen
        '
        Me.chkBackupOnOpen.AutoSize = True
        Me.chkBackupOnOpen.Location = New System.Drawing.Point(75, 142)
        Me.chkBackupOnOpen.Name = "chkBackupOnOpen"
        Me.chkBackupOnOpen.Size = New System.Drawing.Size(94, 17)
        Me.chkBackupOnOpen.TabIndex = 10
        Me.chkBackupOnOpen.Text = "Auto-Backup?"
        Me.chkBackupOnOpen.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.txtSendFromName)
        Me.GroupBox2.Controls.Add(Me.txtSendFromEmail)
        Me.GroupBox2.Controls.Add(Me.txtPassword)
        Me.GroupBox2.Controls.Add(Me.txtUsername)
        Me.GroupBox2.Controls.Add(Me.txtSMTPPort)
        Me.GroupBox2.Controls.Add(Me.txtSMTPServer)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Location = New System.Drawing.Point(3, 179)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(292, 188)
        Me.GroupBox2.TabIndex = 12
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Email Configuration"
        '
        'txtSendFromName
        '
        Me.txtSendFromName.Location = New System.Drawing.Point(140, 156)
        Me.txtSendFromName.Name = "txtSendFromName"
        Me.txtSendFromName.Size = New System.Drawing.Size(146, 20)
        Me.txtSendFromName.TabIndex = 11
        Me.txtSendFromName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtSendFromEmail
        '
        Me.txtSendFromEmail.Location = New System.Drawing.Point(96, 130)
        Me.txtSendFromEmail.Name = "txtSendFromEmail"
        Me.txtSendFromEmail.Size = New System.Drawing.Size(190, 20)
        Me.txtSendFromEmail.TabIndex = 10
        Me.txtSendFromEmail.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtPassword
        '
        Me.txtPassword.Location = New System.Drawing.Point(94, 104)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPassword.Size = New System.Drawing.Size(192, 20)
        Me.txtPassword.TabIndex = 9
        Me.txtPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txtPassword.UseSystemPasswordChar = True
        '
        'txtUsername
        '
        Me.txtUsername.Location = New System.Drawing.Point(94, 78)
        Me.txtUsername.Name = "txtUsername"
        Me.txtUsername.Size = New System.Drawing.Size(192, 20)
        Me.txtUsername.TabIndex = 8
        Me.txtUsername.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtSMTPPort
        '
        Me.txtSMTPPort.Location = New System.Drawing.Point(94, 52)
        Me.txtSMTPPort.Name = "txtSMTPPort"
        Me.txtSMTPPort.Size = New System.Drawing.Size(192, 20)
        Me.txtSMTPPort.TabIndex = 7
        Me.txtSMTPPort.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtSMTPServer
        '
        Me.txtSMTPServer.Location = New System.Drawing.Point(94, 26)
        Me.txtSMTPServer.Name = "txtSMTPServer"
        Me.txtSMTPServer.Size = New System.Drawing.Size(190, 20)
        Me.txtSMTPServer.TabIndex = 6
        Me.txtSMTPServer.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(6, 159)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(128, 13)
        Me.Label9.TabIndex = 5
        Me.Label9.Text = "Send Email Display Name"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(4, 133)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(86, 13)
        Me.Label8.TabIndex = 4
        Me.Label8.Text = "Send From Email"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(35, 107)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(53, 13)
        Me.Label7.TabIndex = 3
        Me.Label7.Text = "Password"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(33, 81)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(55, 13)
        Me.Label6.TabIndex = 2
        Me.Label6.Text = "Username"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(29, 55)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(59, 13)
        Me.Label5.TabIndex = 1
        Me.Label5.Text = "SMTP Port"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(19, 29)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(71, 13)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "SMTP Server"
        '
        'btnEmail
        '
        Me.btnEmail.Location = New System.Drawing.Point(276, 105)
        Me.btnEmail.Name = "btnEmail"
        Me.btnEmail.Size = New System.Drawing.Size(26, 23)
        Me.btnEmail.TabIndex = 14
        Me.btnEmail.Text = "..."
        Me.btnEmail.UseVisualStyleBackColor = True
        '
        'txtEmailTemplate
        '
        Me.txtEmailTemplate.Enabled = False
        Me.txtEmailTemplate.Location = New System.Drawing.Point(108, 100)
        Me.txtEmailTemplate.Multiline = True
        Me.txtEmailTemplate.Name = "txtEmailTemplate"
        Me.txtEmailTemplate.Size = New System.Drawing.Size(161, 34)
        Me.txtEmailTemplate.TabIndex = 13
        Me.txtEmailTemplate.Text = "Select File"
        Me.txtEmailTemplate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(4, 110)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(98, 13)
        Me.Label2.TabIndex = 12
        Me.Label2.Text = "Email Template File"
        '
        'Configuration
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnSaveConfig)
        Me.Name = "Configuration"
        Me.Size = New System.Drawing.Size(316, 413)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnInput As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtInputPath As System.Windows.Forms.TextBox
    Friend WithEvents btnBackup As System.Windows.Forms.Button
    Friend WithEvents txtBackupPath As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents btnSaveConfig As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents txtSendFromName As System.Windows.Forms.TextBox
    Friend WithEvents txtSendFromEmail As System.Windows.Forms.TextBox
    Friend WithEvents txtPassword As System.Windows.Forms.TextBox
    Friend WithEvents txtUsername As System.Windows.Forms.TextBox
    Friend WithEvents txtSMTPPort As System.Windows.Forms.TextBox
    Friend WithEvents txtSMTPServer As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents chkSaveOnClose As System.Windows.Forms.CheckBox
    Friend WithEvents chkBackupOnOpen As System.Windows.Forms.CheckBox
    Friend WithEvents btnEmail As System.Windows.Forms.Button
    Friend WithEvents txtEmailTemplate As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label

End Class
