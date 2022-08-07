//**********************************************************
//* DomainName: Autobahn.Competencies
//* FileName:   CompetencyDefinition_CompetencySetModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.Models;

namespace Autobahn.Competencies.Models
{
     /// <summary>
     /// The CompetencyDefinition_CompetencySet Model
     /// </summary>
    public partial class CompetencyDefinition_CompetencySetModel : AutobahnBase, Interfaces.ICompetencyDefinition_CompetencySetModel
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="CompetencySet"/> model
        /// </summary>
        public Guid CompetencySetId { get; set; }

        /// <summary>
        /// Reference to a required instance of the <see cref="CompetencyDefinition"/> model
        /// </summary>
        public Guid CompetencyDefinitionId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="DataCollection"/> model
        /// </summary>
        public Guid? DataCollectionId { get; set; }

    }
}
