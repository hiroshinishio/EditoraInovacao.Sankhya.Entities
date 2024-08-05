using System.Text.Json;
using Xunit;
using EditoraInovacao.Sankhya.Entities.Transport;
public class BrandTests
{
    [Fact]
    public void Brand_Serialization_Test()
    {
        var brand = new Brand { /* initialize properties */ };
        var json = JsonSerializer.Serialize(brand);
        var deserializedBrand = JsonSerializer.Deserialize<Brand>(json);
        Assert.Equal(brand, deserializedBrand);
    }
}