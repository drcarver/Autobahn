//**********************************************************
//* DomainName: Assessments
//* FileName:   AssessmentParticipantSession_AccommodationModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.Models;

namespace Autobahn.Assessments.Models
{
     /// <summary>
     /// The AssessmentParticipantSession_Accommodation Model
     /// </summary>
    public partial class AssessmentParticipantSession_AccommodationModel : AutobahnBase, Interfaces.IAssessmentParticipantSession_Accommodation
    {
        /// <summary>
        /// The start date and, optionally, time that a record is active as used to support version control.
        /// </summary>
        public Guid AssessmentAccommodationId { get; set; }

        /// <summary>
        /// The start date and, optionally, time that a record is active as used to support version control.
        /// </summary>
        public Guid AssessmentParticipantSessionId { get; set; }

    }
}
