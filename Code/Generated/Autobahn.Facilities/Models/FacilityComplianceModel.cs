//**********************************************************
//* DomainName: Facilities
//* FileName:   FacilityComplianceModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.Models;

namespace Autobahn.Facilities.Models
{
     /// <summary>
     /// The FacilityCompliance Model
     /// </summary>
    public partial class FacilityComplianceModel : AutobahnBase, Interfaces.IFacilityCompliance
    {
        /// <summary>
        /// An indication of whether the school, building, site, system, component, equipment, vehicle, or fixture conforms to the requirements or standards specified in federal, state, or local standards or codes or other officially required guidelines or regulations.
        /// </summary>
        public Guid? RefFacilityComplianceStatusId { get; set; }

    }
}
