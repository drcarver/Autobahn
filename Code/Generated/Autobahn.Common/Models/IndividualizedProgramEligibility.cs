//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   IndividualizedProgramEligibility.cs
//**********************************************************


namespace Autobahn.Common.Models
{
     /// <summary>
     /// The IndividualizedProgramEligibility
     /// </summary>
    public partial class IndividualizedProgramEligibility : AutobahnBase, Interfaces.IIndividualizedProgramEligibility
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="IndividualizedProgram"/> model
        /// </summary>
        public Guid IndividualizedProgramId { get; set; }

        /// <summary>
        /// Defines the IndividualizedProgramEligibility.ConsentToEvaluateDate nullable property
        /// </summary>
        public System.DateTime? ConsentToEvaluateDate { get; set; }

        /// <summary>
        /// Defines the IndividualizedProgramEligibility.ConsentToEvaluateIndicator nullable property
        /// </summary>
        public System.Boolean? ConsentToEvaluateIndicator { get; set; }

        /// <summary>
        /// Defines the IndividualizedProgramEligibility.ParentObservations non nullable property
        /// </summary>
        public System.String ParentObservations { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="DataCollection"/> model
        /// </summary>
        public Guid? DataCollectionId { get; set; }

    }
}
