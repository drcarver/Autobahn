//**********************************************************
//* DomainName: Autobahn.Facilities
//* FileName:   IFacilityManagementPlan.cs
//**********************************************************

namespace Autobahn.Facilities.Interfaces
{
     /// <summary>
     /// The IFacilityManagementPlan
     /// </summary>
    public partial interface IFacilityManagementPlan
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="FacilityManagement"/> model
        /// </summary>
        Guid FacilityManagementId { get; set; }

        /// <summary>
        /// Defines the FacilityManagementPlan.FacilitiesPlanDescription non nullable property
        /// </summary>
        System.String FacilitiesPlanDescription { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefFacilitiesPlanType"/> model
        /// </summary>
        Guid? RefFacilitiesPlanTypeId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefFacilitiesMgmtEmergencyType"/> model
        /// </summary>
        Guid? RefFacilitiesMgmtEmergencyTypeId { get; set; }

        /// <summary>
        /// Defines the FacilityManagementPlan.RecordStartDateTime nullable property
        /// </summary>
        System.DateTime? RecordStartDateTime { get; set; }

        /// <summary>
        /// Defines the FacilityManagementPlan.RecordEndDateTime nullable property
        /// </summary>
        System.DateTime? RecordEndDateTime { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RecordStatus"/> model
        /// </summary>
        Guid? RecordStatusId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="DataCollection"/> model
        /// </summary>
        Guid? DataCollectionId { get; set; }

    }
}
