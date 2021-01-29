using System;

namespace Snmp.Domain.Interfaces
{
    public interface ISnmpMsg
    {
        /// <summary>
        ///     Gets or sets the name of the system.
        /// </summary>
        /// <value>
        ///     The name of the system.
        /// </value>
        string SystemName { get; set; }

        /// <summary>
        ///     Gets or sets the name of the component.
        /// </summary>
        /// <value>
        ///     The name of the component.
        /// </value>
        string ComponentName { get; set; }

        /// <summary>
        ///     Gets or sets the name of the process.
        /// </summary>
        /// <value>
        ///     The name of the process.
        /// </value>
        string ProcessName { get; set; }

        /// <summary>
        ///     Gets or sets the friendly message to display for the associated trap message
        /// </summary>
        /// <value>
        ///     The friendly message
        /// </value>
        string FriendlyMsg { get; set; }

        /// <summary>
        ///     Gets or sets the color to display for a System
        /// </summary>
        /// <value>
        ///     The color.
        /// </value>
        string ElementStatus { get; set; }

        /// <summary>
        ///     Gets or sets the trap message.
        /// </summary>
        /// <value>
        ///     The trap message.
        /// </value>
        string TrapMessage { get; set; }

        DateTime Time { get; set; }
        string ObjectId { get; set; }
        Guid Id { get; set; }
    }
}