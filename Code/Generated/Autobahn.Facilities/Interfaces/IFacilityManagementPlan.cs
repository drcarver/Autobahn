//***************************************************************************
//* DomainName: Facilities Interfaces (used by both models and View Models
//* FileName:   IFacilityManagementPlan.cs
//***************************************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.Facilities.Interfaces
{
     /// <summary>
     /// The IFacilityManagementPlan Interface
     /// </summary>
    public partial interface IFacilityManagementPlan : IAutobahnBase
    {
        /// <summary>
        /// Facilities Plan Description
        /// <para>
        /// A description of the management and accountability plan.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20863">Facilities Plan Description</a>
        /// </para>
        /// </summary>
        System.String FacilitiesPlanDescription { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IFacilityManagement"/> model
        /// </summary>
        Guid FacilityManagementId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefFacilitiesMgmtEmergencyType"/> model
        /// </summary>
        Guid? RefFacilitiesMgmtEmergencyTypeId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefFacilitiesPlanType"/> model
        /// </summary>
        Guid? RefFacilitiesPlanTypeId { get; set; }

    }
}
