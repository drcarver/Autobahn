//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   IIndividualizedProgramEligibilityEvaluation.cs
//**********************************************************

namespace Autobahn.Common.Interfaces
{
     /// <summary>
     /// The IIndividualizedProgramEligibilityEvaluation
     /// </summary>
    public partial interface IIndividualizedProgramEligibilityEvaluation
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="EligibilityEvaluation"/> model
        /// </summary>
        Guid EligibilityEvaluationId { get; set; }

        /// <summary>
        /// Reference to a required instance of the <see cref="IndividualizedProgramEligibility"/> model
        /// </summary>
        Guid IndividualizedProgramEligibilityId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefIEPEligibilityEvaluationType"/> model
        /// </summary>
        Guid? RefIEPEligibilityEvaluationTypeId { get; set; }

        /// <summary>
        /// Defines the IndividualizedProgramEligibilityEvaluation.RecordStartDateTime nullable property
        /// </summary>
        System.DateTime? RecordStartDateTime { get; set; }

        /// <summary>
        /// Defines the IndividualizedProgramEligibilityEvaluation.RecordEndDateTime nullable property
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
