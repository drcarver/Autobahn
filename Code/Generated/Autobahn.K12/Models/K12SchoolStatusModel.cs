//**********************************************************
//* DomainName: Elementary and Secondary (K12)
//* FileName:   K12SchoolStatusModel.cs
//* Name:       Consolidated Migrant Education Program Funds Status
//* Definition: An indication of whether the school has a school-wide program, as defined by current law, in which federal Migrant Education Program (MEP) funds are consolidated.
//***************************************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.Models;

namespace Autobahn.K12.Models
{
     /// <summary>
     /// An indication of whether the school has a school-wide program, as defined by current law, in which federal Migrant Education Program (MEP) funds are consolidated.
     /// </summary>
    public partial class K12SchoolStatusModel : AutobahnBase, Interfaces.IK12SchoolStatus
    {
        /// <summary>
        /// Consolidated Migrant Education Program Funds Status
        /// <para>
        /// An indication of whether the school has a school-wide program, as defined by current law, in which federal Migrant Education Program (MEP) funds are consolidated.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19533">Consolidated Migrant Education Program Funds Status</a>
        /// </para>
        /// </summary>
        public System.Boolean? ConsolidatedMepFundsStatus { get; set; }

        /// <summary>
        /// Accreditation Agency Name
        /// <para>
        /// The full name of an agency that accredited a school.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20500">Accreditation Agency Name</a>
        /// </para>
        /// </summary>
        public Guid K12SchoolId { get; set; }

        /// <summary>
        /// Progress Achieving English Language Proficiency State Defined Status
        /// <para>
        /// The state defined status assigned to the school's performance on the progress of achieving the English language proficiency indicator.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20897">Progress Achieving English Language Proficiency State Defined Status</a>
        /// </para>
        /// </summary>
        public System.String ProgressAcheivingEnglishLearnerProficiencyStateDefinedStatus { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefAlternativeSchoolFocus"/> model
        /// </summary>
        public Guid? RefAlternativeSchoolFocusId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefBlendedLearningModelType"/> model
        /// </summary>
        public Guid? RefBlendedLearningModelTypeId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefComprehensiveAndTargetedSupport"/> model
        /// </summary>
        public Guid? RefComprehensiveAndTargetedSupportId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefComprehensiveSupport"/> model
        /// </summary>
        public Guid? RefComprehensiveSupportId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefInternetAccess"/> model
        /// </summary>
        public Guid? RefInternetAccessId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefMagnetSpecialProgram"/> model
        /// </summary>
        public Guid? RefMagnetSpecialProgramId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefNationalSchoolLunchProgramStatus"/> model
        /// </summary>
        public Guid? RefNationalSchoolLunchProgramStatusId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefNSLPStatus"/> model
        /// </summary>
        public Guid? RefNSLPStatusId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefProgressAchievingEnglishLanguageProficiencyIndicatorStatus"/> model
        /// </summary>
        public Guid? RefProgressAchievingEnglishLanguageProficiencyIndicatorStatusId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefRestructuringAction"/> model
        /// </summary>
        public Guid? RefRestructuringActionId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefSchoolDangerousStatus"/> model
        /// </summary>
        public Guid? RefSchoolDangerousStatusId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefSchoolImprovementStatus"/> model
        /// </summary>
        public Guid? RefSchoolImprovementStatusId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefTargetedSupport"/> model
        /// </summary>
        public Guid? RefTargetedSupportId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefTitleISchoolStatus"/> model
        /// </summary>
        public Guid? RefTitleISchoolStatusId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefVirtualSchoolStatus"/> model
        /// </summary>
        public Guid? RefVirtualSchoolStatusId { get; set; }

    }
}
