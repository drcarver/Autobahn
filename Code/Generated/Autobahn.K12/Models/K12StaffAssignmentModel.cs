//**********************************************************
//* DomainName: Elementary and Secondary (K12)
//* FileName:   K12StaffAssignmentModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.Models;

namespace Autobahn.K12.Models
{
     /// <summary>
     /// The K12StaffAssignment Model
     /// </summary>
    public partial class K12StaffAssignmentModel : AutobahnBase, Interfaces.IK12StaffAssignment
    {
        /// <summary>
        /// The titles of employment, official status, or rank of education staff.
        /// </summary>
        public System.Decimal? ContributionPercentage { get; set; }

        /// <summary>
        /// The titles of employment, official status, or rank of education staff.
        /// </summary>
        public System.Decimal? FullTimeEquivalency { get; set; }

        /// <summary>
        /// The titles of employment, official status, or rank of education staff.
        /// </summary>
        public System.Boolean? HighlyQualifiedTeacherIndicator { get; set; }

        /// <summary>
        /// The titles of employment, official status, or rank of education staff.
        /// </summary>
        public System.Boolean? ItinerantTeacher { get; set; }

        /// <summary>
        /// The titles of employment, official status, or rank of education staff.
        /// </summary>
        public Guid OrganizationPersonRoleId { get; set; }

        /// <summary>
        /// The titles of employment, official status, or rank of education staff.
        /// </summary>
        public System.Boolean? PrimaryAssignment { get; set; }

        /// <summary>
        /// The titles of employment, official status, or rank of education staff.
        /// </summary>
        public Guid? RefClassroomPositionTypeId { get; set; }

        /// <summary>
        /// The titles of employment, official status, or rank of education staff.
        /// </summary>
        public Guid? RefEDFactsTeacherInexperiencedStatusId { get; set; }

        /// <summary>
        /// The titles of employment, official status, or rank of education staff.
        /// </summary>
        public Guid? RefEmergencyOrProvisionalCredentialStatusId { get; set; }

        /// <summary>
        /// The titles of employment, official status, or rank of education staff.
        /// </summary>
        public Guid? RefK12StaffClassificationId { get; set; }

        /// <summary>
        /// The titles of employment, official status, or rank of education staff.
        /// </summary>
        public Guid? RefMepStaffCategoryId { get; set; }

        /// <summary>
        /// The titles of employment, official status, or rank of education staff.
        /// </summary>
        public Guid? RefOutOfFieldStatusId { get; set; }

        /// <summary>
        /// The titles of employment, official status, or rank of education staff.
        /// </summary>
        public Guid? RefProfessionalEducationJobClassificationId { get; set; }

        /// <summary>
        /// The titles of employment, official status, or rank of education staff.
        /// </summary>
        public Guid? RefSpecialEducationAgeGroupTaughtId { get; set; }

        /// <summary>
        /// The titles of employment, official status, or rank of education staff.
        /// </summary>
        public Guid? RefSpecialEducationStaffCategoryId { get; set; }

        /// <summary>
        /// The titles of employment, official status, or rank of education staff.
        /// </summary>
        public Guid? RefTeachingAssignmentRoleId { get; set; }

        /// <summary>
        /// The titles of employment, official status, or rank of education staff.
        /// </summary>
        public Guid? RefTitleIProgramStaffCategoryId { get; set; }

        /// <summary>
        /// The titles of employment, official status, or rank of education staff.
        /// </summary>
        public System.Boolean? SpecialEducationParaprofessional { get; set; }

        /// <summary>
        /// The titles of employment, official status, or rank of education staff.
        /// </summary>
        public System.Boolean? SpecialEducationRelatedServicesPersonnel { get; set; }

        /// <summary>
        /// The titles of employment, official status, or rank of education staff.
        /// </summary>
        public System.Boolean? SpecialEducationTeacher { get; set; }

        /// <summary>
        /// The titles of employment, official status, or rank of education staff.
        /// </summary>
        public System.Boolean? TeacherOfRecord { get; set; }

    }
}
