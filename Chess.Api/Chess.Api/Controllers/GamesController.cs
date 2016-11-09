using System;
using System.Web.Http;

namespace Chess.Api.Controllers
{
    [Authorize]
    [RoutePrefix("game")]
    public class GamesController : ApiController
    {
        [HttpPut]
        [Route("create")]
        public string StartNewGame()
        {
            throw new NotImplementedException();
        }

        [HttpPost]
        [Route("end/{gameId}")]
        public string EndGame()
        {
            throw new NotImplementedException();
        }

        [HttpPost]
        [Route("delete/{gameId}")]
        public string DeleteGame()
        {
            throw new NotImplementedException();
        }

        [HttpPost]
        [Route("move/{gameId}/{move}")]
        public string Move()
        {
            throw new NotImplementedException();
        }
    }
}