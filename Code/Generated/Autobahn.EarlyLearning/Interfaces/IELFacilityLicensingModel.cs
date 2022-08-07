//**********************************************************
//* DomainName: Autobahn.EarlyLearning
//* FileName:   IELFacilityLicensingModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.EarlyLearning.Interfaces
{
     /// <summary>
     /// The IELFacilityLicensingModel Interface
     /// </summary>
    public partial interface IELFacilityLicensingModel : IAutobahnBase
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="Organization"/> model
        /// </summary>
        Guid OrganizationId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefELFacilityLicensingStatus"/> model
        /// </summary>
        Guid? RefELFacilityLicensingStatusId { get; set; }

        /// <summary>
        /// Defines the ELFacilityLicensing.StateLicensedFacilityCapacity nullable property
        /// </summary>
        System.Int32? StateLicensedFacilityCapacity { get; set; }

        /// <summary>
        /// Defines the ELFacilityLicensing.InitialLicensingDate nullable property
        /// </summary>
        System.DateTime? InitialLicensingDate { get; set; }

        /// <summary>
        /// Defines the ELFacilityLicensing.ContinuingLicenseDate nullable property
        /// </summary>
        System.DateTime? ContinuingLicenseDate { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefLicenseExempt"/> model
        /// </summary>
        Guid? RefLicenseExemptId { get; set; }

    }
}
