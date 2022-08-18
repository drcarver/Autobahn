//**********************************************************
//* DomainName: Elementary and Secondary (K12)
//* FileName:   K12StudentEnrollmentModel.cs
//***************************************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.Models;

namespace Autobahn.K12.Models
{
     /// <summary>
     /// The K12StudentEnrollment Model
     /// </summary>
    public partial class K12StudentEnrollmentModel : AutobahnBase, Interfaces.IK12StudentEnrollment
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
        public System.Boolean? DisplacedStudentStatus { get; set; }

        /// <summary>
        /// First Entry Date into a US School
        /// <para>
        /// The year, month and day of a person's initial enrollment into a United States school.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19520">First Entry Date into a US School</a>
        /// </para>
        /// </summary>
        public System.DateTime? FirstEntryDateIntoUSSchool { get; set; }

        /// <summary>
        /// National School Lunch Program Direct Certification Indicator
        /// <para>
        /// Indicates that the student's National School Lunch Program (NSLP) eligibility has been determined through direct certification.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20635">National School Lunch Program Direct Certification Indicator</a>
        /// </para>
        /// </summary>
        public System.Boolean? NSLPDirectCertificationIndicator { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IOrganizationPersonRole"/> model
        /// </summary>
        public Guid OrganizationPersonRoleId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefDirectoryInformationBlockStatus"/> model
        /// </summary>
        public Guid? RefDirectoryInformationBlockStatusId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefEndOfTermStatus"/> model
        /// </summary>
        public Guid? RefEndOfTermStatusId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefEnrollmentStatus"/> model
        /// </summary>
        public Guid? RefEnrollmentStatusId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefEntryGradeLevel"/> model
        /// </summary>
        public Guid? RefEntryGradeLevelId { get; set; }

        /// <summary>
        /// Entry Type
        /// <para>
        /// The process by which a student enters a school during a given academic session.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19099">Entry Type</a>
        /// </para>
        /// </summary>
        public System.Int32? RefEntryType { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefExitGradeLevel"/> model
        /// </summary>
        public Guid? RefExitGradeLevelId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefExitOrWithdrawalStatus"/> model
        /// </summary>
        public Guid? RefExitOrWithdrawalStatusId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefExitOrWithdrawalType"/> model
        /// </summary>
        public Guid? RefExitOrWithdrawalTypeId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefFoodServiceEligibility"/> model
        /// </summary>
        public Guid? RefFoodServiceEligibilityId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefNonPromotionReason"/> model
        /// </summary>
        public Guid? RefNonPromotionReasonId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefPromotionReason"/> model
        /// </summary>
        public Guid? RefPromotionReasonId { get; set; }

        /// <summary>
        /// Public School Residence Status
        /// <para>
        /// An indication of the location of a persons legal residence relative to (within or outside) the boundaries of the public school attended and its administrative unit.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19523">Public School Residence Status</a>
        /// </para>
        /// </summary>
        public System.Int32? RefPublicSchoolResidence { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefStudentEnrollmentAccessType"/> model
        /// </summary>
        public Guid? RefStudentEnrollmentAccessTypeId { get; set; }

    }
}
