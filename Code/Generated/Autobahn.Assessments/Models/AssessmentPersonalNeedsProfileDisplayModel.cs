//**********************************************************
//* DomainName: Assessments
//* FileName:   AssessmentPersonalNeedsProfileDisplayModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.Models;

namespace Autobahn.Assessments.Models
{
     /// <summary>
     /// The AssessmentPersonalNeedsProfileDisplay Model
     /// </summary>
    public partial class AssessmentPersonalNeedsProfileDisplayModel : AutobahnBase, Interfaces.IAssessmentPersonalNeedsProfileDisplay
    {
        /// <summary>
        /// The start date and, optionally, time that a record is active as used to support version control.
        /// </summary>
        public Guid AssessmentPersonalNeedsProfileId { get; set; }

    }
}
