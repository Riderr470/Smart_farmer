using BLL.DTOs;
using BLL.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace SmartFarm.Controllers
{
    public class CommentController : ApiController
    {
        [Route("api/Comment")]
        [HttpGet]
        public HttpResponseMessage Get()
        {
            var data = CommentService.Get();
            return Request.CreateResponse(HttpStatusCode.OK, data);
        }
        [HttpGet]
        [Route("api/Comment/{id}")]
        public HttpResponseMessage Get(int id)
        {
            var data = CommentService.Get(id);
            return Request.CreateResponse(HttpStatusCode.OK, data);
        }
        [HttpPost]
        [Route("api/Comment/add")]
        public HttpResponseMessage Add(CommentDto comment)
        {
            var data = CommentService.AddComment(comment);
            return Request.CreateResponse(HttpStatusCode.OK, data);
        }
    }
}