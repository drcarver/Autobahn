//**********************************************************
//* DomainName: Autobahn.Assessment
//* FileName:   AssessmentSubtest_CompetencyDefinition.cs
//**********************************************************

using Autobahn.Assessment.Interfaces;

namespace Autobahn.Assessment.Models
{
     /// <summary>
     /// The AssessmentSubtest_CompetencyDefinition
     /// </summary>
    public partial class AssessmentSubtest_CompetencyDefinition : IAssessmentSubtest_CompetencyDefinition
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="AssessmentSubtest"/> model
        /// </summary>
        public Guid AssessmentSubtestId { get; set; }

        /// <summary>
        /// Reference to a required instance of the <see cref="CompetencyDefinition"/> model
        /// </summary>
        public Guid CompetencyDefinitionId { get; set; }

        /// <summary>
        /// Defines the AssessmentSubtest_CompetencyDefinition.RecordStartDateTime nullable property
        /// </summary>
        public System.DateTime? RecordStartDateTime { get; set; }

        /// <summary>
        /// Defines the AssessmentSubtest_CompetencyDefinition.RecordEndDateTime nullable property
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
