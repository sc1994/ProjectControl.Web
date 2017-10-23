using System;
using System.Web;
using Microsoft.AspNet.SignalR;
using System.Collections.Concurrent;
using Microsoft.AspNet.SignalR.Hubs;

namespace API.SignalR
{
    [HubName("info")]
    public class InfoHub : Hub
    {
        public static ConcurrentDictionary<string, string> OnLineUsers = new ConcurrentDictionary<string, string>();

        /// <summary>
        /// 前端触发的消息广播
        /// </summary>
        /// <param name="message"></param>
        [HubMethodName("send")]
        public void Send(string message)
        {
            Clients.All.receiveMessage(DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"));
        }


        // ReSharper disable once RedundantOverriddenMember todo 人员上线
        public override System.Threading.Tasks.Task OnConnected()
        {
            return base.OnConnected();
        }

        // ReSharper disable once RedundantOverriddenMember todo 人员下线
        public override System.Threading.Tasks.Task OnDisconnected(bool stopCalled)
        {
            return base.OnDisconnected(stopCalled);
        }
    }
}