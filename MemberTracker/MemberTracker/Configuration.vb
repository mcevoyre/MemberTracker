Imports System.Xml
Imports System.Configuration

Public Class Configuration

#Region "Properties"
    Public Property InputPath As String
        Get
            Return txtInputPath.Text
        End Get
        Set(value As String)
            txtInputPath.Text = value
        End Set
    End Property

    Public Property EmailPath As String
        Get
            Return txtEmailTemplate.Text
        End Get
        Set(value As String)
            txtEmailTemplate.Text = value
        End Set
    End Property

    Public Property BackupPath As String
        Get
            Return txtBackupPath.Text
        End Get
        Set(value As String)
            txtBackupPath.Text = value
        End Set
    End Property

    Public Property AutoBackup As Boolean
        Get
            Return chkBackupOnOpen.Checked
        End Get
        Set(value As Boolean)
            chkBackupOnOpen.Checked = value
        End Set
    End Property

    Public Property AutoSave As Boolean
        Get
            Return chkSaveOnClose.Checked
        End Get
        Set(value As Boolean)
            chkSaveOnClose.Checked = value
        End Set
    End Property

    Public Property SMTPServer
        Get
            Return txtSMTPServer.Text
        End Get
        Set(value)
            txtSMTPServer.Text = value
        End Set
    End Property

    Public Property SMTPPort
        Get
            Return txtSMTPPort.Text
        End Get
        Set(value)
            txtSMTPPort.Text = value
        End Set
    End Property

    Public Property Username
        Get
            Return txtUsername.Text
        End Get
        Set(value)
            txtUsername.Text = value
        End Set
    End Property

    Public Property Password
        Get
            Return txtPassword.Text
        End Get
        Set(value)
            txtPassword.Text = value
        End Set
    End Property

    Public Property SendEmailAddress
        Get
            Return txtSendFromEmail.Text
        End Get
        Set(value)
            txtSendFromEmail.Text = value
        End Set
    End Property

    Public Property SendEmailName
        Get
            Return txtSendFromName.Text
        End Get
        Set(value)
            txtSendFromName.Text = value
        End Set
    End Property

    Private Property _Configured As Boolean
    Public Property ConfigSet As Boolean
        Get
            Return _Configured
        End Get
        Set(value As Boolean)
            _Configured = value
        End Set
    End Property
#End Region

    Public Sub PopulateConfigFromXMLFile(filePath As String)
        Try
            Dim fileStream As New IO.StreamReader(filePath)
            Using readXML As XmlReader = XmlReader.Create(fileStream.BaseStream)
                readXML.ReadToFollowing("InputPath")
                InputPath = readXML.ReadElementContentAsString()
                readXML.ReadToFollowing("BackupPath")
                BackupPath = readXML.ReadElementContentAsString()
                readXML.ReadToFollowing("AutoBackUp")
                Dim backupstring = readXML.ReadElementContentAsString()
                AutoBackup = CBool(backupstring)
                readXML.ReadToFollowing("AutoSave")
                Dim autosaveString = readXML.ReadElementContentAsString()
                AutoSave = CBool(autosaveString)
                readXML.ReadToFollowing("SMTPServer")
                SMTPServer = readXML.ReadElementContentAsString()
                readXML.ReadToFollowing("SMTPPort")
                SMTPPort = readXML.ReadElementContentAsString()
                readXML.ReadToFollowing("UserName")
                Username = readXML.ReadElementContentAsString()
                readXML.ReadToFollowing("Password")
                Password = readXML.ReadElementContentAsString()
                readXML.ReadToFollowing("SendEmailAddress")
                SendEmailAddress = readXML.ReadElementContentAsString()
                readXML.ReadToFollowing("SendEmailName")
                SendEmailName = readXML.ReadElementContentAsString()
                readXML.ReadToFollowing("EmalTemplateFileLocation")
                EmailPath = readXML.ReadElementContentAsString()
            End Using
            fileStream.Close()
        Catch ex As Exception
            ConfigSet = False
        End Try
        ConfigSet = True
    End Sub

    Private Sub btnSaveConfig_Click(sender As Object, e As EventArgs) Handles btnSaveConfig.Click
        Dim saveXMLLocation As String = ConfigurationSettings.AppSettings("ConfigurationSaveLocation")
        Dim xmlSettings As New XmlWriterSettings() With {.Indent = True}
        Try
            Dim fileWrite As New IO.StreamWriter(saveXMLLocation)
            Using writeXML As XmlWriter = XmlWriter.Create(fileWrite.BaseStream, xmlSettings)
                writeXML.WriteStartElement("MemberTrackerConfiguration")

                writeXML.WriteStartElement("InputPath")
                writeXML.WriteString(txtInputPath.Text)
                writeXML.WriteEndElement()
                writeXML.WriteStartElement("BackupPath")
                writeXML.WriteString(txtBackupPath.Text)
                writeXML.WriteEndElement()
                writeXML.WriteStartElement("AutoBackUp")
                writeXML.WriteString(chkBackupOnOpen.Checked.ToString)
                writeXML.WriteEndElement()
                writeXML.WriteStartElement("AutoSave")
                writeXML.WriteString(chkSaveOnClose.Checked.ToString)
                writeXML.WriteEndElement()
                writeXML.WriteStartElement("SMTPServer")
                writeXML.WriteString(txtSMTPServer.Text)
                writeXML.WriteEndElement()
                writeXML.WriteStartElement("SMTPPort")
                writeXML.WriteString(txtSMTPPort.Text)
                writeXML.WriteEndElement()
                writeXML.WriteStartElement("UserName")
                writeXML.WriteString(txtUsername.Text)
                writeXML.WriteEndElement()
                writeXML.WriteStartElement("Password")
                writeXML.WriteString(txtPassword.Text)
                writeXML.WriteEndElement()
                writeXML.WriteStartElement("SendEmailAddress")
                writeXML.WriteString(txtSendFromEmail.Text)
                writeXML.WriteEndElement()
                writeXML.WriteStartElement("SendEmailName")
                writeXML.WriteString(txtSendFromName.Text)
                writeXML.WriteEndElement()
                writeXML.WriteStartElement("EmalTemplateFileLocation")
                writeXML.WriteString(txtEmailTemplate.Text)
                writeXML.WriteEndElement()

                writeXML.WriteEndElement()
            End Using
            fileWrite.Close()
        Catch

        End Try
    End Sub

    Private Sub btnInput_Click(sender As Object, e As EventArgs) Handles btnInput.Click
        Dim ofd As New OpenFileDialog
        If ofd.ShowDialog() = DialogResult.OK Then
            InputPath = ofd.FileName
        End If
    End Sub

    Private Sub btnBackup_Click(sender As Object, e As EventArgs) Handles btnBackup.Click
        Dim ofd As New FolderBrowserDialog
        If ofd.ShowDialog() = DialogResult.OK Then
            BackupPath = ofd.SelectedPath
        End If
    End Sub

    Private Sub btnEmail_Click(sender As Object, e As EventArgs) Handles btnEmail.Click
        Dim ofd As New OpenFileDialog
        If ofd.ShowDialog() = DialogResult.OK Then
            EmailPath = ofd.FileName
        End If
    End Sub
End Class
