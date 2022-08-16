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
        /// 
        /// </summary>
         ConsolidatedMepFundsStatus { get; set; }

        /// <summary>
        /// 
        /// </summary>
         ProgressAcheivingEnglishLearnerProficiencyStateDefinedStatus { get; set; }

        /// <summary>
        /// 
        /// </summary>
         RecordEndDateTime { get; set; }

        /// <summary>
        /// 
        /// </summary>
         RecordStartDateTime { get; set; }

        /// <summary>
        /// 
        /// </summary>
        Guid? RefAlternativeSchoolFocusId { get; set; }

        /// <summary>
        /// 
        /// </summary>
         RefBlendedLearningModelTypeId { get; set; }

        /// <summary>
        /// 
        /// </summary>
         RefInternetAccessId { get; set; }

        /// <summary>
        /// 
        /// </summary>
         RefMagnetSpecialProgramId { get; set; }

        /// <summary>
        /// 
        /// </summary>
         RefNationalSchoolLunchProgramStatusId { get; set; }

        /// <summary>
        /// 
        /// </summary>
         RefProgressAchievingEnglishLanguageProficiencyIndicatorStatusId { get; set; }

        /// <summary>
        /// 
        /// </summary>
         RefRestructuringActionId { get; set; }

        /// <summary>
        /// 
        /// </summary>
         RefTitleISchoolStatusId { get; set; }

        /// <summary>
        /// 
        /// </summary>
         RefVirtualSchoolStatusId { get; set; }

    }
}
