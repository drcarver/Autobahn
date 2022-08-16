//**********************************************************
//* DomainName: Facilities
//* FileName:   FacilityDesignModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.Models;

namespace Autobahn.Facilities.Models
{
     /// <summary>
     /// The FacilityDesign Model
     /// </summary>
    public partial class FacilityDesignModel : AutobahnBase, Interfaces.IFacilityDesign
    {
        /// <summary>
        /// 
        /// </summary>
        public  BuildingArchitectName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  BuildingArchitecturalFirmName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  BuildingDateOfCertificateOfOccupancy { get; set; }

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
        public Guid? RefBuildingDesignTypeId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  RefBuildingEnvOrEnergyPerformanceRatingCatId { get; set; }

    }
}
