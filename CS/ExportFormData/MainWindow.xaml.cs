using System.Windows;

namespace ExportFormData {
    
    public partial class MainWindow : Window {
        public MainWindow() {
            InitializeComponent();
            Viewer.OpenDocument("..\\..\\FormFillDemo.pdf");
        }

        private void Viewer_DocumentLoaded(object sender, RoutedEventArgs e) {
            Viewer.ExportFormData();
        }
    }
}