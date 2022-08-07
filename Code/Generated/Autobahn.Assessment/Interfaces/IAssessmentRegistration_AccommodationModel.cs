//**********************************************************
//* DomainName: Autobahn.Assessment
//* FileName:   IAssessmentRegistration_AccommodationModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.Assessment.Interfaces
{
     /// <summary>
     /// The IAssessmentRegistration_AccommodationModel Interface
     /// </summary>
    public partial interface IAssessmentRegistration_AccommodationModel : IAutobahnBase
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
