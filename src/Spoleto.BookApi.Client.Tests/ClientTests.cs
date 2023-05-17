using Microsoft.Extensions.DependencyInjection;
using Spoleto.BookApi.Client.Providers;
using Spoleto.BookApi.Interfaces.Models;
using Spoleto.FastPayments.AlfaBank.Tests;

namespace Spoleto.BookApi.Client.Tests
{
    public class Tests
    {
        private ServiceProvider _serviceProvider;
        private PersistentProviderOption _settings;

        [OneTimeSetUp]
        public void OneTimeSetUp()
        {
            var services = new ServiceCollection();
            services.AddHttpClient();
            services.AddHttpClient("WithDefaultCredentials")
                .ConfigurePrimaryHttpMessageHandler(h => new HttpClientHandler
                {
                    UseDefaultCredentials = true
                });

            services.AddTransient<IPersistentProvider, PersistentProvider>();

            _serviceProvider = services.BuildServiceProvider();

            _settings = ConfigurationHelper.GetSettings();
        }

        [Test]
        public void LoadObject()
        {
            // Arrange
            var provider = _serviceProvider.GetService<IPersistentProvider>();
            var objId = Guid.NewGuid();

            // Act
            var obj = provider.LoadObject<SaleSlip>(_settings, "dbName", objId);

            // Assert
            Assert.Multiple(() =>
            {
                Assert.That(obj, Is.Not.Null);
                Assert.That(obj.Identity, Is.EqualTo(objId));
            });
        }

        [Test]
        public void CreateObject()
        {
            // Arrange
            var provider = _serviceProvider.GetService<IPersistentProvider>();
            var newItem = new SlipItem
            {
                Identity = Guid.NewGuid(),
                Amount = 100,
                Quantity = 5,
            };
            var newPayment = new SlipPayment
            {
                Identity = Guid.NewGuid(),
                Amount = 500
            };

            var newObj = new SaleSlip
            {
                Identity = Guid.NewGuid(),
                Date = DateTime.Now,
                LegalPersonId = Guid.NewGuid(),
                ShopId = Guid.NewGuid(),
                SlipItems = new List<SlipItem>()
                {
                    newItem
                },
                SlipPayments = new List<SlipPayment>()
                {
                    newPayment
                }
            };

            // Act
            var obj = provider.CreateObject(_settings, "dbName", newObj);

            // Assert
            Assert.Multiple(() =>
            {
                Assert.That(obj, Is.Not.Null);
                Assert.That(obj.Identity, Is.EqualTo(newObj.Identity));
            });
        }

        [Test]
        public void UpdateObject()
        {
            // Arrange
            var provider = _serviceProvider.GetService<IPersistentProvider>();
            var newItem = new SlipItem
            {
                Identity = Guid.NewGuid(),
                Amount = 100,
                Quantity = 5,
            };
            var newPayment = new SlipPayment
            {
                Identity = Guid.NewGuid(),
                Amount = 500
            };

            var newObj = new SaleSlip
            {
                Identity = Guid.NewGuid(),
                Date = DateTime.Now,
                LegalPersonId = Guid.NewGuid(),
                ShopId = Guid.NewGuid(),
                SlipItems = new List<SlipItem>()
                {
                    newItem
                },
                SlipPayments = new List<SlipPayment>()
                {
                    newPayment
                }
            };

            // Act
            var obj = provider.UpdateObject<SaleSlip>(_settings, "dbName", newObj);

            // Assert
            Assert.Multiple(() =>
            {
                Assert.That(obj, Is.Not.Null);
                Assert.That(obj.Identity, Is.EqualTo(newObj.Identity));
            });
        }

        [Test]
        public void PatchObject()
        {
            // Arrange
            var provider = _serviceProvider.GetService<IPersistentProvider>();
            var objId = Guid.NewGuid();
            var newDate = DateTime.UtcNow;
            var newShopId = Guid.NewGuid();

            // Act
            var obj = provider.UpdateOnlyObject(_settings, "dbName", objId, () => new SaleSlip { Date = newDate, ShopId = newShopId });

            // Assert
            Assert.Multiple(() =>
            {
                Assert.That(obj, Is.Not.Null);
                Assert.That(obj.Date, Is.EqualTo(newDate));
                Assert.That(obj.ShopId, Is.EqualTo(newShopId));
            });
        }

