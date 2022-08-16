//***************************************************************************
//* DomainName: Facilities Interfaces (used by both models and View Models
//* FileName:   IFacilityMortgage.cs
//***************************************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.Facilities.Interfaces
{
     /// <summary>
     /// The IFacilityMortgage Interface
     /// </summary>
    public partial interface IFacilityMortgage : IAutobahnBase
    {
        /// <summary>
        /// 
        /// </summary>
        Guid? FacilityMortgageInterestAmount { get; set; }

        /// <summary>
        /// 
        /// </summary>
         FacilityTotalAssessedValue { get; set; }

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
         RefFacilityMortgageInterestTypeId { get; set; }

        /// <summary>
        /// 
        /// </summary>
         RefFacilityMortgageTypeId { get; set; }

    }
}
