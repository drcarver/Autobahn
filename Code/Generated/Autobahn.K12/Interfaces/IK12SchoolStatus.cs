//***************************************************************************
//* DomainName: Elementary and Secondary (K12) Interfaces (used by both models and View Models
//* FileName:   IK12SchoolStatus.cs
//***************************************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.K12.Interfaces
{
     /// <summary>
     /// The IK12SchoolStatus Interface
     /// </summary>
    public partial interface IK12SchoolStatus : IAutobahnBase
    {
        /// <summary>
        /// An indication of the specific group of students whose needs the alternative school is designed to meet.
        /// </summary>
        System.Boolean? ConsolidatedMepFundsStatus { get; set; }

        /// <summary>
        /// An indication of the specific group of students whose needs the alternative school is designed to meet.
        /// </summary>
        Guid K12SchoolId { get; set; }

        /// <summary>
        /// An indication of the specific group of students whose needs the alternative school is designed to meet.
        /// </summary>
        System.String ProgressAcheivingEnglishLearnerProficiencyStateDefinedStatus { get; set; }

        /// <summary>
        /// An indication of the specific group of students whose needs the alternative school is designed to meet.
        /// </summary>
        Guid? RefAlternativeSchoolFocusId { get; set; }

        /// <summary>
        /// An indication of the specific group of students whose needs the alternative school is designed to meet.
        /// </summary>
        Guid? RefBlendedLearningModelTypeId { get; set; }

        /// <summary>
        /// An indication of the specific group of students whose needs the alternative school is designed to meet.
        /// </summary>
        Guid? RefComprehensiveAndTargetedSupportId { get; set; }

        /// <summary>
        /// An indication of the specific group of students whose needs the alternative school is designed to meet.
        /// </summary>
        Guid? RefComprehensiveSupportId { get; set; }

        /// <summary>
        /// An indication of the specific group of students whose needs the alternative school is designed to meet.
        /// </summary>
        Guid? RefInternetAccessId { get; set; }

        /// <summary>
        /// An indication of the specific group of students whose needs the alternative school is designed to meet.
        /// </summary>
        Guid? RefMagnetSpecialProgramId { get; set; }

        /// <summary>
        /// An indication of the specific group of students whose needs the alternative school is designed to meet.
        /// </summary>
        Guid? RefNationalSchoolLunchProgramStatusId { get; set; }

        /// <summary>
        /// An indication of the specific group of students whose needs the alternative school is designed to meet.
        /// </summary>
        Guid? RefNSLPStatusId { get; set; }

        /// <summary>
        /// An indication of the specific group of students whose needs the alternative school is designed to meet.
        /// </summary>
        Guid? RefProgressAchievingEnglishLanguageProficiencyIndicatorStatusId { get; set; }

        /// <summary>
        /// An indication of the specific group of students whose needs the alternative school is designed to meet.
        /// </summary>
        Guid? RefRestructuringActionId { get; set; }

        /// <summary>
        /// An indication of the specific group of students whose needs the alternative school is designed to meet.
        /// </summary>
        Guid? RefSchoolDangerousStatusId { get; set; }

        /// <summary>
        /// An indication of the specific group of students whose needs the alternative school is designed to meet.
        /// </summary>
        Guid? RefSchoolImprovementStatusId { get; set; }

        /// <summary>
        /// An indication of the specific group of students whose needs the alternative school is designed to meet.
        /// </summary>
        Guid? RefTargetedSupportId { get; set; }

        /// <summary>
        /// An indication of the specific group of students whose needs the alternative school is designed to meet.
        /// </summary>
        Guid? RefTitleISchoolStatusId { get; set; }

        /// <summary>
        /// An indication of the specific group of students whose needs the alternative school is designed to meet.
        /// </summary>
        Guid? RefVirtualSchoolStatusId { get; set; }

    }
}
