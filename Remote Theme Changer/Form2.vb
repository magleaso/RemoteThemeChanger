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
            If cmbResolution1.Text.Chars(counter) = "x" Or cmbResolution1.Text.Chars(counter) = "X" Then
                strHorizRes = cmbResolution1.Text.Remove(counter, cmbResolution1.Text.Length - counter)
                strVertRes = cmbResolution1.Text.Remove(0, counter + 1)
                Exit For
            End If
        Next
        Try
            Theme1.HorizRes = Convert.ToInt32(strHorizRes)
            Theme1.VertRes = Convert.ToInt32(strVertRes)
            Debug.Print(Theme1.HorizRes)
            Debug.Print(Theme1.VertRes)
        Catch
            MessageBox.Show("Please enter a valid value for the resolution")
        End Try
    End Sub

    Private Sub cmbResolution2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbResolution2.SelectedIndexChanged
        Dim strHorizRes As String
        Dim strVertRes As String
        For counter As Integer = 0 To (cmbResolution2.Text.Length - 1)
            If cmbResolution2.Text.Chars(counter) = "x" Or cmbResolution2.Text.Chars(counter) = "X" Then
                strHorizRes = cmbResolution2.Text.Remove(counter, cmbResolution2.Text.Length - counter)
                strVertRes = cmbResolution2.Text.Remove(0, counter + 1)
                Exit For
            End If
        Next
        Try
            Theme2.HorizRes = Convert.ToInt32(strHorizRes)
            Theme2.VertRes = Convert.ToInt32(strVertRes)
        Catch
            MessageBox.Show("Please enter a valid value for the resolution")
        End Try
    End Sub

    Private Sub cmbResolution3_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbResolution3.SelectedIndexChanged
        Dim strHorizRes As String
        Dim strVertRes As String
        For counter As Integer = 0 To (cmbResolution3.Text.Length - 1)
            If cmbResolution3.Text.Chars(counter) = "x" Or cmbResolution3.Text.Chars(counter) = "X" Then
                strHorizRes = cmbResolution3.Text.Remove(counter, cmbResolution3.Text.Length - counter)
                strVertRes = cmbResolution3.Text.Remove(0, counter + 1)
                Exit For
            End If
        Next
        Try
            Theme3.HorizRes = Convert.ToInt32(strHorizRes)
            Theme3.VertRes = Convert.ToInt32(strVertRes)
        Catch
            MessageBox.Show("Please enter a valid value for the resolution")
        End Try
    End Sub

    Private Sub cmbResolution4_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbResolution4.SelectedIndexChanged
        Dim strHorizRes As String
        Dim strVertRes As String
        For counter As Integer = 0 To (cmbResolution4.Text.Length - 1)
            If cmbResolution4.Text.Chars(counter) = "x" Or cmbResolution4.Text.Chars(counter) = "X" Then
                strHorizRes = cmbResolution4.Text.Remove(counter, cmbResolution4.Text.Length - counter)
                strVertRes = cmbResolution4.Text.Remove(0, counter + 1)
                Exit For
            End If
        Next
        Try
            Theme4.HorizRes = Convert.ToInt32(strHorizRes)
            Theme4.VertRes = Convert.ToInt32(strVertRes)
        Catch
            MessageBox.Show("Please enter a valid value for the resolution")
        End Try
    End Sub

    Private Sub cmbResolution5_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbResolution5.SelectedIndexChanged
        Dim strHorizRes As String
        Dim strVertRes As String
        For counter As Integer = 0 To (cmbResolution5.Text.Length - 1)
            If cmbResolution5.Text.Chars(counter) = "x" Or cmbResolution5.Text.Chars(counter) = "X" Then
                strHorizRes = cmbResolution5.Text.Remove(counter, cmbResolution5.Text.Length - counter)
                strVertRes = cmbResolution5.Text.Remove(0, counter + 1)
                Exit For
            End If
        Next
        Try
            Theme5.HorizRes = Convert.ToInt32(strHorizRes)
            Theme5.VertRes = Convert.ToInt32(strVertRes)
        Catch
            MessageBox.Show("Please enter a valid value for the resolution")
        End Try
    End Sub

    Private Sub cmbResolution6_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbResolution6.SelectedIndexChanged
        Dim strHorizRes As String
        Dim strVertRes As String
        For counter As Integer = 0 To (cmbResolution6.Text.Length - 1)
            If cmbResolution6.Text.Chars(counter) = "x" Or cmbResolution6.Text.Chars(counter) = "X" Then
                strHorizRes = cmbResolution6.Text.Remove(counter, cmbResolution6.Text.Length - counter)
                strVertRes = cmbResolution6.Text.Remove(0, counter + 1)
                Exit For
            End If
        Next
        Try
            Theme6.HorizRes = Convert.ToInt32(strHorizRes)
            Theme6.VertRes = Convert.ToInt32(strVertRes)
        Catch
            MessageBox.Show("Please enter a valid value for the resolution")
        End Try
    End Sub

    Private Sub txtFilePath1_TextChanged(sender As Object, e As EventArgs) Handles txtFilePath1.TextChanged
        Theme1.Path = txtFilePath1.Text
    End Sub

    Private Sub txtFilePath2_TextChanged(sender As Object, e As EventArgs) Handles txtFilePath2.TextChanged
        Theme2.Path = txtFilePath2.Text
    End Sub

    Private Sub txtFilePath3_TextChanged(sender As Object, e As EventArgs) Handles txtFilePath3.TextChanged
        Theme3.Path = txtFilePath3.Text
    End Sub

    Private Sub txtFilePath4_TextChanged(sender As Object, e As EventArgs) Handles txtFilePath4.TextChanged
        Theme4.Path = txtFilePath4.Text
    End Sub

    Private Sub txtFilePath5_TextChanged(sender As Object, e As EventArgs) Handles txtFilePath5.TextChanged
        Theme5.Path = txtFilePath5.Text
    End Sub

    Private Sub txtFilePath6_TextChanged(sender As Object, e As EventArgs) Handles txtFilePath6.TextChanged
        Theme6.Path = txtFilePath6.Text
    End Sub
End Class