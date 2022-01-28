Imports System
Imports System.IO
Imports System.Security.Cryptography.X509Certificates
Imports DevExpress.Pdf

Namespace PDFSignature

    Friend Class Program

        Shared Sub Main(ByVal args As String())
            Using documentProcessor As DevExpress.Pdf.PdfDocumentProcessor = New DevExpress.Pdf.PdfDocumentProcessor()
                documentProcessor.LoadDocument("..\..\Document.pdf")
                Dim certificate As System.Security.Cryptography.X509Certificates.X509Certificate2 = New System.Security.Cryptography.X509Certificates.X509Certificate2("..\..\SignDemo.pfx", "dxdemo")
                Dim imageData As Byte() = System.IO.File.ReadAllBytes("..\..\image.emf")
                Dim pageNumber As Integer = 1
                Dim angleInDegrees As Integer = 45
                Dim angleInRadians As Double = angleInDegrees * (System.Math.PI / 180)
                Dim signatureBounds As DevExpress.Pdf.PdfOrientedRectangle = New DevExpress.Pdf.PdfOrientedRectangle(New DevExpress.Pdf.PdfPoint(620, 210), 250, 90, angleInRadians)
                Dim signature As DevExpress.Pdf.PdfSignature = New DevExpress.Pdf.PdfSignature(certificate, imageData, pageNumber, signatureBounds)
                signature.Location = "USA"
                signature.ContactInfo = "john.smith@example.com"
                signature.Reason = "Approved"
                documentProcessor.SaveDocument("..\..\SignedDocument.pdf", New DevExpress.Pdf.PdfSaveOptions() With {.Signature = signature})
            End Using
        End Sub
    End Class
End Namespace
