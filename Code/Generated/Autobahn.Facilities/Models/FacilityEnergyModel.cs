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
        /// 
        /// </summary>
        public Guid? BuildingEnergyServiceCompanyName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  RecordEndDateTime { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  RecordStartDateTime { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  RefBuildingEnergySourceTypeId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  RefFacilityUtilityProviderTypeId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  RefFacilityUtilityTypeId { get; set; }

    }
}
