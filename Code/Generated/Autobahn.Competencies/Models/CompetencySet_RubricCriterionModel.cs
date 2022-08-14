//**********************************************************
//* DomainName: Competencies
//* FileName:   CompetencySet_RubricCriterionModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.Models;

namespace Autobahn.Competencies.Models
{
     /// <summary>
     /// The CompetencySet_RubricCriterion Model
     /// </summary>
    public partial class CompetencySet_RubricCriterionModel : AutobahnBase, Interfaces.ICompetencySet_RubricCriterion
    {
        /// <summary>
        /// The start date and, optionally, time that a record is active as used to support version control.
        /// </summary>
        public Guid CompetencySetId { get; set; }

        /// <summary>
        /// The start date and, optionally, time that a record is active as used to support version control.
        /// </summary>
        public Guid RubricCriterionId { get; set; }

    }
}
