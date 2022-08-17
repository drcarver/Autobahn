//***************************************************************************
//* DomainName: Common Models Interfaces (used by both models and View Models
//* FileName:   IIndividualizedProgramAssessmentAccommodation.cs
//***************************************************************************


namespace Autobahn.Common.Interfaces
{
     /// <summary>
     /// The IIndividualizedProgramAssessmentAccommodation Interface
     /// </summary>
    public partial interface IIndividualizedProgramAssessmentAccommodation : IAutobahnBase
    {
        /// <summary>
        /// Reference to an optional instance of the <see cref="IAssessmentAccommodation"/> model
        /// </summary>
        Guid AssessmentAccommodationId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IIndividualizedProgramAssessment"/> model
        /// </summary>
        Guid IndividualizedProgramAssessmentId { get; set; }

    }
}
