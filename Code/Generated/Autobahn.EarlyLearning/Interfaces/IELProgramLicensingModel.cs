//**********************************************************
//* DomainName: Autobahn.EarlyLearning
//* FileName:   IELProgramLicensingModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.EarlyLearning.Interfaces
{
     /// <summary>
     /// The IELProgramLicensingModel Interface
     /// </summary>
    public partial interface IELProgramLicensingModel : IAutobahnBase
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="Organization"/> model
        /// </summary>
        Guid OrganizationId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefELProgramLicenseStatus"/> model
        /// </summary>
        Guid? RefELProgramLicenseStatusId { get; set; }

        /// <summary>
        /// Defines the ELProgramLicensing.InitialLicenseDate nullable property
        /// </summary>
        System.DateTime? InitialLicenseDate { get; set; }

        /// <summary>
        /// Defines the ELProgramLicensing.ContinuingLicenseDate nullable property
        /// </summary>
        System.DateTime? ContinuingLicenseDate { get; set; }

        /// <summary>
        /// Defines the ELProgramLicensing.LicenseSuspensionStatus nullable property
        /// </summary>
        System.Boolean? LicenseSuspensionStatus { get; set; }

        /// <summary>
        /// Defines the ELProgramLicensing.LicenseRevocationStatus nullable property
        /// </summary>
        System.Boolean? LicenseRevocationStatus { get; set; }

        /// <summary>
        /// Defines the ELProgramLicensing.NumberOfFatalities nullable property
        /// </summary>
        System.Int32? NumberOfFatalities { get; set; }

        /// <summary>
        /// Defines the ELProgramLicensing.NumberOfInjuries nullable property
        /// </summary>
        System.Int32? NumberOfInjuries { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefLicenseExempt"/> model
        /// </summary>
        Guid? RefLicenseExemptId { get; set; }

    }
}
