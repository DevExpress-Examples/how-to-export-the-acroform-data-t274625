Imports System.Windows

Namespace ExportFormData

    Partial Public Class MainWindow
        Inherits Window

        Public Sub New()
            InitializeComponent()
            Viewer.OpenDocument("..\..\FormFillDemo.pdf")
        End Sub

        Private Sub Viewer_DocumentLoaded(ByVal sender As Object, ByVal e As RoutedEventArgs)
            Viewer.ExportFormData()
        End Sub
    End Class
End Namespace