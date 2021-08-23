using System;

namespace MasterloopAmqp
{
    public class CommandResponse
    {
        public int Id { get; set; }

        public DateTime? DeliveredAt { get; set; }

        public bool WasAccepted { get; set; }

        public int? ResultCode { get; set; }

        public string Comment { get; set; }
    }
}