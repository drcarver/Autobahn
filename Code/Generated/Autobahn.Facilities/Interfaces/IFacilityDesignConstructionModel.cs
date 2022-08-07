//**********************************************************
//* DomainName: Autobahn.Facilities
//* FileName:   IFacilityDesignConstructionModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.Facilities.Interfaces
{
     /// <summary>
     /// The IFacilityDesignConstructionModel Interface
     /// </summary>
    public partial interface IFacilityDesignConstructionModel : IAutobahnBase
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

    }
}
