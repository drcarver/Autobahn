//**********************************************************
//* DomainName: Autobahn.Competencies
//* FileName:   ICompetencyDefEducationLevel.cs
//**********************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.Competencies.Interfaces
{
     /// <summary>
     /// The ICompetencyDefEducationLevel
     /// </summary>
    public partial interface ICompetencyDefEducationLevel : IAutobahnBase
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="CompetencyDefinition"/> model
        /// </summary>
        Guid CompetencyDefinitionId { get; set; }

        /// <summary>
        /// Reference to a required instance of the <see cref="RefEducationLevel"/> model
        /// </summary>
        Guid RefEducationLevelId { get; set; }

    }
}
