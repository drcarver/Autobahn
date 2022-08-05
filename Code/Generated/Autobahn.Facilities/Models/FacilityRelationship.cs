//**********************************************************
//* DomainName: Autobahn.Facilities
//* FileName:   FacilityRelationship.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.Models;

namespace Autobahn.Facilities.Models
{
     /// <summary>
     /// The FacilityRelationship
     /// </summary>
    public partial class FacilityRelationship : AutobahnBase, Interfaces.IFacilityRelationship
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="Parent_Facility"/> model
        /// </summary>
        public Guid Parent_FacilityId { get; set; }

        /// <summary>
        /// Reference to a required instance of the <see cref="Facility"/> model
        /// </summary>
        public Guid FacilityId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="DataCollection"/> model
        /// </summary>
        public Guid? DataCollectionId { get; set; }

    }
}
