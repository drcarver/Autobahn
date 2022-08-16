//***************************************************************************
//* DomainName: Facilities Interfaces (used by both models and View Models
//* FileName:   IFacilityUtilization.cs
//***************************************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.Facilities.Interfaces
{
     /// <summary>
     /// The IFacilityUtilization Interface
     /// </summary>
    public partial interface IFacilityUtilization : IAutobahnBase
    {
        /// <summary>
        /// 
        /// </summary>
        Guid? BuildingHoursOfPublicUsePerWeek { get; set; }

        /// <summary>
        /// 
        /// </summary>
         BuildingNetAreaOfInstructionalSpace { get; set; }

        /// <summary>
        /// 
        /// </summary>
         BuildingNumberOfTeachingStations { get; set; }

        /// <summary>
        /// 
        /// </summary>
         BuildingPublicUsePolicyDescription { get; set; }

        /// <summary>
        /// 
        /// </summary>
         FacilityEnrollmentCapacity { get; set; }

        /// <summary>
        /// 
        /// </summary>
         RecordEndDateTime { get; set; }

        /// <summary>
        /// 
        /// </summary>
         RecordStartDateTime { get; set; }

    }
}
