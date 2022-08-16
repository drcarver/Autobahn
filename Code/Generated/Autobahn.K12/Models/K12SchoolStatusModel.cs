//**********************************************************
//* DomainName: Elementary and Secondary (K12)
//* FileName:   K12SchoolStatusModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.Models;

namespace Autobahn.K12.Models
{
     /// <summary>
     /// The K12SchoolStatus Model
     /// </summary>
    public partial class K12SchoolStatusModel : AutobahnBase, Interfaces.IK12SchoolStatus
    {
        /// <summary>
        /// 
        /// </summary>
        public  ConsolidatedMepFundsStatus { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  ProgressAcheivingEnglishLearnerProficiencyStateDefinedStatus { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  RecordEndDateTime { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  RecordStartDateTime { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public Guid? RefAlternativeSchoolFocusId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  RefBlendedLearningModelTypeId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  RefInternetAccessId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  RefMagnetSpecialProgramId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  RefNationalSchoolLunchProgramStatusId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  RefProgressAchievingEnglishLanguageProficiencyIndicatorStatusId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  RefRestructuringActionId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  RefTitleISchoolStatusId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  RefVirtualSchoolStatusId { get; set; }

    }
}
