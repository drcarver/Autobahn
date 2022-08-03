//**********************************************************
//* DomainName: Autobahn.Facilities
//* FileName:   FacilityManagementPlan.cs
//**********************************************************

using Autobahn.Facilities.Interfaces;

namespace Autobahn.Facilities.Models
{
     /// <summary>
     /// The FacilityManagementPlan
     /// </summary>
    public partial class FacilityManagementPlan : IFacilityManagementPlan
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="FacilityManagement"/> model
        /// </summary>
        public Guid FacilityManagementId { get; set; }

        /// <summary>
        /// Defines the FacilityManagementPlan.FacilitiesPlanDescription non nullable property
        /// </summary>
        public System.String FacilitiesPlanDescription { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefFacilitiesPlanType"/> model
        /// </summary>
        public Guid? RefFacilitiesPlanTypeId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefFacilitiesMgmtEmergencyType"/> model
        /// </summary>
        public Guid? RefFacilitiesMgmtEmergencyTypeId { get; set; }

        /// <summary>
        /// Defines the FacilityManagementPlan.RecordStartDateTime nullable property
        /// </summary>
        public System.DateTime? RecordStartDateTime { get; set; }

        /// <summary>
        /// Defines the FacilityManagementPlan.RecordEndDateTime nullable property
        /// </summary>
        public System.DateTime? RecordEndDateTime { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RecordStatus"/> model
        /// </summary>
        public Guid? RecordStatusId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="DataCollection"/> model
        /// </summary>
        public Guid? DataCollectionId { get; set; }

    }
}
