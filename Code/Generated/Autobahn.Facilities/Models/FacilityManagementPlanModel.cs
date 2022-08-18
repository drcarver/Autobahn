//**********************************************************
//* DomainName: Facilities
//* FileName:   FacilityManagementPlanModel.cs
//***************************************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.Models;

namespace Autobahn.Facilities.Models
{
     /// <summary>
     /// The FacilityManagementPlan Model
     /// </summary>
    public partial class FacilityManagementPlanModel : AutobahnBase, Interfaces.IFacilityManagementPlan
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
        public System.String FacilitiesPlanDescription { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IFacilityManagement"/> model
        /// </summary>
        public Guid FacilityManagementId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefFacilitiesMgmtEmergencyType"/> model
        /// </summary>
        public Guid? RefFacilitiesMgmtEmergencyTypeId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefFacilitiesPlanType"/> model
        /// </summary>
        public Guid? RefFacilitiesPlanTypeId { get; set; }

    }
}
