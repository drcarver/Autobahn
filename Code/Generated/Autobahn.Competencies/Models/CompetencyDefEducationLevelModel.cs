//**********************************************************
//* DomainName: Competencies
//* FileName:   CompetencyDefEducationLevelModel.cs
//***************************************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.Models;

namespace Autobahn.Competencies.Models
{
     /// <summary>
     /// The CompetencyDefEducationLevel Model
     /// </summary>
    public partial class CompetencyDefEducationLevelModel : AutobahnBase, Interfaces.ICompetencyDefEducationLevel
    {
        /// <summary>
        /// Reference to an optional instance of the <see cref="ICompetencyDefinition"/> model
        /// </summary>
        public Guid CompetencyDefinitionId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefEducationLevel"/> model
        /// </summary>
        public Guid RefEducationLevelId { get; set; }

    }
}
