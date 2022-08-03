//**********************************************************
//* DomainName: Autobahn.Facilities
//* FileName:   IFacilityUtilization.cs
//**********************************************************

namespace Autobahn.Facilities.Interfaces
{
     /// <summary>
     /// The IFacilityUtilization
     /// </summary>
    public partial interface IFacilityUtilization
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="Facility"/> model
        /// </summary>
        Guid FacilityId { get; set; }

        /// <summary>
        /// Defines the FacilityUtilization.BuildingHoursOfPublicUsePerWeek nullable property
        /// </summary>
        System.Int32? BuildingHoursOfPublicUsePerWeek { get; set; }

        /// <summary>
        /// Defines the FacilityUtilization.BuildingNetAreaOfInstructionalSpace nullable property
        /// </summary>
        System.Decimal? BuildingNetAreaOfInstructionalSpace { get; set; }

        /// <summary>
        /// Defines the FacilityUtilization.BuildingNumberOfTeachingStations nullable property
        /// </summary>
        System.Int32? BuildingNumberOfTeachingStations { get; set; }

        /// <summary>
        /// Defines the FacilityUtilization.BuildingPublicUsePolicyDescription non nullable property
        /// </summary>
        System.String BuildingPublicUsePolicyDescription { get; set; }

        /// <summary>
        /// Defines the FacilityUtilization.FacilityEnrollmentCapacity nullable property
        /// </summary>
        System.Int32? FacilityEnrollmentCapacity { get; set; }

        /// <summary>
        /// Defines the FacilityUtilization.RecordStartDateTime nullable property
        /// </summary>
        System.DateTime? RecordStartDateTime { get; set; }

        /// <summary>
        /// Defines the FacilityUtilization.RecordEndDateTime nullable property
        /// </summary>
        System.DateTime? RecordEndDateTime { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RecordStatus"/> model
        /// </summary>
        Guid? RecordStatusId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="DataCollection"/> model
        /// </summary>
        Guid? DataCollectionId { get; set; }

    }
}
