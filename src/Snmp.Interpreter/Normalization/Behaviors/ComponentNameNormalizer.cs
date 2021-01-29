using System;
using Snmp.Parser.Normalization.Interfaces;
using System.Text.Json;
using Snmp.Domain.Interfaces;
using Snmp.Domain.Models;
using BuildingBlocks.Utilities;

namespace Snmp.Parser.Normalization.Behaviors
{
    /// <summary>
    /// Default Behavior for parsing a component name based on the ComponentName property
    /// </summary>
    public class ComponentNameNormalizer : INormalizeComponentName
    {
        /// <summary>
        /// Extracts the NodeName Property from the given JSON String as Component Name.
        /// </summary>
        /// <param name="incomingSnmpMsg"></param>
        /// <returns></returns>
        public virtual string NormalizeComponentName(ISnmpMsg incomingSnmpMsg)
        {
            if (incomingSnmpMsg.ComponentName == null)
            {
                throw new InvalidOperationException(
                    @$"Unable to Normalize Component Name. 
                            SNMP Message does not contain the property: '
                                {typeof(ISnmpMsg).GetProperty("ComponentName").GetJsonPropertyName()}'");
            }

            return incomingSnmpMsg.ComponentName;
        }
    }
}