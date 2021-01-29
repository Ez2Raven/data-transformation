

using System;
using Snmp.Parser.Normalization.Interfaces;
using Microsoft.Extensions.Logging;
using Snmp.Domain.Interfaces;

namespace Snmp.Parser
{
    /// <summary>
    /// Strategy Design Pattern, Encapsulate parsing rules for different SNMP Systems
    /// </summary>
    public abstract class SnmpParserBase
    {
        private ILogger _logger;
        public SnmpParserBase(ILogger log, ISnmpMsg snmpMessage)
        {
            SnmpMessage = snmpMessage;
        }

        public virtual string Name
        {
            get;
            set;
        }

        public virtual ISnmpMsg SnmpMessage
        {
            get;
            set;
        }

        public virtual INormalizeSystemName SystemNameParser
        {
            get;
            set;
        }

        public virtual INormalizeObjectId ObjectIdParser
        {
            get;
            set;
        }

        public virtual INormalizeComponentName ComponentNameParser
        {
            get;
            set;
        }

        public virtual INormalizeFriendlyMessage FriendlyMessageParser
        {
            get;
            set;
        }

        public virtual INormalizeSnmpTime SnmpTimeParser
        {
            get;
            set;
        }

        public virtual INormalizeStatus StatusParser
        {
            get;
            set;
        }

        public virtual INormalizeSubComponent SubComponentNameParser
        {
            get;
            set;
        }

        public virtual INormalizeTrapMessage TrapMessageParser
        {
            get;
            set;
        }

        public virtual string GetObjectID()
        {
            if (ObjectIdParser == null)
            {
                throw new InvalidOperationException("Unable to parse Object ID. Object ID Parser cannot be null.");
            }
            return ObjectIdParser.NormalizeObjectId(SnmpMessage);
        }

        public virtual string GetStatus()
        {
            if (StatusParser == null)
            {
                throw new InvalidOperationException("Unable to parse Status. Status Parser cannot be null.");
            }
            return StatusParser.NormalizeStatus(SnmpMessage);
        }

        public virtual DateTime GetSnmpTime()
        {
            if (SnmpTimeParser == null)
            {
                throw new InvalidOperationException("Unable to parse Snmp Time. Snmp Time Parser cannot be null.");
            }
            return SnmpTimeParser.NormalizeSnmpTime(SnmpMessage);
        }

        public virtual string GetSystemName()
        {
            if (SystemNameParser == null)
            {
                throw new InvalidOperationException("Unable to parse System Name. System Name Parser cannot be null.");
            }
            return SystemNameParser.NormalizeSystemName(SnmpMessage);
        }

        public virtual string GetComponentName()
        {
            if (ComponentNameParser == null)
            {
                throw new InvalidOperationException("Unable to parse Status. Status Parser cannot be null.");
            }
            return ComponentNameParser.NormalizeComponentName(SnmpMessage);
        }

        public virtual string GetSubComponentName()
        {
            if (SubComponentNameParser == null)
            {
                _logger.LogWarning("Sub Component parser behavior is not defined / ignored intentionally. NULL is returned as sub component name");
                return null;
            }
            return SubComponentNameParser.NormalizeSubComponent(SnmpMessage);
        }

        public virtual string GetFriendlyMessage()
        {
            if (FriendlyMessageParser == null)
            {
                throw new InvalidOperationException("Unable to parse Friendly Message. Friend Message Parser cannot be null.");
            }

            string status = GetStatus();

            return FriendlyMessageParser.NormalizeFriendlyMessage(SnmpMessage, status);
        }

        public virtual string GetTrapMessage()
        {
            if (TrapMessageParser == null)
            {
                throw new InvalidOperationException("Unable to parse Trap Message. Trap Message Parser cannot be null.");
            }

            return TrapMessageParser.NormalizeTrapMessage(SnmpMessage);
        }

    }
}

