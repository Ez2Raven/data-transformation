

using System.Text.Json;
using Snmp.Domain.Interfaces;
using Snmp.Domain.Models;

namespace Snmp.Parser.Normalization.Interfaces
{
    /// <summary>
	/// Encapsulated algorithm for parsing System Name
	/// </summary>
	public interface INormalizeSystemName 
	{
		string NormalizeSystemName(ISnmpMsg incomingSnmpMsg);

	}
}

