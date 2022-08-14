//**********************************************************
//* DomainName: Competencies
//* FileName:   CompetencySet_RubricModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.Models;

namespace Autobahn.Competencies.Models
{
     /// <summary>
     /// The CompetencySet_Rubric Model
     /// </summary>
    public partial class CompetencySet_RubricModel : AutobahnBase, Interfaces.ICompetencySet_Rubric
    {
        /// <summary>
        /// The start date and, optionally, time that a record is active as used to support version control.
        /// </summary>
        public Guid CompetencySetId { get; set; }

        /// <summary>
        /// The start date and, optionally, time that a record is active as used to support version control.
        /// </summary>
        public Guid RubricId { get; set; }

    }
}
