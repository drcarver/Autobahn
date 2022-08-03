//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   IPEDSFinance.cs
//**********************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.Common.Models
{
     /// <summary>
     /// The IPEDSFinance
     /// </summary>
    public partial class IPEDSFinance : IIPEDSFinance
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="OrganizationFinancial"/> model
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
        /// Reference to an optional instance of the <see cref="RefIPEDSFASBPellGrantTransactions"/> model
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

        /// <summary>
        /// Defines the IPEDSFinance.RecordStartDateTime nullable property
        /// </summary>
        public System.DateTime? RecordStartDateTime { get; set; }

        /// <summary>
        /// Defines the IPEDSFinance.RecordEndDateTime nullable property
        /// </summary>
        public System.DateTime? RecordEndDateTime { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RecordStatus"/> model
        /// </summary>
        public Guid? RecordStatusId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="DataCollection"/> model
        /// </summary>
        public Guid? DataCollectionId { get; set; }

    }
}
