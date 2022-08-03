//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   RefEdFactsAcademicOrCareerAndTechnicalOutcomeType.cs
//**********************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.Common.Models
{
     /// <summary>
     /// The RefEdFactsAcademicOrCareerAndTechnicalOutcomeType
     /// </summary>
    public partial class RefEdFactsAcademicOrCareerAndTechnicalOutcomeType : IRefEdFactsAcademicOrCareerAndTechnicalOutcomeType
    {
        /// <summary>
        /// Defines the RefEdFactsAcademicOrCareerAndTechnicalOutcomeType.Description non nullable property
        /// </summary>
        public System.String Description { get; set; }

        /// <summary>
        /// Defines the RefEdFactsAcademicOrCareerAndTechnicalOutcomeType.Code non nullable property
        /// </summary>
        public System.String Code { get; set; }

        /// <summary>
        /// Defines the RefEdFactsAcademicOrCareerAndTechnicalOutcomeType.Definition non nullable property
        /// </summary>
        public System.String Definition { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefJurisdiction"/> model
        /// </summary>
        public Guid? RefJurisdictionId { get; set; }

        /// <summary>
        /// Defines the RefEdFactsAcademicOrCareerAndTechnicalOutcomeType.SortOrder nullable property
        /// </summary>
        public System.Decimal? SortOrder { get; set; }

        /// <summary>
        /// Defines the RefEdFactsAcademicOrCareerAndTechnicalOutcomeType.RecordStartDateTime nullable property
        /// </summary>
        public System.DateTime? RecordStartDateTime { get; set; }

        /// <summary>
        /// Defines the RefEdFactsAcademicOrCareerAndTechnicalOutcomeType.RecordEndDateTime nullable property
        /// </summary>
        public System.DateTime? RecordEndDateTime { get; set; }

    }
}
