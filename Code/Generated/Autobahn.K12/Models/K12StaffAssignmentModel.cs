//**********************************************************
//* DomainName: Elementary and Secondary (K12)
//* FileName:   K12StaffAssignmentModel.cs
//* Name:       Teaching Assignment Contribution Percentage
//* Definition: A percentage used to weight the educator's assigned responsibility for student learning in a Class Section, particularly when more than one educator is assigned to the class section.
//***************************************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.Models;

namespace Autobahn.K12.Interfaces
{
     /// <summary>
     /// A percentage used to weight the educator's assigned responsibility for student learning in a Class Section, particularly when more than one educator is assigned to the class section.
     /// </summary>
    public partial class K12StaffAssignmentModel : AutobahnBase, Interfaces.IK12StaffAssignment
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
        public System.Decimal? ContributionPercentage { get; set; }

        /// <summary>
        /// Staff Full Time Equivalency
        /// <para>
        /// The ratio between the hours of work expected in a position and the hours of work normally expected in a full-time position in the same setting.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19118">Staff Full Time Equivalency</a>
        /// </para>
        /// </summary>
        public System.Decimal? FullTimeEquivalency { get; set; }

        /// <summary>
        /// Highly Qualified Teacher Indicator
        /// <para>
        /// An indication that the teacher has been classified as highly qualified based on assignment.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19142">Highly Qualified Teacher Indicator</a>
        /// </para>
        /// </summary>
        public System.Boolean? HighlyQualifiedTeacherIndicator { get; set; }

        /// <summary>
        /// Itinerant Teacher
        /// <para>
        /// An indication of whether a teacher provides instruction in more than one instructional site.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19519">Itinerant Teacher</a>
        /// </para>
        /// </summary>
        public System.Boolean? ItinerantTeacher { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IOrganizationPersonRole"/> model
        /// </summary>
        public Guid OrganizationPersonRoleId { get; set; }

        /// <summary>
        /// Primary Assignment Indicator
        /// <para>
        /// An indication of whether the assignment is the staff member's primary assignment.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19516">Primary Assignment Indicator</a>
        /// </para>
        /// </summary>
        public System.Boolean? PrimaryAssignment { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IRefClassroomPositionType"/> model
        /// </summary>
        public Guid? RefClassroomPositionTypeId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IRefEDFactsTeacherInexperiencedStatus"/> model
        /// </summary>
        public Guid? RefEDFactsTeacherInexperiencedStatusId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IRefEmergencyOrProvisionalCredentialStatus"/> model
        /// </summary>
        public Guid? RefEmergencyOrProvisionalCredentialStatusId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IRefK12StaffClassification"/> model
        /// </summary>
        public Guid? RefK12StaffClassificationId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IRefMepStaffCategory"/> model
        /// </summary>
        public Guid? RefMepStaffCategoryId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IRefOutOfFieldStatus"/> model
        /// </summary>
        public Guid? RefOutOfFieldStatusId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IRefProfessionalEducationJobClassification"/> model
        /// </summary>
        public Guid? RefProfessionalEducationJobClassificationId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IRefSpecialEducationAgeGroupTaught"/> model
        /// </summary>
        public Guid? RefSpecialEducationAgeGroupTaughtId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IRefSpecialEducationStaffCategory"/> model
        /// </summary>
        public Guid? RefSpecialEducationStaffCategoryId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IRefTeachingAssignmentRole"/> model
        /// </summary>
        public Guid? RefTeachingAssignmentRoleId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IRefTitleIProgramStaffCategory"/> model
        /// </summary>
        public Guid? RefTitleIProgramStaffCategoryId { get; set; }

        /// <summary>
        /// Special Education Paraprofessional
        /// <para>
        /// An indication of whether a paraprofessional is employed or contracted to work with children with disabilities who are ages 3 through 21.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19261">Special Education Paraprofessional</a>
        /// </para>
        /// </summary>
        public System.Boolean? SpecialEducationParaprofessional { get; set; }

        /// <summary>
        /// Special Education Related Services Personnel
        /// <para>
        /// An indication of whether a related services person is employed or contracted to work with children with disabilities who are ages 3 through 21.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19262">Special Education Related Services Personnel</a>
        /// </para>
        /// </summary>
        public System.Boolean? SpecialEducationRelatedServicesPersonnel { get; set; }

        /// <summary>
        /// Special Education Teacher
        /// <para>
        /// An indication of whether a teacher is employed or contracted to work with children with disabilities who are ages 3 through 21.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19264">Special Education Teacher</a>
        /// </para>
        /// </summary>
        public System.Boolean? SpecialEducationTeacher { get; set; }

        /// <summary>
        /// Teacher of Record
        /// <para>
        /// Staff member who has a Teacher of Record responsibility for a Class Section based upon the state's definition of Teacher of Record.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19649">Teacher of Record</a>
        /// </para>
        /// </summary>
        public System.Boolean? TeacherOfRecord { get; set; }

    }
}
