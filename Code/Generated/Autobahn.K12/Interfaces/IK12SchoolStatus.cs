//**********************************************************
//* DomainName: Autobahn.K12
//* FileName:   IK12SchoolStatus.cs
//**********************************************************

namespace Autobahn.K12.Interfaces
{
     /// <summary>
     /// The IK12SchoolStatus
     /// </summary>
    public partial interface IK12SchoolStatus
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="K12School"/> model
        /// </summary>
        Guid K12SchoolId { get; set; }

        /// <summary>
        /// Defines the K12SchoolStatus.ConsolidatedMepFundsStatus nullable property
        /// </summary>
        System.Boolean? ConsolidatedMepFundsStatus { get; set; }

        /// <summary>
        /// Defines the K12SchoolStatus.ProgressAcheivingEnglishLearnerProficiencyStateDefinedStatus non nullable property
        /// </summary>
        System.String ProgressAcheivingEnglishLearnerProficiencyStateDefinedStatus { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefMagnetSpecialProgram"/> model
        /// </summary>
        Guid? RefMagnetSpecialProgramId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefAlternativeSchoolFocus"/> model
        /// </summary>
        Guid? RefAlternativeSchoolFocusId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefInternetAccess"/> model
        /// </summary>
        Guid? RefInternetAccessId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefRestructuringAction"/> model
        /// </summary>
        Guid? RefRestructuringActionId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefTitleISchoolStatus"/> model
        /// </summary>
        Guid? RefTitleISchoolStatusId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefNSLPStatus"/> model
        /// </summary>
        Guid? RefNSLPStatusId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefSchoolDangerousStatus"/> model
        /// </summary>
        Guid? RefSchoolDangerousStatusId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefSchoolImprovementStatus"/> model
        /// </summary>
        Guid? RefSchoolImprovementStatusId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefProgressAchievingEnglishLanguageProficiencyIndicatorStatus"/> model
        /// </summary>
        Guid? RefProgressAchievingEnglishLanguageProficiencyIndicatorStatusId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefComprehensiveAndTargetedSupport"/> model
        /// </summary>
        Guid? RefComprehensiveAndTargetedSupportId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefComprehensiveSupport"/> model
        /// </summary>
        Guid? RefComprehensiveSupportId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefTargetedSupport"/> model
        /// </summary>
        Guid? RefTargetedSupportId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefNationalSchoolLunchProgramStatus"/> model
        /// </summary>
        Guid? RefNationalSchoolLunchProgramStatusId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefVirtualSchoolStatus"/> model
        /// </summary>
        Guid? RefVirtualSchoolStatusId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefBlendedLearningModelType"/> model
        /// </summary>
        Guid? RefBlendedLearningModelTypeId { get; set; }

        /// <summary>
        /// Defines the K12SchoolStatus.RecordStartDateTime nullable property
        /// </summary>
        System.DateTime? RecordStartDateTime { get; set; }

        /// <summary>
        /// Defines the K12SchoolStatus.RecordEndDateTime nullable property
        /// </summary>
        System.DateTime? RecordEndDateTime { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RecordStatus"/> model
        /// </summary>
        Guid? RecordStatusId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="DataCollection"/> model
        /// </summary>
        Guid? DataCollectionId { get; set; }

    }
}
