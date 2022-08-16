//**********************************************************
//* DomainName: Facilities
//* FileName:   FacilityDesignConstructionModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.Models;

namespace Autobahn.Facilities.Models
{
     /// <summary>
     /// The FacilityDesignConstruction Model
     /// </summary>
    public partial class FacilityDesignConstructionModel : AutobahnBase, Interfaces.IFacilityDesignConstruction
    {
        /// <summary>
        /// 
        /// </summary>
        public  BuildingAdditionCode { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  BuildingAdditionDescription { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  BuildingSiteImprovementDescription { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public Guid? FacilityAdditionYear { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  FacilityConstructionDate { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  FacilityConstructionYear { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  RecordEndDateTime { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  RecordStartDateTime { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  RefBuildingEnergyConservationMeasureTypeId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  RefFacilityConstructionDateTypeId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  RefFacilityConstructionMaterialTypeId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  RefFacilityJointDevelopmentTypeId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  RefFacilitySiteImprovementLocationTypeId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  RefFacilityStandardTypeId { get; set; }

    }
}
