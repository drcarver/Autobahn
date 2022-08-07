//**********************************************************
//* DomainName: Autobahn.Facilities
//* FileName:   IFacilityEnergyModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.Facilities.Interfaces
{
     /// <summary>
     /// The IFacilityEnergyModel Interface
     /// </summary>
    public partial interface IFacilityEnergyModel : IAutobahnBase
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="Facility"/> model
        /// </summary>
        Guid FacilityId { get; set; }

        /// <summary>
        /// Defines the FacilityEnergy.BuildingEnergyServiceCompanyName non nullable property
        /// </summary>
        System.String BuildingEnergyServiceCompanyName { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefBuildingEnergySourceType"/> model
        /// </summary>
        Guid? RefBuildingEnergySourceTypeId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefFacilityUtilityProviderType"/> model
        /// </summary>
        Guid? RefFacilityUtilityProviderTypeId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefFacilityUtilityType"/> model
        /// </summary>
        Guid? RefFacilityUtilityTypeId { get; set; }

    }
}
