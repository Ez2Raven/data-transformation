using System;
using System.Text.Json;

namespace SystemHealth.Interpreters.Json.Normalization.Interfaces
{
    /// <summary>
	/// Encapsulated algorithm for parsing SNMP Time
	/// </summary>
	public interface ISnmpTimeNormalizer 
	{
		DateTime InterpretElement(JsonElement snmpJsonRootElement);

	}
}

