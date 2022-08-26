//**********************************************************
//* DomainName: Competencies
//* FileName:   CompetencySetModel.cs
//***************************************************************************

using Autobahn.Interfaces.Competencies;
using Autobahn.Interfaces.Common;
using Autobahn.Common.Models;

namespace Autobahn.Competencies.Models
{
     /// <summary>
     /// The CompetencySet Model
     /// </summary>
    public partial class CompetencySetModel : AutobahnBase, ICompetencySet
    {
        public Int32? ChildOfCompetencySet { get; set; }

        /// <summary>
        /// Competency Set Completion Criteria Threshold
        /// <para>
        /// The minimum number of competencies in the set that must be achieved for completion or partial completion of a unit, course, program, degree, certification, or other achievement/award.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19878">Competency Set Completion Criteria Threshold</a>
        /// </para>
        /// </summary>
        public Int32? CompletionCriteriaThreshold { get; set; }

        /// <summary>
        /// Competency Set Completion Criteria
        /// <para>
        /// The criteria for the set of competencies that represent completion or partial completion of a unit, course, program, degree, certification, or other achievement/award. Specifies whether completion requires achievement of all items in the set or some number of items.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19877">Competency Set Completion Criteria</a>
        /// </para>
        /// </summary>
        public Guid? RefCompletionCriteriaId { get; set; }

    }
}
