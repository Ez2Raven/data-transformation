using System.Text.Json;
using SystemHealth.Interpreters.Json.Normalization.Interfaces;

namespace SystemHealth.Interpreters.Json.Normalization.Behaviors
{
    /// <summary>
    /// Default interpretation behavior for a system's component name.
    /// </summary>
    public class DefaultComponentNameNormalizer:IComponentNameNormalizer
    {
        private const string ComponentNameJsonPropertyKey = "componentName";
        public string InterpretElement(JsonElement snmpJsonRootElement)
        {
            JsonElement componentNameElement = snmpJsonRootElement.GetProperty(ComponentNameJsonPropertyKey);
            return componentNameElement.GetString();
        }
    }
}