//**********************************************************
//* DomainName: Assessments
//* FileName:   AssessmentAdministrationModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.Models;

namespace Autobahn.Assessments.Models
{
     /// <summary>
     /// The AssessmentAdministration Model
     /// </summary>
    public partial class AssessmentAdministrationModel : AutobahnBase, Interfaces.IAssessmentAdministration
    {
        /// <summary>
        /// Indicates whether or not the assessment is a secure assessment.
        /// </summary>
        public System.Boolean? AssessmentSecureIndicator { get; set; }

    }
}
