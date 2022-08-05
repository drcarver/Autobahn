//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   IIndividualizedProgramEligibility.cs
//**********************************************************


namespace Autobahn.Common.Interfaces
{
     /// <summary>
     /// The IIndividualizedProgramEligibility
     /// </summary>
    public partial interface IIndividualizedProgramEligibility : IAutobahnBase
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

    }
}
