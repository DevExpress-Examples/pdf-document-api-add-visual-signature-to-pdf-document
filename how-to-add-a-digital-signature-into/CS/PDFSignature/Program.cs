using DevExpress.Pdf;
using System.Security.Cryptography.X509Certificates;

namespace PDFSignature {
    class Program {
        static void Main(string[] args) {

            // Create a PDF document processor.
            using (PdfDocumentProcessor documentProcessor = new PdfDocumentProcessor()) {

                // Load a PDF document. 
                documentProcessor.LoadDocument(@"..\..\Demo.pdf");

                // Load a certificate from a file.
                X509Certificate2 cert = new X509Certificate2(@"..\..\SignDemo.pfx", "dxdemo");

                // Create a PDF signature and specify signing location, contact info and reason.
                PdfSignature signature = new PdfSignature(cert) {
                    Location = "Location",
                    ContactInfo = "ContactInfo",
                    Reason = "Reason"
                };

                // Save the signed document.
                documentProcessor.SaveDocument(@"..\..\SignedDocument.pdf", new PdfSaveOptions() { Signature = signature });
            }
        }
    }
}
