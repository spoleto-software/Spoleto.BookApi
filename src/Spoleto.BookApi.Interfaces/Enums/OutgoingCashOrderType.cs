

namespace Spoleto.BookApi.Interfaces
{
    /// <summary>
    /// Виды операций РКО
    /// </summary>
    public enum OutgoingCashOrderType
    {
        /// <summary>
        /// ОплатаПоставщику
        /// </summary>
        SupplierPayment,

        /// <summary>
        /// ВозвратПокупателю
        /// </summary>
        ReturnToBuyer,

        /// <summary>
        /// УплатаНалога
        /// </summary>
        PayingTax,

        /// <summary>
        /// ВыдачаПодотчетномуЛицу
        /// </summary>
        IssuanceToAccountablePerson,

        /// <summary>
        /// ВыплатаЗаработнойПлатыПоВедомостям
        /// </summary>
        PaymentOfWagesAccordingToStatements,

        /// <summary>
        /// ВыплатаЗаработнойПлатыРаботнику
        /// </summary>
        PaymentOfWagesToEmployee,

        /// <summary>
        /// ВыплатаСотрудникуПоДоговоруПодряда
        /// </summary>
        PaymentToEmployeeByContract,

        /// <summary>
        /// ВыплатаДивидендов
        /// </summary>
        DividendPayment,

        /// <summary>
        /// ВзносНаличнымиВБанк
        /// </summary>
        DepositCashToBank,

        /// <summary>
        /// РасчетыПоКредитамИЗаймам
        /// </summary>
        LoanSettlements,

        /// <summary>
        /// ВозвратЗайма
        /// </summary>
        ReturnLoan,

        /// <summary>
        /// ВозвратКредита
        /// </summary>
        ReturnCredit,

        /// <summary>
        /// ВыдачаЗаймаКонтрагенту
        /// </summary>
        IssuanceOfLoanToCounterparty,

        /// <summary>
        /// Инкассация
        /// </summary>
        Collection,

        /// <summary>
        /// ВыплатаДепонентов
        /// </summary>
        PayoutDepositors,

        /// <summary>
        /// ВыдачаЗаймаРаботнику
        /// </summary>
        IssuanceOfLoanToEmployee,

        /// <summary>
        /// ЛичныеСредстваПредпринимателя
        /// </summary>
        EntrepreneurPersonalFunds,

        /// <summary>
        /// ПрочийРасход
        /// </summary>
        OtherExpense,

        /// <summary>
        /// ВозвратРозничномуПокупателю
        /// </summary>
        ReturnToRetailBuyer
    }


}
