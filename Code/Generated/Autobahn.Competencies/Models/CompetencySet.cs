//**********************************************************
//* DomainName: Autobahn.Competencies
//* FileName:   CompetencySet.cs
//**********************************************************

using Autobahn.Competencies.Interfaces;

namespace Autobahn.Competencies.Models
{
     /// <summary>
     /// The CompetencySet
     /// </summary>
    public partial class CompetencySet : ICompetencySet
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="CompetencySet"/> model
        /// </summary>
        public Guid CompetencySetId { get; set; }

        /// <summary>
        /// Defines the CompetencySet.ChildOf_CompetencySet nullable property
        /// </summary>
        public System.Int32? ChildOf_CompetencySet { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefCompletionCriteria"/> model
        /// </summary>
        public Guid? RefCompletionCriteriaId { get; set; }

        /// <summary>
        /// Defines the CompetencySet.CompletionCriteriaThreshold nullable property
        /// </summary>
        public System.Int32? CompletionCriteriaThreshold { get; set; }

        /// <summary>
        /// Defines the CompetencySet.RecordStartDateTime nullable property
        /// </summary>
        public System.DateTime? RecordStartDateTime { get; set; }

        /// <summary>
        /// Defines the CompetencySet.RecordEndDateTime nullable property
        /// </summary>
        public System.DateTime? RecordEndDateTime { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RecordStatus"/> model
        /// </summary>
        public Guid? RecordStatusId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="DataCollection"/> model
        /// </summary>
        public Guid? DataCollectionId { get; set; }

    }
}
