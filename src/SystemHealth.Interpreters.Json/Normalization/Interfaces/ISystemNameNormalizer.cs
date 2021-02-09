using System.Text.Json;

namespace SystemHealth.Interpreters.Json.Normalization.Interfaces
{
    /// <summary>
	/// Encapsulated algorithm for parsing System Name
	/// </summary>
	public interface ISystemNameNormalizer 
	{
		string InterpretElement(JsonElement snmpJsonRootElement);

	}
}

