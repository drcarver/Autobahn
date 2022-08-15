//***************************************************************************
//* DomainName: Facilities Interfaces (used by both models and View Models
//* FileName:   IFacilityCompliance.cs
//***************************************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.Facilities.Interfaces
{
     /// <summary>
     /// The IFacilityCompliance Interface
     /// </summary>
    public partial interface IFacilityCompliance : IAutobahnBase
    {
        /// <summary>
        /// An indication of whether the school, building, site, system, component, equipment, vehicle, or fixture conforms to the requirements or standards specified in federal, state, or local standards or codes or other officially required guidelines or regulations.
        /// </summary>
        Guid? RefFacilityComplianceStatusId { get; set; }

    }
}
