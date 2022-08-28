//***************************************************************************
//* DomainName: Competencies Interfaces (used by both models and View Models
//* FileName:   ICompetencySetRubric.cs
//***************************************************************************

using Autobahn.Education.Interfaces.Common;

namespace Autobahn.Education.Interfaces.Competencies
{
     /// <summary>
     /// The ICompetencySetRubric Interface
     /// </summary>
    public partial interface ICompetencySetRubric : IAutobahnBase
    {
        #region ICompetencySetRubric
        /// <summary>
        /// Reference to an optional instance of the <see cref="ICompetencySet"/> model
        /// </summary>
        Guid CompetencySetId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IRubric"/> model
        /// </summary>
        Guid RubricId { get; set; }

        #endregion
    }
}
