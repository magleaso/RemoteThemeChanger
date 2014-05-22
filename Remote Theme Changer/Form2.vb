Public Class Form2
    Dim Theme1 As New Theme
    Dim Theme2 As New Theme
    Dim Theme3 As New Theme
    Dim Theme4 As New Theme
    Dim Theme5 As New Theme
    Dim Theme6 As New Theme
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnBrowse1_Click(sender As Object, e As EventArgs) Handles btnBrowse1.Click
        fileDialog1.ShowDialog()
        txtFilePath1.Text = fileDialog1.FileName
    End Sub

    Private Sub btnBrowse2_Click(sender As Object, e As EventArgs) Handles btnBrowse2.Click
        fileDialog2.ShowDialog()
        txtFilePath2.Text = fileDialog2.FileName
    End Sub

    Private Sub btnBrowse3_Click(sender As Object, e As EventArgs) Handles btnBrowse3.Click
        fileDialog3.ShowDialog()
        txtFilePath3.Text = fileDialog3.FileName
    End Sub

    Private Sub btnBrowse4_Click(sender As Object, e As EventArgs) Handles btnBrowse4.Click
        fileDialog4.ShowDialog()
        txtFilePath4.Text = fileDialog4.FileName
    End Sub

    Private Sub btnBrowse5_Click(sender As Object, e As EventArgs) Handles btnBrowse5.Click
        fileDialog5.ShowDialog()
        txtFilePath5.Text = fileDialog5.FileName
    End Sub

    Private Sub btnBrowse6_Click(sender As Object, e As EventArgs) Handles btnBrowse6.Click
        fileDialog6.ShowDialog()
        txtFilePath6.Text = fileDialog6.FileName
    End Sub

    Private Sub cmbResolution1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbResolution1.SelectedIndexChanged
        Dim strHorizRes As String
        Dim strVertRes As String
            For counter As Integer = 0 To (cmbResolution1.Text.Length - 1)
                If cmbResolution1.Text.Chars(counter) = "x" Then
                strHorizRes = cmbResolution1.Text.Remove(counter, cmbResolution1.Text.Length - 1)
                strVertRes = cmbResolution1.Text.Remove(0, counter)
                    Exit For
                End If
        Next
        Try
            Theme1.HorizRes = Integer.Parse(strHorizRes)
            Theme1.VertRes = Integer.Parse(strVertRes)
        Catch
            MessageBox.Show("Please enter a value for the resolution")
        End Try
    End Sub
End Class