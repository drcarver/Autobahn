using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ScafoldADatabase.Entities
{
    /// <summary>
    /// See the CEDS_Def_Desc extended property.
    /// </summary>
    [Table("K12StaffAssignment", Schema = "K12")]
    public partial class K12StaffAssignment
    {
        public K12StaffAssignment()
        {
            TeacherStudentDataLinkExclusions = new HashSet<TeacherStudentDataLinkExclusion>();
        }

        [Key]
        public int K12StaffAssignmentId { get; set; }
        public int OrganizationPersonRoleId { get; set; }
        public bool? PrimaryAssignment { get; set; }
        public bool? TeacherOfRecord { get; set; }
        [Column(TypeName = "decimal(5, 4)")]
        public decimal? FullTimeEquivalency { get; set; }
        [Column(TypeName = "decimal(5, 2)")]
        public decimal? ContributionPercentage { get; set; }
        public bool? ItinerantTeacher { get; set; }
        public bool? HighlyQualifiedTeacherIndicator { get; set; }
        public bool? SpecialEducationTeacher { get; set; }
        public bool? SpecialEducationRelatedServicesPersonnel { get; set; }
        public bool? SpecialEducationParaprofessional { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        public int? RefK12StaffClassificationId { get; set; }
        public int? RefProfessionalEducationJobClassificationId { get; set; }
        public int? RefTeachingAssignmentRoleId { get; set; }
        public int? RefClassroomPositionTypeId { get; set; }
        public int? RefSpecialEducationStaffCategoryId { get; set; }
        public int? RefSpecialEducationAgeGroupTaughtId { get; set; }
        public int? RefMepStaffCategoryId { get; set; }
        public int? RefTitleIProgramStaffCategoryId { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        public int? RefEDFactsTeacherInexperiencedStatusId { get; set; }
        public int? RefEmergencyOrProvisionalCredentialStatusId { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        public int? RefOutOfFieldStatusId { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        [Column(TypeName = "datetime")]
        public DateTime? RecordStartDateTime { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? RecordEndDateTime { get; set; }
        public int? RecordStatusId { get; set; }
        public int? DataCollectionId { get; set; }

        [ForeignKey("DataCollectionId")]
        [InverseProperty("K12staffAssignments")]
        public virtual DataCollection? DataCollection { get; set; }
        [ForeignKey("OrganizationPersonRoleId")]
        [InverseProperty("K12staffAssignments")]
        public virtual OrganizationPersonRole OrganizationPersonRole { get; set; } = null!;
        [ForeignKey("RecordStatusId")]
        [InverseProperty("K12staffAssignments")]
        public virtual RecordStatus? RecordStatus { get; set; }
        [ForeignKey("RefClassroomPositionTypeId")]
        [InverseProperty("K12staffAssignments")]
        public virtual RefClassroomPositionType? RefClassroomPositionType { get; set; }
        [ForeignKey("RefEdfactsTeacherInexperiencedStatusId")]
        [InverseProperty("K12staffAssignments")]
        public virtual RefEdfactsTeacherInexperiencedStatus? RefEdfactsTeacherInexperiencedStatus { get; set; }
        [ForeignKey("RefEmergencyOrProvisionalCredentialStatusId")]
        [InverseProperty("K12staffAssignments")]
        public virtual RefEmergencyOrProvisionalCredentialStatus? RefEmergencyOrProvisionalCredentialStatus { get; set; }
        [ForeignKey("RefK12staffClassificationId")]
        [InverseProperty("K12staffAssignments")]
        public virtual RefK12StaffClassification? RefK12staffClassification { get; set; }
        [ForeignKey("RefMepStaffCategoryId")]
        [InverseProperty("K12staffAssignments")]
        public virtual RefMepStaffCategory? RefMepStaffCategory { get; set; }
        [ForeignKey("RefOutOfFieldStatusId")]
        [InverseProperty("K12staffAssignments")]
        public virtual RefOutOfFieldStatus? RefOutOfFieldStatus { get; set; }
        [ForeignKey("RefProfessionalEducationJobClassificationId")]
        [InverseProperty("K12staffAssignments")]
        public virtual RefProfessionalEducationJobClassification? RefProfessionalEducationJobClassification { get; set; }
        [ForeignKey("RefSpecialEducationAgeGroupTaughtId")]
        [InverseProperty("K12staffAssignments")]
        public virtual RefSpecialEducationAgeGroupTaught? RefSpecialEducationAgeGroupTaught { get; set; }
        [ForeignKey("RefSpecialEducationStaffCategoryId")]
        [InverseProperty("K12staffAssignments")]
        public virtual RefSpecialEducationStaffCategory? RefSpecialEducationStaffCategory { get; set; }
        [ForeignKey("RefTeachingAssignmentRoleId")]
        [InverseProperty("K12staffAssignments")]
        public virtual RefTeachingAssignmentRole? RefTeachingAssignmentRole { get; set; }
        [ForeignKey("RefTitleIprogramStaffCategoryId")]
        [InverseProperty("K12staffAssignments")]
        public virtual RefTitleIProgramStaffCategory? RefTitleIprogramStaffCategory { get; set; }
        [InverseProperty("K12staffAssignment")]
        public virtual ICollection<TeacherStudentDataLinkExclusion> TeacherStudentDataLinkExclusions { get; set; }
    }
}
