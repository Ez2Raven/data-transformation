

using System;
using System.Text.Json;
using Snmp.Domain.Interfaces;
using Snmp.Domain.Models;

namespace Snmp.Parser.Normalization.Interfaces
{
    /// <summary>
	/// Encapsulated algorithm for parsing SNMP Time
	/// </summary>
	public interface INormalizeSnmpTime 
	{
		DateTime NormalizeSnmpTime(ISnmpMsg incomingSnmpMsg);

	}
}

