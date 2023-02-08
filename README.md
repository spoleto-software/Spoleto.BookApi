# Spoleto.BookApi
Интеграция с 1С (обмен данными, проводки)

## Типичные задачи
Загрузка данных в 1С из ERP и обратно.  
Проведение/распроведение документов.  
Поддержка разных версий 1С.  

## Технологии
Полноценный RESTful сервис.  
Вся работа с сервисом через HTTP-запросы.  
Формат данных в запросе: JSON.  
Полный цикл CRUD + Patch (обновление указанных свойств объекта) + специфичные запросы для проведения/распроведения документов.  

Работа через бизнес сущности сервиса, которые выступают в роли DTO. Эти объекты мапятся в сущности 1С. Бизнес сущности имеют для разработчиков более привычный нэйминг на латинице, вместо нейминга 1С на кириллице.

Далее работа с 1С через OData. Это позволяет более гибко работать с 1С, в сравнении с прямой обработкой 1С. Например, доступна такая функциональность, как получение единичных объектов как по идентификатору, так и целого списка объектов по любому динамическому фильтру (совместимому со спецификацией OData), который можно указать в запросе.

Поддержка разных версий 1С. Версирование самого сервиса с обратной совместимостью в рамках мажорной версии 1С.

## Пример использования
В роли примера рассмотрим документ “Данные по продажам”.  
Для формирования данного документа необходимо загрузить информацию по чекам. Каждый чек имеет общую информацию, позиции и оплаты. Ниже представлены модели данных чека.

### Модели данных.
В роли языка программирования использован C#.  

#### Модель чека на продажу
Общая информация.  
```csharp
/// <summary>
/// Чек на продажу
/// </summary>
public class SaleSlip : PersistentObjectBase, ISaleSlip
{
    /// <summary>
    /// Дата чека
    /// </summary>
    public DateTime Date { get; set; }

    /// <summary>
    /// Организация
    /// </summary>
    public Guid LegalPersonId { get; set; }

    /// <summary>
    /// Склад, Id
    /// </summary>
    public Guid WarehouseId { get; set; }

    ///// <summary>
    ///// Склад
    ///// </summary>
    //public IWarehouse Warehouse { get; set; }

    /// <summary>
    /// Место продажи, Id
    /// </summary>
    public Guid ShopId { get; set; }

    ///// <summary>
    ///// Место продажи
    ///// </summary>
    //public IShop Shop { get; set; }

    /// <summary>
    /// Позиции чека
    /// </summary>
    public IEnumerable<SlipItem> SlipItems { get; set; }

    /// <summary>
    /// Оплаты в чеке
    /// </summary>
    public IEnumerable<SlipPayment> SlipPayments { get; set; }
}
```

#### Модель позиций чека
Товары в чеке.
```csharp
/// <summary>
/// Позиция чека
/// </summary>
public class SlipItem : PersistentObjectBase, ISlipItem
{
    public int LineNumber { get; set; }

    public Guid ItemId { get; set; }

    /// <summary>
    /// Номенклатура
    /// </summary>
    public Item Item { get; set; }

    /// <summary>
    /// Количество
    /// </summary>
    public decimal Quantity { get; set; }

    /// <summary>
    /// Цена
    /// </summary>
    public decimal Cost { get; set; }

    /// <summary>
    /// Сумма
    /// </summary>
    public decimal Amount { get; set; }

    /// <summary>
    /// Ставка НДС
    /// </summary>
    public Vat VatValue { get; set; }

    /// <summary>
    /// Сумма НДС
    /// </summary>
    public decimal VatAmount { get; set; }

    /// <summary>
    /// Себестоимость
    /// </summary>
    public decimal SelfCost { get; set; }
}
```

#### Модель оплат в чеке
```csharp
/// <summary>
/// Оплата в чеке
/// </summary>
public class SlipPayment : PersistentObjectBase, ISlipPayment
{
    public int LineNumber { get; set;  }

    /// <summary>
    /// Вид оплаты, Id
    /// </summary>
    public Guid PaymentTypeContractorId { get; set; }

    /// <summary>
    /// Сумма
    /// </summary>
    public decimal Amount { get; set; }
}
```
### Демо примеры
Ознакомиться с демо-примерами как работать со Spoleto.BookApi можно здесь:  
[Spoleto.BookApi.Client.Tests](src/Spoleto.BookApi.Client.Tests#spoletobookapiclienttests)

Несколько примеров здесь:
#### Создание объекта
```csharp
// Инициализация зависимости:
services.AddHttpClient();
services.AddTransient<IPersistentProvider, PersistentProvider>();

// Получение зависимости:
var provider = _serviceProvider.GetService<IPersistentProvider>();

// Либо явное создание провайдера с указанием экземпляра HttpClient:
var httpClient = new HttpClient();
var provider = PersistentProvider.CreateProviderWithHttpClient(httpClient);

// Далее инициализация бизнес объекта:
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

// Собственно создание объекта
var obj = provider.CreateObject(_settings, "db1СName", newObj);
// Либо async:
var obj = await provider.CreateObjectAsync(_settings, "db1СName", newObj);
```

## Реальный кейс
Был реализован функционал по интеграции нашей ERP системы с 1С.  
В роли коннектора со стороны ERP системы использован клиент, написанный на .NET 6/7. Этот клиент выложен в публичный доступ на nuget.org. Благодаря кроссплатформенности .NET этот клиент может быть запущен на разных платформах (Windows, macOS и Linux).  
Данная интеграция позволяет загружать данные из нашей ERP системы в 1С, делать проводки этих документов.

