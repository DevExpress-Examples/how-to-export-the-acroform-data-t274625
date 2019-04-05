<!-- default file list -->
*Files to look at*:

* [MainWindow.xaml](./CS/ExportFormData/MainWindow.xaml) (VB: [MainWindow.xaml](./VB/ExportFormData/MainWindow.xaml))
* [MainWindow.xaml.cs](./CS/ExportFormData/MainWindow.xaml.cs) (VB: [MainWindow.xaml.vb](./VB/ExportFormData/MainWindow.xaml.vb))
<!-- default file list end -->
# How to export the AcroForm data 


<p>This example shows how a PDF document with the AcroForm data (interactive forms) can be exported either to the XML or FDF format.<br /><br /></p>


<h3>Description</h3>

<p>To export a document to the XML or FDF format, call the&nbsp;<a href="https://documentation.devexpress.com/#WPF/DevExpressXpfPdfViewerPdfViewerControl_ExportFormDatatopic">PdfViewerControl.ExportFormData</a> method in the <a href="https://documentation.devexpress.com/#WPF/DevExpressXpfPdfViewerPdfViewerControl_DocumentLoadedtopic">PdfViewerControl.DocumentLoaded</a>&nbsp;event handler. <br /><br />This method invokes the<strong> Save As</strong> dialog window, where you can specify a desired file format (XML or FDF) and the file name to export a document with interactive forms.</p>

<br/>


