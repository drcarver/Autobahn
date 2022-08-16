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
        /// 
        /// </summary>
        public  RecordEndDateTime { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public Guid? RecordStartDateTime { get; set; }

    }
}
