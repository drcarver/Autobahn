//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   IRefEdFactsAcademicOrCareerAndTechnicalOutcomeType.cs
//**********************************************************

namespace Autobahn.Common.Interfaces
{
     /// <summary>
     /// The IRefEdFactsAcademicOrCareerAndTechnicalOutcomeType
     /// </summary>
    public partial interface IRefEdFactsAcademicOrCareerAndTechnicalOutcomeType
    {
        /// <summary>
        /// Defines the RefEdFactsAcademicOrCareerAndTechnicalOutcomeType.Description non nullable property
        /// </summary>
        System.String Description { get; set; }

        /// <summary>
        /// Defines the RefEdFactsAcademicOrCareerAndTechnicalOutcomeType.Code non nullable property
        /// </summary>
        System.String Code { get; set; }

        /// <summary>
        /// Defines the RefEdFactsAcademicOrCareerAndTechnicalOutcomeType.Definition non nullable property
        /// </summary>
        System.String Definition { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefJurisdiction"/> model
        /// </summary>
        Guid? RefJurisdictionId { get; set; }

        /// <summary>
        /// Defines the RefEdFactsAcademicOrCareerAndTechnicalOutcomeType.SortOrder nullable property
        /// </summary>
        System.Decimal? SortOrder { get; set; }

        /// <summary>
        /// Defines the RefEdFactsAcademicOrCareerAndTechnicalOutcomeType.RecordStartDateTime nullable property
        /// </summary>
        System.DateTime? RecordStartDateTime { get; set; }

        /// <summary>
        /// Defines the RefEdFactsAcademicOrCareerAndTechnicalOutcomeType.RecordEndDateTime nullable property
        /// </summary>
        System.DateTime? RecordEndDateTime { get; set; }

    }
}
