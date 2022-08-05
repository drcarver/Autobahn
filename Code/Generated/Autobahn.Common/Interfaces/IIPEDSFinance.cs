//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   IIPEDSFinance.cs
//**********************************************************


namespace Autobahn.Common.Interfaces
{
     /// <summary>
     /// The IIPEDSFinance
     /// </summary>
    public partial interface IIPEDSFinance : IAutobahnBase
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="OrganizationFinancial"/> model
        /// </summary>
        Guid OrganizationFinancialId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefIPEDSFASBFinancialPosition"/> model
        /// </summary>
        Guid? RefIPEDSFASBFinancialPositionId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefIPEDSFASBFunctionalExpense"/> model
        /// </summary>
        Guid? RefIPEDSFASBFunctionalExpenseId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefIPEDSFASBPellGrantTransactions"/> model
        /// </summary>
        Guid? RefIPEDSFASBPellGrantTransactionsId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefIPEDSFASBRevenue"/> model
        /// </summary>
        Guid? RefIPEDSFASBRevenueId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefIPEDSFASBRevenueRestriction"/> model
        /// </summary>
        Guid? RefIPEDSFASBRevenueRestrictionId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefIPEDSFASBScholarshipsandFellowshipsRevenue"/> model
        /// </summary>
        Guid? RefIPEDSFASBScholarshipsandFellowshipsRevenueId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefIPEDSGASBFinancialPosition"/> model
        /// </summary>
        Guid? RefIPEDSGASBFinancialPositionId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefIPEDSGASBFunctionalExpense"/> model
        /// </summary>
        Guid? RefIPEDSGASBFunctionalExpenseId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefIPEDSGASBRevenue"/> model
        /// </summary>
        Guid? RefIPEDSGASBRevenueId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefIPEDSGASBScholarshipsandFellowshipsRevenue"/> model
        /// </summary>
        Guid? RefIPEDSGASBScholarshipsandFellowshipsRevenueId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefIPEDSIntercollegiateAthleticsExpenses"/> model
        /// </summary>
        Guid? RefIPEDSIntercollegiateAthleticsExpensesId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefIPEDSNaturalExpense"/> model
        /// </summary>
        Guid? RefIPEDSNaturalExpenseId { get; set; }

    }
}
