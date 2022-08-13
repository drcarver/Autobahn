//***************************************************************************
//* DomainName: Authentication and Authorization Interfaces (used by both models and View Models
//* FileName:   IIndividualizedProgramAssessment.cs
//***************************************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.Authorization.Interfaces
{
     /// <summary>
     /// The IIndividualizedProgramAssessment Interface
     /// </summary>
    public partial interface IIndividualizedProgramAssessment : IAutobahnBase
    {
        /// <summary>
        /// A statement of why-
        /// </summary>
        Guid AssessmentId { get; set; }

        /// <summary>
        /// A statement of why-
        /// </summary>
        System.String IEPAlternativeAssessmentRationale { get; set; }

        /// <summary>
        /// A statement of why-
        /// </summary>
        Guid IndividualizedProgramId { get; set; }

    }
}
