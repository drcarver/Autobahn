//**********************************************************
//* DomainName: Assessments
//* FileName:   AssessmentLevelsForWhichDesignedModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.Models;

namespace Autobahn.Assessments.Models
{
     /// <summary>
     /// The AssessmentLevelsForWhichDesigned Model
     /// </summary>
    public partial class AssessmentLevelsForWhichDesignedModel : AutobahnBase, Interfaces.IAssessmentLevelsForWhichDesigned
    {
        /// <summary>
        /// The start date and, optionally, time that a record is active as used to support version control.
        /// </summary>
        public Guid AssessmentId { get; set; }

        /// <summary>
        /// The start date and, optionally, time that a record is active as used to support version control.
        /// </summary>
        public Guid RefGradeLevelId { get; set; }

    }
}
