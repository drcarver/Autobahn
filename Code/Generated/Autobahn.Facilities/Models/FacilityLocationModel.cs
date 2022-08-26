//**********************************************************
//* DomainName: Facilities
//* FileName:   FacilityLocationModel.cs
//***************************************************************************

using Autobahn.Interfaces.Facilities;
using Autobahn.Interfaces.Common;
using Autobahn.Common.Models;

namespace Autobahn.Facilities.Models
{
     /// <summary>
     /// The FacilityLocation Model
     /// </summary>
    public partial class FacilityLocationModel : AutobahnBase, IFacilityLocation
    {
        /// <summary>
        /// Reference to an optional instance of the <see cref="IFacility"/> model
        /// </summary>
        public Guid FacilityId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="ILocation"/> model
        /// </summary>
        public Guid LocationId { get; set; }

    }
}
