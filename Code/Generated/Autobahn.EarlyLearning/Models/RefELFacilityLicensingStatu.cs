//**********************************************************
//* DomainName: Autobahn.EarlyLearning
//* FileName:   RefELFacilityLicensingStatu.cs
//**********************************************************

using Autobahn.Common.Models;
using Autobahn.EarlyLearning.Interfaces;

namespace Autobahn.EarlyLearning.Models
{
     /// <summary>
     /// The RefELFacilityLicensingStatu Model
     /// </summary>
    public partial class RefELFacilityLicensingStatu : ReferenceModelBase, IRefELFacilityLicensingStatu
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="RefELFacilityLicensingStatus"/> model
        /// </summary>
        public Guid RefELFacilityLicensingStatusId { get; set; }

    }
}
