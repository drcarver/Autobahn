//**********************************************************
//* DomainName: Assessments
//* FileName:   AssessmentResultRubricCriterionResultModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.Models;

namespace Autobahn.Assessments.Models
{
     /// <summary>
     /// The AssessmentResultRubricCriterionResult Model
     /// </summary>
    public partial class AssessmentResultRubricCriterionResultModel : AutobahnBase, Interfaces.IAssessmentResultRubricCriterionResult
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
