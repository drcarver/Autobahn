//**********************************************************
//* DomainName: Assessments
//* FileName:   AssessmentPersonalNeedLanguageLearnerModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.Models;

namespace Autobahn.Assessments.Models
{
     /// <summary>
     /// The AssessmentPersonalNeedLanguageLearner Model
     /// </summary>
    public partial class AssessmentPersonalNeedLanguageLearnerModel : AutobahnBase, Interfaces.IAssessmentPersonalNeedLanguageLearner
    {
        /// <summary>
        /// 
        /// </summary>
        public  ActivateByDefault { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public Guid? AssignedSupport { get; set; }

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
        public  RefAssessmentNeedsProfileContentLanguageLearnerTypeId { get; set; }

    }
}
