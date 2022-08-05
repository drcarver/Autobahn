//**********************************************************
//* DomainName: Autobahn.Facilities
//* FileName:   IFacilityMandate.cs
//**********************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.Facilities.Interfaces
{
     /// <summary>
     /// The IFacilityMandate
     /// </summary>
    public partial interface IFacilityMandate : IAutobahnBase
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="Facility"/> model
        /// </summary>
        Guid FacilityId { get; set; }

        /// <summary>
        /// Defines the FacilityMandate.FacilityStateOrLocalMandateName non nullable property
        /// </summary>
        System.String FacilityStateOrLocalMandateName { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefFacilitiesMandateAuthorityType"/> model
        /// </summary>
        Guid? RefFacilitiesMandateAuthorityTypeId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefFacilityApplicableFederalMandateType"/> model
        /// </summary>
        Guid? RefFacilityApplicableFederalMandateTypeId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefFacilityFederalMandateInterestType"/> model
        /// </summary>
        Guid? RefFacilityFederalMandateInterestTypeId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefFacilityStateOrLocalMandateInterestType"/> model
        /// </summary>
        Guid? RefFacilityStateOrLocalMandateInterestTypeId { get; set; }

    }
}
