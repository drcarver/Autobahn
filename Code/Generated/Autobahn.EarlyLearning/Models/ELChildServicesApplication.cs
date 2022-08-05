//**********************************************************
//* DomainName: Autobahn.EarlyLearning
//* FileName:   ELChildServicesApplication.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.Models;

namespace Autobahn.EarlyLearning.Models
{
     /// <summary>
     /// The ELChildServicesApplication
     /// </summary>
    public partial class ELChildServicesApplication : AutobahnBase, Interfaces.IELChildServicesApplication
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="OrganizationPersonRole"/> model
        /// </summary>
        public Guid OrganizationPersonRoleId { get; set; }

        /// <summary>
        /// Defines the ELChildServicesApplication.ELApplicationIdentifier non nullable property
        /// </summary>
        public System.String ELApplicationIdentifier { get; set; }

        /// <summary>
        /// Defines the ELChildServicesApplication.ApplicationDate nullable property
        /// </summary>
        public System.DateTime? ApplicationDate { get; set; }

        /// <summary>
        /// Defines the ELChildServicesApplication.ELEnrollmentApplicationDocumentIdentifier non nullable property
        /// </summary>
        public System.String ELEnrollmentApplicationDocumentIdentifier { get; set; }

        /// <summary>
        /// Defines the ELChildServicesApplication.ELEnrollmentApplicationDocumentName non nullable property
        /// </summary>
        public System.String ELEnrollmentApplicationDocumentName { get; set; }

        /// <summary>
        /// Defines the ELChildServicesApplication.ELEnrollmentApplicationDocumentType non nullable property
        /// </summary>
        public System.String ELEnrollmentApplicationDocumentType { get; set; }

        /// <summary>
        /// Defines the ELChildServicesApplication.ELApplicationRequiredDocument nullable property
        /// </summary>
        public System.Boolean? ELApplicationRequiredDocument { get; set; }

        /// <summary>
        /// Defines the ELChildServicesApplication.ELEnrollmentApplicationVerificationDate nullable property
        /// </summary>
        public System.DateTime? ELEnrollmentApplicationVerificationDate { get; set; }

        /// <summary>
        /// Defines the ELChildServicesApplication.ELEnrollmentApplicationVerificationReasonType non nullable property
        /// </summary>
        public System.String ELEnrollmentApplicationVerificationReasonType { get; set; }

        /// <summary>
        /// Defines the ELChildServicesApplication.SitePreferenceRank non nullable property
        /// </summary>
        public System.String SitePreferenceRank { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="DataCollection"/> model
        /// </summary>
        public Guid? DataCollectionId { get; set; }

    }
}
