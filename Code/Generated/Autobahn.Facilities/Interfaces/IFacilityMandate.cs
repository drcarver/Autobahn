//***************************************************************************
//* DomainName: Facilities Interfaces (used by both models and View Models
//* FileName:   IFacilityMandate.cs
//***************************************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.Facilities.Interfaces
{
     /// <summary>
     /// The IFacilityMandate Interface
     /// </summary>
    public partial interface IFacilityMandate : IAutobahnBase
    {
        /// <summary>
        /// 
        /// </summary>
         FacilityStateOrLocalMandateName { get; set; }

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
         RefFacilitiesMandateAuthorityTypeId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        Guid? RefFacilityApplicableFederalMandateTypeId { get; set; }

        /// <summary>
        /// 
        /// </summary>
         RefFacilityFederalMandateInterestTypeId { get; set; }

        /// <summary>
        /// 
        /// </summary>
         RefFacilityStateOrLocalMandateInterestTypeId { get; set; }

    }
}
