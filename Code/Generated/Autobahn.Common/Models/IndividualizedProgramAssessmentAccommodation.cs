//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   IndividualizedProgramAssessmentAccommodation.cs
//**********************************************************


namespace Autobahn.Common.Models
{
     /// <summary>
     /// The IndividualizedProgramAssessmentAccommodation
     /// </summary>
    public partial class IndividualizedProgramAssessmentAccommodation : AutobahnBase, Interfaces.IIndividualizedProgramAssessmentAccommodation
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
        /// Reference to an optional instance of the <see cref="DataCollection"/> model
        /// </summary>
        public Guid? DataCollectionId { get; set; }

    }
}
