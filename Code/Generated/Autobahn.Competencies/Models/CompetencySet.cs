//**********************************************************
//* DomainName: Autobahn.Competencies
//* FileName:   CompetencySet.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.Models;

namespace Autobahn.Competencies.Models
{
     /// <summary>
     /// The CompetencySet
     /// </summary>
    public partial class CompetencySet : AutobahnBase, Interfaces.ICompetencySet
    {
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
        /// Reference to an optional instance of the <see cref="DataCollection"/> model
        /// </summary>
        public Guid? DataCollectionId { get; set; }

    }
}
