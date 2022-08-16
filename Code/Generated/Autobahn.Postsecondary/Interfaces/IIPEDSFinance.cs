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
        /// 
        /// </summary>
         RecordEndDateTime { get; set; }

        /// <summary>
        /// 
        /// </summary>
         RecordStartDateTime { get; set; }

        /// <summary>
        /// 
        /// </summary>
         RefIPEDSFASBFinancialPositionId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        Guid? RefIPEDSFASBFunctionalExpenseId { get; set; }

        /// <summary>
        /// 
        /// </summary>
         RefIPEDSFASBPellGrantTransactionsId { get; set; }

        /// <summary>
        /// 
        /// </summary>
         RefIPEDSFASBRevenueId { get; set; }

        /// <summary>
        /// 
        /// </summary>
         RefIPEDSFASBRevenueRestrictionId { get; set; }

        /// <summary>
        /// 
        /// </summary>
         RefIPEDSFASBScholarshipsandFellowshipsRevenueId { get; set; }

        /// <summary>
        /// 
        /// </summary>
         RefIPEDSGASBFinancialPositionId { get; set; }

        /// <summary>
        /// 
        /// </summary>
         RefIPEDSGASBFunctionalExpenseId { get; set; }

        /// <summary>
        /// 
        /// </summary>
         RefIPEDSGASBRevenueId { get; set; }

        /// <summary>
        /// 
        /// </summary>
         RefIPEDSGASBScholarshipsandFellowshipsRevenueId { get; set; }

        /// <summary>
        /// 
        /// </summary>
         RefIPEDSIntercollegiateAthleticsExpensesId { get; set; }

        /// <summary>
        /// 
        /// </summary>
         RefIPEDSNaturalExpenseId { get; set; }

    }
}
