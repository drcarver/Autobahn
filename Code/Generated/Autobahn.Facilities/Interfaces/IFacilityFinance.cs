//***************************************************************************
//* DomainName: Facilities Interfaces (used by both models and View Models
//* FileName:   IFacilityFinance.cs
//***************************************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.Facilities.Interfaces
{
     /// <summary>
     /// The IFacilityFinance Interface
     /// </summary>
    public partial interface IFacilityFinance : IAutobahnBase
    {
        /// <summary>
        /// 
        /// </summary>
        Guid? FacilityReplacementValue { get; set; }

        /// <summary>
        /// 
        /// </summary>
         IndebtednessAmountAllowed { get; set; }

        /// <summary>
        /// 
        /// </summary>
         InsuranceDeductible { get; set; }

        /// <summary>
        /// 
        /// </summary>
         PublicEducationMillRate { get; set; }

        /// <summary>
        /// 
        /// </summary>
         RecordEndDateTime { get; set; }

        /// <summary>
        /// 
        /// </summary>
         RecordStartDateTime { get; set; }

    }
}
