//**********************************************************
//* DomainName: Assessments
//* FileName:   Assessment_AssessmentAdministrationModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.Models;

namespace Autobahn.Assessments.Models
{
     /// <summary>
     /// The Assessment_AssessmentAdministration Model
     /// </summary>
    public partial class Assessment_AssessmentAdministrationModel : AutobahnBase, Interfaces.IAssessment_AssessmentAdministration
    {
        /// <summary>
        /// The start date and, optionally, time that a record is active as used to support version control.
        /// </summary>
        public Guid AssessmentAdministrationId { get; set; }

        /// <summary>
        /// The start date and, optionally, time that a record is active as used to support version control.
        /// </summary>
        public Guid AssessmentId { get; set; }

    }
}
