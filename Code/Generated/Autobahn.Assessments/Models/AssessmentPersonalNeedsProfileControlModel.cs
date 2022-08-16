//**********************************************************
//* DomainName: Assessments
//* FileName:   AssessmentPersonalNeedsProfileControlModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.Models;

namespace Autobahn.Assessments.Models
{
     /// <summary>
     /// The AssessmentPersonalNeedsProfileControl Model
     /// </summary>
    public partial class AssessmentPersonalNeedsProfileControlModel : AutobahnBase, Interfaces.IAssessmentPersonalNeedsProfileControl
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
