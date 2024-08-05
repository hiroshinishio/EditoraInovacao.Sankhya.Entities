using System;
using System.Text.Json;
using Xunit;
using EditoraInovacao.Sankhya.Entities.Transport;

public class SerializationTests
{
    [Theory]
    [InlineData(typeof(Brand))]
    [InlineData(typeof(Category))]
    [InlineData(typeof(FiscalInvoiceHeaderCustom))]
    [InlineData(typeof(HowKnow))]
    [InlineData(typeof(InvoiceHeaderCustom))]
    [InlineData(typeof(InvoiceHeaderExclusionCustom))]
    [InlineData(typeof(ItemMakeupProductCustom))]
    [InlineData(typeof(KitFormation))]
    [InlineData(typeof(LabelMercadoLivre))]
    [InlineData(typeof(Marketplace))]
    [InlineData(typeof(OrderControl))]
    [InlineData(typeof(OrderControlFlow))]
    [InlineData(typeof(OrderControlFlowResend))]
    [InlineData(typeof(OrderControlPayment))]
    [InlineData(typeof(OrderControlResend))]
    [InlineData(typeof(OrderControlShipment))]
    [InlineData(typeof(OrderControlShipmentTracking))]
    [InlineData(typeof(OrderControlTrackingStatus))]
    [InlineData(typeof(OrderHistory))]
    [InlineData(typeof(OrderImportPending))]
    [InlineData(typeof(PartnerCustom))]
    [InlineData(typeof(ProductChangeLog))]
    [InlineData(typeof(ProductCustom))]
    [InlineData(typeof(ProductInventoryCountHistory))]
    [InlineData(typeof(ProductInventoryCustom))]
    [InlineData(typeof(ProductSuggestedSaleCustom))]
    [InlineData(typeof(SalesChannel))]
    [InlineData(typeof(SellerCustom))]
    [InlineData(typeof(Store))]
    public void TestSerialization(Type modelType)
    {
        object modelInstance = Activator.CreateInstance(modelType);
        string json = JsonSerializer.Serialize(modelInstance);
        object deserializedInstance = JsonSerializer.Deserialize(json, modelType);
        Assert.Equal(modelInstance, deserializedInstance);
    }
}