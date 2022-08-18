//**********************************************************
//* DomainName: Competencies
//* FileName:   CompetencySetModel.cs
//***************************************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.Models;

namespace Autobahn.Competencies.Models
{
     /// <summary>
     /// The CompetencySet Model
     /// </summary>
    public partial class CompetencySetModel : AutobahnBase, Interfaces.ICompetencySet
    {
        public System.Int32? ChildOfCompetencySet { get; set; }

        /// <summary>
        /// Competency Set Completion Criteria Threshold
        /// <para>
        /// The minimum number of competencies in the set that must be achieved for completion or partial completion of a unit, course, program, degree, certification, or other achievement/award.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19878">Competency Set Completion Criteria Threshold</a>
        /// </para>
        /// </summary>
        public System.Int32? CompletionCriteriaThreshold { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefCompletionCriteria"/> model
        /// </summary>
        public Guid? RefCompletionCriteriaId { get; set; }

    }
}
