//**********************************************************
//* DomainName: Postsecondary (PS)
//* FileName:   IPEDSFinanceModel.cs
//***************************************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.Models;

namespace Autobahn.Postsecondary.Models
{
     /// <summary>
     /// The IPEDSFinance Model
     /// </summary>
    public partial class IPEDSFinanceModel : AutobahnBase, Interfaces.IIPEDSFinance
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
        public Guid OrganizationFinancialId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefIPEDSFASBFinancialPosition"/> model
        /// </summary>
        public Guid? RefIPEDSFASBFinancialPositionId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefIPEDSFASBFunctionalExpense"/> model
        /// </summary>
        public Guid? RefIPEDSFASBFunctionalExpenseId { get; set; }

        /// <summary>
        /// IPEDS Finance FASB Pell Grant Transactions
        /// <para>
        /// Method of reporting Pell Grants in IPEDS by degree-granting private, not-for-profit institutions and public institutions using FASB Reporting Standards.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20661">IPEDS Finance FASB Pell Grant Transactions</a>
        /// </para>
        /// </summary>
        public Guid? RefIPEDSFASBPellGrantTransactionsId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefIPEDSFASBRevenue"/> model
        /// </summary>
        public Guid? RefIPEDSFASBRevenueId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefIPEDSFASBRevenueRestriction"/> model
        /// </summary>
        public Guid? RefIPEDSFASBRevenueRestrictionId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefIPEDSFASBScholarshipsandFellowshipsRevenue"/> model
        /// </summary>
        public Guid? RefIPEDSFASBScholarshipsandFellowshipsRevenueId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefIPEDSGASBFinancialPosition"/> model
        /// </summary>
        public Guid? RefIPEDSGASBFinancialPositionId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefIPEDSGASBFunctionalExpense"/> model
        /// </summary>
        public Guid? RefIPEDSGASBFunctionalExpenseId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefIPEDSGASBRevenue"/> model
        /// </summary>
        public Guid? RefIPEDSGASBRevenueId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefIPEDSGASBScholarshipsandFellowshipsRevenue"/> model
        /// </summary>
        public Guid? RefIPEDSGASBScholarshipsandFellowshipsRevenueId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefIPEDSIntercollegiateAthleticsExpenses"/> model
        /// </summary>
        public Guid? RefIPEDSIntercollegiateAthleticsExpensesId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefIPEDSNaturalExpense"/> model
        /// </summary>
        public Guid? RefIPEDSNaturalExpenseId { get; set; }

    }
}
