using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNet.SignalR;
using Microsoft.AspNet.SignalR.Hubs;

namespace WebApplication1.Hubs
{
    [HubName("Echo")]
    public class EchoHub : Hub
    {
        public void Hello()
        {
            Clients.All.hello();
        }

        public void Send(string text)
        {
            Clients.All.Receive(text);
        }
    }
}