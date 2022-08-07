//**********************************************************
//* DomainName: Autobahn.Facilities
//* FileName:   IFacilityRelationshipModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.Facilities.Interfaces
{
     /// <summary>
     /// The IFacilityRelationshipModel Interface
     /// </summary>
    public partial interface IFacilityRelationshipModel : IAutobahnBase
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="Parent_Facility"/> model
        /// </summary>
        Guid Parent_FacilityId { get; set; }

        /// <summary>
        /// Reference to a required instance of the <see cref="Facility"/> model
        /// </summary>
        Guid FacilityId { get; set; }

    }
}
