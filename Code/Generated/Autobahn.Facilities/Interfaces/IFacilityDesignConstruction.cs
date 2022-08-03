//**********************************************************
//* DomainName: Autobahn.Facilities
//* FileName:   IFacilityDesignConstruction.cs
//**********************************************************

namespace Autobahn.Facilities.Interfaces
{
     /// <summary>
     /// The IFacilityDesignConstruction
     /// </summary>
    public partial interface IFacilityDesignConstruction
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="FacilityDesign"/> model
        /// </summary>
        Guid FacilityDesignId { get; set; }

        /// <summary>
        /// Defines the FacilityDesignConstruction.FacilityConstructionDate nullable property
        /// </summary>
        System.DateTime? FacilityConstructionDate { get; set; }

        /// <summary>
        /// Defines the FacilityDesignConstruction.FacilityConstructionYear non nullable property
        /// </summary>
        System.String FacilityConstructionYear { get; set; }

        /// <summary>
        /// Defines the FacilityDesignConstruction.BuildingAdditionCode non nullable property
        /// </summary>
        System.String BuildingAdditionCode { get; set; }

        /// <summary>
        /// Defines the FacilityDesignConstruction.BuildingAdditionDescription non nullable property
        /// </summary>
        System.String BuildingAdditionDescription { get; set; }

        /// <summary>
        /// Defines the FacilityDesignConstruction.FacilityAdditionYear non nullable property
        /// </summary>
        System.String FacilityAdditionYear { get; set; }

        /// <summary>
        /// Defines the FacilityDesignConstruction.BuildingSiteImprovementDescription non nullable property
        /// </summary>
        System.String BuildingSiteImprovementDescription { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefBuildingEnergyConservationMeasureType"/> model
        /// </summary>
        Guid? RefBuildingEnergyConservationMeasureTypeId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefFacilityConstructionDateType"/> model
        /// </summary>
        Guid? RefFacilityConstructionDateTypeId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefFacilityConstructionMaterialType"/> model
        /// </summary>
        Guid? RefFacilityConstructionMaterialTypeId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefFacilityJointDevelopmentType"/> model
        /// </summary>
        Guid? RefFacilityJointDevelopmentTypeId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefFacilitySiteImprovementLocationType"/> model
        /// </summary>
        Guid? RefFacilitySiteImprovementLocationTypeId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefFacilityStandardType"/> model
        /// </summary>
        Guid? RefFacilityStandardTypeId { get; set; }

        /// <summary>
        /// Defines the FacilityDesignConstruction.RecordStartDateTime nullable property
        /// </summary>
        System.DateTime? RecordStartDateTime { get; set; }

        /// <summary>
        /// Defines the FacilityDesignConstruction.RecordEndDateTime nullable property
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
