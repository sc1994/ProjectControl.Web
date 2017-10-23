using Common;
using System.Web.Http;
using API.SignalR;

namespace API.Controllers
{
    public class BroadcastController : ControllerWithHub<InfoHub>
    {
        [HttpGet]
        public ResponseCode Index()
        {
            Hub.Clients.All.broadcast("1233333");
            return ResponseCode.Success;
        }
    }
}
