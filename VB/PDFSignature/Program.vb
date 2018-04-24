Imports DevExpress.Pdf
Imports System.Security.Cryptography.X509Certificates

Namespace PDFSignature
    Friend Class Program
        Shared Sub Main(ByVal args() As String)

            ' Create a PDF document processor.
            Using documentProcessor As New PdfDocumentProcessor()

                ' Load a PDF document. 
                documentProcessor.LoadDocument("..\..\Demo.pdf")

                ' Load a certificate from a file.
                Dim cert As New X509Certificate2("..\..\SignDemo.pfx", "dxdemo")

                ' Create a PDF signature and specify signing location, contact info and reason.
                Dim signature As New PdfSignature(cert) With { _
                    .Location = "Location", _
                    .ContactInfo = "ContactInfo", _
                    .Reason = "Reason" _
                }

                ' Save the signed document.
                documentProcessor.SaveDocument("..\..\SignedDocument.pdf", New PdfSaveOptions() With {.Signature = signature})
            End Using
        End Sub
    End Class
End Namespace
