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
        /// The primary means by which air is circulated, freshened, and exhausted.
        /// </summary>
        public Guid BuildingSystemComponentId { get; set; }

        /// <summary>
        /// The primary means by which air is circulated, freshened, and exhausted.
        /// </summary>
        public Guid? RefBuildingAirDistributionSystemTypeId { get; set; }

        /// <summary>
        /// The primary means by which air is circulated, freshened, and exhausted.
        /// </summary>
        public Guid? RefBuildingCommMgmtComponentSystemTypeId { get; set; }

        /// <summary>
        /// The primary means by which air is circulated, freshened, and exhausted.
        /// </summary>
        public Guid? RefBuildingCoolingGenerationSystemTypeId { get; set; }

        /// <summary>
        /// The primary means by which air is circulated, freshened, and exhausted.
        /// </summary>
        public Guid? RefBuildingElectricalSystemTypeId { get; set; }

        /// <summary>
        /// The primary means by which air is circulated, freshened, and exhausted.
        /// </summary>
        public Guid? RefBuildingFireProtectionSystemTypeId { get; set; }

        /// <summary>
        /// The primary means by which air is circulated, freshened, and exhausted.
        /// </summary>
        public Guid? RefBuildingHeatingGenerationSystemTypeId { get; set; }

        /// <summary>
        /// The primary means by which air is circulated, freshened, and exhausted.
        /// </summary>
        public Guid? RefBuildingHVACSystemTypeId { get; set; }

        /// <summary>
        /// The primary means by which air is circulated, freshened, and exhausted.
        /// </summary>
        public Guid? RefBuildingMechanicalConveyingSystemTypeId { get; set; }

        /// <summary>
        /// The primary means by which air is circulated, freshened, and exhausted.
        /// </summary>
        public Guid? RefBuildingMechanicalSystemTypeId { get; set; }

        /// <summary>
        /// The primary means by which air is circulated, freshened, and exhausted.
        /// </summary>
        public Guid? RefBuildingPlumbingSystemTypeId { get; set; }

        /// <summary>
        /// The primary means by which air is circulated, freshened, and exhausted.
        /// </summary>
        public Guid? RefBuildingSecuritySystemTypeId { get; set; }

        /// <summary>
        /// The primary means by which air is circulated, freshened, and exhausted.
        /// </summary>
        public Guid? RefBuildingSystemTypeId { get; set; }

        /// <summary>
        /// The primary means by which air is circulated, freshened, and exhausted.
        /// </summary>
        public Guid? RefBuildingTechnologyWiringSystemTypeId { get; set; }

        /// <summary>
        /// The primary means by which air is circulated, freshened, and exhausted.
        /// </summary>
        public Guid? RefBuildingVerticalTransportationSystemTypeId { get; set; }

    }
}
