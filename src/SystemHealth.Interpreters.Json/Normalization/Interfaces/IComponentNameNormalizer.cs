using System.Text.Json;

namespace SystemHealth.Interpreters.Json.Normalization.Interfaces
{
    /// <summary>
	/// Encapsulated algorithm for parsing Component Name that is used to represent a Dashboard L3 Node.
	/// </summary>
	public interface IComponentNameNormalizer 
	{
		string InterpretElement(JsonElement snmpJsonRootElement);

	}
}

