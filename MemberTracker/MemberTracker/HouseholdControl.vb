Public Class HouseholdControl

    Public Event UpdateCurrentNodeTag(member As Member, household As Member_Household)
    Public Event DeleteHousehold(household As Member_Household)
    Private _currentHousehold As Member_Household

    Public Sub PassHouseholdToControl(currentHousehold As Member_Household)
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
        ofd.Filter = "Picture Files|*.png;*.jpg;*.bmp;*.gif;*.jpeg"
        If ofd.ShowDialog = DialogResult.OK Then
            txtPictureLocation.Text = ofd.FileName
        End If
    End Sub

    Private Sub txtPictureLocation_TextChanged(sender As Object, e As EventArgs) Handles txtPictureLocation.TextChanged
        Try
            pbHouseholdPhoto.ImageLocation = txtPictureLocation.Text
            pbHouseholdPhoto.Image = Drawing.Image.FromFile(txtPictureLocation.Text)
        Catch
            pbHouseholdPhoto.Image = pbHouseholdPhoto.ErrorImage
        End Try
    End Sub

    Private Sub btnSaveChanges_Click(sender As Object, e As EventArgs) Handles btnSaveChanges.Click
        _currentHousehold = GetHouseholdFromControl()
        RaiseEvent UpdateCurrentNodeTag(Nothing, _currentHousehold)
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        If MessageBox.Show("Household and associated members will be permanently deleted. Press OK to proceed or Cancel to quit.", "Are you sure?", MessageBoxButtons.OKCancel) = DialogResult.OK Then
            RaiseEvent DeleteHousehold(GetHouseholdFromControl())
        End If
    End Sub

    Private Sub txtEmailAddress_TextChanged(sender As Object, e As EventArgs) Handles txtEmailAddress.TextChanged
        If txtEmailAddress.Text.Contains(" ") Then
            RemoveHandler txtEmailAddress.TextChanged, AddressOf txtEmailAddress_TextChanged
            txtEmailAddress.Text = String.Join("", txtEmailAddress.Text.Split(" "))
            AddHandler txtEmailAddress.TextChanged, AddressOf txtEmailAddress_TextChanged
            txtEmailAddress.Select(txtEmailAddress.TextLength, 0)
        End If
    End Sub
End Class
