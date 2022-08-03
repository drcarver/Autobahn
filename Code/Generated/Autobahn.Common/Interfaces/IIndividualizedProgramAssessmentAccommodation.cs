//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   IIndividualizedProgramAssessmentAccommodation.cs
//**********************************************************

namespace Autobahn.Common.Interfaces
{
     /// <summary>
     /// The IIndividualizedProgramAssessmentAccommodation
     /// </summary>
    public partial interface IIndividualizedProgramAssessmentAccommodation
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="AssessmentAccommodation"/> model
        /// </summary>
        Guid AssessmentAccommodationId { get; set; }

        /// <summary>
        /// Reference to a required instance of the <see cref="IndividualizedProgramAssessment"/> model
        /// </summary>
        Guid IndividualizedProgramAssessmentId { get; set; }

        /// <summary>
        /// Defines the IndividualizedProgramAssessmentAccommodation.RecordStartDateTime nullable property
        /// </summary>
        System.DateTime? RecordStartDateTime { get; set; }

        /// <summary>
        /// Defines the IndividualizedProgramAssessmentAccommodation.RecordEndDateTime nullable property
        /// </summary>
        System.DateTime? RecordEndDateTime { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RecordStatus"/> model
        /// </summary>
        Guid? RecordStatusId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="DataCollection"/> model
        /// </summary>
        Guid? DataCollectionId { get; set; }

    }
}
