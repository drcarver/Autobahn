//**********************************************************
//* DomainName: Assessments
//* FileName:   AssessmentRegistrationAccommodationModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.Models;

namespace Autobahn.Assessments.Models
{
     /// <summary>
     /// The AssessmentRegistrationAccommodation Model
     /// </summary>
    public partial class AssessmentRegistrationAccommodationModel : AutobahnBase, Interfaces.IAssessmentRegistrationAccommodation
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
