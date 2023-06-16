using System;
using System.Collections.Generic;
using System.Text;

namespace Spoleto.BookApi.Interfaces
{
    public class WaybillExpendBase  : Waybill, IWaybillExpendBase
    {
        /// <summary>
        /// Тип накладной на отгрузку
        /// </summary>
        public WaybillExpendType? WaybillExpendType { get; set; }

        /// <summary>
        /// Банковский счет, Id
        /// </summary>
        public Guid? BankAccountId { get; set; }

        /// <summary>
        /// Банковский счет
        /// </summary>
        [RelatedKey(nameof(BankAccountId))]
        public IBankAccount BankAccount { get; set; }

        /// <summary>
        /// Руководитель, Id
        /// </summary>
        public Guid? HeadId { get; set; }

        /// <summary>
        /// Руководитель
        /// </summary>
        [RelatedKey(nameof(HeadId))]
        public IEmployee Head { get; set; }

        /// <summary>
        /// Главный бухгалтер, Id
        /// </summary>
        public Guid? ChiefAccountantId { get; set; }

        /// <summary>
        /// Главный бухгалтер
        /// </summary>
        [RelatedKey(nameof(ChiefAccountantId))]
        public IEmployee ChiefAccountant { get; set; }

        /// <summary>
        /// Ответственное лицо (отпуск груза разрешил), Id
        /// </summary>
        public Guid? ResponsiblePersonId { get; set; }

        /// <summary>
        /// Ответственное лицо (отпуск груза разрешил)
        /// </summary>
        [RelatedKey(nameof(ResponsiblePersonId))]
        public IEmployee ResponsiblePerson { get; set; }

        /// <summary>
        /// Кладовщик (отпуск груза произвел), Id
        /// </summary>
        public Guid? StorekeeperId { get; set; }

        /// <summary>
        /// Кладовщик (отпуск груза произвел)
        /// </summary>
        [RelatedKey(nameof(StorekeeperId))]
        public IEmployee Storekeeper { get; set; }

    }
}
