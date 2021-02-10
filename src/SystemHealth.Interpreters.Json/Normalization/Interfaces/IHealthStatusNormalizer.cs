using System.Text.Json;

namespace SystemHealth.Interpreters.Json.Normalization.Interfaces
{
    /// <summary>
	/// Encapsulated algorithm for parsing Status
	/// </summary>
	public interface IHealthStatusNormalizer 
	{
		string InterpretElement(JsonElement snmpJsonRootElement);

	}
}

