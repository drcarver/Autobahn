//**********************************************************
//* DomainName: Autobahn.Facilities
//* FileName:   IRefFacilityComplianceStatu.cs
//**********************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.Facilities.Interfaces
{
     /// <summary>
     /// The RefFacilityComplianceStatu Interface
     /// </summary>
    public partial interface IRefFacilityComplianceStatu : IReferenceModel
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="RefFacilityComplianceStatus"/> model
        /// </summary>
        Guid RefFacilityComplianceStatusId { get; set; }

    }
}
