Imports DevExpress.Pdf
Imports System.Security.Cryptography.X509Certificates
Imports System.IO


Namespace Signatures
    Class Program
        Public Shared Sub Main(ByVal args() As String)

            Using documentProcessor As PdfDocumentProcessor = New PdfDocumentProcessor()
                documentProcessor.LoadDocument("..\..\Document.pdf")
                Dim certificate As X509Certificate2 = New X509Certificate2("..\..\SignDemo.pfx", "dxdemo")
                Dim imageData As Byte() = File.ReadAllBytes("..\..\image.emf")
                Dim pageNumber As Integer = 1
                Dim angleInDegrees As Integer = 45
                Dim angleInRadians As Double = angleInDegrees * (Math.PI / 180)
                Dim signatureBounds As PdfOrientedRectangle = New PdfOrientedRectangle(New PdfPoint(620, 210), 250, 90, angleInRadians)
                Dim signature As DevExpress.Pdf.PdfSignature = New PdfSignature(certificate, imageData, pageNumber, signatureBounds)
                signature.Location = "USA"
                signature.ContactInfo = "john.smith@example.com"
                signature.Reason = "Approved"
                documentProcessor.SaveDocument("..\..\SignedDocument.pdf", New PdfSaveOptions() With {
                    .Signature = signature
                })
            End Using
        End Sub
    End Class
End Namespace
