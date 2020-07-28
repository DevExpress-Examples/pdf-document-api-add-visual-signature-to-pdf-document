# How to add a digital signature into a PDF document


This example illustrates how to apply a digital signature to a PDF document. <br><br>The Universal Subscription or an additional Office File API Subscription is required to use this example in production code. Please refer to the <a href="https://www.devexpress.com/Subscriptions/">DevExpress Subscription</a> page for pricing information. <br><br><br>


<h3>Description</h3>

To accomplish this task, do the following:<br />&bull; Create a PDF document processor.<br />&bull; Load a PDF file from a file using the <a href="https://documentation.devexpress.com/#DocumentServer/DevExpressPdfPdfDocumentProcessor_LoadDocumenttopic">PdfDocumentProcessor.LoadDocument&nbsp;</a> method.<br />
&bull;&nbsp;Create a certificate using&nbsp;a certificate file name and a password to access the certificate;<br />&bull;
Create a document visual signature using one of the <a href="https://documentation.devexpress.com/#CoreLibraries/clsDevExpressPdfPdfSignaturetopic">PdfSignature</a>  constructor overloads that takes 4 arguments. For example, using a certificate, image data represented by a byte array, and specifying the page number and signature bounds. The signature bounds are represented by a  <a href="https://documentation.devexpress.com/CoreLibraries/DevExpress.Pdf.PdfOrientedRectangle.class">DevExpress.Pdf.PdfOrientedRectangle&nbsp;</a>  object. You can specify the rotation angle for the signature (in radians) when creating a **PdfOrientedRectangle** object. 
<br />&bull; Specify signing location, contact info and reason using the <a href="https://documentation.devexpress.com/#CoreLibraries/DevExpressPdfPdfSignature_Locationtopic">PdfSignature.Location</a>, <a href="https://documentation.devexpress.com/#CoreLibraries/DevExpressPdfPdfSignature_ContactInfotopic">PdfSignature.ContactInfo</a> and <a href="https://documentation.devexpress.com/#CoreLibraries/DevExpressPdfPdfSignature_Reasontopic">PdfSignature.Reason</a> properties, correspondingly.<br />&bull; 
Save the signed document with signing information by calling the <a href="https://documentation.devexpress.com/#DocumentServer/DevExpressPdfPdfDocumentProcessor_SaveDocumenttopic">PdfDocumentProcessor.SaveDocument&nbsp;</a> method.<br /><br /><br />

<br/>

**See also**: <a href="https://github.com/DevExpress-Examples/pdf-document-api-multiple-signatures">How to Apply Multiple Signatures</a>


