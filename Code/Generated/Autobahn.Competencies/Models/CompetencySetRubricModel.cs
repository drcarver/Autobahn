//**********************************************************
//* DomainName: Competencies
//* FileName:   CompetencySetRubricModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.Models;

namespace Autobahn.Competencies.Models
{
     /// <summary>
     /// The CompetencySetRubric Model
     /// </summary>
    public partial class CompetencySetRubricModel : AutobahnBase, Interfaces.ICompetencySetRubric
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
