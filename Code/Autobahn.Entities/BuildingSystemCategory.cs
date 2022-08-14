using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Autobahn.Entities
{
    [Table("BuildingSystemCategory")]
    public partial class BuildingSystemCategory
    {
        public int BuildingSystemCategoryId { get; set; }

        public int BuildingSystemComponentId { get; set; }

        public int? RefBuildingAirDistributionSystemTypeId { get; set; }

        public int? RefBuildingCommMgmtComponentSystemTypeId { get; set; }

        public int? RefBuildingCoolingGenerationSystemTypeId { get; set; }

        public int? RefBuildingElectricalSystemTypeId { get; set; }

        public int? RefBuildingFireProtectionSystemTypeId { get; set; }

        public int? RefBuildingHeatingGenerationSystemTypeId { get; set; }

        public int? RefBuildingHVACSystemTypeId { get; set; }

        public int? RefBuildingMechanicalConveyingSystemTypeId { get; set; }

        public int? RefBuildingMechanicalSystemTypeId { get; set; }

        public int? RefBuildingPlumbingSystemTypeId { get; set; }

        public int? RefBuildingSecuritySystemTypeId { get; set; }

        public int? RefBuildingSystemTypeId { get; set; }

        public int? RefBuildingTechnologyWiringSystemTypeId { get; set; }

        public int? RefBuildingVerticalTransportationSystemTypeId { get; set; }

        public DateTime? RecordStartDateTime { get; set; }

        public DateTime? RecordEndDateTime { get; set; }

        public int? RecordStatusId { get; set; }

        public int? DataCollectionId { get; set; }

        public virtual BuildingSystemComponent BuildingSystemComponent { get; set; }

        public virtual DataCollection DataCollection { get; set; }

        public virtual RecordStatus RecordStatus { get; set; }

        public virtual RefBuildingAirDistributionSystemType RefBuildingAirDistributionSystemType { get; set; }

        public virtual RefBuildingCommMgmtComponentSystemType RefBuildingCommMgmtComponentSystemType { get; set; }

        public virtual RefBuildingCoolingGenerationSystemType RefBuildingCoolingGenerationSystemType { get; set; }

        public virtual RefBuildingElectricalSystemType RefBuildingElectricalSystemType { get; set; }

        public virtual RefBuildingFireProtectionSystemType RefBuildingFireProtectionSystemType { get; set; }

        public virtual RefBuildingHeatingGenerationSystemType RefBuildingHeatingGenerationSystemType { get; set; }

        public virtual RefBuildingHVACSystemType RefBuildingHVACSystemType { get; set; }

        public virtual RefBuildingMechanicalConveyingSystemType RefBuildingMechanicalConveyingSystemType { get; set; }

        public virtual RefBuildingMechanicalSystemType RefBuildingMechanicalSystemType { get; set; }

        public virtual RefBuildingPlumbingSystemType RefBuildingPlumbingSystemType { get; set; }

        public virtual RefBuildingSecuritySystemType RefBuildingSecuritySystemType { get; set; }

        public virtual RefBuildingSystemType RefBuildingSystemType { get; set; }

        public virtual RefBuildingTechnologyWiringSystemType RefBuildingTechnologyWiringSystemType { get; set; }

        public virtual RefBuildingVerticalTransportationSystemType RefBuildingVerticalTransportationSystemType { get; set; }
    }
}
