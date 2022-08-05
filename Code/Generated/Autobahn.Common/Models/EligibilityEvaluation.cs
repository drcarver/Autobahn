//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   EligibilityEvaluation.cs
//**********************************************************


namespace Autobahn.Common.Models
{
     /// <summary>
     /// The EligibilityEvaluation
     /// </summary>
    public partial class EligibilityEvaluation : AutobahnBase, Interfaces.IEligibilityEvaluation
    {
        /// <summary>
        /// Defines the EligibilityEvaluation.Description non nullable property
        /// </summary>
        public System.String Description { get; set; }

        /// <summary>
        /// Defines the EligibilityEvaluation.EvaluationDate nullable property
        /// </summary>
        public System.DateTime? EvaluationDate { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="DataCollection"/> model
        /// </summary>
        public Guid? DataCollectionId { get; set; }

    }
}
