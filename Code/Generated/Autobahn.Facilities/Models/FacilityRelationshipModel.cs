//**********************************************************
//* DomainName: Facilities
//* FileName:   FacilityRelationshipModel.cs
//***************************************************************************

using Autobahn.Interfaces.Facilities;
using Autobahn.Interfaces.Common;
using Autobahn.Common.Models;

namespace Autobahn.Facilities.Models
{
     /// <summary>
     /// The FacilityRelationship Model
     /// </summary>
    public partial class FacilityRelationshipModel : AutobahnBase, IFacilityRelationship
    {
        /// <summary>
        /// Reference to an optional instance of the <see cref="IFacility"/> model
        /// </summary>
        public Guid FacilityId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IParentFacility"/> model
        /// </summary>
        public Guid ParentFacilityId { get; set; }

    }
}
