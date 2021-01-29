

using System.Text.Json;
using Snmp.Domain.Interfaces;
using Snmp.Domain.Models;

namespace Snmp.Parser.Normalization.Interfaces
{
    /// <summary>
	/// Encapsulated algorithm for parsing Trap Message
	/// </summary>
	public interface INormalizeTrapMessage 
	{
		string NormalizeTrapMessage(ISnmpMsg incomingSnmpMsg);

	}
}

