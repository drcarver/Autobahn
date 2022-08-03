//**********************************************************
//* DomainName: Autobahn.Assessment
//* FileName:   AssessmentSubtestELDevelopmentalDomain.cs
//**********************************************************

using Autobahn.Assessment.Interfaces;

namespace Autobahn.Assessment.Models
{
     /// <summary>
     /// The AssessmentSubtestELDevelopmentalDomain
     /// </summary>
    public partial class AssessmentSubtestELDevelopmentalDomain : IAssessmentSubtestELDevelopmentalDomain
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="AssessmentSubtest"/> model
        /// </summary>
        public Guid AssessmentSubtestId { get; set; }

        /// <summary>
        /// Reference to a required instance of the <see cref="RefAssessmentELDevelopmentalDomain"/> model
        /// </summary>
        public Guid RefAssessmentELDevelopmentalDomainId { get; set; }

        /// <summary>
        /// Defines the AssessmentSubtestELDevelopmentalDomain.RecordStartDateTime nullable property
        /// </summary>
        public System.DateTime? RecordStartDateTime { get; set; }

        /// <summary>
        /// Defines the AssessmentSubtestELDevelopmentalDomain.RecordEndDateTime nullable property
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
