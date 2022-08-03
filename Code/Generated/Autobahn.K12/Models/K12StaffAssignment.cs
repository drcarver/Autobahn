//**********************************************************
//* DomainName: Autobahn.K12
//* FileName:   K12StaffAssignment.cs
//**********************************************************

using Autobahn.K12.Interfaces;

namespace Autobahn.K12.Models
{
     /// <summary>
     /// The K12StaffAssignment
     /// </summary>
    public partial class K12StaffAssignment : IK12StaffAssignment
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="OrganizationPersonRole"/> model
        /// </summary>
        public Guid OrganizationPersonRoleId { get; set; }

        /// <summary>
        /// Defines the K12StaffAssignment.PrimaryAssignment nullable property
        /// </summary>
        public System.Boolean? PrimaryAssignment { get; set; }

        /// <summary>
        /// Defines the K12StaffAssignment.TeacherOfRecord nullable property
        /// </summary>
        public System.Boolean? TeacherOfRecord { get; set; }

        /// <summary>
        /// Defines the K12StaffAssignment.FullTimeEquivalency nullable property
        /// </summary>
        public System.Decimal? FullTimeEquivalency { get; set; }

        /// <summary>
        /// Defines the K12StaffAssignment.ContributionPercentage nullable property
        /// </summary>
        public System.Decimal? ContributionPercentage { get; set; }

        /// <summary>
        /// Defines the K12StaffAssignment.ItinerantTeacher nullable property
        /// </summary>
        public System.Boolean? ItinerantTeacher { get; set; }

        /// <summary>
        /// Defines the K12StaffAssignment.HighlyQualifiedTeacherIndicator nullable property
        /// </summary>
        public System.Boolean? HighlyQualifiedTeacherIndicator { get; set; }

        /// <summary>
        /// Defines the K12StaffAssignment.SpecialEducationTeacher nullable property
        /// </summary>
        public System.Boolean? SpecialEducationTeacher { get; set; }

        /// <summary>
        /// Defines the K12StaffAssignment.SpecialEducationRelatedServicesPersonnel nullable property
        /// </summary>
        public System.Boolean? SpecialEducationRelatedServicesPersonnel { get; set; }

        /// <summary>
        /// Defines the K12StaffAssignment.SpecialEducationParaprofessional nullable property
        /// </summary>
        public System.Boolean? SpecialEducationParaprofessional { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefK12StaffClassification"/> model
        /// </summary>
        public Guid? RefK12StaffClassificationId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefProfessionalEducationJobClassification"/> model
        /// </summary>
        public Guid? RefProfessionalEducationJobClassificationId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefTeachingAssignmentRole"/> model
        /// </summary>
        public Guid? RefTeachingAssignmentRoleId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefClassroomPositionType"/> model
        /// </summary>
        public Guid? RefClassroomPositionTypeId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefSpecialEducationStaffCategory"/> model
        /// </summary>
        public Guid? RefSpecialEducationStaffCategoryId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefSpecialEducationAgeGroupTaught"/> model
        /// </summary>
        public Guid? RefSpecialEducationAgeGroupTaughtId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefMepStaffCategory"/> model
        /// </summary>
        public Guid? RefMepStaffCategoryId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefTitleIProgramStaffCategory"/> model
        /// </summary>
        public Guid? RefTitleIProgramStaffCategoryId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefEDFactsTeacherInexperiencedStatus"/> model
        /// </summary>
        public Guid? RefEDFactsTeacherInexperiencedStatusId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefEmergencyOrProvisionalCredentialStatus"/> model
        /// </summary>
        public Guid? RefEmergencyOrProvisionalCredentialStatusId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefOutOfFieldStatus"/> model
        /// </summary>
        public Guid? RefOutOfFieldStatusId { get; set; }

        /// <summary>
        /// Defines the K12StaffAssignment.RecordStartDateTime nullable property
        /// </summary>
        public System.DateTime? RecordStartDateTime { get; set; }

        /// <summary>
        /// Defines the K12StaffAssignment.RecordEndDateTime nullable property
        /// </summary>
        public System.DateTime? RecordEndDateTime { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RecordStatus"/> model
        /// </summary>
        public Guid? RecordStatusId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="DataCollection"/> model
        /// </summary>
        public Guid? DataCollectionId { get; set; }

    }
}
