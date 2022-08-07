//**********************************************************
//* DomainName: Autobahn.K12
//* FileName:   IK12StaffAssignmentModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.K12.Interfaces
{
     /// <summary>
     /// The IK12StaffAssignmentModel Interface
     /// </summary>
    public partial interface IK12StaffAssignmentModel : IAutobahnBase
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="OrganizationPersonRole"/> model
        /// </summary>
        Guid OrganizationPersonRoleId { get; set; }

        /// <summary>
        /// Defines the K12StaffAssignment.PrimaryAssignment nullable property
        /// </summary>
        System.Boolean? PrimaryAssignment { get; set; }

        /// <summary>
        /// Defines the K12StaffAssignment.TeacherOfRecord nullable property
        /// </summary>
        System.Boolean? TeacherOfRecord { get; set; }

        /// <summary>
        /// Defines the K12StaffAssignment.FullTimeEquivalency nullable property
        /// </summary>
        System.Decimal? FullTimeEquivalency { get; set; }

        /// <summary>
        /// Defines the K12StaffAssignment.ContributionPercentage nullable property
        /// </summary>
        System.Decimal? ContributionPercentage { get; set; }

        /// <summary>
        /// Defines the K12StaffAssignment.ItinerantTeacher nullable property
        /// </summary>
        System.Boolean? ItinerantTeacher { get; set; }

        /// <summary>
        /// Defines the K12StaffAssignment.HighlyQualifiedTeacherIndicator nullable property
        /// </summary>
        System.Boolean? HighlyQualifiedTeacherIndicator { get; set; }

        /// <summary>
        /// Defines the K12StaffAssignment.SpecialEducationTeacher nullable property
        /// </summary>
        System.Boolean? SpecialEducationTeacher { get; set; }

        /// <summary>
        /// Defines the K12StaffAssignment.SpecialEducationRelatedServicesPersonnel nullable property
        /// </summary>
        System.Boolean? SpecialEducationRelatedServicesPersonnel { get; set; }

        /// <summary>
        /// Defines the K12StaffAssignment.SpecialEducationParaprofessional nullable property
        /// </summary>
        System.Boolean? SpecialEducationParaprofessional { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefK12StaffClassification"/> model
        /// </summary>
        Guid? RefK12StaffClassificationId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefProfessionalEducationJobClassification"/> model
        /// </summary>
        Guid? RefProfessionalEducationJobClassificationId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefTeachingAssignmentRole"/> model
        /// </summary>
        Guid? RefTeachingAssignmentRoleId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefClassroomPositionType"/> model
        /// </summary>
        Guid? RefClassroomPositionTypeId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefSpecialEducationStaffCategory"/> model
        /// </summary>
        Guid? RefSpecialEducationStaffCategoryId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefSpecialEducationAgeGroupTaught"/> model
        /// </summary>
        Guid? RefSpecialEducationAgeGroupTaughtId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefMepStaffCategory"/> model
        /// </summary>
        Guid? RefMepStaffCategoryId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefTitleIProgramStaffCategory"/> model
        /// </summary>
        Guid? RefTitleIProgramStaffCategoryId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefEDFactsTeacherInexperiencedStatus"/> model
        /// </summary>
        Guid? RefEDFactsTeacherInexperiencedStatusId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefEmergencyOrProvisionalCredentialStatus"/> model
        /// </summary>
        Guid? RefEmergencyOrProvisionalCredentialStatusId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefOutOfFieldStatus"/> model
        /// </summary>
        Guid? RefOutOfFieldStatusId { get; set; }

    }
}
