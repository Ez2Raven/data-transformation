using System.Text.Json;
using Microsoft.Extensions.Logging;
using Snmp.Domain.Interfaces;

namespace Snmp.Parser
{
    public class SnmpParser : SnmpParserBase
    {
        public SnmpParser(ILogger log, ISnmpMsg snmpMessage) : base(log, snmpMessage)
        {
        }
    }
}