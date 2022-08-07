//**********************************************************
//* DomainName: Autobahn.Facilities
//* FileName:   FacilityDesignConstructionModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.Models;

namespace Autobahn.Facilities.Models
{
     /// <summary>
     /// The FacilityDesignConstruction Model
     /// </summary>
    public partial class FacilityDesignConstructionModel : AutobahnBase, Interfaces.IFacilityDesignConstructionModel
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="FacilityDesign"/> model
        /// </summary>
        public Guid FacilityDesignId { get; set; }

        /// <summary>
        /// Defines the FacilityDesignConstruction.FacilityConstructionDate nullable property
        /// </summary>
        public System.DateTime? FacilityConstructionDate { get; set; }

        /// <summary>
        /// Defines the FacilityDesignConstruction.FacilityConstructionYear non nullable property
        /// </summary>
        public System.String FacilityConstructionYear { get; set; }

        /// <summary>
        /// Defines the FacilityDesignConstruction.BuildingAdditionCode non nullable property
        /// </summary>
        public System.String BuildingAdditionCode { get; set; }

        /// <summary>
        /// Defines the FacilityDesignConstruction.BuildingAdditionDescription non nullable property
        /// </summary>
        public System.String BuildingAdditionDescription { get; set; }

        /// <summary>
        /// Defines the FacilityDesignConstruction.FacilityAdditionYear non nullable property
        /// </summary>
        public System.String FacilityAdditionYear { get; set; }

        /// <summary>
        /// Defines the FacilityDesignConstruction.BuildingSiteImprovementDescription non nullable property
        /// </summary>
        public System.String BuildingSiteImprovementDescription { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefBuildingEnergyConservationMeasureType"/> model
        /// </summary>
        public Guid? RefBuildingEnergyConservationMeasureTypeId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefFacilityConstructionDateType"/> model
        /// </summary>
        public Guid? RefFacilityConstructionDateTypeId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefFacilityConstructionMaterialType"/> model
        /// </summary>
        public Guid? RefFacilityConstructionMaterialTypeId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefFacilityJointDevelopmentType"/> model
        /// </summary>
        public Guid? RefFacilityJointDevelopmentTypeId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefFacilitySiteImprovementLocationType"/> model
        /// </summary>
        public Guid? RefFacilitySiteImprovementLocationTypeId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefFacilityStandardType"/> model
        /// </summary>
        public Guid? RefFacilityStandardTypeId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="DataCollection"/> model
        /// </summary>
        public Guid? DataCollectionId { get; set; }

    }
}
