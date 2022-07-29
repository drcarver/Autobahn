namespace Autobahn.Entities
{
    public partial class K12StaffAssignment
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public K12StaffAssignment()
        {
            TeacherStudentDataLinkExclusions = new HashSet<TeacherStudentDataLinkExclusion>();
        }

        public int K12StaffAssignmentId { get; set; }

        public int OrganizationPersonRoleId { get; set; }

        public bool? PrimaryAssignment { get; set; }

        public bool? TeacherOfRecord { get; set; }

        public decimal? FullTimeEquivalency { get; set; }

        public decimal? ContributionPercentage { get; set; }

        public bool? ItinerantTeacher { get; set; }

        public bool? HighlyQualifiedTeacherIndicator { get; set; }

        public bool? SpecialEducationTeacher { get; set; }

        public bool? SpecialEducationRelatedServicesPersonnel { get; set; }

        public bool? SpecialEducationParaprofessional { get; set; }

        public int? RefK12StaffClassificationId { get; set; }

        public int? RefProfessionalEducationJobClassificationId { get; set; }

        public int? RefTeachingAssignmentRoleId { get; set; }

        public int? RefClassroomPositionTypeId { get; set; }

        public int? RefSpecialEducationStaffCategoryId { get; set; }

        public int? RefSpecialEducationAgeGroupTaughtId { get; set; }

        public int? RefMepStaffCategoryId { get; set; }

        public int? RefTitleIProgramStaffCategoryId { get; set; }

        public int? RefEDFactsTeacherInexperiencedStatusId { get; set; }

        public int? RefEmergencyOrProvisionalCredentialStatusId { get; set; }

        public int? RefOutOfFieldStatusId { get; set; }

        public DateTime? RecordStartDateTime { get; set; }

        public DateTime? RecordEndDateTime { get; set; }

        public int? RecordStatusId { get; set; }

        public int? DataCollectionId { get; set; }

        public virtual DataCollection DataCollection { get; set; }

        public virtual OrganizationPersonRole OrganizationPersonRole { get; set; }

        public virtual OrganizationPersonRole OrganizationPersonRole1 { get; set; }

        public virtual RecordStatus RecordStatus { get; set; }

        public virtual RefClassroomPositionType RefClassroomPositionType { get; set; }

        public virtual RefEDFactsTeacherInexperiencedStatu RefEDFactsTeacherInexperiencedStatu { get; set; }

        public virtual RefK12StaffClassification RefK12StaffClassification { get; set; }

        public virtual RefEmergencyOrProvisionalCredentialStatu RefEmergencyOrProvisionalCredentialStatu { get; set; }

        public virtual RefMepStaffCategory RefMepStaffCategory { get; set; }

        public virtual RefOutOfFieldStatu RefOutOfFieldStatu { get; set; }

        public virtual RefProfessionalEducationJobClassification RefProfessionalEducationJobClassification { get; set; }

        public virtual RefSpecialEducationAgeGroupTaught RefSpecialEducationAgeGroupTaught { get; set; }

        public virtual RefSpecialEducationStaffCategory RefSpecialEducationStaffCategory { get; set; }

        public virtual RefTeachingAssignmentRole RefTeachingAssignmentRole { get; set; }

        public virtual RefTitleIProgramStaffCategory RefTitleIProgramStaffCategory { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TeacherStudentDataLinkExclusion> TeacherStudentDataLinkExclusions { get; set; }
    }
}
