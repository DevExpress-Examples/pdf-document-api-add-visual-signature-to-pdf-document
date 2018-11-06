# How to add a digital signature into a PDF document


This example illustrates how to apply a digital signature to a PDF document. <br><br>The Universal Subscription or an additional Document Server Subscription is required to use this example in production code. Please refer to the <a href="https://www.devexpress.com/Subscriptions/">DevExpress Subscription</a> page for pricing information. <br><br><br>


<h3>Description</h3>

To accomplish this task, do the following:<br />&bull; Create a PDF document processor.<br />&bull; Load a PDF file from a file using the <a href="https://documentation.devexpress.com/#DocumentServer/DevExpressPdfPdfDocumentProcessor_LoadDocumenttopic">PdfDocumentProcessor.LoadDocument&nbsp;</a> method.<br />&bull;&nbsp;Create a certificate using&nbsp;a certificate file name and a password to access the certificate;<br />&bull; Create a document digital signature represented by&nbsp;a <a href="https://documentation.devexpress.com/#CoreLibraries/clsDevExpressPdfPdfSignaturetopic">PdfSignature</a> object&nbsp;using&nbsp; the&nbsp;certificate;<br />&bull; Specify signing location, contact info and reason using the <a href="https://documentation.devexpress.com/#CoreLibraries/DevExpressPdfPdfSignature_Locationtopic">PdfSignature.Location</a>, <a href="https://documentation.devexpress.com/#CoreLibraries/DevExpressPdfPdfSignature_ContactInfotopic">PdfSignature.ContactInfo</a> and <a href="https://documentation.devexpress.com/#CoreLibraries/DevExpressPdfPdfSignature_Reasontopic">PdfSignature.Reason</a> properties, correspondingly.<br />&bull; Save the signed document with signing information by calling the <a href="https://documentation.devexpress.com/#DocumentServer/DevExpressPdfPdfDocumentProcessor_SaveDocumenttopic">PdfDocumentProcessor.SaveDocument&nbsp;</a> method.<br /><br /><br />

<br/>


