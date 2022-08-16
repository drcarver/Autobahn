//***************************************************************************
//* DomainName: Invalid or Unreferenced Models Interfaces (used by both models and View Models
//* FileName:   IFinancialAidApplication.cs
//***************************************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.Invalid.Interfaces
{
     /// <summary>
     /// The IFinancialAidApplication Interface
     /// </summary>
    public partial interface IFinancialAidApplication : IAutobahnBase
    {
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
        Guid? RefFinancialAidApplicationTypeId { get; set; }

    }
}
