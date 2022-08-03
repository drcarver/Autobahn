//**********************************************************
//* DomainName: Autobahn.Assessment
//* FileName:   AssessmentSubtestLevelsForWhichDesigned.cs
//**********************************************************

using Autobahn.Assessment.Interfaces;

namespace Autobahn.Assessment.Models
{
     /// <summary>
     /// The AssessmentSubtestLevelsForWhichDesigned
     /// </summary>
    public partial class AssessmentSubtestLevelsForWhichDesigned : IAssessmentSubtestLevelsForWhichDesigned
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
        /// Defines the AssessmentSubtestLevelsForWhichDesigned.RecordStartDateTime nullable property
        /// </summary>
        public System.DateTime? RecordStartDateTime { get; set; }

        /// <summary>
        /// Defines the AssessmentSubtestLevelsForWhichDesigned.RecordEndDateTime nullable property
        /// </summary>
        public System.DateTime? RecordEndDateTime { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RecordStatus"/> model
        /// </summary>
        public Guid? RecordStatusId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="DataCollection"/> model
        /// </summary>
        public Guid? DataCollectionId { get; set; }

    }
}
