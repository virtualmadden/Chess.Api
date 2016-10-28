using System.Web.Http;

namespace Chess.Api.Controllers
{
    [Authorize]
    [RoutePrefix("api/game")]
    public class GamesController : ApiController
    {
        [HttpPut]
        [Route("create")]
        public string StartNewGame()
        {
            return string.Empty;
        }
    }
}