//***************************************************************************
//* DomainName: Early Learning (EL) Interfaces (used by both models and View Models
//* FileName:   IELChildServicesApplication.cs
//***************************************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.EarlyLearning.Interfaces
{
     /// <summary>
     /// The IELChildServicesApplication Interface
     /// </summary>
    public partial interface IELChildServicesApplication : IAutobahnBase
    {
        /// <summary>
        /// The year, month and day on which an individual  application is received by the organization.
        /// </summary>
        System.DateTime? ApplicationDate { get; set; }

        /// <summary>
        /// The year, month and day on which an individual  application is received by the organization.
        /// </summary>
        System.String ELApplicationIdentifier { get; set; }

        /// <summary>
        /// The year, month and day on which an individual  application is received by the organization.
        /// </summary>
        System.Boolean? ELApplicationRequiredDocument { get; set; }

        /// <summary>
        /// The year, month and day on which an individual  application is received by the organization.
        /// </summary>
        System.String ELEnrollmentApplicationDocumentIdentifier { get; set; }

        /// <summary>
        /// The year, month and day on which an individual  application is received by the organization.
        /// </summary>
        System.String ELEnrollmentApplicationDocumentName { get; set; }

        /// <summary>
        /// The year, month and day on which an individual  application is received by the organization.
        /// </summary>
        System.String ELEnrollmentApplicationDocumentType { get; set; }

        /// <summary>
        /// The year, month and day on which an individual  application is received by the organization.
        /// </summary>
        System.DateTime? ELEnrollmentApplicationVerificationDate { get; set; }

        /// <summary>
        /// The year, month and day on which an individual  application is received by the organization.
        /// </summary>
        System.String ELEnrollmentApplicationVerificationReasonType { get; set; }

        /// <summary>
        /// The year, month and day on which an individual  application is received by the organization.
        /// </summary>
        Guid OrganizationPersonRoleId { get; set; }

        /// <summary>
        /// The year, month and day on which an individual  application is received by the organization.
        /// </summary>
        System.String SitePreferenceRank { get; set; }

    }
}
