Imports Microsoft.VisualBasic

Public Class Theme
    Private _horizRes
    Public Property HorizRes As Integer
        Get
            Return _horizRes
        End Get
        Set(value As Integer)
            _horizRes = HorizRes
        End Set
    End Property

    Private _vertRes
    Public Property VertRes As Integer
        Get
            Return _vertRes
        End Get
        Set(value As Integer)
            _vertRes = VertRes
        End Set
    End Property

    Private _path
    Public Property Path As String
        Get
            Return _path
        End Get
        Set(value As String)
            _path = Path
        End Set
    End Property

End Class
