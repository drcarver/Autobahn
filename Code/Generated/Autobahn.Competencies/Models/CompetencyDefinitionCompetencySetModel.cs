//**********************************************************
//* DomainName: Competencies
//* FileName:   CompetencyDefinitionCompetencySetModel.cs
//***************************************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.Models;

namespace Autobahn.Competencies.Interfaces
{
     /// <summary>
     /// The CompetencyDefinitionCompetencySet Model
     /// </summary>
    public partial class CompetencyDefinitionCompetencySetModel : AutobahnBase, Interfaces.ICompetencyDefinitionCompetencySet
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
