using System;
using System.ComponentModel.DataAnnotations;

namespace Autobahn.Entities
{
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

        public int? RecordStatusId { get; set; }

        public int? DataCollectionId { get; set; }

        public virtual DataCollection DataCollection { get; set; }

        public virtual K12School K12School { get; set; }

        public virtual RecordStatus RecordStatus { get; set; }

        public virtual RefAlternativeSchoolFocu RefAlternativeSchoolFocu { get; set; }

        public virtual RefBlendedLearningModelType RefBlendedLearningModelType { get; set; }

        public virtual RefComprehensiveAndTargetedSupport RefComprehensiveAndTargetedSupport { get; set; }

        public virtual RefComprehensiveSupport RefComprehensiveSupport { get; set; }

        public virtual RefInternetAccess RefInternetAccess { get; set; }

        public virtual RefMagnetSpecialProgram RefMagnetSpecialProgram { get; set; }

        public virtual RefNationalSchoolLunchProgramStatu RefNationalSchoolLunchProgramStatu { get; set; }

        public virtual RefNSLPStatu RefNSLPStatu { get; set; }

        public virtual RefProgressAchievingEnglishLanguageProficiencyIndicatorStatu RefProgressAchievingEnglishLanguageProficiencyIndicatorStatu { get; set; }

        public virtual RefRestructuringAction RefRestructuringAction { get; set; }

        public virtual RefSchoolDangerousStatu RefSchoolDangerousStatu { get; set; }

        public virtual RefSchoolImprovementStatu RefSchoolImprovementStatu { get; set; }

        public virtual RefTargetedSupport RefTargetedSupport { get; set; }

        public virtual RefTitleISchoolStatu RefTitleISchoolStatu { get; set; }

        public virtual RefVirtualSchoolStatu RefVirtualSchoolStatu { get; set; }
    }
}
