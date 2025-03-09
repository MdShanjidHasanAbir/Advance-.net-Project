using BLL.DTOs;
using BLL.Service;
using iText.Kernel.Pdf;
using iText.Layout;
using iText.Layout.Element;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace TFSManagement.Controllers
{
    public class FeedbackController : ApiController
    {


        [HttpGet]
        [Route("api/feedbacks")]
        public HttpResponseMessage Feedbacks()
        {
            try
            {
                var data = FeedbackService.Get();
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, new { Massage = ex.Message });
            }
        }
        [HttpGet]
         [Route("api/feedback/{id}")]
         public HttpResponseMessage Feedbacks(int id)
         {
             try
             {
                 var data = FeedbackService.Get(id);
                 return Request.CreateResponse(HttpStatusCode.OK, data);
             }
             catch (Exception ex)
             {
                 return Request.CreateResponse(HttpStatusCode.InternalServerError, new { Massage = ex.Message });
             }
         }
        [HttpGet]
        [Route("api/feedback/search/{title}")]
        public HttpResponseMessage SearchByTitle(string title)
        {
            var data = FeedbackService.SearchByTitle(title);
            return Request.CreateResponse(HttpStatusCode.OK, data);
        }


        [HttpGet]
        [Route("api/feedback/search/{catagory}")]
        public HttpResponseMessage SearchByCatagory(string name)
        {
            var data = FeedbackService.SearchByCatagory(name);
            return Request.CreateResponse(HttpStatusCode.OK, data);
        }

        [HttpGet]
        [Route("api/feedback/export")]
        public HttpResponseMessage ExportFeedbacksToPdf()
        {
            try
            {
                var data = FeedbackService.Get(); // Fetch all feedback data

                using (var stream = new MemoryStream())
                {
                    var pdfWriter = new PdfWriter(stream);
                    var pdfDoc = new PdfDocument(pdfWriter);
                    var document = new Document(pdfDoc);

                    try
                    {
                        document.Add(new Paragraph("Feedback Report").SetFontSize(20));
                        document.Add(new Paragraph(" ")); // Add a blank line

                        // Add feedback details
                        foreach (var feedback in data)
                        {
                            document.Add(new Paragraph($"Title: {feedback.Title ?? "N/A"}"));
                            document.Add(new Paragraph($"Description: {feedback.Description ?? "N/A"}"));
                            document.Add(new Paragraph($"Category: {feedback.Catagory ?? "N/A"}"));
                            document.Add(new Paragraph($"Submission Date: {feedback.Date.ToString() ?? "N/A"}"));
                            document.Add(new Paragraph("-----")); // Separator
                        }
                    }
                    finally
                    {
                        document.Close(); // Ensure the document is closed
                        pdfDoc.Close(); // Ensure the PDF document is closed
                    }

                    stream.Position = 0; // Reset the stream position

                    // Return the PDF as a downloadable file
                    var result = new HttpResponseMessage(HttpStatusCode.OK)
                    {
                        Content = new ByteArrayContent(stream.ToArray())
                    };
                    result.Content.Headers.ContentDisposition = new System.Net.Http.Headers.ContentDispositionHeaderValue("attachment")
                    {
                        FileName = "FeedbacksReport.pdf"
                    };
                    result.Content.Headers.ContentType = new System.Net.Http.Headers.MediaTypeHeaderValue("application/pdf");

                    return result;
                }
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, new { Message = ex.Message });
            }
        }



    }
}
