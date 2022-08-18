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
        /// Building Institutional Equipment Description
        /// <para>
        /// Equipment that is installed for use in support of instructional program such as kilns for art, planetarium equipment for astronomy, fitness equipment for physical education.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20782">Building Institutional Equipment Description</a>
        /// </para>
        /// </summary>
        Guid BuildingSystemComponentId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefBuildingAirDistributionSystemType"/> model
        /// </summary>
        Guid? RefBuildingAirDistributionSystemTypeId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefBuildingCommMgmtComponentSystemType"/> model
        /// </summary>
        Guid? RefBuildingCommMgmtComponentSystemTypeId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefBuildingCoolingGenerationSystemType"/> model
        /// </summary>
        Guid? RefBuildingCoolingGenerationSystemTypeId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefBuildingElectricalSystemType"/> model
        /// </summary>
        Guid? RefBuildingElectricalSystemTypeId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefBuildingFireProtectionSystemType"/> model
        /// </summary>
        Guid? RefBuildingFireProtectionSystemTypeId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefBuildingHeatingGenerationSystemType"/> model
        /// </summary>
        Guid? RefBuildingHeatingGenerationSystemTypeId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefBuildingHVACSystemType"/> model
        /// </summary>
        Guid? RefBuildingHVACSystemTypeId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefBuildingMechanicalConveyingSystemType"/> model
        /// </summary>
        Guid? RefBuildingMechanicalConveyingSystemTypeId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefBuildingMechanicalSystemType"/> model
        /// </summary>
        Guid? RefBuildingMechanicalSystemTypeId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefBuildingPlumbingSystemType"/> model
        /// </summary>
        Guid? RefBuildingPlumbingSystemTypeId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefBuildingSecuritySystemType"/> model
        /// </summary>
        Guid? RefBuildingSecuritySystemTypeId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefBuildingSystemType"/> model
        /// </summary>
        Guid? RefBuildingSystemTypeId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefBuildingTechnologyWiringSystemType"/> model
        /// </summary>
        Guid? RefBuildingTechnologyWiringSystemTypeId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefBuildingVerticalTransportationSystemType"/> model
        /// </summary>
        Guid? RefBuildingVerticalTransportationSystemTypeId { get; set; }

    }
}
