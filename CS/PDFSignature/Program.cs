using System;
using System.IO;
using System.Security.Cryptography.X509Certificates;
using DevExpress.Pdf;

namespace PDFSignature {
    class Program {
        static void Main(string[] args) {


            using (PdfDocumentProcessor documentProcessor = new PdfDocumentProcessor()) {

                documentProcessor.LoadDocument(@"..\..\Document.pdf");

                X509Certificate2 certificate = new X509Certificate2(@"..\..\SignDemo.pfx", "dxdemo");

                byte[] imageData = File.ReadAllBytes("..\\..\\image.emf");
                int pageNumber = 1;

                int angleInDegrees = 45;
                double angleInRadians = angleInDegrees * (Math.PI / 180);
                PdfOrientedRectangle signatureBounds = new PdfOrientedRectangle(new PdfPoint(620, 210), 250, 90, angleInRadians);
                PdfSignature signature = new PdfSignature(certificate, imageData, pageNumber, signatureBounds);

                signature.Location = "USA";
                signature.ContactInfo = "john.smith@example.com";
                signature.Reason = "Approved";

                documentProcessor.SaveDocument(@"..\..\SignedDocument.pdf", new PdfSaveOptions() { Signature = signature });
            }
        }
    }
}
