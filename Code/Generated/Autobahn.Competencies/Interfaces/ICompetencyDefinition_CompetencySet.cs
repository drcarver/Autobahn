//**********************************************************
//* DomainName: Autobahn.Competencies
//* FileName:   ICompetencyDefinition_CompetencySet.cs
//**********************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.Competencies.Interfaces
{
     /// <summary>
     /// The ICompetencyDefinition_CompetencySet
     /// </summary>
    public partial interface ICompetencyDefinition_CompetencySet : IAutobahnBase
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
