

using System.Text.Json;
using Snmp.Domain.Models;

namespace Snmp.Parser.Normalization.Interfaces
{
    /// <summary>
	/// Encapsulated algorithm for parsing the Source IP / hostname where the message is generated
	/// </summary>
	public interface INormalizeSource
	{
		string NormalizeSource(SnmpMsg incomingSnmpMsg); 

	}
}

