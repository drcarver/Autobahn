//**********************************************************
//* DomainName: Autobahn.Assessment
//* FileName:   AssessmentSubtestLevelsForWhichDesigned.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.Models;

namespace Autobahn.Assessment.Models
{
     /// <summary>
     /// The AssessmentSubtestLevelsForWhichDesigned
     /// </summary>
    public partial class AssessmentSubtestLevelsForWhichDesigned : AutobahnBase, Interfaces.IAssessmentSubtestLevelsForWhichDesigned
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="AssessmentSubTest"/> model
        /// </summary>
        public Guid AssessmentSubTestId { get; set; }

        /// <summary>
        /// Reference to a required instance of the <see cref="RefGrade"/> model
        /// </summary>
        public Guid RefGradeId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="DataCollection"/> model
        /// </summary>
        public Guid? DataCollectionId { get; set; }

    }
}
