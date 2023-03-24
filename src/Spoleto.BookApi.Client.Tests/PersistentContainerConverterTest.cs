using System.Text.Encodings.Web;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Text.Unicode;
using Spoleto.BookApi.Interfaces.Models;

namespace Spoleto.BookApi.Client.Tests
{
    public class PersistentContainerConverterTest
    {
        private static readonly JavaScriptEncoder _cyrillicEncoder = JavaScriptEncoder.Create(UnicodeRanges.BasicLatin, UnicodeRanges.Cyrillic);

        private JsonSerializerOptions _serializerOptions;

        [OneTimeSetUp]
        public void OneTimeSetUp()
        {
            _serializerOptions = new JsonSerializerOptions
            {
                DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingNull,
                Encoder = _cyrillicEncoder,
                WriteIndented = true
            };

            //_serializerOptions.Converters.Add(new JsonStringEnumConverter());
        }

        [Test]
        public void ContainerWithUnitsAndSlips()
        {
            // Arrange
            var container = new PersistentContainer();
            var items = new List<PersistentContainerItem>();
            container.Items = items;
            var item1 = new PersistentContainerItem(typeof(Unit))
            {
                Objects = new List<PersistentObjectBase>
                {
                    new Unit {Identity = Guid.NewGuid(),Code="шт.", Name="Штука" },
                    new Unit {Identity = Guid.NewGuid(), Code="кг.", Name="Килограмм" },
                    new Unit {Identity = Guid.NewGuid(), Code="m.", Name="Meter" },
                }
            };
            var item2 = new PersistentContainerItem(typeof(SaleSlip))
            {
                Objects = new List<PersistentObjectBase>
                {
                    new SaleSlip {Date = DateTime.Now, Identity = Guid.NewGuid(), LegalPersonId = Guid.NewGuid() },
                    new SaleSlip {Date = DateTime.Now.AddDays(-1), Identity=Guid.NewGuid(), LegalPersonId = Guid.NewGuid() }
                }
            };
            items.Add(item1);
            items.Add(item2);

            // Act
            var json = JsonSerializer.Serialize(container, _serializerOptions);
            var containerFromJson = JsonSerializer.Deserialize<PersistentContainer>(json, _serializerOptions);

            // Assert
            Assert.Multiple(() =>
            {
                Assert.That(containerFromJson, Is.Not.Null);
                Assert.That(containerFromJson.Items.Count, Is.EqualTo(container.Items.Count));
                Assert.That(containerFromJson.Items[0].Objects.Count, Is.EqualTo(container.Items[0].Objects.Count));

                Assert.That(((Unit)containerFromJson.Items[0].Objects[0]).Code, Is.EqualTo(((Unit)container.Items[0].Objects[0]).Code));
                Assert.That(((SaleSlip)containerFromJson.Items[1].Objects[0]).LegalPersonId, Is.EqualTo(((SaleSlip)container.Items[1].Objects[0]).LegalPersonId));
            });
        }

        [Test]
        public void StateContainerWithUnitsAndSlips()
        {
            // Arrange
            var container = new PersistentStateContainer();
            var items = new List<PersistentStateContainerItem>();
            container.Items = items;
            var item1 = new PersistentStateContainerItem(typeof(Unit))
            {
                ObjectState = Interfaces.ObjectState.Changed,
                Objects = new List<PersistentObjectBase>
                {
                    new Unit {Identity = Guid.NewGuid(),Code="шт.", Name="Штука" },
                    new Unit {Identity = Guid.NewGuid(), Code="кг.", Name="Килограмм" },
                    new Unit {Identity = Guid.NewGuid(), Code="m.", Name="Meter" },
                }
            };
            var item2 = new PersistentStateContainerItem(typeof(SaleSlip))
            {
                ObjectState = Interfaces.ObjectState.Added,
                Objects = new List<PersistentObjectBase>
                {
                    new SaleSlip {Date = DateTime.Now, Identity = Guid.NewGuid(), LegalPersonId = Guid.NewGuid() },
                    new SaleSlip {Date = DateTime.Now.AddDays(-1), Identity = Guid.NewGuid(), LegalPersonId = Guid.NewGuid() }
                }
            };
            items.Add(item1);
            items.Add(item2);

            // Act
            var json = JsonSerializer.Serialize(container, _serializerOptions);
            var containerFromJson = JsonSerializer.Deserialize<PersistentStateContainer>(json, _serializerOptions);

            // Assert
            Assert.Multiple(() =>
            {
                Assert.That(containerFromJson, Is.Not.Null);
                Assert.That(containerFromJson.Items.Count, Is.EqualTo(container.Items.Count));
                Assert.That(containerFromJson.Items[0].Objects.Count, Is.EqualTo(container.Items[0].Objects.Count));
                Assert.That(((Unit)containerFromJson.Items[0].Objects[0]).Code, Is.EqualTo(((Unit)container.Items[0].Objects[0]).Code));
                Assert.That(((SaleSlip)containerFromJson.Items[1].Objects[0]).LegalPersonId, Is.EqualTo(((SaleSlip)container.Items[1].Objects[0]).LegalPersonId));

                Assert.That(containerFromJson.Items[0].ObjectState, Is.EqualTo(container.Items[0].ObjectState));
                Assert.That(containerFromJson.Items[1].ObjectState, Is.EqualTo(container.Items[1].ObjectState));
            });
        }
    }
}
