//**********************************************************
//* DomainName: Autobahn.Facilities
//* FileName:   IFacilityCompliance.cs
//**********************************************************

namespace Autobahn.Facilities.Interfaces
{
     /// <summary>
     /// The IFacilityCompliance
     /// </summary>
    public partial interface IFacilityCompliance
    {
        /// <summary>
        /// Reference to an optional instance of the <see cref="FacilityMandate"/> model
        /// </summary>
        Guid? FacilityMandateId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="BuildingSystemComponent"/> model
        /// </summary>
        Guid? BuildingSystemComponentId { get; set; }

        /// <summary>
        /// Defines the FacilityCompliance.FacilityComplianceName non nullable property
        /// </summary>
        System.String FacilityComplianceName { get; set; }

        /// <summary>
        /// Defines the FacilityCompliance.FacilityComplianceDeterminationDate nullable property
        /// </summary>
        System.DateTime? FacilityComplianceDeterminationDate { get; set; }

        /// <summary>
        /// Defines the FacilityCompliance.ComponentOrFixtureCheckDate nullable property
        /// </summary>
        System.DateTime? ComponentOrFixtureCheckDate { get; set; }

        /// <summary>
        /// Defines the FacilityCompliance.FacilityComponentDeficiencyDescription non nullable property
        /// </summary>
        System.String FacilityComponentDeficiencyDescription { get; set; }

        /// <summary>
        /// Defines the FacilityCompliance.FacilityEstimatedCostToEliminateDeferredMaint nullable property
        /// </summary>
        System.Decimal? FacilityEstimatedCostToEliminateDeferredMaint { get; set; }

        /// <summary>
        /// Defines the FacilityCompliance.FacilityInspectionScoreResultDescription non nullable property
        /// </summary>
        System.String FacilityInspectionScoreResultDescription { get; set; }

        /// <summary>
        /// Defines the FacilityCompliance.FacilityInspectionViolationDescription non nullable property
        /// </summary>
        System.String FacilityInspectionViolationDescription { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefFacilityComplianceStatus"/> model
        /// </summary>
        Guid? RefFacilityComplianceStatusId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefFacilityMaintStandardType"/> model
        /// </summary>
        Guid? RefFacilityMaintStandardTypeId { get; set; }

        /// <summary>
        /// Defines the FacilityCompliance.RecordStartDateTime nullable property
        /// </summary>
        System.DateTime? RecordStartDateTime { get; set; }

        /// <summary>
        /// Defines the FacilityCompliance.RecordEndDateTime nullable property
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
