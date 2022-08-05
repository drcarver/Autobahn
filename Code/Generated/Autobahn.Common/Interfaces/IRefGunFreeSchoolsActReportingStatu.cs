//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   IRefGunFreeSchoolsActReportingStatu.cs
//**********************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.Common.Interfaces
{
     /// <summary>
     /// The RefGunFreeSchoolsActReportingStatu Interface
     /// </summary>
    public partial interface IRefGunFreeSchoolsActReportingStatu : IReferenceModel
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="RefGunFreeSchoolsActReportingStatus"/> model
        /// </summary>
        Guid RefGunFreeSchoolsActReportingStatusId { get; set; }

    }
}
