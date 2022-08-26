//**********************************************************
//* DomainName: Assessments
//* FileName:   AssessmentLevelsForWhichDesignedModel.cs
//***************************************************************************

using Autobahn.Interfaces.Assessments;
using Autobahn.Interfaces.Common;
using Autobahn.Common.Models;

namespace Autobahn.Assessments.Models
{
     /// <summary>
     /// The AssessmentLevelsForWhichDesigned Model
     /// </summary>
    public partial class AssessmentLevelsForWhichDesignedModel : AutobahnBase, IAssessmentLevelsForWhichDesigned
    {
        /// <summary>
        /// Reference to an optional instance of the <see cref="IAssessment"/> model
        /// </summary>
        public Guid AssessmentId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefGradeLevel"/> model
        /// </summary>
        public Guid RefGradeLevelId { get; set; }

    }
}
