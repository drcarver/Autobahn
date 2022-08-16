//**********************************************************
//* DomainName: Invalid or Unreferenced Models
//* FileName:   IDEAEligibilityEvaluationCategoryModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.Models;

namespace Autobahn.Invalid.Models
{
     /// <summary>
     /// The IDEAEligibilityEvaluationCategory Model
     /// </summary>
    public partial class IDEAEligibilityEvaluationCategoryModel : AutobahnBase, Interfaces.IIDEAEligibilityEvaluationCategory
    {
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
        public Guid? RefIDEAEligibilityEvaluationCategoryId { get; set; }

    }
}
