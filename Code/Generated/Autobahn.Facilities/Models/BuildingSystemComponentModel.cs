//**********************************************************
//* DomainName: Facilities
//* FileName:   BuildingSystemComponentModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.Models;

namespace Autobahn.Facilities.Models
{
     /// <summary>
     /// The BuildingSystemComponent Model
     /// </summary>
    public partial class BuildingSystemComponentModel : AutobahnBase, Interfaces.IBuildingSystemComponent
    {
        /// <summary>
        /// 
        /// </summary>
        public  BuildingInstitutionalEquipmentDescription { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  ComponentOrFixtureUsefulLife { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  Identifier { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  InstallationDate { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  LifecycleCost { get; set; }

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
        public  RefFacilityFurnishingsTypeId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public Guid? RefFacilitySystemOrComponentConditionId { get; set; }

    }
}
