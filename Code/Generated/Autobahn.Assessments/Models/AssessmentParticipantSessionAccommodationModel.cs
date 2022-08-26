//**********************************************************
//* DomainName: Assessments
//* FileName:   AssessmentParticipantSessionAccommodationModel.cs
//***************************************************************************

using Autobahn.Interfaces.Assessments;
using Autobahn.Interfaces.Common;
using Autobahn.Common.Models;

namespace Autobahn.Assessments.Models
{
     /// <summary>
     /// The AssessmentParticipantSessionAccommodation Model
     /// </summary>
    public partial class AssessmentParticipantSessionAccommodationModel : AutobahnBase, IAssessmentParticipantSessionAccommodation
    {
        /// <summary>
        /// Reference to an optional instance of the <see cref="IAssessmentAccommodation"/> model
        /// </summary>
        public Guid AssessmentAccommodationId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IAssessmentParticipantSession"/> model
        /// </summary>
        public Guid AssessmentParticipantSessionId { get; set; }

    }
}
