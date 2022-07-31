//**********************************************************
//* DomainName: Autobahn.Competencies
//* FileName:   ICompetencySet.cs
//**********************************************************

namespace Autobahn.Competencies.Interfaces
{
     /// <summary>
     /// The ICompetencySet
     /// </summary>
    public partial Interface ICompetencySet
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="CompetencySet"/> model
        /// </summary>
        Guid CompetencySetId { get; set; }

        /// <summary>
        /// Defines the CompetencySet.ChildOf_CompetencySet nullable property
        /// </summary>
        System.Int32? ChildOf_CompetencySet { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefCompletionCriteria"/> model
        /// </summary>
        Guid? RefCompletionCriteriaId { get; set; }

        /// <summary>
        /// Defines the CompetencySet.CompletionCriteriaThreshold nullable property
        /// </summary>
        System.Int32? CompletionCriteriaThreshold { get; set; }

        /// <summary>
        /// Defines the CompetencySet.RecordStartDateTime nullable property
        /// </summary>
        System.DateTime? RecordStartDateTime { get; set; }

        /// <summary>
        /// Defines the CompetencySet.RecordEndDateTime nullable property
        /// </summary>
        System.DateTime? RecordEndDateTime { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RecordStatus"/> model
        /// </summary>
        Guid? RecordStatusId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="DataCollection"/> model
        /// </summary>
        Guid? DataCollectionId { get; set; }

    }
}
