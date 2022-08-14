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
        /// The start date and, optionally, time that a record is active as used to support version control.
        /// </summary>
        public Guid AssessmentSubTestId { get; set; }

        /// <summary>
        /// The start date and, optionally, time that a record is active as used to support version control.
        /// </summary>
        public Guid RefGradeId { get; set; }

    }
}
