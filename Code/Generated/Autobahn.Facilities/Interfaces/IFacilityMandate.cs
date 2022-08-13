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
        /// The particular federal law, regulation, or standard that pertains to a school facility.
        /// </summary>
        Guid FacilityId { get; set; }

        /// <summary>
        /// The particular federal law, regulation, or standard that pertains to a school facility.
        /// </summary>
        System.String FacilityStateOrLocalMandateName { get; set; }

        /// <summary>
        /// The particular federal law, regulation, or standard that pertains to a school facility.
        /// </summary>
        Guid? RefFacilitiesMandateAuthorityTypeId { get; set; }

        /// <summary>
        /// The particular federal law, regulation, or standard that pertains to a school facility.
        /// </summary>
        Guid? RefFacilityApplicableFederalMandateTypeId { get; set; }

        /// <summary>
        /// The particular federal law, regulation, or standard that pertains to a school facility.
        /// </summary>
        Guid? RefFacilityFederalMandateInterestTypeId { get; set; }

        /// <summary>
        /// The particular federal law, regulation, or standard that pertains to a school facility.
        /// </summary>
        Guid? RefFacilityStateOrLocalMandateInterestTypeId { get; set; }

    }
}
