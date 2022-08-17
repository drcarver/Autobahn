//***************************************************************************
//* DomainName: Early Learning (EL) Interfaces (used by both models and View Models
//* FileName:   IELChildServicesApplication.cs
//* Name:       Application Date
//* Definition: 
//***************************************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.EarlyLearning.Interfaces
{
     /// <summary>
     /// 
     /// </summary>
    public partial interface IELChildServicesApplication : IAutobahnBase
    {
        /// <summary>
        /// Application Date
        /// <para>
        /// The year, month and day on which an individual  application is received by the organization.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19323">Application Date</a>
        /// </para>
        /// </summary>
        System.DateTime? ApplicationDate { get; set; }

        /// <summary>
        /// Early Learning Application Identifier
        /// <para>
        /// Identifier for the application for enrollment or direct services filled out on behalf of a child
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20576">Early Learning Application Identifier</a>
        /// </para>
        /// </summary>
        System.String ELApplicationIdentifier { get; set; }

        /// <summary>
        /// Early Learning Application Required Document
        /// <para>
        /// Identifies a specific document required for enrollment.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20578">Early Learning Application Required Document</a>
        /// </para>
        /// </summary>
        System.Boolean? ELApplicationRequiredDocument { get; set; }

        /// <summary>
        /// Early Learning Enrollment Application Document Identifier
        /// <para>
        /// Identifier for an enrollment application document record.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20572">Early Learning Enrollment Application Document Identifier</a>
        /// </para>
        /// </summary>
        System.String ELEnrollmentApplicationDocumentIdentifier { get; set; }

        /// <summary>
        /// Early Learning Enrollment Application Document Name
        /// <para>
        /// Document name for an enrollment application document record.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20573">Early Learning Enrollment Application Document Name</a>
        /// </para>
        /// </summary>
        System.String ELEnrollmentApplicationDocumentName { get; set; }

        /// <summary>
        /// Early Learning Enrollment Application Document Type
        /// <para>
        /// Document type for an enrollment application document record.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20574">Early Learning Enrollment Application Document Type</a>
        /// </para>
        /// </summary>
        System.String ELEnrollmentApplicationDocumentType { get; set; }

        /// <summary>
        /// Early Learning Enrollment Application Verification Date
        /// <para>
        /// Date the required document was verified for the enrollment application
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20571">Early Learning Enrollment Application Verification Date</a>
        /// </para>
        /// </summary>
        System.DateTime? ELEnrollmentApplicationVerificationDate { get; set; }

        /// <summary>
        /// Early Learning Enrollment Application Verification Reason Type
        /// <para>
        /// Identifies the reason for verification of enrollment application information
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20579">Early Learning Enrollment Application Verification Reason Type</a>
        /// </para>
        /// </summary>
        System.String ELEnrollmentApplicationVerificationReasonType { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IOrganizationPersonRole"/> model
        /// </summary>
        Guid OrganizationPersonRoleId { get; set; }

        /// <summary>
        /// Site Preference Rank
        /// <para>
        /// The applicant preference that the family has for the program sites.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20608">Site Preference Rank</a>
        /// </para>
        /// </summary>
        System.String SitePreferenceRank { get; set; }

    }
}
