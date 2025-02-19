Imports DevExpress.Pdf
Imports System
Imports System.Diagnostics
Imports System.IO
Imports System.Security.Cryptography.X509Certificates

Namespace PDFSignature

    Friend Class Program

        Shared Sub Main(ByVal args As String())
            Using documentProcessor As DevExpress.Pdf.PdfDocumentProcessor = New DevExpress.Pdf.PdfDocumentProcessor()
                documentProcessor.LoadDocument("..\..\..\Document.pdf")
                Dim certificate As X509Certificate2 = New X509Certificate2("..\..\..\SignDemo.pfx", "dxdemo")
                Dim imageData As Byte() = File.ReadAllBytes("..\..\..\image.emf")
                Dim pageNumber As Integer = 1
                Dim angleInDegrees As Integer = 45
                Dim angleInRadians As Double = angleInDegrees * (Math.PI / 180)
                Dim signatureBounds As DevExpress.Pdf.PdfOrientedRectangle = New DevExpress.Pdf.PdfOrientedRectangle(New DevExpress.Pdf.PdfPoint(620, 210), 250, 90, angleInRadians)
                Dim signature As DevExpress.Pdf.PdfSignature = New DevExpress.Pdf.PdfSignature(certificate, imageData, pageNumber, signatureBounds)
                signature.Location = "USA"
                signature.ContactInfo = "john.smith@example.com"
                signature.Reason = "Approved"
                documentProcessor.SaveDocument("..\..\..\SignedDocument.pdf", New DevExpress.Pdf.PdfSaveOptions() With {.Signature = signature})
            End Using

            Process.Start(New ProcessStartInfo("..\..\..\SignedDocument.pdf") With {.UseShellExecute = True})
        End Sub
    End Class
End Namespace
