//**********************************************************
//* DomainName: Assessments
//* FileName:   AssessmentPersonalNeedsProfileModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.Models;

namespace Autobahn.Assessments.Models
{
     /// <summary>
     /// The AssessmentPersonalNeedsProfile Model
     /// </summary>
    public partial class AssessmentPersonalNeedsProfileModel : AutobahnBase, Interfaces.IAssessmentPersonalNeedsProfile
    {
        /// <summary>
        /// 
        /// </summary>
        public  ActivateByDefault { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  AssessmentNeedType { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public Guid? AssignedSupportFlag { get; set; }

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
