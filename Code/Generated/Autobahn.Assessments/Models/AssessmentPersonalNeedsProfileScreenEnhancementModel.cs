//**********************************************************
//* DomainName: Assessments
//* FileName:   AssessmentPersonalNeedsProfileScreenEnhancementModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.Models;

namespace Autobahn.Assessments.Models
{
     /// <summary>
     /// The AssessmentPersonalNeedsProfileScreenEnhancement Model
     /// </summary>
    public partial class AssessmentPersonalNeedsProfileScreenEnhancementModel : AutobahnBase, Interfaces.IAssessmentPersonalNeedsProfileScreenEnhancement
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
