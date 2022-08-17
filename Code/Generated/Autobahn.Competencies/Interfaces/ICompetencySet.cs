//***************************************************************************
//* DomainName: Competencies Interfaces (used by both models and View Models
//* FileName:   ICompetencySet.cs
//***************************************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.Competencies.Interfaces
{
     /// <summary>
     /// The ICompetencySet Interface
     /// </summary>
    public partial interface ICompetencySet : IAutobahnBase
    {
        System.Int32? ChildOfCompetencySet { get; set; }

        /// <summary>
        /// Competency Set Completion Criteria Threshold
        /// <para>
        /// The minimum number of competencies in the set that must be achieved for completion or partial completion of a unit, course, program, degree, certification, or other achievement/award.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19878">Competency Set Completion Criteria Threshold</a>
        /// </para>
        /// </summary>
        System.Int32? CompletionCriteriaThreshold { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IRefCompletionCriteria"/> model
        /// </summary>
        Guid? RefCompletionCriteriaId { get; set; }

    }
}
