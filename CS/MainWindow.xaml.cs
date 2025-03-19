using DevExpress.Pdf;
using DevExpress.Xpf.PdfViewer;
using System.Windows;

namespace ImportExportFormData {

    public partial class MainWindow : DevExpress.Xpf.Core.ThemedWindow
    {
        public MainWindow() {
            InitializeComponent();
            Viewer.OpenDocument("FormFillDemo.pdf");
        }

        private void Viewer_DocumentLoaded(object sender, RoutedEventArgs e) {
            //Viewer.ImportFormData();
            Viewer.Import("FormFillDemo.fdf");
            Viewer.SaveDocument("ImportedDocument.pdf");
        }

        private void Viewer_DocumentClosing(DependencyObject d, DocumentClosingEventArgs e) {
            e.SaveDialogResult = MessageBoxResult.Cancel;
            e.Handled = true;
        }
    }
}
