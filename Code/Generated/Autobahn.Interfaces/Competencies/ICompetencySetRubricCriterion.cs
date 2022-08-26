//***************************************************************************
//* DomainName: Competencies Interfaces (used by both models and View Models
//* FileName:   ICompetencySetRubricCriterion.cs
//***************************************************************************

using Autobahn.Interfaces.Common;

namespace Autobahn.Interfaces.Competencies
{
     /// <summary>
     /// The ICompetencySetRubricCriterion Interface
     /// </summary>
    public partial interface ICompetencySetRubricCriterion : IAutobahnBase
    {
        /// <summary>
        /// Reference to an optional instance of the <see cref="ICompetencySet"/> model
        /// </summary>
        Guid CompetencySetId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IRubricCriterion"/> model
        /// </summary>
        Guid RubricCriterionId { get; set; }

    }
}
