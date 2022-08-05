//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   RefGunFreeSchoolsActReportingStatu.cs
//**********************************************************

using Autobahn.Common.Models;
using Autobahn.Common.Interfaces;

namespace Autobahn.Common.Models
{
     /// <summary>
     /// The RefGunFreeSchoolsActReportingStatu Model
     /// </summary>
    public partial class RefGunFreeSchoolsActReportingStatu : ReferenceModelBase, IRefGunFreeSchoolsActReportingStatu
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="RefGunFreeSchoolsActReportingStatus"/> model
        /// </summary>
        public Guid RefGunFreeSchoolsActReportingStatusId { get; set; }

    }
}
