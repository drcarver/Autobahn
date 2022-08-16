//**********************************************************
//* DomainName: Assessments
//* FileName:   AssessmentNeedScreenEnhancementModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.Models;

namespace Autobahn.Assessments.Models
{
     /// <summary>
     /// The AssessmentNeedScreenEnhancement Model
     /// </summary>
    public partial class AssessmentNeedScreenEnhancementModel : AutobahnBase, Interfaces.IAssessmentNeedScreenEnhancement
    {
        /// <summary>
        /// 
        /// </summary>
        public  ForegroundColor { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public Guid? InvertColorChoice { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  Magnification { get; set; }

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
