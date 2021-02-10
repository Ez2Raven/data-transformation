using System;
using System.Text.Json;
using SystemHealth.Interpreters.Json;
using Xunit;

namespace SystemHealth.Interpreters.Tests
{
    public class DefaultSnmpJsonInterpreterTest
    {
        [Theory]
        [InlineData("someJsonString","Kafka")]
        public void Invoke_DefaultComponentNameNormalizer_ReturnsSameString(string stubSnmpJsonMsg, string expected)
        {
            // Arrange
            JsonElement stubJsonRootElement;
            using (JsonDocument document = JsonDocument.Parse(stubSnmpJsonMsg))
            {
                stubJsonRootElement = document.RootElement.Clone();
            }

            var stubInterpreter = CreateDefaultSnmpJsonInterpreter(stubJsonRootElement);

            // Act
            var actualComponentName = stubInterpreter.InterpretComponentName();
            
            // Assert
            Assert.Equal(expected, actualComponentName);
            
        }

        private ISnmpJsonInterpreter CreateDefaultSnmpJsonInterpreter(JsonElement stubJsonRootElement)
        {
            throw new NotImplementedException();
        }
    }
}