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
        /// The number of hours that all or part of a building is used for purposes other than general education by the community or other organizations.
        /// </summary>
        System.Int32? BuildingHoursOfPublicUsePerWeek { get; set; }

    }
}
