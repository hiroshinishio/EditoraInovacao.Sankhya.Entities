using Xunit;
using Newtonsoft.Json;
using Src.EditoraInovacao.Sankhya.Entities.Transport;

namespace EditoraInovacao.Sankhya.Entities.Tests
{
    public class SerializationTests
    {
        [Fact]
        public void Test_Serialization_And_Deserialization()
        {
            var model = new Brand 
            { 
                Id = 1, 
                Name = "Test Brand" 
            };
            var json = JsonConvert.SerializeObject(model);
            var deserializedModel = JsonConvert.DeserializeObject<Brand>(json); Assert.Equal(model.Id, deserializedModel.Id); Assert.Equal(model.Name, deserializedModel.Name); } } }