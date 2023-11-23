using NUnit.Framework;

namespace Library.Tests
{
    public class EquipmentCreatorTests
    {
        [Test]
        public void CreateExistingEquipment()
        {
            // Arrange
            var description = "prueba";

            // Act
            var resultFirstCreation = EquipmentCreator.CreateEquipment(description);

            // Assert
            Assert.IsNotNull(resultFirstCreation);
            Assert.That(resultFirstCreation.Description, Is.EqualTo(description));

            // intentar crear el equipo existente nuevamente
            var resultSecondCreation = EquipmentCreator.CreateEquipment(description);

            // verificar que el segundo intento no crea uno nuevo
            Assert.IsNotNull(resultSecondCreation);
            Assert.That(resultSecondCreation.Description, Is.EqualTo(description));
            Assert.That(resultSecondCreation, Is.SameAs(resultFirstCreation));
            // el equipment debería ser el mismo al intentar crear uno existente
        }

        [Test]
        public void CreateNewEquipment()
        {
            // Arrange 
            var description = "prueba2";

            // Act
            var result = EquipmentCreator.CreateEquipment(description);

            // Assert
            Assert.IsNotNull(result);
            Assert.That(result.Description, Is.EqualTo(description));
            Assert.That(result.HourlyCost, Is.EqualTo(0));
        }

        [Test]
        public void AddEquipment()
        {
            // Arrange
            var description = "prueba3";
            var hourlyCost = 5;

            // Act
            EquipmentCreator.AddEquipmentToCatalog(description, hourlyCost);

            // Assert
            var result = EquipmentCreator.CreateEquipment(description);

            Assert.IsNotNull(result);
            Assert.That(result.Description, Is.EqualTo(description));
            Assert.That(result.HourlyCost, Is.EqualTo(hourlyCost));
        }
    }
}