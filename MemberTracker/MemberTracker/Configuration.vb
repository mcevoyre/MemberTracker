Public Class Configuration

    Public Property FilePath As String
        Get
            Return txtFilePath.Text
        End Get
        Set(value As String)
            txtFilePath.Text = value
        End Set
    End Property

    Public ReadOnly Property SheetName As String
        Get
            Return txtSheetName.Text
        End Get
    End Property


    Private Sub btnFileSelect_Click(sender As Object, e As EventArgs) Handles btnFileSelect.Click
        Dim ofd As New OpenFileDialog
        If ofd.ShowDialog() = DialogResult.OK Then
            FilePath = ofd.FileName
        End If
    End Sub

End Class
