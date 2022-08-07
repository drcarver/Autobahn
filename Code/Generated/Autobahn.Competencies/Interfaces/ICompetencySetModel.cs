//**********************************************************
//* DomainName: Autobahn.Competencies
//* FileName:   ICompetencySetModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.Competencies.Interfaces
{
     /// <summary>
     /// The ICompetencySetModel Interface
     /// </summary>
    public partial interface ICompetencySetModel : IAutobahnBase
    {
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

    }
}
