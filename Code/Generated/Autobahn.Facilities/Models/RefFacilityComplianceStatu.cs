//**********************************************************
//* DomainName: Autobahn.Facilities
//* FileName:   RefFacilityComplianceStatu.cs
//**********************************************************

using Autobahn.Common.Models;
using Autobahn.Facilities.Interfaces;

namespace Autobahn.Facilities.Models
{
     /// <summary>
     /// The RefFacilityComplianceStatu Model
     /// </summary>
    public partial class RefFacilityComplianceStatu : ReferenceModelBase, IRefFacilityComplianceStatu
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="RefFacilityComplianceStatus"/> model
        /// </summary>
        public Guid RefFacilityComplianceStatusId { get; set; }

    }
}
