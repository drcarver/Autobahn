//**********************************************************
//* DomainName: Competencies
//* FileName:   CompetencyDefinitionCompetencySetModel.cs
//***************************************************************************

using Autobahn.Interfaces.Competencies;
using Autobahn.Interfaces.Common;
using Autobahn.Common.Models;

namespace Autobahn.Competencies.Models
{
     /// <summary>
     /// The CompetencyDefinitionCompetencySet Model
     /// </summary>
    public partial class CompetencyDefinitionCompetencySetModel : AutobahnBase, ICompetencyDefinitionCompetencySet
    {
        /// <summary>
        /// Reference to an optional instance of the <see cref="ICompetencyDefinition"/> model
        /// </summary>
        public Guid CompetencyDefinitionId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="ICompetencySet"/> model
        /// </summary>
        public Guid CompetencySetId { get; set; }

    }
}
