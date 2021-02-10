using System.Text.Json;

namespace SystemHealth.Interpreters.Json.Normalization.Interfaces
{
    /// <summary>
	/// Encapsulated algorithm for parsing Trap Message
	/// </summary>
	public interface ITrapMessageNormalizer 
	{
		string InterpretElement(JsonElement snmpJsonRootElement);

	}
}

