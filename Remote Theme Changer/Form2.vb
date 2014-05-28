Public Class Form2
    Dim Theme1 As New Theme
    Dim Theme2 As New Theme
    Dim Theme3 As New Theme
    Dim Theme4 As New Theme
    Dim Theme5 As New Theme
    Dim ThemeFallback As New Theme
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ToolTip1.InitialDelay = 150
        ToolTip1.ReshowDelay = 100
        ToolTip1.SetToolTip(Me.Label5, "What is this?")
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

    Private Sub comboBoxCheck1
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
            If Theme1.HorizRes = 0 Or Theme1.VertRes = 0 Then
                MessageBox.Show("Please enter a valid resolution in the first box.", "Invalid First Resolution")
            End If
        Catch
            MessageBox.Show("Please enter a valid value for the first resolution")
        End Try
    End Sub

    Private Sub comboBoxCheck2()
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
            If Theme2.HorizRes = 0 Or Theme2.VertRes = 0 Then
                MessageBox.Show("Please enter a valid resolution in the second box.", "Invalid Second Resolution")
            End If
        Catch
            MessageBox.Show("Please enter a valid value for the second resolution")
        End Try
    End Sub

    Private Sub comboBoxCheck3()
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
            If Theme3.HorizRes = 0 Or Theme3.VertRes = 0 Then
                MessageBox.Show("Please enter a valid resolution in the third box.", "Invalid Third Resolution")
            End If
        Catch
            MessageBox.Show("Please enter a valid value for the third resolution")
        End Try
    End Sub

    Private Sub comboBoxCheck4()
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
            If Theme4.HorizRes = 0 Or Theme4.VertRes = 0 Then
                MessageBox.Show("Please enter a valid resolution in the fourth box.", "Invalid Fourth Resolution")
            End If
        Catch
            MessageBox.Show("Please enter a valid value for the fourth resolution")
        End Try
    End Sub

    Private Sub comboBoxCheck5()
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
            If Theme5.HorizRes = 0 Or Theme5.VertRes = 0 Then
                MessageBox.Show("Please enter a valid resolution in the fifth box.", "Invalid Fifth Resolution")
            End If
        Catch
            MessageBox.Show("Please enter a valid value for the fifth resolution")
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
        ThemeFallback.Path = txtFilePath6.Text
    End Sub

    Private Sub chkManual_CheckedChanged(sender As Object, e As EventArgs) Handles chkManual.CheckedChanged
        If chkManual.Checked = True Then
            txtFilePath1.ReadOnly = False
            txtFilePath2.ReadOnly = False
            txtFilePath3.ReadOnly = False
            txtFilePath4.ReadOnly = False
            txtFilePath5.ReadOnly = False
            txtFilePath6.ReadOnly = False
        Else
            txtFilePath1.ReadOnly = True
            txtFilePath2.ReadOnly = True
            txtFilePath3.ReadOnly = True
            txtFilePath4.ReadOnly = True
            txtFilePath5.ReadOnly = True
            txtFilePath6.ReadOnly = True
        End If
    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click
        MessageBox.Show("This is the themepack that will be applied if the computer" & vbNewLine & "does not fit any of the other resolutions." & vbNewLine & vbNewLine & "(1280x1024 is recommended)", "What was that?")
    End Sub

    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        comboBoxCheck1()
        comboBoxCheck2()
        comboBoxCheck3()
        comboBoxCheck4()
        comboBoxCheck5()

    End Sub
End Class