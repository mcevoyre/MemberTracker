Public Class HouseholdControl

    Public Event UpdateCurrentNodeTag(member As Member, household As Member_Household)
    Private _currentHousehold As Member_Household

    Public Sub PassHouseholdToControl(currentHousehold As Member_Household)
        dtpJoinedChurch.Value = currentHousehold.JoinedChurch
        txtAddress.Text = currentHousehold.Address
        txtCity.Text = currentHousehold.City
        txtState.Text = currentHousehold.State
        txtZipCode.Text = currentHousehold.ZipCode
        txtHomePhone.Text = currentHousehold.HomePhone
        txtCellPhone.Text = currentHousehold.CellPhone
        txtEmailAddress.Text = currentHousehold.EmailAddress
        txtPictureLocation.Text = currentHousehold.PicturePath
        txtHouseID.Text = currentHousehold.ID
        _currentHousehold = currentHousehold
    End Sub

    Public Function GetHouseholdFromControl() As Member_Household
        Dim tempHousehold As New Member_Household
        tempHousehold.JoinedChurch = dtpJoinedChurch.Value
        tempHousehold.Address = txtAddress.Text
        tempHousehold.City = txtCity.Text
        tempHousehold.State = txtState.Text
        tempHousehold.ZipCode = txtZipCode.Text
        tempHousehold.HomePhone = txtHomePhone.Text
        tempHousehold.CellPhone = txtCellPhone.Text
        tempHousehold.EmailAddress = txtEmailAddress.Text
        tempHousehold.PicturePath = txtPictureLocation.Text
        tempHousehold.ID = txtHouseID.Text
        Return tempHousehold
    End Function

    Private Sub btnFileSelection_Click(sender As Object, e As EventArgs) Handles btnFileSelection.Click
        Dim ofd As New OpenFileDialog
        If ofd.ShowDialog = DialogResult.OK Then
            txtPictureLocation.Text = ofd.FileName
        End If
    End Sub

    Private Sub txtPictureLocation_TextChanged(sender As Object, e As EventArgs) Handles txtPictureLocation.TextChanged
        pbHouseholdPhoto.ImageLocation = txtPictureLocation.Text
        pbHouseholdPhoto.Image = Drawing.Image.FromFile(txtPictureLocation.Text)
    End Sub

    Private Sub btnSaveChanges_Click(sender As Object, e As EventArgs) Handles btnSaveChanges.Click
        _currentHousehold = GetHouseholdFromControl()
        RaiseEvent UpdateCurrentNodeTag(Nothing, _currentHousehold)
    End Sub
End Class
