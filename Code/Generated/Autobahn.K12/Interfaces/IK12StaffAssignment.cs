//***************************************************************************
//* DomainName: Elementary and Secondary (K12) Interfaces (used by both models and View Models
//* FileName:   IK12StaffAssignment.cs
//***************************************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.K12.Interfaces
{
     /// <summary>
     /// The IK12StaffAssignment Interface
     /// </summary>
    public partial interface IK12StaffAssignment : IAutobahnBase
    {
        /// <summary>
        /// The titles of employment, official status, or rank of education staff.
        /// </summary>
        System.Decimal? ContributionPercentage { get; set; }

        /// <summary>
        /// The titles of employment, official status, or rank of education staff.
        /// </summary>
        System.Decimal? FullTimeEquivalency { get; set; }

        /// <summary>
        /// The titles of employment, official status, or rank of education staff.
        /// </summary>
        System.Boolean? HighlyQualifiedTeacherIndicator { get; set; }

        /// <summary>
        /// The titles of employment, official status, or rank of education staff.
        /// </summary>
        System.Boolean? ItinerantTeacher { get; set; }

        /// <summary>
        /// The titles of employment, official status, or rank of education staff.
        /// </summary>
        Guid OrganizationPersonRoleId { get; set; }

        /// <summary>
        /// The titles of employment, official status, or rank of education staff.
        /// </summary>
        System.Boolean? PrimaryAssignment { get; set; }

        /// <summary>
        /// The titles of employment, official status, or rank of education staff.
        /// </summary>
        Guid? RefClassroomPositionTypeId { get; set; }

        /// <summary>
        /// The titles of employment, official status, or rank of education staff.
        /// </summary>
        Guid? RefEDFactsTeacherInexperiencedStatusId { get; set; }

        /// <summary>
        /// The titles of employment, official status, or rank of education staff.
        /// </summary>
        Guid? RefEmergencyOrProvisionalCredentialStatusId { get; set; }

        /// <summary>
        /// The titles of employment, official status, or rank of education staff.
        /// </summary>
        Guid? RefK12StaffClassificationId { get; set; }

        /// <summary>
        /// The titles of employment, official status, or rank of education staff.
        /// </summary>
        Guid? RefMepStaffCategoryId { get; set; }

        /// <summary>
        /// The titles of employment, official status, or rank of education staff.
        /// </summary>
        Guid? RefOutOfFieldStatusId { get; set; }

        /// <summary>
        /// The titles of employment, official status, or rank of education staff.
        /// </summary>
        Guid? RefProfessionalEducationJobClassificationId { get; set; }

        /// <summary>
        /// The titles of employment, official status, or rank of education staff.
        /// </summary>
        Guid? RefSpecialEducationAgeGroupTaughtId { get; set; }

        /// <summary>
        /// The titles of employment, official status, or rank of education staff.
        /// </summary>
        Guid? RefSpecialEducationStaffCategoryId { get; set; }

        /// <summary>
        /// The titles of employment, official status, or rank of education staff.
        /// </summary>
        Guid? RefTeachingAssignmentRoleId { get; set; }

        /// <summary>
        /// The titles of employment, official status, or rank of education staff.
        /// </summary>
        Guid? RefTitleIProgramStaffCategoryId { get; set; }

        /// <summary>
        /// The titles of employment, official status, or rank of education staff.
        /// </summary>
        System.Boolean? SpecialEducationParaprofessional { get; set; }

        /// <summary>
        /// The titles of employment, official status, or rank of education staff.
        /// </summary>
        System.Boolean? SpecialEducationRelatedServicesPersonnel { get; set; }

        /// <summary>
        /// The titles of employment, official status, or rank of education staff.
        /// </summary>
        System.Boolean? SpecialEducationTeacher { get; set; }

        /// <summary>
        /// The titles of employment, official status, or rank of education staff.
        /// </summary>
        System.Boolean? TeacherOfRecord { get; set; }

    }
}
