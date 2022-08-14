//**********************************************************
//* DomainName: Assessments
//* FileName:   AssessmentAssessmentAdministrationModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.Models;

namespace Autobahn.Assessments.Models
{
     /// <summary>
     /// The AssessmentAssessmentAdministration Model
     /// </summary>
    public partial class AssessmentAssessmentAdministrationModel : AutobahnBase, Interfaces.IAssessmentAssessmentAdministration
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
