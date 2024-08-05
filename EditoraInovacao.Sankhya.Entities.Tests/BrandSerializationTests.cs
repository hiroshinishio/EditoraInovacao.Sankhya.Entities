using Xunit;
using EditoraInovacao.Sankhya.Entities.Transport;
using System.Text.Json;

namespace EditoraInovacao.Sankhya.Entities.Tests
{
    public class BrandSerializationTests
    {
        [Fact]
        public void TestBrandSerialization()
        {
            var brand = new Brand
            {
                Code = 1,
                CodeUser = 2,
                Name = "Test Brand",
                Title = "Test Brand Title",
                Description = "Test Description",
                Keywords = "test,brand",
                IsActive = true,
                IsInPlatform = true,
                DateChanged = DateTime.Now,
                User = new User { Code = 1, Name = "Test User" }
            };

            var json = JsonSerializer.Serialize(brand);
            var deserializedBrand = JsonSerializer.Deserialize<Brand>(json);

            Assert.Equal(brand.Code, deserializedBrand.Code);
            Assert.Equal(brand.CodeUser, deserializedBrand.CodeUser);
            Assert.Equal(brand.Name, deserializedBrand.Name);
            Assert.Equal(brand.Title, deserializedBrand.Title);
            Assert.Equal(brand.Description, deserializedBrand.Description);
            Assert.Equal(brand.Keywords, deserializedBrand.Keywords);
            Assert.Equal(brand.IsActive, deserializedBrand.IsActive);
            Assert.Equal(brand.IsInPlatform, deserializedBrand.IsInPlatform);
            Assert.Equal(brand.DateChanged, deserializedBrand.DateChanged);
            Assert.Equal(brand.User.Code, deserializedBrand.User.Code);
            Assert.Equal(brand.User.Name, deserializedBrand.User.Name);
        }
    }
}