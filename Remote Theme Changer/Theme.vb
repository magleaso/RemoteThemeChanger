Imports Microsoft.VisualBasic

Public Class Theme
    Private pvHorizRes
    Public Property HorizRes As Integer
        Get
            Return pvHorizRes
        End Get
        Set(value As Integer)
            pvHorizRes = value
        End Set
    End Property

    Private pvVertRes
    Public Property VertRes As Integer
        Get
            Return pvVertRes
        End Get
        Set(value As Integer)
            pvVertRes = value
        End Set
    End Property

    Private pvPath
    Public Property Path As String
        Get
            Return pvPath
        End Get
        Set(value As String)
            pvPath = value
        End Set
    End Property

End Class
