//***************************************************************************
//* DomainName: Postsecondary (PS) Interfaces (used by both models and View Models
//* FileName:   IIPEDSFinance.cs
//***************************************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.Postsecondary.Interfaces
{
     /// <summary>
     /// The IIPEDSFinance Interface
     /// </summary>
    public partial interface IIPEDSFinance : IAutobahnBase
    {
        /// <summary>
        /// Financial Accounting Period Actual Value
        /// <para>
        /// The actual value of a financial account for the specified accounting period or fiscal year.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20317">Financial Accounting Period Actual Value</a>
        /// </para>
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
        /// IPEDS Finance FASB Pell Grant Transactions
        /// <para>
        /// Method of reporting Pell Grants in IPEDS by degree-granting private, not-for-profit institutions and public institutions using FASB Reporting Standards.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20661">IPEDS Finance FASB Pell Grant Transactions</a>
        /// </para>
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
