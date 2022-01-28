<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128595251/18.2.2%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/T243905)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->
# PDF Document API - Add a Visual Signature to a PDF document


This example illustrates how to sign a PDF document. Please note that the PdfDocumentProcessor class allows you to apply only one digital signature to a PDF document. If you need to sign the same PDF document multiple times, use the solution from this example: <a href="https://github.com/DevExpress-Examples/pdf-document-api-multiple-signatures">How to Apply Multiple Signatures</a>.

<br><br>The Universal Subscription or an additional Office File API Subscription is required to use this example in production code. Please refer to the <a href="https://www.devexpress.com/Subscriptions/">DevExpress Subscription</a> page for pricing information. <br><br><br>


<h3>Description</h3>

To accomplish this task, do the following:<br />&bull; Create a PDF document processor.<br />&bull; Load a PDF file from a file using the <a href="https://documentation.devexpress.com/#DocumentServer/DevExpressPdfPdfDocumentProcessor_LoadDocumenttopic">PdfDocumentProcessor.LoadDocument&nbsp;</a> method.<br />
&bull;&nbsp;Create a certificate using&nbsp;a certificate file name and a password to access the certificate;<br />&bull;
Create a document visual signature using one of the <a href="https://documentation.devexpress.com/#CoreLibraries/clsDevExpressPdfPdfSignaturetopic">PdfSignature</a>  constructor overloads that takes 4 arguments. For example, using a certificate, image data represented by a byte array, and specifying the page number and signature bounds. The signature bounds are represented by a  <a href="https://documentation.devexpress.com/CoreLibraries/DevExpress.Pdf.PdfOrientedRectangle.class">DevExpress.Pdf.PdfOrientedRectangle&nbsp;</a>  object. You can specify the rotation angle for the signature (in radians) when creating a **PdfOrientedRectangle** object. 
<br />&bull; Specify signing location, contact info and reason using the <a href="https://documentation.devexpress.com/#CoreLibraries/DevExpressPdfPdfSignature_Locationtopic">PdfSignature.Location</a>, <a href="https://documentation.devexpress.com/#CoreLibraries/DevExpressPdfPdfSignature_ContactInfotopic">PdfSignature.ContactInfo</a> and <a href="https://documentation.devexpress.com/#CoreLibraries/DevExpressPdfPdfSignature_Reasontopic">PdfSignature.Reason</a> properties, correspondingly.<br />&bull; 
Save the signed document with signing information by calling the <a href="https://documentation.devexpress.com/#DocumentServer/DevExpressPdfPdfDocumentProcessor_SaveDocumenttopic">PdfDocumentProcessor.SaveDocument&nbsp;</a> method.<br /><br /><br />

<br/>




