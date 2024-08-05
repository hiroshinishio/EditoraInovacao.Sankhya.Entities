using System.Text.Json;
using Xunit;
using EditoraInovacao.Sankhya.Entities.Transport;

namespace EditoraInovacao.Sankhya.Entities.Tests
{
    public class SerializationTests
    {
        [Fact]
        public void TestSerializeBrand()
        {
            var brand = new Brand { /* initialize properties */ };
            var json = JsonSerializer.Serialize(brand);
            Assert.NotNull(json);
        }

        [Fact]
        public void TestDeserializeBrand()
        {
            var json = "{ /* JSON representation of Brand */ }";
            var brand = JsonSerializer.Deserialize<Brand>(json);
            Assert.NotNull(brand);
        }
    }
}