//***************************************************************************
//* DomainName: Facilities Interfaces (used by both models and View Models
//* FileName:   IFacilityRelationship.cs
//***************************************************************************

using Autobahn.Education.Interfaces.Common;

namespace Autobahn.Education.Interfaces.Facilities
{
     /// <summary>
     /// The IFacilityRelationship Interface
     /// </summary>
    public partial interface IFacilityRelationship : IAutobahnBase
    {
        #region IFacilityRelationship
        /// <summary>
        /// Reference to an optional instance of the <see cref="IFacility"/> model
        /// </summary>
        Guid FacilityId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IParentFacility"/> model
        /// </summary>
        Guid ParentFacilityId { get; set; }

        #endregion
    }
}
