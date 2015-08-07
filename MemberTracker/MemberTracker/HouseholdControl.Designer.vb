<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class HouseholdControl
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
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtAddress = New System.Windows.Forms.TextBox()
        Me.txtCity = New System.Windows.Forms.TextBox()
        Me.txtState = New System.Windows.Forms.TextBox()
        Me.txtZipCode = New System.Windows.Forms.TextBox()
        Me.txtHomePhone = New System.Windows.Forms.TextBox()
        Me.txtPictureLocation = New System.Windows.Forms.TextBox()
        Me.txtCellPhone = New System.Windows.Forms.TextBox()
        Me.txtEmailAddress = New System.Windows.Forms.TextBox()
        Me.btnFileSelection = New System.Windows.Forms.Button()
        Me.pbHouseholdPhoto = New System.Windows.Forms.PictureBox()
        Me.btnSaveChanges = New System.Windows.Forms.Button()
        Me.txtHouseID = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.btnDelete = New System.Windows.Forms.Button()
        CType(Me.pbHouseholdPhoto, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(67, 52)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(45, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Address"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(88, 89)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(24, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "City"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(80, 115)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(32, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "State"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(62, 141)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(50, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Zip Code"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(43, 167)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(69, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Home Phone"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(54, 193)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(58, 13)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Cell Phone"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(80, 219)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(32, 13)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "Email"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(28, 245)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(84, 13)
        Me.Label8.TabIndex = 7
        Me.Label8.Text = "Picture Location"
        '
        'txtAddress
        '
        Me.txtAddress.Location = New System.Drawing.Point(118, 35)
        Me.txtAddress.Multiline = True
        Me.txtAddress.Name = "txtAddress"
        Me.txtAddress.Size = New System.Drawing.Size(173, 45)
        Me.txtAddress.TabIndex = 9
        '
        'txtCity
        '
        Me.txtCity.Location = New System.Drawing.Point(118, 86)
        Me.txtCity.Name = "txtCity"
        Me.txtCity.Size = New System.Drawing.Size(173, 20)
        Me.txtCity.TabIndex = 10
        '
        'txtState
        '
        Me.txtState.Location = New System.Drawing.Point(118, 112)
        Me.txtState.Name = "txtState"
        Me.txtState.Size = New System.Drawing.Size(173, 20)
        Me.txtState.TabIndex = 11
        '
        'txtZipCode
        '
        Me.txtZipCode.Location = New System.Drawing.Point(118, 138)
        Me.txtZipCode.Name = "txtZipCode"
        Me.txtZipCode.Size = New System.Drawing.Size(173, 20)
        Me.txtZipCode.TabIndex = 12
        '
        'txtHomePhone
        '
        Me.txtHomePhone.Location = New System.Drawing.Point(118, 164)
        Me.txtHomePhone.Name = "txtHomePhone"
        Me.txtHomePhone.Size = New System.Drawing.Size(173, 20)
        Me.txtHomePhone.TabIndex = 13
        '
        'txtPictureLocation
        '
        Me.txtPictureLocation.Location = New System.Drawing.Point(118, 242)
        Me.txtPictureLocation.Multiline = True
        Me.txtPictureLocation.Name = "txtPictureLocation"
        Me.txtPictureLocation.Size = New System.Drawing.Size(173, 45)
        Me.txtPictureLocation.TabIndex = 15
        '
        'txtCellPhone
        '
        Me.txtCellPhone.Location = New System.Drawing.Point(118, 190)
        Me.txtCellPhone.Name = "txtCellPhone"
        Me.txtCellPhone.Size = New System.Drawing.Size(173, 20)
        Me.txtCellPhone.TabIndex = 16
        '
        'txtEmailAddress
        '
        Me.txtEmailAddress.Location = New System.Drawing.Point(118, 216)
        Me.txtEmailAddress.Name = "txtEmailAddress"
        Me.txtEmailAddress.Size = New System.Drawing.Size(173, 20)
        Me.txtEmailAddress.TabIndex = 18
        '
        'btnFileSelection
        '
        Me.btnFileSelection.Location = New System.Drawing.Point(297, 239)
        Me.btnFileSelection.Name = "btnFileSelection"
        Me.btnFileSelection.Size = New System.Drawing.Size(23, 23)
        Me.btnFileSelection.TabIndex = 19
        Me.btnFileSelection.Text = "..."
        Me.btnFileSelection.UseVisualStyleBackColor = True
        '
        'pbHouseholdPhoto
        '
        Me.pbHouseholdPhoto.Location = New System.Drawing.Point(326, 14)
        Me.pbHouseholdPhoto.Name = "pbHouseholdPhoto"
        Me.pbHouseholdPhoto.Size = New System.Drawing.Size(380, 329)
        Me.pbHouseholdPhoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.pbHouseholdPhoto.TabIndex = 20
        Me.pbHouseholdPhoto.TabStop = False
        '
        'btnSaveChanges
        '
        Me.btnSaveChanges.Location = New System.Drawing.Point(118, 293)
        Me.btnSaveChanges.Name = "btnSaveChanges"
        Me.btnSaveChanges.Size = New System.Drawing.Size(81, 34)
        Me.btnSaveChanges.TabIndex = 23
        Me.btnSaveChanges.Text = "Save Household"
        Me.btnSaveChanges.UseVisualStyleBackColor = True
        '
        'txtHouseID
        '
        Me.txtHouseID.Location = New System.Drawing.Point(118, 11)
        Me.txtHouseID.Name = "txtHouseID"
        Me.txtHouseID.Size = New System.Drawing.Size(173, 20)
        Me.txtHouseID.TabIndex = 25
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(23, 14)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(89, 13)
        Me.Label10.TabIndex = 24
        Me.Label10.Text = "Household Name"
        '
        'btnDelete
        '
        Me.btnDelete.Location = New System.Drawing.Point(206, 293)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(85, 34)
        Me.btnDelete.TabIndex = 26
        Me.btnDelete.Text = "Delete Household"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'HouseholdControl
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.txtHouseID)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.btnSaveChanges)
        Me.Controls.Add(Me.pbHouseholdPhoto)
        Me.Controls.Add(Me.btnFileSelection)
        Me.Controls.Add(Me.txtEmailAddress)
        Me.Controls.Add(Me.txtCellPhone)
        Me.Controls.Add(Me.txtPictureLocation)
        Me.Controls.Add(Me.txtHomePhone)
        Me.Controls.Add(Me.txtZipCode)
        Me.Controls.Add(Me.txtState)
        Me.Controls.Add(Me.txtCity)
        Me.Controls.Add(Me.txtAddress)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "HouseholdControl"
        Me.Size = New System.Drawing.Size(709, 359)
        CType(Me.pbHouseholdPhoto, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtAddress As System.Windows.Forms.TextBox
    Friend WithEvents txtCity As System.Windows.Forms.TextBox
    Friend WithEvents txtState As System.Windows.Forms.TextBox
    Friend WithEvents txtZipCode As System.Windows.Forms.TextBox
    Friend WithEvents txtHomePhone As System.Windows.Forms.TextBox
    Friend WithEvents txtPictureLocation As System.Windows.Forms.TextBox
    Friend WithEvents txtCellPhone As System.Windows.Forms.TextBox
    Friend WithEvents txtEmailAddress As System.Windows.Forms.TextBox
    Friend WithEvents btnFileSelection As System.Windows.Forms.Button
    Friend WithEvents pbHouseholdPhoto As System.Windows.Forms.PictureBox
    Friend WithEvents btnSaveChanges As System.Windows.Forms.Button
    Friend WithEvents txtHouseID As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents btnDelete As System.Windows.Forms.Button

End Class
