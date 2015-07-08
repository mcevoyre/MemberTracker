<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MemberControl
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.chkMarried = New System.Windows.Forms.CheckBox()
        Me.chkBaptized = New System.Windows.Forms.CheckBox()
        Me.chkSalvation = New System.Windows.Forms.CheckBox()
        Me.chkShareInformation = New System.Windows.Forms.CheckBox()
        Me.txtFirstName = New System.Windows.Forms.TextBox()
        Me.txtLastName = New System.Windows.Forms.TextBox()
        Me.cboSpouse = New System.Windows.Forms.ComboBox()
        Me.dtpDOB = New System.Windows.Forms.DateTimePicker()
        Me.dtpAnniversaryDate = New System.Windows.Forms.DateTimePicker()
        Me.chkAttendedOrientation = New System.Windows.Forms.CheckBox()
        Me.dtpOrientationDate = New System.Windows.Forms.DateTimePicker()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtAge = New System.Windows.Forms.TextBox()
        Me.btnSaveChanges = New System.Windows.Forms.Button()
        Me.txtMinistryTopics = New System.Windows.Forms.TextBox()
        Me.chkPastorContact = New System.Windows.Forms.CheckBox()
        Me.txtNotes = New System.Windows.Forms.TextBox()
        Me.chkMemberArchived = New System.Windows.Forms.CheckBox()
        Me.chkMemberActive = New System.Windows.Forms.CheckBox()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(83, 6)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(57, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "First Name"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(82, 32)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(58, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Last Name"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(74, 61)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(66, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Date of Birth"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(52, 161)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(88, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Anniversary Date"
        '
        'chkMarried
        '
        Me.chkMarried.AutoSize = True
        Me.chkMarried.Location = New System.Drawing.Point(146, 135)
        Me.chkMarried.Name = "chkMarried"
        Me.chkMarried.Size = New System.Drawing.Size(67, 17)
        Me.chkMarried.TabIndex = 4
        Me.chkMarried.Text = "Married?"
        Me.chkMarried.UseVisualStyleBackColor = True
        '
        'chkBaptized
        '
        Me.chkBaptized.AutoSize = True
        Me.chkBaptized.Location = New System.Drawing.Point(146, 211)
        Me.chkBaptized.Name = "chkBaptized"
        Me.chkBaptized.Size = New System.Drawing.Size(67, 17)
        Me.chkBaptized.TabIndex = 5
        Me.chkBaptized.Text = "Baptized"
        Me.chkBaptized.UseVisualStyleBackColor = True
        '
        'chkSalvation
        '
        Me.chkSalvation.AutoSize = True
        Me.chkSalvation.Location = New System.Drawing.Point(146, 234)
        Me.chkSalvation.Name = "chkSalvation"
        Me.chkSalvation.Size = New System.Drawing.Size(70, 17)
        Me.chkSalvation.TabIndex = 6
        Me.chkSalvation.Text = "Salvation"
        Me.chkSalvation.UseVisualStyleBackColor = True
        '
        'chkShareInformation
        '
        Me.chkShareInformation.AutoSize = True
        Me.chkShareInformation.Location = New System.Drawing.Point(146, 257)
        Me.chkShareInformation.Name = "chkShareInformation"
        Me.chkShareInformation.Size = New System.Drawing.Size(109, 17)
        Me.chkShareInformation.TabIndex = 7
        Me.chkShareInformation.Text = "Share Information"
        Me.chkShareInformation.UseVisualStyleBackColor = True
        '
        'txtFirstName
        '
        Me.txtFirstName.Location = New System.Drawing.Point(146, 3)
        Me.txtFirstName.Name = "txtFirstName"
        Me.txtFirstName.Size = New System.Drawing.Size(145, 20)
        Me.txtFirstName.TabIndex = 8
        '
        'txtLastName
        '
        Me.txtLastName.Location = New System.Drawing.Point(146, 29)
        Me.txtLastName.Name = "txtLastName"
        Me.txtLastName.Size = New System.Drawing.Size(145, 20)
        Me.txtLastName.TabIndex = 9
        '
        'cboSpouse
        '
        Me.cboSpouse.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboSpouse.Enabled = False
        Me.cboSpouse.FormattingEnabled = True
        Me.cboSpouse.Location = New System.Drawing.Point(146, 184)
        Me.cboSpouse.Name = "cboSpouse"
        Me.cboSpouse.Size = New System.Drawing.Size(121, 21)
        Me.cboSpouse.TabIndex = 10
        '
        'dtpDOB
        '
        Me.dtpDOB.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpDOB.Location = New System.Drawing.Point(146, 55)
        Me.dtpDOB.Name = "dtpDOB"
        Me.dtpDOB.Size = New System.Drawing.Size(145, 20)
        Me.dtpDOB.TabIndex = 13
        '
        'dtpAnniversaryDate
        '
        Me.dtpAnniversaryDate.Enabled = False
        Me.dtpAnniversaryDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpAnniversaryDate.Location = New System.Drawing.Point(146, 158)
        Me.dtpAnniversaryDate.Name = "dtpAnniversaryDate"
        Me.dtpAnniversaryDate.Size = New System.Drawing.Size(145, 20)
        Me.dtpAnniversaryDate.TabIndex = 14
        '
        'chkAttendedOrientation
        '
        Me.chkAttendedOrientation.AutoSize = True
        Me.chkAttendedOrientation.Location = New System.Drawing.Point(146, 349)
        Me.chkAttendedOrientation.Name = "chkAttendedOrientation"
        Me.chkAttendedOrientation.Size = New System.Drawing.Size(189, 17)
        Me.chkAttendedOrientation.TabIndex = 15
        Me.chkAttendedOrientation.Text = "Attended New Member Orientation"
        Me.chkAttendedOrientation.UseVisualStyleBackColor = True
        '
        'dtpOrientationDate
        '
        Me.dtpOrientationDate.Enabled = False
        Me.dtpOrientationDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpOrientationDate.Location = New System.Drawing.Point(146, 372)
        Me.dtpOrientationDate.Name = "dtpOrientationDate"
        Me.dtpOrientationDate.Size = New System.Drawing.Size(145, 20)
        Me.dtpOrientationDate.TabIndex = 16
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(1, 111)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(139, 13)
        Me.Label5.TabIndex = 17
        Me.Label5.Text = "Ministry Topics Interested In"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(97, 187)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(43, 13)
        Me.Label6.TabIndex = 18
        Me.Label6.Text = "Spouse"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(74, 378)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(66, 13)
        Me.Label7.TabIndex = 19
        Me.Label7.Text = "Course Date"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(114, 84)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(26, 13)
        Me.Label8.TabIndex = 20
        Me.Label8.Text = "Age"
        '
        'txtAge
        '
        Me.txtAge.Enabled = False
        Me.txtAge.Location = New System.Drawing.Point(146, 81)
        Me.txtAge.Name = "txtAge"
        Me.txtAge.Size = New System.Drawing.Size(145, 20)
        Me.txtAge.TabIndex = 21
        Me.txtAge.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btnSaveChanges
        '
        Me.btnSaveChanges.Location = New System.Drawing.Point(146, 527)
        Me.btnSaveChanges.Name = "btnSaveChanges"
        Me.btnSaveChanges.Size = New System.Drawing.Size(145, 23)
        Me.btnSaveChanges.TabIndex = 22
        Me.btnSaveChanges.Text = "Save Changes"
        Me.btnSaveChanges.UseVisualStyleBackColor = True
        '
        'txtMinistryTopics
        '
        Me.txtMinistryTopics.Location = New System.Drawing.Point(146, 108)
        Me.txtMinistryTopics.Name = "txtMinistryTopics"
        Me.txtMinistryTopics.Size = New System.Drawing.Size(145, 20)
        Me.txtMinistryTopics.TabIndex = 23
        '
        'chkPastorContact
        '
        Me.chkPastorContact.AutoSize = True
        Me.chkPastorContact.Location = New System.Drawing.Point(146, 280)
        Me.chkPastorContact.Name = "chkPastorContact"
        Me.chkPastorContact.Size = New System.Drawing.Size(125, 17)
        Me.chkPastorContact.TabIndex = 24
        Me.chkPastorContact.Text = "Have Pastor Contact"
        Me.chkPastorContact.UseVisualStyleBackColor = True
        '
        'txtNotes
        '
        Me.txtNotes.Location = New System.Drawing.Point(146, 398)
        Me.txtNotes.Multiline = True
        Me.txtNotes.Name = "txtNotes"
        Me.txtNotes.Size = New System.Drawing.Size(248, 123)
        Me.txtNotes.TabIndex = 25
        '
        'chkMemberArchived
        '
        Me.chkMemberArchived.AutoSize = True
        Me.chkMemberArchived.Location = New System.Drawing.Point(146, 326)
        Me.chkMemberArchived.Name = "chkMemberArchived"
        Me.chkMemberArchived.Size = New System.Drawing.Size(109, 17)
        Me.chkMemberArchived.TabIndex = 26
        Me.chkMemberArchived.Text = "Member Archived"
        Me.chkMemberArchived.UseVisualStyleBackColor = True
        '
        'chkMemberActive
        '
        Me.chkMemberActive.AutoSize = True
        Me.chkMemberActive.Location = New System.Drawing.Point(146, 303)
        Me.chkMemberActive.Name = "chkMemberActive"
        Me.chkMemberActive.Size = New System.Drawing.Size(97, 17)
        Me.chkMemberActive.TabIndex = 27
        Me.chkMemberActive.Text = "Member Active"
        Me.chkMemberActive.UseVisualStyleBackColor = True
        '
        'MemberControl
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.Controls.Add(Me.chkMemberActive)
        Me.Controls.Add(Me.chkMemberArchived)
        Me.Controls.Add(Me.txtNotes)
        Me.Controls.Add(Me.chkPastorContact)
        Me.Controls.Add(Me.txtMinistryTopics)
        Me.Controls.Add(Me.btnSaveChanges)
        Me.Controls.Add(Me.txtAge)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.dtpOrientationDate)
        Me.Controls.Add(Me.chkAttendedOrientation)
        Me.Controls.Add(Me.dtpAnniversaryDate)
        Me.Controls.Add(Me.dtpDOB)
        Me.Controls.Add(Me.cboSpouse)
        Me.Controls.Add(Me.txtLastName)
        Me.Controls.Add(Me.txtFirstName)
        Me.Controls.Add(Me.chkShareInformation)
        Me.Controls.Add(Me.chkSalvation)
        Me.Controls.Add(Me.chkBaptized)
        Me.Controls.Add(Me.chkMarried)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "MemberControl"
        Me.Size = New System.Drawing.Size(397, 555)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents chkMarried As System.Windows.Forms.CheckBox
    Friend WithEvents chkBaptized As System.Windows.Forms.CheckBox
    Friend WithEvents chkSalvation As System.Windows.Forms.CheckBox
    Friend WithEvents chkShareInformation As System.Windows.Forms.CheckBox
    Friend WithEvents txtFirstName As System.Windows.Forms.TextBox
    Friend WithEvents txtLastName As System.Windows.Forms.TextBox
    Friend WithEvents cboSpouse As System.Windows.Forms.ComboBox
    Friend WithEvents dtpDOB As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpAnniversaryDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents chkAttendedOrientation As System.Windows.Forms.CheckBox
    Friend WithEvents dtpOrientationDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtAge As System.Windows.Forms.TextBox
    Friend WithEvents btnSaveChanges As System.Windows.Forms.Button
    Friend WithEvents txtMinistryTopics As System.Windows.Forms.TextBox
    Friend WithEvents chkPastorContact As System.Windows.Forms.CheckBox
    Friend WithEvents txtNotes As System.Windows.Forms.TextBox
    Friend WithEvents chkMemberArchived As System.Windows.Forms.CheckBox
    Friend WithEvents chkMemberActive As System.Windows.Forms.CheckBox

End Class
