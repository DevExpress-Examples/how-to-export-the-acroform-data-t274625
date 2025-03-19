Imports DevExpress.Xpf.PdfViewer
Imports DevExpress.Pdf
Imports System.Windows

Namespace ImportExportFormData

    Partial Public Class MainWindow
        Inherits Window

        Public Sub New()
            InitializeComponent()
            Viewer.OpenDocument("FormFillDemo.pdf")
        End Sub

        Private Sub Viewer_DocumentLoaded(ByVal sender As Object, ByVal e As RoutedEventArgs)
            'Viewer.ImportExportFormData()
            Viewer.Import("DataForm.fdf")
            Viewer.SaveDocument("ImportedDocument.pdf")
        End Sub

        Private Sub Viewer_DocumentClosing(ByVal d As DependencyObject, ByVal e As DocumentClosingEventArgs)
            e.SaveDialogResult = MessageBoxResult.Cancel
            e.Handled = True
        End Sub
    End Class
End Namespace
