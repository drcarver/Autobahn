//**********************************************************
//* DomainName: Assessments
//* FileName:   AssessmentFormSectionAssessmentItemModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.Models;

namespace Autobahn.Assessments.Models
{
     /// <summary>
     /// The AssessmentFormSectionAssessmentItem Model
     /// </summary>
    public partial class AssessmentFormSectionAssessmentItemModel : AutobahnBase, Interfaces.IAssessmentFormSectionAssessmentItem
    {
        /// <summary>
        /// 
        /// </summary>
        public  RecordEndDateTime { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  RecordStartDateTime { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public Guid? SequenceNumber { get; set; }

    }
}
