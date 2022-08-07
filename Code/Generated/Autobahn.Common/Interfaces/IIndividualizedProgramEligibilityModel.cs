//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   IIndividualizedProgramEligibilityModel.cs
//**********************************************************


namespace Autobahn.Common.Interfaces
{
     /// <summary>
     /// The IIndividualizedProgramEligibilityModel Interface
     /// </summary>
    public partial interface IIndividualizedProgramEligibilityModel : IAutobahnBase
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
