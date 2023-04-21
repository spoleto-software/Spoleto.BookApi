using System;
using System.Collections.Generic;
using System.Text;

namespace Spoleto.BookApi.Interfaces
{
    /// <summary>
    /// Сотрудник
    /// </summary>
    public interface IEmployee : IPersistentReference
    {
        /// <summary>
        /// Фамилия
        /// </summary>
        string Surname { get; set; }

        /// <summary>
        /// Имя
        /// </summary>
        string Name { get; set; }

        /// <summary>
        /// Отчество
        /// </summary>
        string Patronymic { get; set; }

        /// <summary>
        /// Инициалы
        /// </summary>
        string Initials { get; set; }   

        /// <summary>
        /// Полное имя
        /// </summary>
        string FullName { get; set; }

        /// <summary>
        /// Пол
        /// </summary>
        Gender Gender { get; set; }

        /// <summary>
        /// Дата рождения
        /// </summary>
        DateTime BirthDate { get; set; }

        /// <summary>
        /// Место рождения
        /// </summary>
        string BirthPlace { get; set; }

        /// <summary>
        /// Дата регистрации
        /// </summary>
        DateTime RegistryDate { get; set; }

        /// <summary>
        /// ИНН
        /// </summary>
        string INN { get; set; }

        /// <summary>
        /// Номер пенсионного страхового свидетельства
        /// </summary>
        string PensionInsuranceCertificate { get; set; }

        /// <summary>
        /// Банковский счет, Id
        /// </summary>
        Guid? BankAccountId { get; set; }

        /// <summary>
        /// Банковский счет
        /// </summary>
        [RelatedKey(nameof(BankAccountId))]
        IBankAccount BankAccount { get; set; }

    }
}
