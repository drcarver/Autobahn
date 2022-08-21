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
    [Table("K12StudentEnrollment")]
    [Index("OrganizationPersonRoleId", Name = "IX_OrganizationPersonRoleId")]
    public partial class K12studentEnrollment
    {
        [Key]
        [Column("K12StudentEnrollmentId")]
        public int K12studentEnrollmentId { get; set; }
        public int OrganizationPersonRoleId { get; set; }
        public bool? DisplacedStudentStatus { get; set; }
        [Column("FirstEntryDateIntoUSSchool", TypeName = "date")]
        public DateTime? FirstEntryDateIntoUsschool { get; set; }
        [Column("NSLPDirectCertificationIndicator")]
        public bool? NslpdirectCertificationIndicator { get; set; }
        public int? RefEntryGradeLevelId { get; set; }
        public int? RefPublicSchoolResidence { get; set; }
        public int? RefEnrollmentStatusId { get; set; }
        public int? RefEntryType { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        public int? RefExitGradeLevelId { get; set; }
        public int? RefExitOrWithdrawalStatusId { get; set; }
        public int? RefExitOrWithdrawalTypeId { get; set; }
        public int? RefEndOfTermStatusId { get; set; }
        public int? RefPromotionReasonId { get; set; }
        public int? RefNonPromotionReasonId { get; set; }
        public int? RefFoodServiceEligibilityId { get; set; }
        public int? RefDirectoryInformationBlockStatusId { get; set; }
        public int? RefStudentEnrollmentAccessTypeId { get; set; }
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
        [InverseProperty("K12studentEnrollments")]
        public virtual DataCollection? DataCollection { get; set; }
        [ForeignKey("OrganizationPersonRoleId")]
        [InverseProperty("K12studentEnrollments")]
        public virtual OrganizationPersonRole OrganizationPersonRole { get; set; } = null!;
        [ForeignKey("RecordStatusId")]
        [InverseProperty("K12studentEnrollments")]
        public virtual RecordStatus? RecordStatus { get; set; }
        [ForeignKey("RefDirectoryInformationBlockStatusId")]
        [InverseProperty("K12studentEnrollments")]
        public virtual RefDirectoryInformationBlockStatus? RefDirectoryInformationBlockStatus { get; set; }
        [ForeignKey("RefEndOfTermStatusId")]
        [InverseProperty("K12studentEnrollments")]
        public virtual RefEndOfTermStatus? RefEndOfTermStatus { get; set; }
        [ForeignKey("RefEnrollmentStatusId")]
        [InverseProperty("K12studentEnrollments")]
        public virtual RefEnrollmentStatus? RefEnrollmentStatus { get; set; }
        [ForeignKey("RefEntryGradeLevelId")]
        [InverseProperty("K12studentEnrollmentRefEntryGradeLevels")]
        public virtual RefGradeLevel? RefEntryGradeLevel { get; set; }
        [ForeignKey("RefEntryType")]
        [InverseProperty("K12studentEnrollments")]
        public virtual RefEntryType? RefEntryTypeNavigation { get; set; }
        [ForeignKey("RefExitGradeLevelId")]
        [InverseProperty("K12studentEnrollmentRefExitGradeLevels")]
        public virtual RefGradeLevel? RefExitGradeLevel { get; set; }
        [ForeignKey("RefExitOrWithdrawalStatusId")]
        [InverseProperty("K12studentEnrollments")]
        public virtual RefExitOrWithdrawalStatus? RefExitOrWithdrawalStatus { get; set; }
        [ForeignKey("RefExitOrWithdrawalTypeId")]
        [InverseProperty("K12studentEnrollments")]
        public virtual RefExitOrWithdrawalType? RefExitOrWithdrawalType { get; set; }
        [ForeignKey("RefFoodServiceEligibilityId")]
        [InverseProperty("K12studentEnrollments")]
        public virtual RefFoodServiceEligibility? RefFoodServiceEligibility { get; set; }
        [ForeignKey("RefNonPromotionReasonId")]
        [InverseProperty("K12studentEnrollments")]
        public virtual RefNonPromotionReason? RefNonPromotionReason { get; set; }
        [ForeignKey("RefPromotionReasonId")]
        [InverseProperty("K12studentEnrollments")]
        public virtual RefPromotionReason? RefPromotionReason { get; set; }
        [ForeignKey("RefPublicSchoolResidence")]
        [InverseProperty("K12studentEnrollments")]
        public virtual RefPublicSchoolResidence? RefPublicSchoolResidenceNavigation { get; set; }
        [ForeignKey("RefStudentEnrollmentAccessTypeId")]
        [InverseProperty("K12studentEnrollments")]
        public virtual RefStudentEnrollmentAccessType? RefStudentEnrollmentAccessType { get; set; }
    }
}
