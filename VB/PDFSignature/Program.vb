Imports DevExpress.Pdf
Imports System.Security.Cryptography.X509Certificates

Namespace PDFSignature

    Friend Class Program

        Shared Sub Main(ByVal args As String())
            ' Create a PDF document processor.
            Using documentProcessor As DevExpress.Pdf.PdfDocumentProcessor = New DevExpress.Pdf.PdfDocumentProcessor()
                ' Load a PDF document. 
                documentProcessor.LoadDocument("..\..\Demo.pdf")
                ' Load a certificate from a file.
                Dim cert As System.Security.Cryptography.X509Certificates.X509Certificate2 = New System.Security.Cryptography.X509Certificates.X509Certificate2("..\..\SignDemo.pfx", "dxdemo")
                ' Create a PDF signature and specify signing location, contact info and reason.
                Dim signature As DevExpress.Pdf.PdfSignature = New DevExpress.Pdf.PdfSignature(cert) With {.Location = "Location", .ContactInfo = "ContactInfo", .Reason = "Reason"}
                ' Save the signed document.
                documentProcessor.SaveDocument("..\..\SignedDocument.pdf", New DevExpress.Pdf.PdfSaveOptions() With {.Signature = signature})
            End Using
        End Sub
    End Class
End Namespace
