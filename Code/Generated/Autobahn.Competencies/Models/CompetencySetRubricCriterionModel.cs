//**********************************************************
//* DomainName: Competencies
//* FileName:   CompetencySetRubricCriterionModel.cs
//**********************************************************

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
        /// The start date and, optionally, time that a record is active as used to support version control.
        /// </summary>
        public Guid CompetencySetId { get; set; }

        /// <summary>
        /// The start date and, optionally, time that a record is active as used to support version control.
        /// </summary>
        public Guid RubricCriterionId { get; set; }

    }
}
