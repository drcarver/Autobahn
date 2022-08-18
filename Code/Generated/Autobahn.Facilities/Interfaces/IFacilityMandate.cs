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
        /// Building Area
        /// <para>
        /// The sum of the areas at each floor level included within the principal outside faces of exterior walls, including roofed areas with finished floors that may not have exterior walls, but are connected to the main building. This sum should include all stories or areas having floor surfaces with clear standing head room (6.5 feet or 1.98 meters) but omit architectural setbacks or projections.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20745">Building Area</a>
        /// </para>
        /// </summary>
        Guid FacilityId { get; set; }

        /// <summary>
        /// Facility State or Local Mandate Name
        /// <para>
        /// The specific law, rule, regulation, or standard of a state or local government that pertains to public school facilities.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20787">Facility State or Local Mandate Name</a>
        /// </para>
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
