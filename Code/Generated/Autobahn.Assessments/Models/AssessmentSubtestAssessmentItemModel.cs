//**********************************************************
//* DomainName: Assessments
//* FileName:   AssessmentSubtestAssessmentItemModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.Models;

namespace Autobahn.Assessments.Models
{
     /// <summary>
     /// The AssessmentSubtestAssessmentItem Model
     /// </summary>
    public partial class AssessmentSubtestAssessmentItemModel : AutobahnBase, Interfaces.IAssessmentSubtestAssessmentItem
    {
        /// <summary>
        /// 
        /// </summary>
        public Guid? ItemWeightCorrect { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  ItemWeightIncorrect { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  ItemWeightNotAttempted { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  RecordEndDateTime { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  RecordStartDateTime { get; set; }

    }
}
