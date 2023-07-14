
namespace Spoleto.BookApi.Interfaces
{
    public enum IncomingCashOrderType
    {
        /// <summary>
        /// ОплатаПокупателя
        /// </summary>
        BuyerPayment,

        /// <summary>
        /// РозничнаяВыручка
        /// </summary>
        RetailRevenue,

        /// <summary>
        /// ВозвратОтПодотчетногоЛица
        /// </summary>
        AccountableRefund,

        /// <summary>
        /// ВозвратОтПоставщика
        /// </summary>
        ReturnFromSupplier,

        /// <summary>
        /// ПолучениеНаличныхВБанке
        /// </summary>
        GettingCashInBank,

        /// <summary>
        /// РасчетыПоКредитамИЗаймам
        /// </summary>
        LoanSettlements,

        /// <summary>
        /// ПолучениеЗайма
        /// </summary>
        GettingLoan,

        /// <summary>
        /// ПолучениеКредита
        /// </summary>
        GettingCredit,

        /// <summary>
        /// ВозвратЗаймаКонтрагентом
        /// </summary>
        ReturnLoanByCounterparty,

        /// <summary>
        /// ВозвратЗаймаРаботником
        /// </summary>
        ReturnLoanByEmployee,

        /// <summary>
        /// ЛичныеСредстваПредпринимателя
        /// </summary>
        EntrepreneurPersonalFunds,

        /// <summary>
        /// ВзносВУставныйКапитал
        /// </summary>
        ContributionInAuthorizedCapital,

        /// <summary>
        /// ПрочийПриход
        /// </summary>
        OtherIncoming
    }
}
