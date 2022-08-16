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
        /// 
        /// </summary>
         BuildingAdditionCode { get; set; }

        /// <summary>
        /// 
        /// </summary>
         BuildingAdditionDescription { get; set; }

        /// <summary>
        /// 
        /// </summary>
         BuildingSiteImprovementDescription { get; set; }

        /// <summary>
        /// 
        /// </summary>
        Guid? FacilityAdditionYear { get; set; }

        /// <summary>
        /// 
        /// </summary>
         FacilityConstructionDate { get; set; }

        /// <summary>
        /// 
        /// </summary>
         FacilityConstructionYear { get; set; }

        /// <summary>
        /// 
        /// </summary>
         RecordEndDateTime { get; set; }

        /// <summary>
        /// 
        /// </summary>
         RecordStartDateTime { get; set; }

        /// <summary>
        /// 
        /// </summary>
         RefBuildingEnergyConservationMeasureTypeId { get; set; }

        /// <summary>
        /// 
        /// </summary>
         RefFacilityConstructionDateTypeId { get; set; }

        /// <summary>
        /// 
        /// </summary>
         RefFacilityConstructionMaterialTypeId { get; set; }

        /// <summary>
        /// 
        /// </summary>
         RefFacilityJointDevelopmentTypeId { get; set; }

        /// <summary>
        /// 
        /// </summary>
         RefFacilitySiteImprovementLocationTypeId { get; set; }

        /// <summary>
        /// 
        /// </summary>
         RefFacilityStandardTypeId { get; set; }

    }
}
