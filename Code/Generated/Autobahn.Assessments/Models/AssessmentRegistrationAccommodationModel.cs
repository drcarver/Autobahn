//**********************************************************
//* DomainName: Assessments
//* FileName:   AssessmentRegistrationAccommodationModel.cs
//***************************************************************************

using Autobahn.Interfaces.Assessments;
using Autobahn.Interfaces.Common;
using Autobahn.Common.Models;

namespace Autobahn.Assessments.Models
{
     /// <summary>
     /// The AssessmentRegistrationAccommodation Model
     /// </summary>
    public partial class AssessmentRegistrationAccommodationModel : AutobahnBase, IAssessmentRegistrationAccommodation
    {
        /// <summary>
        /// Reference to an optional instance of the <see cref="IAssessmentAccommodation"/> model
        /// </summary>
        public Guid AssessmentAccommodationId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IAssessmentRegistration"/> model
        /// </summary>
        public Guid AssessmentRegistrationId { get; set; }

    }
}
