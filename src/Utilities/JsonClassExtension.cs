using System.Reflection;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace BuildingBlocks.Utilities
{
    public static class JsonClassExtension
    {
        /// <summary>
        /// Get the Json Property Name associated with the given class property
        /// </summary>
        /// <param name="modelProperty"></param>
        /// <returns>Returns the name of <see cref="JsonPropertyNameAttribute"/> placed on the C# Property.
        /// If not declared on the C# property, returns the C# property name converted by <see cref="JsonNamingPolicy"/>
        /// </returns>
        public static string GetJsonPropertyName(this PropertyInfo modelProperty)
        {
            return modelProperty.GetCustomAttribute<JsonPropertyNameAttribute>() == null
                ? JsonNamingPolicy.CamelCase.ConvertName(modelProperty.Name)
                : modelProperty.GetCustomAttribute<JsonPropertyNameAttribute>().Name;
        }
    }
}