//**********************************************************
//* DomainName: Assessments
//* FileName:   AssessmentPersonalNeedScreenReaderModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.Models;

namespace Autobahn.Assessments.Models
{
     /// <summary>
     /// The AssessmentPersonalNeedScreenReader Model
     /// </summary>
    public partial class AssessmentPersonalNeedScreenReaderModel : AutobahnBase, Interfaces.IAssessmentPersonalNeedScreenReader
    {
        /// <summary>
        /// 
        /// </summary>
        public  Pitch { get; set; }

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
        public  RefAssessmentNeedLinkIndicationTypeId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public Guid? RefAssessmentNeedUsageTypeId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  SpeechRate { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  Volume { get; set; }

    }
}
