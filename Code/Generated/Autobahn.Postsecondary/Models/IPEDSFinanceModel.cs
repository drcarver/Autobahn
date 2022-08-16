//**********************************************************
//* DomainName: Postsecondary (PS)
//* FileName:   IPEDSFinanceModel.cs
//**********************************************************

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
        /// 
        /// </summary>
        public  RecordEndDateTime { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  RecordStartDateTime { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  RefIPEDSFASBFinancialPositionId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public Guid? RefIPEDSFASBFunctionalExpenseId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  RefIPEDSFASBPellGrantTransactionsId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  RefIPEDSFASBRevenueId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  RefIPEDSFASBRevenueRestrictionId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  RefIPEDSFASBScholarshipsandFellowshipsRevenueId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  RefIPEDSGASBFinancialPositionId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  RefIPEDSGASBFunctionalExpenseId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  RefIPEDSGASBRevenueId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  RefIPEDSGASBScholarshipsandFellowshipsRevenueId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  RefIPEDSIntercollegiateAthleticsExpensesId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  RefIPEDSNaturalExpenseId { get; set; }

    }
}
