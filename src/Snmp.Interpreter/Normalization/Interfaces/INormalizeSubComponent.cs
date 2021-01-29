

using System.Text.Json;
using Snmp.Domain.Interfaces;
using Snmp.Domain.Models;

namespace Snmp.Parser.Normalization.Interfaces
{
    /// <summary>
	/// Encapsulated algorithm for parsing Sub Component which is used to represent a Dashboard L4 Node if necessary.
	/// </summary>
	public interface INormalizeSubComponent 
	{
		string NormalizeSubComponent(ISnmpMsg incomingSnmpMsg);

	}
}

