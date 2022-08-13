//**********************************************************
//* DomainName: Facilities
//* FileName:   FacilityEnergyModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.Models;

namespace Autobahn.Facilities.Models
{
     /// <summary>
     /// The FacilityEnergy Model
     /// </summary>
    public partial class FacilityEnergyModel : AutobahnBase, Interfaces.IFacilityEnergy
    {
        /// <summary>
        /// The name of the company that designs, procures, finances, installs, maintains, and guarantees the performance of energy conservation measures in an owner's facility or facilities.
        /// </summary>
        public System.String BuildingEnergyServiceCompanyName { get; set; }

        /// <summary>
        /// The name of the company that designs, procures, finances, installs, maintains, and guarantees the performance of energy conservation measures in an owner's facility or facilities.
        /// </summary>
        public Guid FacilityId { get; set; }

        /// <summary>
        /// The name of the company that designs, procures, finances, installs, maintains, and guarantees the performance of energy conservation measures in an owner's facility or facilities.
        /// </summary>
        public Guid? RefBuildingEnergySourceTypeId { get; set; }

        /// <summary>
        /// The name of the company that designs, procures, finances, installs, maintains, and guarantees the performance of energy conservation measures in an owner's facility or facilities.
        /// </summary>
        public Guid? RefFacilityUtilityProviderTypeId { get; set; }

        /// <summary>
        /// The name of the company that designs, procures, finances, installs, maintains, and guarantees the performance of energy conservation measures in an owner's facility or facilities.
        /// </summary>
        public Guid? RefFacilityUtilityTypeId { get; set; }

    }
}
