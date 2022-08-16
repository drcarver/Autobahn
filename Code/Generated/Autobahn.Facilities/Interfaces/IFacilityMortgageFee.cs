//***************************************************************************
//* DomainName: Facilities Interfaces (used by both models and View Models
//* FileName:   IFacilityMortgageFee.cs
//***************************************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.Facilities.Interfaces
{
     /// <summary>
     /// The IFacilityMortgageFee Interface
     /// </summary>
    public partial interface IFacilityMortgageFee : IAutobahnBase
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
        Guid? RefFacilityFinancingFeeTypeId { get; set; }

    }
}
