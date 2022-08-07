//**********************************************************
//* DomainName: Autobahn.Competencies
//* FileName:   ICompetencyDefinition_CompetencySetModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.Competencies.Interfaces
{
     /// <summary>
     /// The ICompetencyDefinition_CompetencySetModel Interface
     /// </summary>
    public partial interface ICompetencyDefinition_CompetencySetModel : IAutobahnBase
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="CompetencySet"/> model
        /// </summary>
        Guid CompetencySetId { get; set; }

        /// <summary>
        /// Reference to a required instance of the <see cref="CompetencyDefinition"/> model
        /// </summary>
        Guid CompetencyDefinitionId { get; set; }

    }
}
