//***************************************************************************
//* DomainName: Assessments Interfaces (used by both models and View Models
//* FileName:   IAssessmentAssessmentAdministration.cs
//***************************************************************************

using Autobahn.Education.Interfaces.Common;

namespace Autobahn.Education.Interfaces.Assessments
{
     /// <summary>
     /// The IAssessmentAssessmentAdministration Interface
     /// </summary>
    public partial interface IAssessmentAssessmentAdministration : IAutobahnBase
    {
        #region IAssessmentAssessmentAdministration
        /// <summary>
        /// Reference to an optional instance of the <see cref="IAssessmentAdministration"/> model
        /// </summary>
        Guid AssessmentAdministrationId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IAssessment"/> model
        /// </summary>
        Guid AssessmentId { get; set; }

        #endregion
    }
}
