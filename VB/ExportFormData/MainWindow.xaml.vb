Imports System.Windows

Namespace ExportFormData

    Public Partial Class MainWindow
        Inherits Window

        Public Sub New()
            Me.InitializeComponent()
            Me.Viewer.OpenDocument("..\..\FormFillDemo.pdf")
        End Sub

        Private Sub Viewer_DocumentLoaded(ByVal sender As Object, ByVal e As RoutedEventArgs)
            Me.Viewer.ExportFormData()
        End Sub
    End Class
End Namespace
