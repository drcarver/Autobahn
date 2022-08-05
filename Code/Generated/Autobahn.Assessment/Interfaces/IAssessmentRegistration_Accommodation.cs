//**********************************************************
//* DomainName: Autobahn.Assessment
//* FileName:   IAssessmentRegistration_Accommodation.cs
//**********************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.Assessment.Interfaces
{
     /// <summary>
     /// The IAssessmentRegistration_Accommodation
     /// </summary>
    public partial interface IAssessmentRegistration_Accommodation : IAutobahnBase
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="AssessmentRegistration"/> model
        /// </summary>
        Guid AssessmentRegistrationId { get; set; }

        /// <summary>
        /// Reference to a required instance of the <see cref="AssessmentAccommodation"/> model
        /// </summary>
        Guid AssessmentAccommodationId { get; set; }

    }
}
