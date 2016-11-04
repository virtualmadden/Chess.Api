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
        [Route("users/{userId}")]
        [HttpGet]
        public HttpResponseMessage GetUserById(int userId, [FromBody] Credentials credentials)
        {
            throw new NotImplementedException();
        }

        [Route("users/{username}")]
        [HttpGet]
        public HttpResponseMessage GetUserByUserName(string userName, [FromBody] Credentials credentials)
        {
            throw new NotImplementedException();
        }
    }
}