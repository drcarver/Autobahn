using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Autobahn.Entities
{
    [Table("K12SchoolStatus")]
    public partial class K12SchoolStatus
    {
        public int K12SchoolStatusId { get; set; }

        public int K12SchoolId { get; set; }

        public bool? ConsolidatedMepFundsStatus { get; set; }

        [StringLength(50)]
        public string ProgressAcheivingEnglishLearnerProficiencyStateDefinedStatus { get; set; }

        public int? RefMagnetSpecialProgramId { get; set; }

        public int? RefAlternativeSchoolFocusId { get; set; }

        public int? RefInternetAccessId { get; set; }

        public int? RefRestructuringActionId { get; set; }

        public int? RefTitleISchoolStatusId { get; set; }

        public int? RefNSLPStatusId { get; set; }

        public int? RefSchoolDangerousStatusId { get; set; }

        public int? RefSchoolImprovementStatusId { get; set; }

        public int? RefProgressAchievingEnglishLanguageProficiencyIndicatorStatusId { get; set; }

        public int? RefComprehensiveAndTargetedSupportId { get; set; }

        public int? RefComprehensiveSupportId { get; set; }

        public int? RefTargetedSupportId { get; set; }

        public int? RefNationalSchoolLunchProgramStatusId { get; set; }

        public int? RefVirtualSchoolStatusId { get; set; }

        public int? RefBlendedLearningModelTypeId { get; set; }

        public DateTime? RecordStartDateTime { get; set; }

        public DateTime? RecordEndDateTime { get; set; }

        public Guid? RecordStatusId { get; set; }

        public Guid? DataCollectionId { get; set; }

        public virtual DataCollection DataCollection { get; set; }

        public virtual K12School K12School { get; set; }

        public virtual RecordStatus RecordStatus { get; set; }

        public virtual RefAlternativeSchoolFocus RefAlternativeSchoolFocus { get; set; }

        public virtual RefBlendedLearningModelType RefBlendedLearningModelType { get; set; }

        public virtual RefComprehensiveAndTargetedSupport RefComprehensiveAndTargetedSupport { get; set; }

        public virtual RefComprehensiveSupport RefComprehensiveSupport { get; set; }

        public virtual RefInternetAccess RefInternetAccess { get; set; }

        public virtual RefMagnetSpecialProgram RefMagnetSpecialProgram { get; set; }

        public virtual RefNationalSchoolLunchProgramStatus RefNationalSchoolLunchProgramStatus { get; set; }

        public virtual RefNSLPStatus RefNSLPStatus { get; set; }

        public virtual RefProgressAchievingEnglishLanguageProficiencyIndicatorStatus RefProgressAchievingEnglishLanguageProficiencyIndicatorStatus { get; set; }

        public virtual RefRestructuringAction RefRestructuringAction { get; set; }

        public virtual RefSchoolDangerousStatus RefSchoolDangerousStatus { get; set; }

        public virtual RefSchoolImprovementStatus RefSchoolImprovementStatus { get; set; }

        public virtual RefTargetedSupport RefTargetedSupport { get; set; }

        public virtual RefTitleISchoolStatus RefTitleISchoolStatus { get; set; }

        public virtual RefVirtualSchoolStatus RefVirtualSchoolStatus { get; set; }
    }
}
