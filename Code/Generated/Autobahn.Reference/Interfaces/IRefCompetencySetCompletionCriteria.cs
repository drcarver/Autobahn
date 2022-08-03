//**********************************************************
//* DomainName: Autobahn.Reference
//* FileName:   IRefCompetencySetCompletionCriteria.cs
//**********************************************************

namespace Autobahn.Reference.Interfaces
{
     /// <summary>
     /// The IRefCompetencySetCompletionCriteria
     /// </summary>
    public partial interface IRefCompetencySetCompletionCriteria
    {
        /// <summary>
        /// Defines the RefCompetencySetCompletionCriteria.Description non nullable property
        /// </summary>
        System.String Description { get; set; }

        /// <summary>
        /// Defines the RefCompetencySetCompletionCriteria.Code non nullable property
        /// </summary>
        System.String Code { get; set; }

        /// <summary>
        /// Defines the RefCompetencySetCompletionCriteria.Definition non nullable property
        /// </summary>
        System.String Definition { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefJurisdiction"/> model
        /// </summary>
        Guid? RefJurisdictionId { get; set; }

        /// <summary>
        /// Defines the RefCompetencySetCompletionCriteria.SortOrder nullable property
        /// </summary>
        System.Decimal? SortOrder { get; set; }

        /// <summary>
        /// Defines the RefCompetencySetCompletionCriteria.RecordStartDateTime nullable property
        /// </summary>
        System.DateTime? RecordStartDateTime { get; set; }

        /// <summary>
        /// Defines the RefCompetencySetCompletionCriteria.RecordEndDateTime nullable property
        /// </summary>
        System.DateTime? RecordEndDateTime { get; set; }

    }
}
