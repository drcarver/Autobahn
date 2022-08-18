//**********************************************************
//* DomainName: Facilities
//* FileName:   BuildingSystemCategoryModel.cs
//***************************************************************************

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
        /// Building Institutional Equipment Description
        /// <para>
        /// Equipment that is installed for use in support of instructional program such as kilns for art, planetarium equipment for astronomy, fitness equipment for physical education.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20782">Building Institutional Equipment Description</a>
        /// </para>
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

    }
}
