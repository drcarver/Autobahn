//**********************************************************
//* DomainName: Autobahn.Competencies
//* FileName:   ICompetencySet_Rubric.cs
//**********************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.Competencies.Interfaces
{
     /// <summary>
     /// The ICompetencySet_Rubric
     /// </summary>
    public partial interface ICompetencySet_Rubric : IAutobahnBase
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="CompetencySet"/> model
        /// </summary>
        Guid CompetencySetId { get; set; }

        /// <summary>
        /// Reference to a required instance of the <see cref="Rubric"/> model
        /// </summary>
        Guid RubricId { get; set; }

    }
}
