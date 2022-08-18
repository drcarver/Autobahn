//***************************************************************************
//* DomainName: Elementary and Secondary (K12) Interfaces (used by both models and View Models
//* FileName:   IK12StudentEnrollment.cs
//***************************************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.K12.Interfaces
{
     /// <summary>
     /// The IK12StudentEnrollment Interface
     /// </summary>
    public partial interface IK12StudentEnrollment : IAutobahnBase
    {
        /// <summary>
        /// Displaced Student Status
        /// <para>
        /// A student who was enrolled, or eligible for enrollment, but has enrolled in another place because of a crisis.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19603">Displaced Student Status</a>
        /// </para>
        /// </summary>
        System.Boolean? DisplacedStudentStatus { get; set; }

        /// <summary>
        /// First Entry Date into a US School
        /// <para>
        /// The year, month and day of a person's initial enrollment into a United States school.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19520">First Entry Date into a US School</a>
        /// </para>
        /// </summary>
        System.DateTime? FirstEntryDateIntoUSSchool { get; set; }

        /// <summary>
        /// National School Lunch Program Direct Certification Indicator
        /// <para>
        /// Indicates that the student's National School Lunch Program (NSLP) eligibility has been determined through direct certification.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20635">National School Lunch Program Direct Certification Indicator</a>
        /// </para>
        /// </summary>
        System.Boolean? NSLPDirectCertificationIndicator { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IOrganizationPersonRole"/> model
        /// </summary>
        Guid OrganizationPersonRoleId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefDirectoryInformationBlockStatus"/> model
        /// </summary>
        Guid? RefDirectoryInformationBlockStatusId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefEndOfTermStatus"/> model
        /// </summary>
        Guid? RefEndOfTermStatusId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefEnrollmentStatus"/> model
        /// </summary>
        Guid? RefEnrollmentStatusId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefEntryGradeLevel"/> model
        /// </summary>
        Guid? RefEntryGradeLevelId { get; set; }

        /// <summary>
        /// Entry Type
        /// <para>
        /// The process by which a student enters a school during a given academic session.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19099">Entry Type</a>
        /// </para>
        /// </summary>
        System.Int32? RefEntryType { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefExitGradeLevel"/> model
        /// </summary>
        Guid? RefExitGradeLevelId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefExitOrWithdrawalStatus"/> model
        /// </summary>
        Guid? RefExitOrWithdrawalStatusId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefExitOrWithdrawalType"/> model
        /// </summary>
        Guid? RefExitOrWithdrawalTypeId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefFoodServiceEligibility"/> model
        /// </summary>
        Guid? RefFoodServiceEligibilityId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefNonPromotionReason"/> model
        /// </summary>
        Guid? RefNonPromotionReasonId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefPromotionReason"/> model
        /// </summary>
        Guid? RefPromotionReasonId { get; set; }

        /// <summary>
        /// Public School Residence Status
        /// <para>
        /// An indication of the location of a persons legal residence relative to (within or outside) the boundaries of the public school attended and its administrative unit.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19523">Public School Residence Status</a>
        /// </para>
        /// </summary>
        System.Int32? RefPublicSchoolResidence { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefStudentEnrollmentAccessType"/> model
        /// </summary>
        Guid? RefStudentEnrollmentAccessTypeId { get; set; }

    }
}
