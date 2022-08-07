//**********************************************************
//* DomainName: Autobahn.Competencies
//* FileName:   ICompetencyDefEducationLevelModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.Competencies.Interfaces
{
     /// <summary>
     /// The ICompetencyDefEducationLevelModel Interface
     /// </summary>
    public partial interface ICompetencyDefEducationLevelModel : IAutobahnBase
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
