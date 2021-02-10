using System.Text.Json;

namespace SystemHealth.Interpreters.Json.Normalization.Interfaces
{
    /// <summary>
	/// Encapsulated algorithm for parsing Object ID
	/// </summary>
	public interface IObjectIdNormalizer 
	{
		/// <summary>
        /// Normalize the Object ID depending on how an External System defines its SNMP OID
        /// </summary>
        /// <param name="snmpJsonRootElement"></param>
        /// <returns></returns>
        string InterpretElement(JsonElement snmpJsonRootElement);

	}
}

