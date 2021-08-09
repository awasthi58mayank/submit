using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using ProjectXDTO;
using ProjectXBL;
using Newtonsoft.Json;

namespace ActivityWebApi.Controllers
{
    public class PXController : ApiController
    {
        Projectxbl objBAL;

        [HttpGet]
        [ActionName("GetAllFaculties")]
        public HttpResponseMessage GetFaculties()
        {
            try
            {
                objBAL = new Projectxbl();
                List<FacultyDTO> FacLst = objBAL.GetFaculties();
                if (FacLst != null)
                {
                    var response = new HttpResponseMessage(HttpStatusCode.OK);
                    response.Content = new StringContent(JsonConvert.SerializeObject(FacLst));
                    response.Content.Headers.ContentType = new System.Net.Http.Headers.MediaTypeHeaderValue("application/json");
                    return response;
                }
                else
                {
                    var response = new HttpResponseMessage(HttpStatusCode.NoContent);
                    response.Content = new StringContent("No Table Found");
                    return response;
                }

            }
            catch (Exception)
            {
                var response = new HttpResponseMessage(HttpStatusCode.InternalServerError);
                response.Content = new StringContent("Oops!! SomeThing went wrong");
                return response;
            }
        }

        [HttpGet]
        [ActionName("GetAllCourses")]
        public HttpResponseMessage GetCourses()
        {
            try
            {
                objBAL = new Projectxbl();
                List<CourseDTO> CourseLst = objBAL.GetCourses();
                if (CourseLst != null)
                {
                    var response = new HttpResponseMessage(HttpStatusCode.OK);
                    response.Content = new StringContent(JsonConvert.SerializeObject(CourseLst));
                    response.Content.Headers.ContentType = new System.Net.Http.Headers.MediaTypeHeaderValue("application/json");
                    return response;
                }
                else
                {
                    var response = new HttpResponseMessage(HttpStatusCode.NoContent);
                    response.Content = new StringContent("No Table Found");
                    return response;
                }

            }
            catch (Exception)
            {
                var response = new HttpResponseMessage(HttpStatusCode.InternalServerError);
                response.Content = new StringContent("Oops! SomeThing went wrong");
                return response;
            }
        }

    }
}