        [Test]
        public void PatchObjectViaDictionary()
        {
            // Arrange
            var provider = _serviceProvider.GetService<IPersistentProvider>();
            var objId = Guid.NewGuid();
            var newDate = DateTime.UtcNow;
            var newShopId = Guid.NewGuid();

            // Act
            var obj = provider.UpdateOnlyObject<SaleSlip>(_settings, "dbName", objId, new Dictionary<string, object> { { "Date", newDate }, { "ShopId", newShopId } });

            // Assert
            Assert.Multiple(() =>
            {
                Assert.That(obj, Is.Not.Null);
                Assert.That(obj.Date, Is.EqualTo(newDate));
                Assert.That(obj.ShopId, Is.EqualTo(newShopId));
            });
        }

        [Test]
        public void DeleteObject()
        {
            // Arrange
            var provider = _serviceProvider.GetService<IPersistentProvider>();
            var objId = Guid.NewGuid();

            // Act
            provider.DeleteObject<SaleSlip>(_settings, "dbName", objId);

            // Assert
            Assert.Pass();
        }

        [Test]
        public void LoadObjectList()
        {
            // Arrange
            var provider = _serviceProvider.GetService<IPersistentProvider>();
            var criteria = Guid.NewGuid();

            // Act
            var objList = provider.LoadObjectList<SaleSlip>(_settings, "dbName", criteria);

            // Assert
            Assert.Multiple(() =>
            {
                Assert.That(objList, Is.Not.Null);
            });
        }

        [Test]
        public async Task CreateContainer()
        {
            // Arrange
            var provider = _serviceProvider.GetService<IPersistentProvider>();
            var newItem = new SlipItem
            {
                Identity = Guid.NewGuid(),
                Amount = 100,
                Quantity = 5,
            };
            var newPayment = new SlipPayment
            {
                Identity = Guid.NewGuid(),
                Amount = 500
            };

            var newObj = new SaleSlip
            {
                Identity = Guid.NewGuid(),
                Date = DateTime.Now,
                LegalPersonId = Guid.NewGuid(),
                ShopId = Guid.NewGuid(),
                SlipItems = new List<SlipItem>()
                {
                    newItem
                },
                SlipPayments = new List<SlipPayment>()
                {
                    newPayment
                }
            };

            var report = new SaleSlipReport
            {
                Items = new ()
                {
                    newObj
                }
            };            

            var container = new PersistentContainer
            {
                Items = new ()
                {
                    new (typeof(SaleSlipReport)) {
                        Objects = new List<PersistentObjectBase>()
                        {
                            report
                        }
                    }
                }
            };

            // Act
            var createdContainer = await provider.CreateContainerAsync(_settings, "dbName",true, container);

            // Assert
            Assert.Multiple(() =>
            {
                Assert.That(createdContainer, Is.Not.Null);
                Assert.That(createdContainer.Items.Count, Is.EqualTo(container.Items.Count));
            });
        }

        [Test]
        public async Task ProcessContainer()
        {
            // Arrange
            var provider = _serviceProvider.GetService<IPersistentProvider>();
            var newItem = new SlipItem
            {
                Identity = Guid.NewGuid(),
                Amount = 100,
                Quantity = 5,
            };
            var newPayment = new SlipPayment
            {
                Identity = Guid.NewGuid(),
                Amount = 500
            };

            var newObj = new SaleSlip
            {
                Identity = Guid.NewGuid(),
                Date = DateTime.Now,
                LegalPersonId = Guid.NewGuid(),
                ShopId = Guid.NewGuid(),
                SlipItems = new List<SlipItem>()
                {
                    newItem
                },
                SlipPayments = new List<SlipPayment>()
                {
                    newPayment
                }
            };

            var report = new SaleSlipReport
            {
                Items = new()
                {
                    newObj
                }
            };

            var container = new PersistentStateContainer
            {
                Items = new ()
                {
                    new (typeof(SaleSlipReport)) {
                        ObjectState = Interfaces.ObjectState.Created,
                        Objects = new ()
                        {
                            report
                        }
                    }
                }
            };

            // Act
            var createdContainer = await provider.ProcessContainerAsync(_settings, "dbName", container);

            // Assert
            Assert.Multiple(() =>
            {
                Assert.That(createdContainer, Is.Not.Null);
                Assert.That(createdContainer.Items.Count, Is.EqualTo(container.Items.Count));
            });
        }
    }
}