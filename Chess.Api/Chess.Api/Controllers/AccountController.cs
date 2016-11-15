using System;
using System.Net.Http;
using System.Web.Http;
using Chess.Api.Models.UserTypes;

namespace Chess.Api.Controllers
{
    [Authorize]
    [RoutePrefix("users")]
    public class AccountController : ApiController
    {
        [HttpPut]
        [Route("create")]
        public HttpResponseMessage CreateUser(int userId, [FromBody] Credentials credentials)
        {
            throw new NotImplementedException();
        }

        [HttpGet]
        [Route("find/{userId}")]
        public HttpResponseMessage GetUserById(int userId, [FromBody] Credentials credentials)
        {
            throw new NotImplementedException();
        }

        [HttpGet]
        [Route("find/{username}")]
        public HttpResponseMessage GetUserByUserName(string userName, [FromBody] Credentials credentials)
        {
            throw new NotImplementedException();
        }
    }
}