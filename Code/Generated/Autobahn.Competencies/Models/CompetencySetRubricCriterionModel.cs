//**********************************************************
//* DomainName: Competencies
//* FileName:   CompetencySetRubricCriterionModel.cs
//***************************************************************************

using Autobahn.Interfaces.Competencies;
using Autobahn.Interfaces.Common;
using Autobahn.Common.Models;

namespace Autobahn.Competencies.Models
{
     /// <summary>
     /// The CompetencySetRubricCriterion Model
     /// </summary>
    public partial class CompetencySetRubricCriterionModel : AutobahnBase, ICompetencySetRubricCriterion
    {
        /// <summary>
        /// Reference to an optional instance of the <see cref="ICompetencySet"/> model
        /// </summary>
        public Guid CompetencySetId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IRubricCriterion"/> model
        /// </summary>
        public Guid RubricCriterionId { get; set; }

    }
}
