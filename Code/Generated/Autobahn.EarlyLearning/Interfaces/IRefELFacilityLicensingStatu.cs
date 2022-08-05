//**********************************************************
//* DomainName: Autobahn.EarlyLearning
//* FileName:   IRefELFacilityLicensingStatu.cs
//**********************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.EarlyLearning.Interfaces
{
     /// <summary>
     /// The RefELFacilityLicensingStatu Interface
     /// </summary>
    public partial interface IRefELFacilityLicensingStatu : IReferenceModel
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="RefELFacilityLicensingStatus"/> model
        /// </summary>
        Guid RefELFacilityLicensingStatusId { get; set; }

    }
}
