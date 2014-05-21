Public Class Form1
    Dim strAdditionalArguments As String
    Dim arrPCList As New ArrayList
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        colPCList.Width = 344
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
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

    End Sub
End Class