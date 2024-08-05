using Newtonsoft.Json;
using EditoraInovacao.Sankhya.Entities.Transport;
using Xunit;

namespace EditoraInovacao.Sankhya.Entities.Tests.Transport
{
    public class SerializationTests
    {
        [Fact]
        public void CanSerializeAndDeserializeBrand()
        {
            var brand = new Brand { Code = 1, Name = "Test Brand" };
            var json = JsonConvert.SerializeObject(brand);
            var deserializedBrand = JsonConvert.DeserializeObject<Brand>(json);
            Assert.Equal(brand.Code, deserializedBrand.Code);
            Assert.Equal(brand.Name, deserializedBrand.Name);
        }
    }
}