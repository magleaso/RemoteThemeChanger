Public Class Form1
    Dim strLaunchArgs As String
    Dim strAdditionalArguments As String
    Dim arrPCList As New ArrayList
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        colPCList.Width = 344
    End Sub

    Public Sub CmdAndWait(ByVal ProcessArgs As String)
        Dim objProcess As System.Diagnostics.Process
        Try
            objProcess = New System.Diagnostics.Process()
            objProcess.StartInfo.FileName = "cmd.exe"
            objProcess.StartInfo.UseShellExecute = True
            objProcess.StartInfo.Arguments = ProcessArgs
            objProcess.StartInfo.WindowStyle = ProcessWindowStyle.Normal
            objProcess.Start()

            'Wait until the process passes back an exit code
            'objProcess.WaitForExit()

            'Free resources associated with this process
            objProcess.Close()
        Catch
            MessageBox.Show("Could not start process cmd.exe with args " & Chr(34) & ProcessArgs & Chr(34), "Error")
        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnStart.Click
        For Each row As DataGridViewRow In gridPCList.Rows
            arrPCList.Add(row.Cells(0).Value)
        Next

        For i As Integer = 0 To arrPCList.Count - 1
            strAdditionalArguments += arrPCList(i) & " "
        Next

        '   Dear Shell,
        '       Please run that script that changes themes remotely with the provided arguments. You will find enclosed
        '   a strAdditionalArguments that can be quite helpful. Thanks, bro.

        '   Regards,

        '   Matt Gleason

        strLaunchArgs = "/c " & Chr(34) & "C:\Program Files\ThemeChanger\RemoteRegedit.vbs" & Chr(34) & " " & strAdditionalArguments
        CmdAndWait(strLaunchArgs)
    End Sub

    Private Sub lblHelp_Click(sender As Object, e As EventArgs) Handles lblHelp.Click
        MessageBox.Show("Enter the PC's you would like to change" & vbNewLine & "the theme for in the box on the left, then" & vbNewLine & "select 'Next'.", "Help Menu")
    End Sub
End Class