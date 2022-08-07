//**********************************************************
//* DomainName: Autobahn.Competencies
//* FileName:   ICompetencySet_RubricCriterionModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.Competencies.Interfaces
{
     /// <summary>
     /// The ICompetencySet_RubricCriterionModel Interface
     /// </summary>
    public partial interface ICompetencySet_RubricCriterionModel : IAutobahnBase
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="CompetencySet"/> model
        /// </summary>
        Guid CompetencySetId { get; set; }

        /// <summary>
        /// Reference to a required instance of the <see cref="RubricCriterion"/> model
        /// </summary>
        Guid RubricCriterionId { get; set; }

    }
}
