//**********************************************************
//* DomainName: Autobahn.EarlyLearning
//* FileName:   ELFacilityLicensingModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.Models;

namespace Autobahn.EarlyLearning.Models
{
     /// <summary>
     /// The ELFacilityLicensing Model
     /// </summary>
    public partial class ELFacilityLicensingModel : AutobahnBase, Interfaces.IELFacilityLicensingModel
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="Organization"/> model
        /// </summary>
        public Guid OrganizationId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefELFacilityLicensingStatus"/> model
        /// </summary>
        public Guid? RefELFacilityLicensingStatusId { get; set; }

        /// <summary>
        /// Defines the ELFacilityLicensing.StateLicensedFacilityCapacity nullable property
        /// </summary>
        public System.Int32? StateLicensedFacilityCapacity { get; set; }

        /// <summary>
        /// Defines the ELFacilityLicensing.InitialLicensingDate nullable property
        /// </summary>
        public System.DateTime? InitialLicensingDate { get; set; }

        /// <summary>
        /// Defines the ELFacilityLicensing.ContinuingLicenseDate nullable property
        /// </summary>
        public System.DateTime? ContinuingLicenseDate { get; set; }

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
