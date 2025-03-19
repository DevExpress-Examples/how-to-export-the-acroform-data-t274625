<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128658606/24.2.1%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/T274735)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
[![](https://img.shields.io/badge/💬_Leave_Feedback-feecdd?style=flat-square)](#does-this-example-address-your-development-requirementsobjectives)
<!-- default badges end -->

# WPF PDF Viewer - Import/Export the AcroForm Data 

This example imports an XML/FDF file data to PDF document AcroForm (interactive forms) and exports form values to the XML or FDF format.

![image](https://github.com/user-attachments/assets/7ed5fbc5-6d26-4909-866e-b9e064bf7710)

## Import AcroForm Data
Call the [PdfViewerControl.ImportExportFormData](https://documentation.devexpress.com/#WPF/DevExpressXpfPdfViewerPdfViewerControl_ImportExportFormDatatopic) method after the document is loaded to import the AcroForm data either from the XML or FDF format.

## Export AcroForm Data
Call the [PdfViewerControl.ExportFormData](https://documentation.devexpress.com/#WPF/DevExpressXpfPdfViewerPdfViewerControl_ExportFormDatatopic) method in the [PdfViewerControl.DocumentLoaded](https://documentation.devexpress.com/#WPF/DevExpressXpfPdfViewerPdfViewerControl_DocumentLoadedtopic) event handler to export a document to the XML or FDF format. This method invokes the Save As dialog window, where you can specify a desired file format (XML or FDF) and the file name to export a document with interactive forms.

<!-- default file list -->
## Files to Look At

* [MainWindow.xaml](./CS/MainWindow.xaml) (VB: [MainWindow.xaml](./VB/MainWindow.xaml))
* [MainWindow.xaml.cs](./CS/MainWindow.xaml.cs) (VB: [MainWindow.xaml.vb](./VB/MainWindow.xaml.vb))
<!-- default file list end -->

## Documentation

- [PdfViewerControl.GetText(PdfDocumentArea)](https://docs.devexpress.com/WPF/DevExpress.Xpf.PdfViewer.PdfViewerControl.GetText(DevExpress.Pdf.PdfDocumentArea))

<!-- feedback -->
## Does this example address your development requirements/objectives?

[<img src="https://www.devexpress.com/support/examples/i/yes-button.svg"/>](https://www.devexpress.com/support/examples/survey.xml?utm_source=github&utm_campaign=how-to-export-the-acroform-data-t274625&~~~was_helpful=yes) [<img src="https://www.devexpress.com/support/examples/i/no-button.svg"/>](https://www.devexpress.com/support/examples/survey.xml?utm_source=github&utm_campaign=how-to-export-the-acroform-data-t274625&~~~was_helpful=no)

(you will be redirected to DevExpress.com to submit your response)
<!-- feedback end -->
