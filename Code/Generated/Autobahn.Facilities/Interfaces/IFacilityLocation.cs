//**********************************************************
//* DomainName: Autobahn.Facilities
//* FileName:   IFacilityLocation.cs
//**********************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.Facilities.Interfaces
{
     /// <summary>
     /// The IFacilityLocation
     /// </summary>
    public partial interface IFacilityLocation : IAutobahnBase
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="Facility"/> model
        /// </summary>
        Guid FacilityId { get; set; }

        /// <summary>
        /// Reference to a required instance of the <see cref="Location"/> model
        /// </summary>
        Guid LocationId { get; set; }

    }
}
