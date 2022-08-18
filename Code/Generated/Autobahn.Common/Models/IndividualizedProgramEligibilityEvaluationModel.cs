//**********************************************************
//* DomainName: Common Models
//* FileName:   IndividualizedProgramEligibilityEvaluationModel.cs
//***************************************************************************


namespace Autobahn.Common.Models
{
     /// <summary>
     /// The IndividualizedProgramEligibilityEvaluation Model
     /// </summary>
    public partial class IndividualizedProgramEligibilityEvaluationModel : AutobahnBase, Interfaces.IIndividualizedProgramEligibilityEvaluation
    {
        /// <summary>
        /// Reference to an optional instance of the <see cref="IEligibilityEvaluation"/> model
        /// </summary>
        public Guid EligibilityEvaluationId { get; set; }

        /// <summary>
        /// Consent to Evaluation Date
        /// <para>
        /// The date the consent to evaluation occurred.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20708">Consent to Evaluation Date</a>
        /// </para>
        /// </summary>
        public Guid IndividualizedProgramEligibilityId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefIEPEligibilityEvaluationType"/> model
        /// </summary>
        public Guid? RefIEPEligibilityEvaluationTypeId { get; set; }

    }
}
