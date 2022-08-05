//**********************************************************
//* DomainName: Autobahn.Assessment
//* FileName:   AssessmentRegistration_Accommodation.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.Models;

namespace Autobahn.Assessment.Models
{
     /// <summary>
     /// The AssessmentRegistration_Accommodation
     /// </summary>
    public partial class AssessmentRegistration_Accommodation : AutobahnBase, Interfaces.IAssessmentRegistration_Accommodation
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="AssessmentRegistration"/> model
        /// </summary>
        public Guid AssessmentRegistrationId { get; set; }

        /// <summary>
        /// Reference to a required instance of the <see cref="AssessmentAccommodation"/> model
        /// </summary>
        public Guid AssessmentAccommodationId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="DataCollection"/> model
        /// </summary>
        public Guid? DataCollectionId { get; set; }

    }
}
