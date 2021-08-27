<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128658584/16.2.3%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/T274625)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->
<!-- default file list -->
*Files to look at*:

* [MainWindow.xaml](./CS/ExportFormData/MainWindow.xaml) (VB: [MainWindow.xaml](./VB/ExportFormData/MainWindow.xaml))
* [MainWindow.xaml.cs](./CS/ExportFormData/MainWindow.xaml.cs) (VB: [MainWindow.xaml.vb](./VB/ExportFormData/MainWindow.xaml.vb))
<!-- default file list end -->
# How to export the AcroForm data 


<p>This example shows how a PDF document with the AcroForm data (interactive forms) can be exported either to the XML or FDF format.<br /><br /></p>


<h3>Description</h3>

To export a document to the XML or FDF format, call the <a href="https://documentation.devexpress.com/#WPF/DevExpressXpfPdfViewerPdfViewerControl_ExportFormDatatopic">PdfViewerControl.ExportFormData </a>method in the <a href="https://documentation.devexpress.com/#WPF/DevExpressXpfPdfViewerPdfViewerControl_DocumentLoadedtopic">PdfViewerControl.DocumentLoaded </a>event handler. <br><br>This method invokes the Save As dialog window, where you can specify a desired file format (XML or FDF) and the file name to export a document with interactive forms.

<br/>


