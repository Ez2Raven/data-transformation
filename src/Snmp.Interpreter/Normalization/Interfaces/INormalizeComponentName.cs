

using System.Text.Json;
using Snmp.Domain.Interfaces;
using Snmp.Domain.Models;

namespace Snmp.Parser.Normalization.Interfaces
{
    /// <summary>
	/// Encapsulated algorithm for parsing Component Name that is used to represent a Dashboard L3 Node.
	/// </summary>
	public interface INormalizeComponentName 
	{
		string NormalizeComponentName(ISnmpMsg incomingSnmpMsg);

	}
}

