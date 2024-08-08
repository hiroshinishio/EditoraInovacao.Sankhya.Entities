using Microsoft.VisualStudio.TestTools.UnitTesting;
using Newtonsoft.Json;
using Src.EditoraInovacao.Sankhya.Entities.Transport;

namespace EditoraInovacao.Sankhya.Entities.Tests
{
    [TestClass]
    public class SerializationTests
    {
        [TestMethod]
        public void TestBrandSerialization()
        {
            var brand = new Brand { /* initialize properties */ };
            var json = JsonConvert.SerializeObject(brand);
            var deserializedBrand = JsonConvert.DeserializeObject<Brand>(json);
            Assert.AreEqual(brand, deserializedBrand);
        }
    }
}