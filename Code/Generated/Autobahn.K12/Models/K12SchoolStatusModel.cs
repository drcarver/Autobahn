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
        /// An indication of the specific group of students whose needs the alternative school is designed to meet.
        /// </summary>
        public System.Boolean? ConsolidatedMepFundsStatus { get; set; }

        /// <summary>
        /// An indication of the specific group of students whose needs the alternative school is designed to meet.
        /// </summary>
        public Guid K12SchoolId { get; set; }

        /// <summary>
        /// An indication of the specific group of students whose needs the alternative school is designed to meet.
        /// </summary>
        public System.String ProgressAcheivingEnglishLearnerProficiencyStateDefinedStatus { get; set; }

        /// <summary>
        /// An indication of the specific group of students whose needs the alternative school is designed to meet.
        /// </summary>
        public Guid? RefAlternativeSchoolFocusId { get; set; }

        /// <summary>
        /// An indication of the specific group of students whose needs the alternative school is designed to meet.
        /// </summary>
        public Guid? RefBlendedLearningModelTypeId { get; set; }

        /// <summary>
        /// An indication of the specific group of students whose needs the alternative school is designed to meet.
        /// </summary>
        public Guid? RefComprehensiveAndTargetedSupportId { get; set; }

        /// <summary>
        /// An indication of the specific group of students whose needs the alternative school is designed to meet.
        /// </summary>
        public Guid? RefComprehensiveSupportId { get; set; }

        /// <summary>
        /// An indication of the specific group of students whose needs the alternative school is designed to meet.
        /// </summary>
        public Guid? RefInternetAccessId { get; set; }

        /// <summary>
        /// An indication of the specific group of students whose needs the alternative school is designed to meet.
        /// </summary>
        public Guid? RefMagnetSpecialProgramId { get; set; }

        /// <summary>
        /// An indication of the specific group of students whose needs the alternative school is designed to meet.
        /// </summary>
        public Guid? RefNationalSchoolLunchProgramStatusId { get; set; }

        /// <summary>
        /// An indication of the specific group of students whose needs the alternative school is designed to meet.
        /// </summary>
        public Guid? RefNSLPStatusId { get; set; }

        /// <summary>
        /// An indication of the specific group of students whose needs the alternative school is designed to meet.
        /// </summary>
        public Guid? RefProgressAchievingEnglishLanguageProficiencyIndicatorStatusId { get; set; }

        /// <summary>
        /// An indication of the specific group of students whose needs the alternative school is designed to meet.
        /// </summary>
        public Guid? RefRestructuringActionId { get; set; }

        /// <summary>
        /// An indication of the specific group of students whose needs the alternative school is designed to meet.
        /// </summary>
        public Guid? RefSchoolDangerousStatusId { get; set; }

        /// <summary>
        /// An indication of the specific group of students whose needs the alternative school is designed to meet.
        /// </summary>
        public Guid? RefSchoolImprovementStatusId { get; set; }

        /// <summary>
        /// An indication of the specific group of students whose needs the alternative school is designed to meet.
        /// </summary>
        public Guid? RefTargetedSupportId { get; set; }

        /// <summary>
        /// An indication of the specific group of students whose needs the alternative school is designed to meet.
        /// </summary>
        public Guid? RefTitleISchoolStatusId { get; set; }

        /// <summary>
        /// An indication of the specific group of students whose needs the alternative school is designed to meet.
        /// </summary>
        public Guid? RefVirtualSchoolStatusId { get; set; }

    }
}
