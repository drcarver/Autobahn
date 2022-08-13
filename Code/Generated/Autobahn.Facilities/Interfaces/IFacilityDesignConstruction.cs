//***************************************************************************
//* DomainName: Facilities Interfaces (used by both models and View Models
//* FileName:   IFacilityDesignConstruction.cs
//***************************************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.Facilities.Interfaces
{
     /// <summary>
     /// The IFacilityDesignConstruction Interface
     /// </summary>
    public partial interface IFacilityDesignConstruction : IAutobahnBase
    {
        /// <summary>
        /// The year the construction on the addition was completed.
        /// </summary>
        System.String BuildingAdditionCode { get; set; }

        /// <summary>
        /// The year the construction on the addition was completed.
        /// </summary>
        System.String BuildingAdditionDescription { get; set; }

        /// <summary>
        /// The year the construction on the addition was completed.
        /// </summary>
        System.String BuildingSiteImprovementDescription { get; set; }

        /// <summary>
        /// The year the construction on the addition was completed.
        /// </summary>
        System.String FacilityAdditionYear { get; set; }

        /// <summary>
        /// The year the construction on the addition was completed.
        /// </summary>
        System.DateTime? FacilityConstructionDate { get; set; }

        /// <summary>
        /// The year the construction on the addition was completed.
        /// </summary>
        System.String FacilityConstructionYear { get; set; }

        /// <summary>
        /// The year the construction on the addition was completed.
        /// </summary>
        Guid FacilityDesignId { get; set; }

        /// <summary>
        /// The year the construction on the addition was completed.
        /// </summary>
        Guid? RefBuildingEnergyConservationMeasureTypeId { get; set; }

        /// <summary>
        /// The year the construction on the addition was completed.
        /// </summary>
        Guid? RefFacilityConstructionDateTypeId { get; set; }

        /// <summary>
        /// The year the construction on the addition was completed.
        /// </summary>
        Guid? RefFacilityConstructionMaterialTypeId { get; set; }

        /// <summary>
        /// The year the construction on the addition was completed.
        /// </summary>
        Guid? RefFacilityJointDevelopmentTypeId { get; set; }

        /// <summary>
        /// The year the construction on the addition was completed.
        /// </summary>
        Guid? RefFacilitySiteImprovementLocationTypeId { get; set; }

        /// <summary>
        /// The year the construction on the addition was completed.
        /// </summary>
        Guid? RefFacilityStandardTypeId { get; set; }

    }
}
