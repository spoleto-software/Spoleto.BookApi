using System;
using System.Collections.Generic;
using System.Text;

namespace Spoleto.BookApi.Interfaces
{
    /// <summary>
    /// Накладная на отгрузку
    /// </summary>
    public interface IWaybillExpend : IWaybill
    {
        /// <summary>
        /// Тип накладной на отгрузку
        /// </summary>
        WaybillExpendType? WaybillExpendType { get; set; }


        /// <summary>
        /// Банковский счет, Id
        /// </summary>
        Guid? BankAccountId { get; set; }

        /// <summary>
        /// Банковский счет
        /// </summary>
        [RelatedKey(nameof(BankAccountId))]
        IBankAccount BankAccount { get; set; }

        /// <summary>
        /// Руководитель, Id
        /// </summary>
        Guid? HeadId { get; set; }

        /// <summary>
        /// Руководитель
        /// </summary>
        [RelatedKey(nameof(HeadId))]
        IEmployee Head { get; set; }

        /// <summary>
        /// Главный бухгалтер, Id
        /// </summary>
        Guid? ChiefAccountantId { get; set; }

        /// <summary>
        /// Главный бухгалтер
        /// </summary>
        [RelatedKey(nameof(ChiefAccountantId))]
        IEmployee ChiefAccountant { get; set; }

        /// <summary>
        /// Ответственное лицо (отпуск груза разрешил), Id
        /// </summary>
        Guid? ResponsiblePersonId { get; set; }

        /// <summary>
        /// Ответственное лицо (отпуск груза разрешил)
        /// </summary>
        [RelatedKey(nameof(ResponsiblePersonId))]
        IEmployee ResponsiblePerson { get; set; }

        /// <summary>
        /// Кладовщик (отпуск груза произвел), Id
        /// </summary>
        Guid? StorekeeperId { get; set; }

        /// <summary>
        /// Кладовщик (отпуск груза произвел)
        /// </summary>
        [RelatedKey(nameof(StorekeeperId))]
        IEmployee Storekeeper { get; set; }
    }
}
