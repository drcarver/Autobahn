//**********************************************************
//* DomainName: Competencies
//* FileName:   CompetencySetRubricCriterionModel.cs
//***************************************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.Models;

namespace Autobahn.Competencies.Models
{
     /// <summary>
     /// The CompetencySetRubricCriterion Model
     /// </summary>
    public partial class CompetencySetRubricCriterionModel : AutobahnBase, Interfaces.ICompetencySetRubricCriterion
    {
        /// <summary>
        /// Reference to an optional instance of the <see cref="ICompetencySet"/> model
        /// </summary>
        public Guid CompetencySetId { get; set; }

        /// <summary>
        /// Rubric Criterion Category
        /// <para>
        /// A textual label for category by which Rubric Criterion may be grouped.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20441">Rubric Criterion Category</a>
        /// </para>
        /// </summary>
        public Guid RubricCriterionId { get; set; }

    }
}
