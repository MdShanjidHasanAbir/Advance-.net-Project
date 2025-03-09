using BLL.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace TFSManagement.Controllers
{
    public class TeacherController : ApiController
    {
        [HttpGet]
        [Route("api/teachers")]
        public HttpResponseMessage Teachers()
        {
            try
            {
                var data = TeacherService.Get();
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, new { Massage = ex.Message });
            }
        }
        [HttpGet]
        [Route("api/teachers/{id}")]
        public HttpResponseMessage Teachers(int id)
        {
            try
            {
                var data = TeacherService.Get(id);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, new { Massage = ex.Message });
            }
        }
        [HttpGet]
        [Route("api/teachers/{id}/feedbacks")]
        public HttpResponseMessage TeacherFeedbacks(int id)
        {
            try
            {
                var data = TeacherService.GetwithFeedbacks(id);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, new { Massage = ex.Message });
            }
        }
    }
}
