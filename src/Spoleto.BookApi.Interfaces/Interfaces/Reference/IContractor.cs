using System;
using System.Collections.Generic;
using System.Text;

namespace Spoleto.BookApi.Interfaces
{
    public interface IContractor : IPersistentReference
    {
        /// <summary>
        /// Наименование
        /// </summary>
        string Name { get; set; }

        /// <summary>
		/// Наименование полное
		/// </summary>
        string FullName { get; set; }
        
        /// <summary>
        /// Обособленное подразделение
        /// </summary>
        bool? IsCompanyDivision { get; set; }

        /// <summary>
        /// Тип контрагента
        /// </summary>
        ContractorType? ContractorType { get; set; }

        /// <summary>
        /// ИНН
        /// </summary>
        string INN { get; set; }

        /// <summary>
        /// КПП
        /// </summary>
        string KPP { get; set; }

        /// <summary>
        /// КодПоОКПО
        /// </summary>
        string OKPOCode{ get; set; }

        /// <summary>
        /// Комментарий
        /// </summary>
        string Note { get; set; }

        /// <summary>
        /// ДополнительнаяИнформация
        /// </summary>
        string AdditionalInfo { get; set; }

        /// <summary>
        /// ДатаРегистрации
        /// </summary>
        DateTime? DateRegistration { get; set; }
   
        /// <summary>
        /// ДатаСоздания
        /// </summary>
        DateTime? DateCreate { get; set; }

        /// <summary>
        /// Parent,Id
        /// </summary>
        Guid ParentId { get; set; }

        /// <summary>
        /// Parent
        /// </summary>
        [RelatedKey(nameof(ParentId))]
        IContractor Parent { get; set; }

        /// <summary>
        /// Головной контрагент, Id
        /// </summary>
        Guid MainContractorId { get; set; }

        /// <summary>
        /// Головной контрагент
        /// </summary>
        [RelatedKey(nameof(MainContractorId))]
        IContractor MainContractor { get; set; }

        /// <summary>
        /// Банковский счет, Id
        /// </summary>
        Guid BankAccountId { get; set; }

        /// <summary>
        /// Банковский счет
        /// </summary>
        [RelatedKey(nameof(BankAccountId))]
        IBankAccount BankAccount { get; set; }

        /// <summary>
        /// Страна регистрации, Id
        /// </summary>
        Guid CountryId { get; set; }

        /// <summary>
        /// Страна регистрации
        /// </summary>
        [RelatedKey(nameof(CountryId))]
        ICountry Country { get; set; }

        /// <summary>
        ///  Основное контактное лицо, Id
        /// </summary>
        Guid ContactPersonId { get; set; }

        /// <summary>
        /// Основное контактное лицо
        /// </summary>
        [RelatedKey(nameof(ContactPersonId))]
        IContactPerson ContactPerson { get; set; }

        /// <summary>
        /// Контактная информация
        /// </summary>
        List<IContactInfo> ContactInfo { get; set; }
    }
}
