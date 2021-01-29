

using System.Text.Json;
using Snmp.Domain.Interfaces;
using Snmp.Domain.Models;

namespace Snmp.Parser.Normalization.Interfaces
{
    /// <summary>
	/// Encapsulated algorithm for parsing Object ID
	/// </summary>
	public interface INormalizeObjectId 
	{
		/// <summary>
        /// Normalize the Object ID depending on how an External System defines its SNMP OID
        /// </summary>
        /// <param name="incomingSnmpMsg"></param>
        /// <returns></returns>
        string NormalizeObjectId(ISnmpMsg incomingSnmpMsg);

	}
}

