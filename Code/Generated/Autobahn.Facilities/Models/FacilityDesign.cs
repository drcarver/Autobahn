//**********************************************************
//* DomainName: Autobahn.Facilities
//* FileName:   FacilityDesign.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.Models;

namespace Autobahn.Facilities.Models
{
     /// <summary>
     /// The FacilityDesign
     /// </summary>
    public partial class FacilityDesign : AutobahnBase, Interfaces.IFacilityDesign
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="Facility"/> model
        /// </summary>
        public Guid FacilityId { get; set; }

        /// <summary>
        /// Defines the FacilityDesign.BuildingArchitectName non nullable property
        /// </summary>
        public System.String BuildingArchitectName { get; set; }

        /// <summary>
        /// Defines the FacilityDesign.BuildingArchitecturalFirmName non nullable property
        /// </summary>
        public System.String BuildingArchitecturalFirmName { get; set; }

        /// <summary>
        /// Defines the FacilityDesign.BuildingDateOfCertificateOfOccupancy nullable property
        /// </summary>
        public System.DateTime? BuildingDateOfCertificateOfOccupancy { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefBuildingDesignType"/> model
        /// </summary>
        public Guid? RefBuildingDesignTypeId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefBuildingEnvOrEnergyPerformanceRatingCat"/> model
        /// </summary>
        public Guid? RefBuildingEnvOrEnergyPerformanceRatingCatId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="DataCollection"/> model
        /// </summary>
        public Guid? DataCollectionId { get; set; }

    }
}
