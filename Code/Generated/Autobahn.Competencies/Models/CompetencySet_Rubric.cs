//**********************************************************
//* DomainName: Autobahn.Competencies
//* FileName:   CompetencySet_Rubric.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.Models;

namespace Autobahn.Competencies.Models
{
     /// <summary>
     /// The CompetencySet_Rubric
     /// </summary>
    public partial class CompetencySet_Rubric : AutobahnBase, Interfaces.ICompetencySet_Rubric
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="CompetencySet"/> model
        /// </summary>
        public Guid CompetencySetId { get; set; }

        /// <summary>
        /// Reference to a required instance of the <see cref="Rubric"/> model
        /// </summary>
        public Guid RubricId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="DataCollection"/> model
        /// </summary>
        public Guid? DataCollectionId { get; set; }

    }
}
