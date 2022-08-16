//**********************************************************
//* DomainName: Assessments
//* FileName:   AssessmentItemPossibleResponseModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.Models;

namespace Autobahn.Assessments.Models
{
     /// <summary>
     /// The AssessmentItemPossibleResponse Model
     /// </summary>
    public partial class AssessmentItemPossibleResponseModel : AutobahnBase, Interfaces.IAssessmentItemPossibleResponse
    {
        /// <summary>
        /// 
        /// </summary>
        public  CorrectIndicator { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public Guid? FeedbackMessage { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  PossibleResponseOption { get; set; }

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
        public  SequenceNumber { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  Value { get; set; }

    }
}
