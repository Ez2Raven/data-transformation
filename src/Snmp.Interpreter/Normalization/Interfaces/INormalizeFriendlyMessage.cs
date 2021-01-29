

using System.Text.Json;
using Snmp.Domain.Interfaces;
using Snmp.Domain.Models;

namespace Snmp.Parser.Normalization.Interfaces
{
    /// <summary>
	/// Encapsulated algorithm for parsing Friendly Messages.
	/// </summary>
	public interface INormalizeFriendlyMessage 
	{
		/// <summary>
		/// Normalizes the friendly message.
		/// <para>Friendly message should inform the user the general status of the system components</para>
		/// </summary>
		/// <param name="incomingSnmpMsg">The incoming SNMP MSG.</param>
		/// <param name="status">The status.</param>
		/// <returns></returns>
		string NormalizeFriendlyMessage(ISnmpMsg incomingSnmpMsg, string status);
	}
}

