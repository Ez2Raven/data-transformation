using System;
using SystemHealth.Interpreters.Json.Normalization.Interfaces;

namespace SystemHealth.Interpreters.Json
{
    /// <summary>
    ///     Strategy Design Pattern, Encapsulate interpretation rules for different Systems' SNMP definition
    /// </summary>
    public interface ISnmpJsonInterpreter
    {
        ISystemNameNormalizer SystemNameNormalizer { get; }
        IObjectIdNormalizer ObjectIdNormalizer { get; }
        IComponentNameNormalizer ComponentNameNormalizer { get; }
        IFriendlyMessageNormalizer FriendlyMessageNormalizer { get; }
        ISnmpTimeNormalizer SnmpTimeNormalizer { get; }
        IHealthStatusNormalizer HealthStatusNormalizer { get; }
        ISubComponentNormalizer SubComponentNameNormalizer { get; }
        ITrapMessageNormalizer TrapMessageNormalizer { get; }

        string InterpretSystemName();
        string InterpretObjectId();
        string InterpretComponentName();
        string InterpretFriendlyMessage();
        DateTime InterpretSnmpTime();
        string InterpretHealthStatus();
        string InterpretSubComponentName();
        string InterpretTrapMessage();

    }
}