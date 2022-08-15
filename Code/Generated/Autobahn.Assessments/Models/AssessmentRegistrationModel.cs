//**********************************************************
//* DomainName: Assessments
//* FileName:   AssessmentRegistrationModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.Models;

namespace Autobahn.Assessments.Models
{
     /// <summary>
     /// The AssessmentRegistration Model
     /// </summary>
    public partial class AssessmentRegistrationModel : AutobahnBase, Interfaces.IAssessmentRegistration
    {
        /// <summary>
        /// An indication of whether a student participated in an assessment.
        /// </summary>
        public Guid? RefAssessmentParticipationIndicatorId { get; set; }

    }
}
