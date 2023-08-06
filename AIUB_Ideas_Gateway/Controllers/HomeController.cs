﻿using BLL.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace AIUB_Ideas_Gateway.Controllers
{
    public class HomeController : ApiController
    {
        [HttpGet]
        [Route("api/home")]
        [Route("api/aig")]
        public HttpResponseMessage AllPosts()
        {
            try
            {
                var posts = PostServices.AllPosts();
                return Request.CreateResponse(HttpStatusCode.OK, posts);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, ex);
            }
        }
    }
}