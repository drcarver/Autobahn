//**********************************************************
//* DomainName: Facilities
//* FileName:   FacilityRelationshipModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.Models;

namespace Autobahn.Facilities.Models
{
     /// <summary>
     /// The FacilityRelationship Model
     /// </summary>
    public partial class FacilityRelationshipModel : AutobahnBase, Interfaces.IFacilityRelationship
    {
        /// <summary>
        /// The start date and, optionally, time that a record is active as used to support version control.
        /// </summary>
        public Guid FacilityId { get; set; }

        /// <summary>
        /// The start date and, optionally, time that a record is active as used to support version control.
        /// </summary>
        public Guid Parent_FacilityId { get; set; }

    }
}
