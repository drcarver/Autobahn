//***************************************************************************
//* DomainName: Assessments Interfaces (used by both models and View Models
//* FileName:   IAssessmentAssessmentAdministration.cs
//***************************************************************************

using Autobahn.Interfaces.Common;

namespace Autobahn.Interfaces.Assessments
{
     /// <summary>
     /// The IAssessmentAssessmentAdministration Interface
     /// </summary>
    public partial interface IAssessmentAssessmentAdministration : IAutobahnBase
    {
        /// <summary>
        /// Reference to an optional instance of the <see cref="IAssessmentAdministration"/> model
        /// </summary>
        Guid AssessmentAdministrationId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IAssessment"/> model
        /// </summary>
        Guid AssessmentId { get; set; }

    }
}
