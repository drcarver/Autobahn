//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   IRefEdFactsAcademicOrCareerAndTechnicalOutcomeExitType.cs
//**********************************************************

namespace Autobahn.Common.Interfaces
{
     /// <summary>
     /// The IRefEdFactsAcademicOrCareerAndTechnicalOutcomeExitType
     /// </summary>
    public partial interface IRefEdFactsAcademicOrCareerAndTechnicalOutcomeExitType
    {
        /// <summary>
        /// Defines the RefEdFactsAcademicOrCareerAndTechnicalOutcomeExitType.Description non nullable property
        /// </summary>
        System.String Description { get; set; }

        /// <summary>
        /// Defines the RefEdFactsAcademicOrCareerAndTechnicalOutcomeExitType.Code non nullable property
        /// </summary>
        System.String Code { get; set; }

        /// <summary>
        /// Defines the RefEdFactsAcademicOrCareerAndTechnicalOutcomeExitType.Definition non nullable property
        /// </summary>
        System.String Definition { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefJurisdiction"/> model
        /// </summary>
        Guid? RefJurisdictionId { get; set; }

        /// <summary>
        /// Defines the RefEdFactsAcademicOrCareerAndTechnicalOutcomeExitType.SortOrder nullable property
        /// </summary>
        System.Decimal? SortOrder { get; set; }

        /// <summary>
        /// Defines the RefEdFactsAcademicOrCareerAndTechnicalOutcomeExitType.RecordStartDateTime nullable property
        /// </summary>
        System.DateTime? RecordStartDateTime { get; set; }

        /// <summary>
        /// Defines the RefEdFactsAcademicOrCareerAndTechnicalOutcomeExitType.RecordEndDateTime nullable property
        /// </summary>
        System.DateTime? RecordEndDateTime { get; set; }

    }
}
