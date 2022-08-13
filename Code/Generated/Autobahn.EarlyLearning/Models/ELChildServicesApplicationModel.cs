//**********************************************************
//* DomainName: Early Learning (EL)
//* FileName:   ELChildServicesApplicationModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.Models;

namespace Autobahn.EarlyLearning.Models
{
     /// <summary>
     /// The ELChildServicesApplication Model
     /// </summary>
    public partial class ELChildServicesApplicationModel : AutobahnBase, Interfaces.IELChildServicesApplication
    {
        /// <summary>
        /// The year, month and day on which an individual  application is received by the organization.
        /// </summary>
        public System.DateTime? ApplicationDate { get; set; }

        /// <summary>
        /// The year, month and day on which an individual  application is received by the organization.
        /// </summary>
        public System.String ELApplicationIdentifier { get; set; }

        /// <summary>
        /// The year, month and day on which an individual  application is received by the organization.
        /// </summary>
        public System.Boolean? ELApplicationRequiredDocument { get; set; }

        /// <summary>
        /// The year, month and day on which an individual  application is received by the organization.
        /// </summary>
        public System.String ELEnrollmentApplicationDocumentIdentifier { get; set; }

        /// <summary>
        /// The year, month and day on which an individual  application is received by the organization.
        /// </summary>
        public System.String ELEnrollmentApplicationDocumentName { get; set; }

        /// <summary>
        /// The year, month and day on which an individual  application is received by the organization.
        /// </summary>
        public System.String ELEnrollmentApplicationDocumentType { get; set; }

        /// <summary>
        /// The year, month and day on which an individual  application is received by the organization.
        /// </summary>
        public System.DateTime? ELEnrollmentApplicationVerificationDate { get; set; }

        /// <summary>
        /// The year, month and day on which an individual  application is received by the organization.
        /// </summary>
        public System.String ELEnrollmentApplicationVerificationReasonType { get; set; }

        /// <summary>
        /// The year, month and day on which an individual  application is received by the organization.
        /// </summary>
        public Guid OrganizationPersonRoleId { get; set; }

        /// <summary>
        /// The year, month and day on which an individual  application is received by the organization.
        /// </summary>
        public System.String SitePreferenceRank { get; set; }

    }
}
