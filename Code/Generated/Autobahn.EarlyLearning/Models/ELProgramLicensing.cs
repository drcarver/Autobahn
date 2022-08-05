//**********************************************************
//* DomainName: Autobahn.EarlyLearning
//* FileName:   ELProgramLicensing.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.Models;

namespace Autobahn.EarlyLearning.Models
{
     /// <summary>
     /// The ELProgramLicensing
     /// </summary>
    public partial class ELProgramLicensing : AutobahnBase, Interfaces.IELProgramLicensing
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="Organization"/> model
        /// </summary>
        public Guid OrganizationId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefELProgramLicenseStatus"/> model
        /// </summary>
        public Guid? RefELProgramLicenseStatusId { get; set; }

        /// <summary>
        /// Defines the ELProgramLicensing.InitialLicenseDate nullable property
        /// </summary>
        public System.DateTime? InitialLicenseDate { get; set; }

        /// <summary>
        /// Defines the ELProgramLicensing.ContinuingLicenseDate nullable property
        /// </summary>
        public System.DateTime? ContinuingLicenseDate { get; set; }

        /// <summary>
        /// Defines the ELProgramLicensing.LicenseSuspensionStatus nullable property
        /// </summary>
        public System.Boolean? LicenseSuspensionStatus { get; set; }

        /// <summary>
        /// Defines the ELProgramLicensing.LicenseRevocationStatus nullable property
        /// </summary>
        public System.Boolean? LicenseRevocationStatus { get; set; }

        /// <summary>
        /// Defines the ELProgramLicensing.NumberOfFatalities nullable property
        /// </summary>
        public System.Int32? NumberOfFatalities { get; set; }

        /// <summary>
        /// Defines the ELProgramLicensing.NumberOfInjuries nullable property
        /// </summary>
        public System.Int32? NumberOfInjuries { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefLicenseExempt"/> model
        /// </summary>
        public Guid? RefLicenseExemptId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="DataCollection"/> model
        /// </summary>
        public Guid? DataCollectionId { get; set; }

    }
}
