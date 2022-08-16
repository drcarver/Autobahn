//**********************************************************
//* DomainName: Assessments
//* FileName:   AssessmentNeedApipControlModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.Models;

namespace Autobahn.Assessments.Models
{
     /// <summary>
     /// The AssessmentNeedApipControl Model
     /// </summary>
    public partial class AssessmentNeedApipControlModel : AutobahnBase, Interfaces.IAssessmentNeedApipControl
    {
        /// <summary>
        /// 
        /// </summary>
        public Guid? AssessmentNeedTimeMultiplier { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  BackgroundColor { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  LineReaderHighlightColor { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  OverlayColor { get; set; }

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
        public  RefAssessmentNeedIncreasedWhitespacingTypeId { get; set; }

    }
}
