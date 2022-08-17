//**********************************************************
//* DomainName: Common Models
//* FileName:   IndividualizedProgramAssessmentAccommodationModel.cs
//***************************************************************************


namespace Autobahn.Common.Interfaces
{
     /// <summary>
     /// The IndividualizedProgramAssessmentAccommodation Model
     /// </summary>
    public partial class IndividualizedProgramAssessmentAccommodationModel : AutobahnBase, Interfaces.IIndividualizedProgramAssessmentAccommodation
    {
        /// <summary>
        /// Reference to an optional instance of the <see cref="IAssessmentAccommodation"/> model
        /// </summary>
        public Guid AssessmentAccommodationId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IIndividualizedProgramAssessment"/> model
        /// </summary>
        public Guid IndividualizedProgramAssessmentId { get; set; }

    }
}
