using System.Text.Json;

namespace SystemHealth.Interpreters.Json.Normalization.Interfaces
{
    /// <summary>
	/// Encapsulated algorithm for parsing Sub Component which is used to represent a Dashboard L4 Node if necessary.
	/// </summary>
	public interface ISubComponentNormalizer 
	{
		string InterpretElement(JsonElement snmpJsonRootElement);

	}
}

