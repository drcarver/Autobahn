//**********************************************************
//* DomainName: Assessments
//* FileName:   AssessmentRegistration_AccommodationModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.Models;

namespace Autobahn.Assessments.Models
{
     /// <summary>
     /// The AssessmentRegistration_Accommodation Model
     /// </summary>
    public partial class AssessmentRegistration_AccommodationModel : AutobahnBase, Interfaces.IAssessmentRegistration_Accommodation
    {
        /// <summary>
        /// The start date and, optionally, time that a record is active as used to support version control.
        /// </summary>
        public Guid AssessmentAccommodationId { get; set; }

        /// <summary>
        /// The start date and, optionally, time that a record is active as used to support version control.
        /// </summary>
        public Guid AssessmentRegistrationId { get; set; }

    }
}
