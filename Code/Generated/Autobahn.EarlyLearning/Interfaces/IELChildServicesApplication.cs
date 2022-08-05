//**********************************************************
//* DomainName: Autobahn.EarlyLearning
//* FileName:   IELChildServicesApplication.cs
//**********************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.EarlyLearning.Interfaces
{
     /// <summary>
     /// The IELChildServicesApplication
     /// </summary>
    public partial interface IELChildServicesApplication : IAutobahnBase
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="OrganizationPersonRole"/> model
        /// </summary>
        Guid OrganizationPersonRoleId { get; set; }

        /// <summary>
        /// Defines the ELChildServicesApplication.ELApplicationIdentifier non nullable property
        /// </summary>
        System.String ELApplicationIdentifier { get; set; }

        /// <summary>
        /// Defines the ELChildServicesApplication.ApplicationDate nullable property
        /// </summary>
        System.DateTime? ApplicationDate { get; set; }

        /// <summary>
        /// Defines the ELChildServicesApplication.ELEnrollmentApplicationDocumentIdentifier non nullable property
        /// </summary>
        System.String ELEnrollmentApplicationDocumentIdentifier { get; set; }

        /// <summary>
        /// Defines the ELChildServicesApplication.ELEnrollmentApplicationDocumentName non nullable property
        /// </summary>
        System.String ELEnrollmentApplicationDocumentName { get; set; }

        /// <summary>
        /// Defines the ELChildServicesApplication.ELEnrollmentApplicationDocumentType non nullable property
        /// </summary>
        System.String ELEnrollmentApplicationDocumentType { get; set; }

        /// <summary>
        /// Defines the ELChildServicesApplication.ELApplicationRequiredDocument nullable property
        /// </summary>
        System.Boolean? ELApplicationRequiredDocument { get; set; }

        /// <summary>
        /// Defines the ELChildServicesApplication.ELEnrollmentApplicationVerificationDate nullable property
        /// </summary>
        System.DateTime? ELEnrollmentApplicationVerificationDate { get; set; }

        /// <summary>
        /// Defines the ELChildServicesApplication.ELEnrollmentApplicationVerificationReasonType non nullable property
        /// </summary>
        System.String ELEnrollmentApplicationVerificationReasonType { get; set; }

        /// <summary>
        /// Defines the ELChildServicesApplication.SitePreferenceRank non nullable property
        /// </summary>
        System.String SitePreferenceRank { get; set; }

    }
}
