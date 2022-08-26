//**********************************************************
//* DomainName: Assessments
//* FileName:   AssessmentSubtestLevelsForWhichDesignedModel.cs
//***************************************************************************

using Autobahn.Interfaces.Assessments;
using Autobahn.Interfaces.Common;
using Autobahn.Common.Models;

namespace Autobahn.Assessments.Models
{
     /// <summary>
     /// The AssessmentSubtestLevelsForWhichDesigned Model
     /// </summary>
    public partial class AssessmentSubtestLevelsForWhichDesignedModel : AutobahnBase, IAssessmentSubtestLevelsForWhichDesigned
    {
        /// <summary>
        /// Reference to an optional instance of the <see cref="IAssessmentSubTest"/> model
        /// </summary>
        public Guid AssessmentSubTestId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefGrade"/> model
        /// </summary>
        public Guid RefGradeId { get; set; }

    }
}
