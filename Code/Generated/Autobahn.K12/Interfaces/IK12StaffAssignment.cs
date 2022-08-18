//***************************************************************************
//* DomainName: Elementary and Secondary (K12) Interfaces (used by both models and View Models
//* FileName:   IK12StaffAssignment.cs
//* Name:       Teaching Assignment Contribution Percentage
//* Definition: 
//***************************************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.K12.Interfaces
{
     /// <summary>
     /// 
     /// </summary>
    public partial interface IK12StaffAssignment : IAutobahnBase
    {
        /// <summary>
        /// Teaching Assignment Contribution Percentage
        /// <para>
        /// A percentage used to weight the educator's assigned responsibility for student learning in a Class Section, particularly when more than one educator is assigned to the class section.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19651">Teaching Assignment Contribution Percentage</a>
        /// </para>
        /// </summary>
        System.Decimal? ContributionPercentage { get; set; }

        /// <summary>
        /// Staff Full Time Equivalency
        /// <para>
        /// The ratio between the hours of work expected in a position and the hours of work normally expected in a full-time position in the same setting.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19118">Staff Full Time Equivalency</a>
        /// </para>
        /// </summary>
        System.Decimal? FullTimeEquivalency { get; set; }

        /// <summary>
        /// Highly Qualified Teacher Indicator
        /// <para>
        /// An indication that the teacher has been classified as highly qualified based on assignment.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19142">Highly Qualified Teacher Indicator</a>
        /// </para>
        /// </summary>
        System.Boolean? HighlyQualifiedTeacherIndicator { get; set; }

        /// <summary>
        /// Itinerant Teacher
        /// <para>
        /// An indication of whether a teacher provides instruction in more than one instructional site.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19519">Itinerant Teacher</a>
        /// </para>
        /// </summary>
        System.Boolean? ItinerantTeacher { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IOrganizationPersonRole"/> model
        /// </summary>
        Guid OrganizationPersonRoleId { get; set; }

        /// <summary>
        /// Primary Assignment Indicator
        /// <para>
        /// An indication of whether the assignment is the staff member's primary assignment.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19516">Primary Assignment Indicator</a>
        /// </para>
        /// </summary>
        System.Boolean? PrimaryAssignment { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefClassroomPositionType"/> model
        /// </summary>
        Guid? RefClassroomPositionTypeId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefEDFactsTeacherInexperiencedStatus"/> model
        /// </summary>
        Guid? RefEDFactsTeacherInexperiencedStatusId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefEmergencyOrProvisionalCredentialStatus"/> model
        /// </summary>
        Guid? RefEmergencyOrProvisionalCredentialStatusId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefK12StaffClassification"/> model
        /// </summary>
        Guid? RefK12StaffClassificationId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefMepStaffCategory"/> model
        /// </summary>
        Guid? RefMepStaffCategoryId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefOutOfFieldStatus"/> model
        /// </summary>
        Guid? RefOutOfFieldStatusId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefProfessionalEducationJobClassification"/> model
        /// </summary>
        Guid? RefProfessionalEducationJobClassificationId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefSpecialEducationAgeGroupTaught"/> model
        /// </summary>
        Guid? RefSpecialEducationAgeGroupTaughtId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefSpecialEducationStaffCategory"/> model
        /// </summary>
        Guid? RefSpecialEducationStaffCategoryId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefTeachingAssignmentRole"/> model
        /// </summary>
        Guid? RefTeachingAssignmentRoleId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefTitleIProgramStaffCategory"/> model
        /// </summary>
        Guid? RefTitleIProgramStaffCategoryId { get; set; }

        /// <summary>
        /// Special Education Paraprofessional
        /// <para>
        /// An indication of whether a paraprofessional is employed or contracted to work with children with disabilities who are ages 3 through 21.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19261">Special Education Paraprofessional</a>
        /// </para>
        /// </summary>
        System.Boolean? SpecialEducationParaprofessional { get; set; }

        /// <summary>
        /// Special Education Related Services Personnel
        /// <para>
        /// An indication of whether a related services person is employed or contracted to work with children with disabilities who are ages 3 through 21.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19262">Special Education Related Services Personnel</a>
        /// </para>
        /// </summary>
        System.Boolean? SpecialEducationRelatedServicesPersonnel { get; set; }

        /// <summary>
        /// Special Education Teacher
        /// <para>
        /// An indication of whether a teacher is employed or contracted to work with children with disabilities who are ages 3 through 21.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19264">Special Education Teacher</a>
        /// </para>
        /// </summary>
        System.Boolean? SpecialEducationTeacher { get; set; }

        /// <summary>
        /// Teacher of Record
        /// <para>
        /// Staff member who has a Teacher of Record responsibility for a Class Section based upon the state's definition of Teacher of Record.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19649">Teacher of Record</a>
        /// </para>
        /// </summary>
        System.Boolean? TeacherOfRecord { get; set; }

    }
}
