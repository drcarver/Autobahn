//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   IIndividualizedProgramEligibility.cs
//**********************************************************

namespace Autobahn.Common.Interfaces
{
     /// <summary>
     /// The IIndividualizedProgramEligibility
     /// </summary>
    public partial interface IIndividualizedProgramEligibility
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="IndividualizedProgram"/> model
        /// </summary>
        Guid IndividualizedProgramId { get; set; }

        /// <summary>
        /// Defines the IndividualizedProgramEligibility.ConsentToEvaluateDate nullable property
        /// </summary>
        System.DateTime? ConsentToEvaluateDate { get; set; }

        /// <summary>
        /// Defines the IndividualizedProgramEligibility.ConsentToEvaluateIndicator nullable property
        /// </summary>
        System.Boolean? ConsentToEvaluateIndicator { get; set; }

        /// <summary>
        /// Defines the IndividualizedProgramEligibility.ParentObservations non nullable property
        /// </summary>
        System.String ParentObservations { get; set; }

        /// <summary>
        /// Defines the IndividualizedProgramEligibility.RecordStartDateTime nullable property
        /// </summary>
        System.DateTime? RecordStartDateTime { get; set; }

        /// <summary>
        /// Defines the IndividualizedProgramEligibility.RecordEndDateTime nullable property
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
