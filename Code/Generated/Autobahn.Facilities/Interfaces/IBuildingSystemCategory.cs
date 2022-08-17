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
        /// Reference to an optional instance of the <see cref="IRefBuildingAirDistributionSystemType"/> model
        /// </summary>
        Guid? RefBuildingAirDistributionSystemTypeId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IRefBuildingCommMgmtComponentSystemType"/> model
        /// </summary>
        Guid? RefBuildingCommMgmtComponentSystemTypeId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IRefBuildingCoolingGenerationSystemType"/> model
        /// </summary>
        Guid? RefBuildingCoolingGenerationSystemTypeId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IRefBuildingElectricalSystemType"/> model
        /// </summary>
        Guid? RefBuildingElectricalSystemTypeId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IRefBuildingFireProtectionSystemType"/> model
        /// </summary>
        Guid? RefBuildingFireProtectionSystemTypeId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IRefBuildingHeatingGenerationSystemType"/> model
        /// </summary>
        Guid? RefBuildingHeatingGenerationSystemTypeId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IRefBuildingHVACSystemType"/> model
        /// </summary>
        Guid? RefBuildingHVACSystemTypeId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IRefBuildingMechanicalConveyingSystemType"/> model
        /// </summary>
        Guid? RefBuildingMechanicalConveyingSystemTypeId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IRefBuildingMechanicalSystemType"/> model
        /// </summary>
        Guid? RefBuildingMechanicalSystemTypeId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IRefBuildingPlumbingSystemType"/> model
        /// </summary>
        Guid? RefBuildingPlumbingSystemTypeId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IRefBuildingSecuritySystemType"/> model
        /// </summary>
        Guid? RefBuildingSecuritySystemTypeId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IRefBuildingSystemType"/> model
        /// </summary>
        Guid? RefBuildingSystemTypeId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IRefBuildingTechnologyWiringSystemType"/> model
        /// </summary>
        Guid? RefBuildingTechnologyWiringSystemTypeId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IRefBuildingVerticalTransportationSystemType"/> model
        /// </summary>
        Guid? RefBuildingVerticalTransportationSystemTypeId { get; set; }

    }
}
