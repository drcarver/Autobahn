//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   IIndividualizedProgramAssessmentAccommodation.cs
//**********************************************************


namespace Autobahn.Common.Interfaces
{
     /// <summary>
     /// The IIndividualizedProgramAssessmentAccommodation
     /// </summary>
    public partial interface IIndividualizedProgramAssessmentAccommodation : IAutobahnBase
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="AssessmentAccommodation"/> model
        /// </summary>
        Guid AssessmentAccommodationId { get; set; }

        /// <summary>
        /// Reference to a required instance of the <see cref="IndividualizedProgramAssessment"/> model
        /// </summary>
        Guid IndividualizedProgramAssessmentId { get; set; }

    }
}
