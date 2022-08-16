//***************************************************************************
//* DomainName: Invalid or Unreferenced Models Interfaces (used by both models and View Models
//* FileName:   IFinancialAidAward.cs
//***************************************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.Invalid.Interfaces
{
     /// <summary>
     /// The IFinancialAidAward Interface
     /// </summary>
    public partial interface IFinancialAidAward : IAutobahnBase
    {
        /// <summary>
        /// 
        /// </summary>
        Guid? FinancialAidAwardAmount { get; set; }

        /// <summary>
        /// 
        /// </summary>
         FinancialAidYearDesignator { get; set; }

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
         RefFinancialAidAwardTypeId { get; set; }

        /// <summary>
        /// 
        /// </summary>
         RefFinancialAidStatusId { get; set; }

    }
}
