//***************************************************************************
//* DomainName: Facilities Interfaces (used by both models and View Models
//* FileName:   IBuildingSystemCategory.cs
//***************************************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.Facilities.Interfaces
{
     /// <summary>
     /// The IBuildingSystemCategory Interface
     /// </summary>
    public partial interface IBuildingSystemCategory : IAutobahnBase
    {
        /// <summary>
        /// The primary means by which air is circulated, freshened, and exhausted.
        /// </summary>
        Guid BuildingSystemComponentId { get; set; }

        /// <summary>
        /// The primary means by which air is circulated, freshened, and exhausted.
        /// </summary>
        Guid? RefBuildingAirDistributionSystemTypeId { get; set; }

        /// <summary>
        /// The primary means by which air is circulated, freshened, and exhausted.
        /// </summary>
        Guid? RefBuildingCommMgmtComponentSystemTypeId { get; set; }

        /// <summary>
        /// The primary means by which air is circulated, freshened, and exhausted.
        /// </summary>
        Guid? RefBuildingCoolingGenerationSystemTypeId { get; set; }

        /// <summary>
        /// The primary means by which air is circulated, freshened, and exhausted.
        /// </summary>
        Guid? RefBuildingElectricalSystemTypeId { get; set; }

        /// <summary>
        /// The primary means by which air is circulated, freshened, and exhausted.
        /// </summary>
        Guid? RefBuildingFireProtectionSystemTypeId { get; set; }

        /// <summary>
        /// The primary means by which air is circulated, freshened, and exhausted.
        /// </summary>
        Guid? RefBuildingHeatingGenerationSystemTypeId { get; set; }

        /// <summary>
        /// The primary means by which air is circulated, freshened, and exhausted.
        /// </summary>
        Guid? RefBuildingHVACSystemTypeId { get; set; }

        /// <summary>
        /// The primary means by which air is circulated, freshened, and exhausted.
        /// </summary>
        Guid? RefBuildingMechanicalConveyingSystemTypeId { get; set; }

        /// <summary>
        /// The primary means by which air is circulated, freshened, and exhausted.
        /// </summary>
        Guid? RefBuildingMechanicalSystemTypeId { get; set; }

        /// <summary>
        /// The primary means by which air is circulated, freshened, and exhausted.
        /// </summary>
        Guid? RefBuildingPlumbingSystemTypeId { get; set; }

        /// <summary>
        /// The primary means by which air is circulated, freshened, and exhausted.
        /// </summary>
        Guid? RefBuildingSecuritySystemTypeId { get; set; }

        /// <summary>
        /// The primary means by which air is circulated, freshened, and exhausted.
        /// </summary>
        Guid? RefBuildingSystemTypeId { get; set; }

        /// <summary>
        /// The primary means by which air is circulated, freshened, and exhausted.
        /// </summary>
        Guid? RefBuildingTechnologyWiringSystemTypeId { get; set; }

        /// <summary>
        /// The primary means by which air is circulated, freshened, and exhausted.
        /// </summary>
        Guid? RefBuildingVerticalTransportationSystemTypeId { get; set; }

    }
}
