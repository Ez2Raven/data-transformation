using System;
using System.Text.Json;
using SystemHealth.Interpreters.Json.Normalization.Interfaces;
using Microsoft.Extensions.Logging;

namespace SystemHealth.Interpreters.Json
{
    /// <summary>
    /// Interprets contextual meaning from a system's JSON health message based on assigned normalization behaviors.
    /// Currently expects a <see cref="JsonElement.Clone"/> of the <see cref="JsonDocument.RootElement"/>, leaving
    /// the lifetime ownership and dispose responsibility to the caller.
    /// </summary>
    public sealed class DefaultSnmpJsonInterpreter : ISnmpJsonInterpreter
    {
        private string Name { get; }

        private JsonElement SnmpJsonRootElementClone { get; }

        public ISystemNameNormalizer SystemNameNormalizer { get; }

        public IObjectIdNormalizer ObjectIdNormalizer { get; }

        public IComponentNameNormalizer ComponentNameNormalizer { get; }

        public IFriendlyMessageNormalizer FriendlyMessageNormalizer { get; }

        public ISnmpTimeNormalizer SnmpTimeNormalizer { get; }

        public IHealthStatusNormalizer HealthStatusNormalizer { get; }

        public ISubComponentNormalizer SubComponentNameNormalizer { get; }

        public ITrapMessageNormalizer TrapMessageNormalizer { get; }

        public string InterpretSystemName()
        {
            return SystemNameNormalizer.InterpretElement(SnmpJsonRootElementClone);
        }

        public string InterpretObjectId()
        {
            return ObjectIdNormalizer.InterpretElement(SnmpJsonRootElementClone);
        }

        public string InterpretComponentName()
        {
            return ComponentNameNormalizer.InterpretElement(SnmpJsonRootElementClone);
        }

        public string InterpretFriendlyMessage()
        {
            return FriendlyMessageNormalizer.InterpretElement(SnmpJsonRootElementClone);
        }

        public DateTime InterpretSnmpTime()
        {
            return SnmpTimeNormalizer.InterpretElement(SnmpJsonRootElementClone);
        }

        public string InterpretHealthStatus()
        {
            return HealthStatusNormalizer.InterpretElement(SnmpJsonRootElementClone);
        }

        public string InterpretSubComponentName()
        {
            return SubComponentNameNormalizer.InterpretElement(SnmpJsonRootElementClone);
        }

        public string InterpretTrapMessage()
        {
            return TrapMessageNormalizer.InterpretElement(SnmpJsonRootElementClone);
        }

        private readonly ILogger<DefaultSnmpJsonInterpreter> _logger;

        /// <summary>
        /// Instantiate an instance that interprets the most commonly used snmp conventions. 
        /// </summary>
        /// <param name="logger">
        ///     <see cref="Microsoft.Extensions.Logging.ILogger"/> from dependency injection.
        /// </param>
        /// <param name="name"> Name of the System to interpret </param>
        /// <param name="snmpJsonRootElementClone">
        ///     <see cref="JsonElement.Clone"/> of the <see cref="JsonDocument.RootElement"/>
        /// </param>
        /// <param name="systemNameNormalizer">
        ///     Default Implementation of <see cref="ISystemNameNormalizer"/>
        /// </param>
        /// <param name="objectIdNormalizer">
        ///     Default Implementation of <see cref="IObjectIdNormalizer"/>
        /// </param>
        /// <param name="componentNameNormalizer">
        ///     Default Implementation of a <see cref="IComponentNameNormalizer"/>
        /// </param>
        /// <param name="friendlyMessageNormalizer">
        ///     Default Implementation of a <see cref="IFriendlyMessageNormalizer"/>
        /// </param>
        /// <param name="snmpTimeNormalizer">
        ///     Default Implementation of a <see cref="ISnmpTimeNormalizer"/></param>
        /// <param name="healthStatusNormalizer">
        ///     Default Implementation of a <see cref="IHealthStatusNormalizer"/>
        /// </param>
        /// <param name="subComponentNameNormalizer">
        ///     Default Implementation of a <see cref="ISubComponentNormalizer"/>
        /// </param>
        /// <param name="trapMessageNormalizer">
        ///     Default Implementation of a <see cref="ITrapMessageNormalizer"/>
        /// </param>
        public DefaultSnmpJsonInterpreter(ILogger<DefaultSnmpJsonInterpreter> logger, string name,
            JsonElement snmpJsonRootElementClone,
            ISystemNameNormalizer systemNameNormalizer, IObjectIdNormalizer objectIdNormalizer,
            IComponentNameNormalizer componentNameNormalizer,
            IFriendlyMessageNormalizer friendlyMessageNormalizer,
            ISnmpTimeNormalizer snmpTimeNormalizer, IHealthStatusNormalizer healthStatusNormalizer,
            ISubComponentNormalizer subComponentNameNormalizer,
            ITrapMessageNormalizer trapMessageNormalizer)
        {
            _logger = logger;
            Name = name;
            SnmpJsonRootElementClone = snmpJsonRootElementClone;
            SystemNameNormalizer = systemNameNormalizer;
            ObjectIdNormalizer = objectIdNormalizer;
            ComponentNameNormalizer = componentNameNormalizer;
            FriendlyMessageNormalizer = friendlyMessageNormalizer;
            SnmpTimeNormalizer = snmpTimeNormalizer;
            HealthStatusNormalizer = healthStatusNormalizer;
            SubComponentNameNormalizer = subComponentNameNormalizer;
            TrapMessageNormalizer = trapMessageNormalizer;
        }
    }
}