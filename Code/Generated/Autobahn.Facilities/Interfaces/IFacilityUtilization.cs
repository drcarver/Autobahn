//**********************************************************
//* DomainName: Autobahn.Facilities
//* FileName:   IFacilityUtilization.cs
//**********************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.Facilities.Interfaces
{
     /// <summary>
     /// The IFacilityUtilization
     /// </summary>
    public partial interface IFacilityUtilization : IAutobahnBase
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

    }
}
