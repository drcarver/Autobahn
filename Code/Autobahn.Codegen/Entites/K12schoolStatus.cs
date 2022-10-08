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
    [Table("K12SchoolStatus", Schema = "K12")]
    public partial class K12SchoolStatus
    {
        [Key]
        public int K12SchoolStatusId { get; set; }
        public int K12SchoolId { get; set; }
        public bool? ConsolidatedMepFundsStatus { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        [StringLength(50)]
        public string? ProgressAcheivingEnglishLearnerProficiencyStateDefinedStatus { get; set; }
        public int? RefMagnetSpecialProgramId { get; set; }
        public int? RefAlternativeSchoolFocusId { get; set; }
        public int? RefInternetAccessId { get; set; }
        public int? RefRestructuringActionId { get; set; }
        public int? RefTitleISchoolStatusId { get; set; }
        public int? RefNSLPStatusId { get; set; }
        public int? RefSchoolDangerousStatusId { get; set; }
        public int? RefSchoolImprovementStatusId { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        public int? RefProgressAchievingEnglishLanguageProficiencyIndicatorStatusId { get; set; }
        public int? RefComprehensiveAndTargetedSupportId { get; set; }
        public int? RefComprehensiveSupportId { get; set; }
        public int? RefTargetedSupportId { get; set; }
        public int? RefNationalSchoolLunchProgramStatusId { get; set; }
        public int? RefVirtualSchoolStatusId { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        public int? RefBlendedLearningModelTypeId { get; set; }
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
        [InverseProperty("K12schoolStatuses")]
        public virtual DataCollection? DataCollection { get; set; }
        [ForeignKey("K12schoolId")]
        [InverseProperty("K12schoolStatuses")]
        public virtual K12School K12school { get; set; } = null!;
        [ForeignKey("RecordStatusId")]
        [InverseProperty("K12schoolStatuses")]
        public virtual RecordStatus? RecordStatus { get; set; }
        [ForeignKey("RefAlternativeSchoolFocusId")]
        [InverseProperty("K12schoolStatuses")]
        public virtual RefAlternativeSchoolFocus? RefAlternativeSchoolFocus { get; set; }
        [ForeignKey("RefBlendedLearningModelTypeId")]
        [InverseProperty("K12schoolStatuses")]
        public virtual RefBlendedLearningModelType? RefBlendedLearningModelType { get; set; }
        [ForeignKey("RefComprehensiveAndTargetedSupportId")]
        [InverseProperty("K12schoolStatuses")]
        public virtual RefComprehensiveAndTargetedSupport? RefComprehensiveAndTargetedSupport { get; set; }
        [ForeignKey("RefComprehensiveSupportId")]
        [InverseProperty("K12schoolStatuses")]
        public virtual RefComprehensiveSupport? RefComprehensiveSupport { get; set; }
        [ForeignKey("RefInternetAccessId")]
        [InverseProperty("K12schoolStatuses")]
        public virtual RefInternetAccess? RefInternetAccess { get; set; }
        [ForeignKey("RefMagnetSpecialProgramId")]
        [InverseProperty("K12schoolStatuses")]
        public virtual RefMagnetSpecialProgram? RefMagnetSpecialProgram { get; set; }
        [ForeignKey("RefNationalSchoolLunchProgramStatusId")]
        [InverseProperty("K12schoolStatuses")]
        public virtual RefNationalSchoolLunchProgramStatus? RefNationalSchoolLunchProgramStatus { get; set; }
        [ForeignKey("RefNslpstatusId")]
        [InverseProperty("K12schoolStatuses")]
        public virtual RefNSLPStatus? RefNslpstatus { get; set; }
        [ForeignKey("RefProgressAchievingEnglishLanguageProficiencyIndicatorStatusId")]
        [InverseProperty("K12schoolStatuses")]
        public virtual RefProgressAchievingEnglishLanguageProficiencyIndicatorStatus? RefProgressAchievingEnglishLanguageProficiencyIndicatorStatus { get; set; }
        [ForeignKey("RefRestructuringActionId")]
        [InverseProperty("K12schoolStatuses")]
        public virtual RefRestructuringAction? RefRestructuringAction { get; set; }
        [ForeignKey("RefSchoolDangerousStatusId")]
        [InverseProperty("K12schoolStatuses")]
        public virtual RefSchoolDangerousStatus? RefSchoolDangerousStatus { get; set; }
        [ForeignKey("RefSchoolImprovementStatusId")]
        [InverseProperty("K12schoolStatuses")]
        public virtual RefSchoolImprovementStatus? RefSchoolImprovementStatus { get; set; }
        [ForeignKey("RefTargetedSupportId")]
        [InverseProperty("K12schoolStatuses")]
        public virtual RefTargetedSupport? RefTargetedSupport { get; set; }
        [ForeignKey("RefTitleIschoolStatusId")]
        [InverseProperty("K12schoolStatuses")]
        public virtual RefTitleISchoolStatus? RefTitleIschoolStatus { get; set; }
        [ForeignKey("RefVirtualSchoolStatusId")]
        [InverseProperty("K12schoolStatuses")]
        public virtual RefVirtualSchoolStatus? RefVirtualSchoolStatus { get; set; }
    }
}
