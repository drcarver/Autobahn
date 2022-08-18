//***************************************************************************
//* DomainName: Elementary and Secondary (K12) Interfaces (used by both models and View Models
//* FileName:   IK12SchoolStatus.cs
//* Name:       Consolidated Migrant Education Program Funds Status
//* Definition: Consolidated MEP Funds Status
//***************************************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.K12.Interfaces
{
     /// <summary>
     /// Consolidated MEP Funds Status
     /// </summary>
    public partial interface IK12SchoolStatus : IAutobahnBase
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
        System.Boolean? ConsolidatedMepFundsStatus { get; set; }

        /// <summary>
        /// Accreditation Agency Name
        /// <para>
        /// The full name of an agency that accredited a school.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20500">Accreditation Agency Name</a>
        /// </para>
        /// </summary>
        Guid K12SchoolId { get; set; }

        /// <summary>
        /// Progress Achieving English Language Proficiency State Defined Status
        /// <para>
        /// The state defined status assigned to the school's performance on the progress of achieving the English language proficiency indicator.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20897">Progress Achieving English Language Proficiency State Defined Status</a>
        /// </para>
        /// </summary>
        System.String ProgressAcheivingEnglishLearnerProficiencyStateDefinedStatus { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefAlternativeSchoolFocus"/> model
        /// </summary>
        Guid? RefAlternativeSchoolFocusId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefBlendedLearningModelType"/> model
        /// </summary>
        Guid? RefBlendedLearningModelTypeId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefComprehensiveAndTargetedSupport"/> model
        /// </summary>
        Guid? RefComprehensiveAndTargetedSupportId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefComprehensiveSupport"/> model
        /// </summary>
        Guid? RefComprehensiveSupportId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefInternetAccess"/> model
        /// </summary>
        Guid? RefInternetAccessId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefMagnetSpecialProgram"/> model
        /// </summary>
        Guid? RefMagnetSpecialProgramId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefNationalSchoolLunchProgramStatus"/> model
        /// </summary>
        Guid? RefNationalSchoolLunchProgramStatusId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefNSLPStatus"/> model
        /// </summary>
        Guid? RefNSLPStatusId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefProgressAchievingEnglishLanguageProficiencyIndicatorStatus"/> model
        /// </summary>
        Guid? RefProgressAchievingEnglishLanguageProficiencyIndicatorStatusId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefRestructuringAction"/> model
        /// </summary>
        Guid? RefRestructuringActionId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefSchoolDangerousStatus"/> model
        /// </summary>
        Guid? RefSchoolDangerousStatusId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefSchoolImprovementStatus"/> model
        /// </summary>
        Guid? RefSchoolImprovementStatusId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefTargetedSupport"/> model
        /// </summary>
        Guid? RefTargetedSupportId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefTitleISchoolStatus"/> model
        /// </summary>
        Guid? RefTitleISchoolStatusId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefVirtualSchoolStatus"/> model
        /// </summary>
        Guid? RefVirtualSchoolStatusId { get; set; }

    }
}
