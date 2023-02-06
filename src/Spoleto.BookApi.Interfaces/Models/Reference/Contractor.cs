using System;
using System.Collections.Generic;
using System.Text;

namespace Spoleto.BookApi.Interfaces.Models
{
    public class Contractor : PersistentObjectBase, IContractor
    {
        /// <summary>
        /// Наименование
        /// </summary>
        public string Name { get; set; }

        /// <summary>
		/// Наименование полное
		/// </summary>
        public string FullName { get; set; }

        /// <summary>
        /// Обособленное подразделение
        /// </summary>
        public bool? IsCompanyDivision { get; set; }

        /// <summary>
        /// Тип контрагента
        /// </summary>
        public ContractorType? ContractorType { get; set; }

        /// <summary>
        /// ИНН
        /// </summary>
        public string INN { get; set; }

        /// <summary>
        /// КПП
        /// </summary>
        public string KPP { get; set; }

        /// <summary>
        /// КодПоОКПО
        /// </summary>
        public string OKPOCode { get; set; }

        /// <summary>
        /// Комментарий
        /// </summary>
        public string Note { get; set; }

        /// <summary>
        /// ДополнительнаяИнформация
        /// </summary>
        public string AdditionalInfo { get; set; }

        /// <summary>
        /// ДатаРегистрации
        /// </summary>
        public DateTime? DateRegistration { get; set; }

        /// <summary>
        /// ДатаСоздания
        /// </summary>
        public DateTime? DateCreate { get; set; }

        /// <summary>
        /// Parent,Id
        /// </summary>
        public Guid ParentId { get; set; }

        /// <summary>
        /// Parent
        /// </summary>
        public IContractor Parent { get; set; }

        /// <summary>
        /// Головной контрагент, Id
        /// </summary>
        public Guid MainContractorId { get; set; }

        /// <summary>
        /// Головной контрагент
        /// </summary>
        public IContractor MainContractor { get; set; }

        /// <summary>
        /// Банковский счет, Id
        /// </summary>
        public Guid BankAccountId { get; set; }

        /// <summary>
        /// Банковский счет
        /// </summary>
        public IBankAccount BankAccount { get; set; }

        /// <summary>
        /// Страна регистрации, Id
        /// </summary>
        public Guid CountryId { get; set; }

        /// <summary>
        /// Страна регистрации
        /// </summary>
        public ICountry Country { get; set; }

        /// <summary>
        ///  Основное контактное лицо, Id
        /// </summary>
        public Guid ContactPersonId { get; set; }

        /// <summary>
        /// Основное контактное лицо
        /// </summary>
        public IContactPerson ContactPerson { get; set; }

        /// <summary>
        /// Контактная информация
        /// </summary>
        public List<IContactInfo> ContactInfo { get; set; }
    }
}
