//**********************************************************
//* DomainName: Assessments
//* FileName:   AssessmentItemRubricCriterionResultModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.Models;

namespace Autobahn.Assessments.Models
{
     /// <summary>
     /// The AssessmentItemRubricCriterionResult Model
     /// </summary>
    public partial class AssessmentItemRubricCriterionResultModel : AutobahnBase, Interfaces.IAssessmentItemRubricCriterionResult
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