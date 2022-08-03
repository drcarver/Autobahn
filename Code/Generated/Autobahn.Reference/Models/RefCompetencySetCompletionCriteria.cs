//**********************************************************
//* DomainName: Autobahn.Reference
//* FileName:   RefCompetencySetCompletionCriteria.cs
//**********************************************************

using Autobahn.Reference.Interfaces;

namespace Autobahn.Reference.Models
{
     /// <summary>
     /// The RefCompetencySetCompletionCriteria
     /// </summary>
    public partial class RefCompetencySetCompletionCriteria : IRefCompetencySetCompletionCriteria
    {
        /// <summary>
        /// Defines the RefCompetencySetCompletionCriteria.Description non nullable property
        /// </summary>
        public System.String Description { get; set; }

        /// <summary>
        /// Defines the RefCompetencySetCompletionCriteria.Code non nullable property
        /// </summary>
        public System.String Code { get; set; }

        /// <summary>
        /// Defines the RefCompetencySetCompletionCriteria.Definition non nullable property
        /// </summary>
        public System.String Definition { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefJurisdiction"/> model
        /// </summary>
        public Guid? RefJurisdictionId { get; set; }

        /// <summary>
        /// Defines the RefCompetencySetCompletionCriteria.SortOrder nullable property
        /// </summary>
        public System.Decimal? SortOrder { get; set; }

        /// <summary>
        /// Defines the RefCompetencySetCompletionCriteria.RecordStartDateTime nullable property
        /// </summary>
        public System.DateTime? RecordStartDateTime { get; set; }

        /// <summary>
        /// Defines the RefCompetencySetCompletionCriteria.RecordEndDateTime nullable property
        /// </summary>
        public System.DateTime? RecordEndDateTime { get; set; }

    }
}
