//**********************************************************
//* DomainName: Competencies
//* FileName:   CompetencyDefinitionCompetencySetModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.Models;

namespace Autobahn.Competencies.Models
{
     /// <summary>
     /// The CompetencyDefinitionCompetencySet Model
     /// </summary>
    public partial class CompetencyDefinitionCompetencySetModel : AutobahnBase, Interfaces.ICompetencyDefinitionCompetencySet
    {
        /// <summary>
        /// The start date and, optionally, time that a record is active as used to support version control.
        /// </summary>
        public Guid CompetencyDefinitionId { get; set; }

        /// <summary>
        /// The start date and, optionally, time that a record is active as used to support version control.
        /// </summary>
        public Guid CompetencySetId { get; set; }

    }
}
