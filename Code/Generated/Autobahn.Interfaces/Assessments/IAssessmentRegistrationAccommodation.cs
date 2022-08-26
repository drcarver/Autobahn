//***************************************************************************
//* DomainName: Assessments Interfaces (used by both models and View Models
//* FileName:   IAssessmentRegistrationAccommodation.cs
//***************************************************************************

using Autobahn.Interfaces.Common;

namespace Autobahn.Interfaces.Assessments
{
     /// <summary>
     /// The IAssessmentRegistrationAccommodation Interface
     /// </summary>
    public partial interface IAssessmentRegistrationAccommodation : IAutobahnBase
    {
        /// <summary>
        /// Reference to an optional instance of the <see cref="IAssessmentAccommodation"/> model
        /// </summary>
        Guid AssessmentAccommodationId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IAssessmentRegistration"/> model
        /// </summary>
        Guid AssessmentRegistrationId { get; set; }

    }
}
