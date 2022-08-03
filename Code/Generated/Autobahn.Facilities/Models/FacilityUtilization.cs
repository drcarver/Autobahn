//**********************************************************
//* DomainName: Autobahn.Facilities
//* FileName:   FacilityUtilization.cs
//**********************************************************

using Autobahn.Facilities.Interfaces;

namespace Autobahn.Facilities.Models
{
     /// <summary>
     /// The FacilityUtilization
     /// </summary>
    public partial class FacilityUtilization : IFacilityUtilization
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
        /// Defines the FacilityUtilization.RecordStartDateTime nullable property
        /// </summary>
        public System.DateTime? RecordStartDateTime { get; set; }

        /// <summary>
        /// Defines the FacilityUtilization.RecordEndDateTime nullable property
        /// </summary>
        public System.DateTime? RecordEndDateTime { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RecordStatus"/> model
        /// </summary>
        public Guid? RecordStatusId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="DataCollection"/> model
        /// </summary>
        public Guid? DataCollectionId { get; set; }

    }
}
