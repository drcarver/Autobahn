//**********************************************************
//* DomainName: Autobahn.Competencies
//* FileName:   CompetencySet_RubricCriterion.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.Models;

namespace Autobahn.Competencies.Models
{
     /// <summary>
     /// The CompetencySet_RubricCriterion
     /// </summary>
    public partial class CompetencySet_RubricCriterion : AutobahnBase, Interfaces.ICompetencySet_RubricCriterion
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="CompetencySet"/> model
        /// </summary>
        public Guid CompetencySetId { get; set; }

        /// <summary>
        /// Reference to a required instance of the <see cref="RubricCriterion"/> model
        /// </summary>
        public Guid RubricCriterionId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="DataCollection"/> model
        /// </summary>
        public Guid? DataCollectionId { get; set; }

    }
}
