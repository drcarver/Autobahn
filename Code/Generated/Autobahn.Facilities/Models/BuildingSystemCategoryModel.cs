//**********************************************************
//* DomainName: Facilities
//* FileName:   BuildingSystemCategoryModel.cs
//***************************************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.Models;

namespace Autobahn.Facilities.Interfaces
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
        /// Reference to an optional instance of the <see cref="IRefBuildingAirDistributionSystemType"/> model
        /// </summary>
        public Guid? RefBuildingAirDistributionSystemTypeId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IRefBuildingCommMgmtComponentSystemType"/> model
        /// </summary>
        public Guid? RefBuildingCommMgmtComponentSystemTypeId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IRefBuildingCoolingGenerationSystemType"/> model
        /// </summary>
        public Guid? RefBuildingCoolingGenerationSystemTypeId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IRefBuildingElectricalSystemType"/> model
        /// </summary>
        public Guid? RefBuildingElectricalSystemTypeId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IRefBuildingFireProtectionSystemType"/> model
        /// </summary>
        public Guid? RefBuildingFireProtectionSystemTypeId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IRefBuildingHeatingGenerationSystemType"/> model
        /// </summary>
        public Guid? RefBuildingHeatingGenerationSystemTypeId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IRefBuildingHVACSystemType"/> model
        /// </summary>
        public Guid? RefBuildingHVACSystemTypeId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IRefBuildingMechanicalConveyingSystemType"/> model
        /// </summary>
        public Guid? RefBuildingMechanicalConveyingSystemTypeId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IRefBuildingMechanicalSystemType"/> model
        /// </summary>
        public Guid? RefBuildingMechanicalSystemTypeId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IRefBuildingPlumbingSystemType"/> model
        /// </summary>
        public Guid? RefBuildingPlumbingSystemTypeId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IRefBuildingSecuritySystemType"/> model
        /// </summary>
        public Guid? RefBuildingSecuritySystemTypeId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IRefBuildingSystemType"/> model
        /// </summary>
        public Guid? RefBuildingSystemTypeId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IRefBuildingTechnologyWiringSystemType"/> model
        /// </summary>
        public Guid? RefBuildingTechnologyWiringSystemTypeId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IRefBuildingVerticalTransportationSystemType"/> model
        /// </summary>
        public Guid? RefBuildingVerticalTransportationSystemTypeId { get; set; }

    }
}
