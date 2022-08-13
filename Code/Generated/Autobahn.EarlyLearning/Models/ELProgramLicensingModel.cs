//**********************************************************
//* DomainName: Early Learning (EL)
//* FileName:   ELProgramLicensingModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.Models;

namespace Autobahn.EarlyLearning.Models
{
     /// <summary>
     /// The ELProgramLicensing Model
     /// </summary>
    public partial class ELProgramLicensingModel : AutobahnBase, Interfaces.IELProgramLicensing
    {
        /// <summary>
        /// The year, month and day on which a program or center received its initial license.
        /// </summary>
        public System.DateTime? ContinuingLicenseDate { get; set; }

        /// <summary>
        /// The year, month and day on which a program or center received its initial license.
        /// </summary>
        public System.DateTime? InitialLicenseDate { get; set; }

        /// <summary>
        /// The year, month and day on which a program or center received its initial license.
        /// </summary>
        public System.Boolean? LicenseRevocationStatus { get; set; }

        /// <summary>
        /// The year, month and day on which a program or center received its initial license.
        /// </summary>
        public System.Boolean? LicenseSuspensionStatus { get; set; }

        /// <summary>
        /// The year, month and day on which a program or center received its initial license.
        /// </summary>
        public System.Int32? NumberOfFatalities { get; set; }

        /// <summary>
        /// The year, month and day on which a program or center received its initial license.
        /// </summary>
        public System.Int32? NumberOfInjuries { get; set; }

        /// <summary>
        /// The year, month and day on which a program or center received its initial license.
        /// </summary>
        public Guid OrganizationId { get; set; }

        /// <summary>
        /// The year, month and day on which a program or center received its initial license.
        /// </summary>
        public Guid? RefELProgramLicenseStatusId { get; set; }

        /// <summary>
        /// The year, month and day on which a program or center received its initial license.
        /// </summary>
        public Guid? RefLicenseExemptId { get; set; }

    }
}
