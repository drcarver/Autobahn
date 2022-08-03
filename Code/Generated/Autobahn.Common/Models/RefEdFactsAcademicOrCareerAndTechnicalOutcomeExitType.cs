//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   RefEdFactsAcademicOrCareerAndTechnicalOutcomeExitType.cs
//**********************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.Common.Models
{
     /// <summary>
     /// The RefEdFactsAcademicOrCareerAndTechnicalOutcomeExitType
     /// </summary>
    public partial class RefEdFactsAcademicOrCareerAndTechnicalOutcomeExitType : IRefEdFactsAcademicOrCareerAndTechnicalOutcomeExitType
    {
        /// <summary>
        /// Defines the RefEdFactsAcademicOrCareerAndTechnicalOutcomeExitType.Description non nullable property
        /// </summary>
        public System.String Description { get; set; }

        /// <summary>
        /// Defines the RefEdFactsAcademicOrCareerAndTechnicalOutcomeExitType.Code non nullable property
        /// </summary>
        public System.String Code { get; set; }

        /// <summary>
        /// Defines the RefEdFactsAcademicOrCareerAndTechnicalOutcomeExitType.Definition non nullable property
        /// </summary>
        public System.String Definition { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefJurisdiction"/> model
        /// </summary>
        public Guid? RefJurisdictionId { get; set; }

        /// <summary>
        /// Defines the RefEdFactsAcademicOrCareerAndTechnicalOutcomeExitType.SortOrder nullable property
        /// </summary>
        public System.Decimal? SortOrder { get; set; }

        /// <summary>
        /// Defines the RefEdFactsAcademicOrCareerAndTechnicalOutcomeExitType.RecordStartDateTime nullable property
        /// </summary>
        public System.DateTime? RecordStartDateTime { get; set; }

        /// <summary>
        /// Defines the RefEdFactsAcademicOrCareerAndTechnicalOutcomeExitType.RecordEndDateTime nullable property
        /// </summary>
        public System.DateTime? RecordEndDateTime { get; set; }

    }
}