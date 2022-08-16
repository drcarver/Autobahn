//**********************************************************
//* DomainName: Facilities
//* FileName:   BuildingSystemCategoryModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.Models;

namespace Autobahn.Facilities.Models
{
     /// <summary>
     /// The BuildingSystemCategory Model
     /// </summary>
    public partial class BuildingSystemCategoryModel : AutobahnBase, Interfaces.IBuildingSystemCategory
    {
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
        public Guid? RefBuildingAirDistributionSystemTypeId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  RefBuildingCommMgmtComponentSystemTypeId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  RefBuildingCoolingGenerationSystemTypeId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  RefBuildingElectricalSystemTypeId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  RefBuildingFireProtectionSystemTypeId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  RefBuildingHeatingGenerationSystemTypeId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  RefBuildingHVACSystemTypeId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  RefBuildingMechanicalConveyingSystemTypeId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  RefBuildingMechanicalSystemTypeId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  RefBuildingPlumbingSystemTypeId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  RefBuildingSecuritySystemTypeId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  RefBuildingSystemTypeId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  RefBuildingTechnologyWiringSystemTypeId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  RefBuildingVerticalTransportationSystemTypeId { get; set; }

    }
}
