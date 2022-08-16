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
        /// 
        /// </summary>
        public  ActualEndDateTime { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  ActualStartDateTime { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  AllottedTime { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  Location { get; set; }

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
        public Guid? RefAssessmentSessionSpecialCircumstanceTypeId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  RefAssessmentSessionTypeId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  ScheduledEndDateTime { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  ScheduledStartDateTime { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  SecurityIssue { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  SpecialEventDescription { get; set; }

    }
}
