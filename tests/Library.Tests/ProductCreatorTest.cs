namespace Library.Tests;

using Full_GRASP_And_SOLID;
using NUnit.Framework;

public class AdminTests
{

    [Test]
    public void ExistingProductReturnsExistingProductTest()
    {
        // Arrange
        string description = "ProductoPrueba";
        ProductCreator.AddProductToCatalog(description, 10.0);

        // Act
        Product result = ProductCreator.CreateProduct(description);

        // Assert
        Assert.IsNotNull(result);
        Assert.That(result.Description, Is.EqualTo(description));
        Assert.That(result.UnitCost, Is.EqualTo(10.0));
    }

    [Test]
    public void NewProductTest()
    {
        // Arrange
        string description = "NuevoProdPrueba";

        // Act
        Product result = ProductCreator.CreateProduct(description);

        // Assert
        Assert.IsNotNull(result);
        Assert.That(result.Description, Is.EqualTo(description));
        Assert.That(result.UnitCost, Is.EqualTo(0.0));
    }

    [Test]
    public void AddProductToCatalogTest()
    {

        // Arrange
        string description = "NuevoProdPruebaElJuancho";
        double expectedCost = 15.0;

        // Act
        ProductCreator.AddProductToCatalog(description, expectedCost);

        // Assert
        Product product = ProductCreator.CreateProduct(description);

        Assert.IsNotNull(product);
        Assert.That(product.Description, Is.EqualTo(description));
        Assert.That(product.UnitCost, Is.EqualTo(expectedCost));
    }
}