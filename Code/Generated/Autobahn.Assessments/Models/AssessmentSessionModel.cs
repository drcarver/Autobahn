//**********************************************************
//* DomainName: Assessments
//* FileName:   AssessmentSessionModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.Models;

namespace Autobahn.Assessments.Models
{
     /// <summary>
     /// The AssessmentSession Model
     /// </summary>
    public partial class AssessmentSessionModel : AutobahnBase, Interfaces.IAssessmentSession
    {
        /// <summary>
        /// An unusual event occurred during the administration of the assessment. This could include fire alarm, student became ill, etc.
        /// </summary>
        public Guid? RefAssessmentSessionSpecialCircumstanceTypeId { get; set; }

    }
}
