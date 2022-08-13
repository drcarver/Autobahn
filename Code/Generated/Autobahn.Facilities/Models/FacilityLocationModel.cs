//**********************************************************
//* DomainName: Facilities
//* FileName:   FacilityLocationModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.Models;

namespace Autobahn.Facilities.Models
{
     /// <summary>
     /// The FacilityLocation Model
     /// </summary>
    public partial class FacilityLocationModel : AutobahnBase, Interfaces.IFacilityLocation
    {
        /// <summary>
        /// The start date and, optionally, time that a record is active as used to support version control.
        /// </summary>
        public Guid FacilityId { get; set; }

        /// <summary>
        /// The start date and, optionally, time that a record is active as used to support version control.
        /// </summary>
        public Guid LocationId { get; set; }

    }
}
