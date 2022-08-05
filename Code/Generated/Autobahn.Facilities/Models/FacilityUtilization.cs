//**********************************************************
//* DomainName: Autobahn.Facilities
//* FileName:   FacilityUtilization.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.Models;

namespace Autobahn.Facilities.Models
{
     /// <summary>
     /// The FacilityUtilization
     /// </summary>
    public partial class FacilityUtilization : AutobahnBase, Interfaces.IFacilityUtilization
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="Facility"/> model
        /// </summary>
        public Guid FacilityId { get; set; }

        /// <summary>
        /// Defines the FacilityUtilization.BuildingHoursOfPublicUsePerWeek nullable property
        /// </summary>
        public System.Int32? BuildingHoursOfPublicUsePerWeek { get; set; }

        /// <summary>
        /// Defines the FacilityUtilization.BuildingNetAreaOfInstructionalSpace nullable property
        /// </summary>
        public System.Decimal? BuildingNetAreaOfInstructionalSpace { get; set; }

        /// <summary>
        /// Defines the FacilityUtilization.BuildingNumberOfTeachingStations nullable property
        /// </summary>
        public System.Int32? BuildingNumberOfTeachingStations { get; set; }

        /// <summary>
        /// Defines the FacilityUtilization.BuildingPublicUsePolicyDescription non nullable property
        /// </summary>
        public System.String BuildingPublicUsePolicyDescription { get; set; }

        /// <summary>
        /// Defines the FacilityUtilization.FacilityEnrollmentCapacity nullable property
        /// </summary>
        public System.Int32? FacilityEnrollmentCapacity { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="DataCollection"/> model
        /// </summary>
        public Guid? DataCollectionId { get; set; }

    }
}
