//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   IndividualizedProgramAssessmentAccommodation.cs
//**********************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.Common.Models
{
     /// <summary>
     /// The IndividualizedProgramAssessmentAccommodation
     /// </summary>
    public partial class IndividualizedProgramAssessmentAccommodation : IIndividualizedProgramAssessmentAccommodation
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="AssessmentAccommodation"/> model
        /// </summary>
        public Guid AssessmentAccommodationId { get; set; }

        /// <summary>
        /// Reference to a required instance of the <see cref="IndividualizedProgramAssessment"/> model
        /// </summary>
        public Guid IndividualizedProgramAssessmentId { get; set; }

        /// <summary>
        /// Defines the IndividualizedProgramAssessmentAccommodation.RecordStartDateTime nullable property
        /// </summary>
        public System.DateTime? RecordStartDateTime { get; set; }

        /// <summary>
        /// Defines the IndividualizedProgramAssessmentAccommodation.RecordEndDateTime nullable property
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
