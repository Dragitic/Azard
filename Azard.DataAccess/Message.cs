using System;

namespace Azard.DataAccess
{
    public class Message
    {
        public int Id { get; set; }
        public string Text { get; set; }
        public DateTime MsgSendTime { get; set; }
    }
}