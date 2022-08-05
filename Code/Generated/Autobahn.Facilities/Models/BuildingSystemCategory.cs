//**********************************************************
//* DomainName: Autobahn.Facilities
//* FileName:   BuildingSystemCategory.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.Models;

namespace Autobahn.Facilities.Models
{
     /// <summary>
     /// The BuildingSystemCategory
     /// </summary>
    public partial class BuildingSystemCategory : AutobahnBase, Interfaces.IBuildingSystemCategory
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="BuildingSystemComponent"/> model
        /// </summary>
        public Guid BuildingSystemComponentId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefBuildingAirDistributionSystemType"/> model
        /// </summary>
        public Guid? RefBuildingAirDistributionSystemTypeId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefBuildingCommMgmtComponentSystemType"/> model
        /// </summary>
        public Guid? RefBuildingCommMgmtComponentSystemTypeId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefBuildingCoolingGenerationSystemType"/> model
        /// </summary>
        public Guid? RefBuildingCoolingGenerationSystemTypeId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefBuildingElectricalSystemType"/> model
        /// </summary>
        public Guid? RefBuildingElectricalSystemTypeId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefBuildingFireProtectionSystemType"/> model
        /// </summary>
        public Guid? RefBuildingFireProtectionSystemTypeId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefBuildingHeatingGenerationSystemType"/> model
        /// </summary>
        public Guid? RefBuildingHeatingGenerationSystemTypeId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefBuildingHVACSystemType"/> model
        /// </summary>
        public Guid? RefBuildingHVACSystemTypeId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefBuildingMechanicalConveyingSystemType"/> model
        /// </summary>
        public Guid? RefBuildingMechanicalConveyingSystemTypeId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefBuildingMechanicalSystemType"/> model
        /// </summary>
        public Guid? RefBuildingMechanicalSystemTypeId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefBuildingPlumbingSystemType"/> model
        /// </summary>
        public Guid? RefBuildingPlumbingSystemTypeId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefBuildingSecuritySystemType"/> model
        /// </summary>
        public Guid? RefBuildingSecuritySystemTypeId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefBuildingSystemType"/> model
        /// </summary>
        public Guid? RefBuildingSystemTypeId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefBuildingTechnologyWiringSystemType"/> model
        /// </summary>
        public Guid? RefBuildingTechnologyWiringSystemTypeId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefBuildingVerticalTransportationSystemType"/> model
        /// </summary>
        public Guid? RefBuildingVerticalTransportationSystemTypeId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="DataCollection"/> model
        /// </summary>
        public Guid? DataCollectionId { get; set; }

    }
}
