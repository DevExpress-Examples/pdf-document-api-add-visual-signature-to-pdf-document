<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128595251/15.1.3%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/T243905)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
[![](https://img.shields.io/badge/💬_Leave_Feedback-feecdd?style=flat-square)](#does-this-example-address-your-development-requirementsobjectives)
<!-- default badges end -->
<!-- default file list -->
*Files to look at*:

* [Program.cs](./CS/PDFSignature/Program.cs) (VB: [Program.vb](./VB/PDFSignature/Program.vb))
<!-- default file list end -->
# How to add a digital signature into a PDF document


This example illustrates how to apply a digital signature to a PDF document. <br><br>The Universal Subscription or an additional Document Server Subscription is required to use this example in production code. Please refer to the <a href="https://www.devexpress.com/Subscriptions/">DevExpress Subscription</a> page for pricing information. <br><br><br>


<h3>Description</h3>

To accomplish this task, do the following:<br />&bull; Create a PDF document processor.<br />&bull; Load a PDF file from a file using the <a href="https://documentation.devexpress.com/#DocumentServer/DevExpressPdfPdfDocumentProcessor_LoadDocumenttopic">PdfDocumentProcessor.LoadDocument&nbsp;</a> method.<br />&bull;&nbsp;Create a certificate using&nbsp;a certificate file name and a password to access the certificate;<br />&bull; Create a document digital signature represented by&nbsp;a <a href="https://documentation.devexpress.com/#CoreLibraries/clsDevExpressPdfPdfSignaturetopic">PdfSignature</a> object&nbsp;using&nbsp; the&nbsp;certificate;<br />&bull; Specify signing location, contact info and reason using the <a href="https://documentation.devexpress.com/#CoreLibraries/DevExpressPdfPdfSignature_Locationtopic">PdfSignature.Location</a>, <a href="https://documentation.devexpress.com/#CoreLibraries/DevExpressPdfPdfSignature_ContactInfotopic">PdfSignature.ContactInfo</a> and <a href="https://documentation.devexpress.com/#CoreLibraries/DevExpressPdfPdfSignature_Reasontopic">PdfSignature.Reason</a> properties, correspondingly.<br />&bull; Save the signed document with signing information by calling the <a href="https://documentation.devexpress.com/#DocumentServer/DevExpressPdfPdfDocumentProcessor_SaveDocumenttopic">PdfDocumentProcessor.SaveDocument&nbsp;</a> method.<br /><br /><br />

<br/>


<!-- feedback -->
## Does this example address your development requirements/objectives?

[<img src="https://www.devexpress.com/support/examples/i/yes-button.svg"/>](https://www.devexpress.com/support/examples/survey.xml?utm_source=github&utm_campaign=pdf-document-api-add-visual-signature-to-pdf-document&~~~was_helpful=yes) [<img src="https://www.devexpress.com/support/examples/i/no-button.svg"/>](https://www.devexpress.com/support/examples/survey.xml?utm_source=github&utm_campaign=pdf-document-api-add-visual-signature-to-pdf-document&~~~was_helpful=no)

(you will be redirected to DevExpress.com to submit your response)
<!-- feedback end -->
