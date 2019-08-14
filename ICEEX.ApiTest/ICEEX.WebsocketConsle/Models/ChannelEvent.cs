using System;
using System.Collections.Generic;
using System.Text;

namespace ICEEX.WebsocketConsle.Models
{
    public class ChannelEvent : BaseEvent
    {
        public string Channel { set; get; }
    }
}
