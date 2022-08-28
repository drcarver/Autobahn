//***************************************************************************
//* DomainName: Facilities Interfaces (used by both models and View Models
//* FileName:   IFacilityLocation.cs
//***************************************************************************

using Autobahn.Education.Interfaces.Common;

namespace Autobahn.Education.Interfaces.Facilities
{
     /// <summary>
     /// The IFacilityLocation Interface
     /// </summary>
    public partial interface IFacilityLocation : IAutobahnBase
    {
        #region IFacilityLocation
        /// <summary>
        /// Reference to an optional instance of the <see cref="IFacility"/> model
        /// </summary>
        Guid FacilityId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="ILocation"/> model
        /// </summary>
        Guid LocationId { get; set; }

        #endregion
    }
}
