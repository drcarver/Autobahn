//**********************************************************
//* DomainName: Assessments
//* FileName:   AssessmentSubtestLevelsForWhichDesignedModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.Models;

namespace Autobahn.Assessments.Models
{
     /// <summary>
     /// The AssessmentSubtestLevelsForWhichDesigned Model
     /// </summary>
    public partial class AssessmentSubtestLevelsForWhichDesignedModel : AutobahnBase, Interfaces.IAssessmentSubtestLevelsForWhichDesigned
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
