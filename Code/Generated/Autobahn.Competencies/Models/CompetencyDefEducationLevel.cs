//**********************************************************
//* DomainName: Autobahn.Competencies
//* FileName:   CompetencyDefEducationLevel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.Models;

namespace Autobahn.Competencies.Models
{
     /// <summary>
     /// The CompetencyDefEducationLevel
     /// </summary>
    public partial class CompetencyDefEducationLevel : AutobahnBase, Interfaces.ICompetencyDefEducationLevel
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="CompetencyDefinition"/> model
        /// </summary>
        public Guid CompetencyDefinitionId { get; set; }

        /// <summary>
        /// Reference to a required instance of the <see cref="RefEducationLevel"/> model
        /// </summary>
        public Guid RefEducationLevelId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="DataCollection"/> model
        /// </summary>
        public Guid? DataCollectionId { get; set; }

    }
}
