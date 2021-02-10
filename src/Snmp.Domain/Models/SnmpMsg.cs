using System;
using Snmp.Domain.Interfaces;

namespace Snmp.Domain.Models
{
    public class SnmpMsg:ISnmpMsg
    {
        public string SystemName { get; set; }
        public string ComponentName { get; set; }
        public string ProcessName { get; set; }
        public string FriendlyMsg { get; set; }
        public string ElementStatus { get; set; }
        public string TrapMessage { get; set; }
        public DateTime Time { get; set; }
        public string ObjectId { get; set; }
        public Guid Id { get; set; }
    }
}