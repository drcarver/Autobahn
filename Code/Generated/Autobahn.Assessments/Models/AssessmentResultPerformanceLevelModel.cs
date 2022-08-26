//**********************************************************
//* DomainName: Assessments
//* FileName:   AssessmentResultPerformanceLevelModel.cs
//***************************************************************************

using Autobahn.Interfaces.Assessments;
using Autobahn.Interfaces.Common;
using Autobahn.Common.Models;

namespace Autobahn.Assessments.Models
{
     /// <summary>
     /// The AssessmentResultPerformanceLevel Model
     /// </summary>
    public partial class AssessmentResultPerformanceLevelModel : AutobahnBase, IAssessmentResultPerformanceLevel
    {
        /// <summary>
        /// Reference to an optional instance of the <see cref="IAssessmentPerformanceLevel"/> model
        /// </summary>
        public Guid AssessmentPerformanceLevelId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IAssessmentResult"/> model
        /// </summary>
        public Guid AssessmentResultId { get; set; }

    }
}
