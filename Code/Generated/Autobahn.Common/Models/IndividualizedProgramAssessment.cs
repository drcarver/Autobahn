//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   IndividualizedProgramAssessment.cs
//**********************************************************


namespace Autobahn.Common.Models
{
     /// <summary>
     /// The IndividualizedProgramAssessment
     /// </summary>
    public partial class IndividualizedProgramAssessment : AutobahnBase, Interfaces.IIndividualizedProgramAssessment
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="Assessment"/> model
        /// </summary>
        public Guid AssessmentId { get; set; }

        /// <summary>
        /// Reference to a required instance of the <see cref="IndividualizedProgram"/> model
        /// </summary>
        public Guid IndividualizedProgramId { get; set; }

        /// <summary>
        /// Defines the IndividualizedProgramAssessment.IEPAlternativeAssessmentRationale non nullable property
        /// </summary>
        public System.String IEPAlternativeAssessmentRationale { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="DataCollection"/> model
        /// </summary>
        public Guid? DataCollectionId { get; set; }

    }
}
