//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   IIndividualizedProgramAssessment.cs
//**********************************************************


namespace Autobahn.Common.Interfaces
{
     /// <summary>
     /// The IIndividualizedProgramAssessment
     /// </summary>
    public partial interface IIndividualizedProgramAssessment : IAutobahnBase
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="Assessment"/> model
        /// </summary>
        Guid AssessmentId { get; set; }

        /// <summary>
        /// Reference to a required instance of the <see cref="IndividualizedProgram"/> model
        /// </summary>
        Guid IndividualizedProgramId { get; set; }

        /// <summary>
        /// Defines the IndividualizedProgramAssessment.IEPAlternativeAssessmentRationale non nullable property
        /// </summary>
        System.String IEPAlternativeAssessmentRationale { get; set; }

    }
}
