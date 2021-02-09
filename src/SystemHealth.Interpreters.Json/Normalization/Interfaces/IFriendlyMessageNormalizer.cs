using System.Text.Json;

namespace SystemHealth.Interpreters.Json.Normalization.Interfaces
{
    /// <summary>
	/// Encapsulated algorithm for parsing Friendly Messages.
	/// </summary>
	public interface IFriendlyMessageNormalizer 
	{
		/// <summary>
		/// Normalizes the friendly message.
		/// <para>Friendly message should inform the user the general status of the system components</para>
		/// </summary>
		/// <param name="snmpJsonRootElement">The incoming SNMP MSG.</param>
		/// <returns></returns>
		string InterpretElement(JsonElement snmpJsonRootElement);
	}
}

