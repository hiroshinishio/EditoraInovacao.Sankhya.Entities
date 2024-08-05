using Xunit;
using Newtonsoft.Json;
using EditoraInovacao.Sankhya.Entities.Transport;

public class BrandTests
{
    [Fact]
    public void Brand_Serialization_Test()
    {
        // Arrange
        var brand = new Brand
        {
            Code = 1,
            Name = "Test Brand",
            CodeUser = 123
        };

        // Act
        var json = JsonConvert.SerializeObject(brand);
        var deserializedBrand = JsonConvert.DeserializeObject<Brand>(json);

        // Assert
        Assert.Equal(brand.Code, deserializedBrand.Code);
        Assert.Equal(brand.Name, deserializedBrand.Name);
        Assert.Equal(brand.CodeUser, deserializedBrand.CodeUser);
    }
}