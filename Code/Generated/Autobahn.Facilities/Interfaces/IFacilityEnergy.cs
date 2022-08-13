//***************************************************************************
//* DomainName: Facilities Interfaces (used by both models and View Models
//* FileName:   IFacilityEnergy.cs
//***************************************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.Facilities.Interfaces
{
     /// <summary>
     /// The IFacilityEnergy Interface
     /// </summary>
    public partial interface IFacilityEnergy : IAutobahnBase
    {
        /// <summary>
        /// The name of the company that designs, procures, finances, installs, maintains, and guarantees the performance of energy conservation measures in an owner's facility or facilities.
        /// </summary>
        System.String BuildingEnergyServiceCompanyName { get; set; }

        /// <summary>
        /// The name of the company that designs, procures, finances, installs, maintains, and guarantees the performance of energy conservation measures in an owner's facility or facilities.
        /// </summary>
        Guid FacilityId { get; set; }

        /// <summary>
        /// The name of the company that designs, procures, finances, installs, maintains, and guarantees the performance of energy conservation measures in an owner's facility or facilities.
        /// </summary>
        Guid? RefBuildingEnergySourceTypeId { get; set; }

        /// <summary>
        /// The name of the company that designs, procures, finances, installs, maintains, and guarantees the performance of energy conservation measures in an owner's facility or facilities.
        /// </summary>
        Guid? RefFacilityUtilityProviderTypeId { get; set; }

        /// <summary>
        /// The name of the company that designs, procures, finances, installs, maintains, and guarantees the performance of energy conservation measures in an owner's facility or facilities.
        /// </summary>
        Guid? RefFacilityUtilityTypeId { get; set; }

    }
}
