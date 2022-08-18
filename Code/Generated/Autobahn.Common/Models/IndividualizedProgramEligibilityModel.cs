//**********************************************************
//* DomainName: Common Models
//* FileName:   IndividualizedProgramEligibilityModel.cs
//* Name:       Consent to Evaluation Date
//* Definition: The date the consent to evaluation occurred.
//***************************************************************************


namespace Autobahn.Common.Models
{
     /// <summary>
     /// The date the consent to evaluation occurred.
     /// </summary>
    public partial class IndividualizedProgramEligibilityModel : AutobahnBase, Interfaces.IIndividualizedProgramEligibility
    {
        /// <summary>
        /// Consent to Evaluation Date
        /// <para>
        /// The date the consent to evaluation occurred.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20708">Consent to Evaluation Date</a>
        /// </para>
        /// </summary>
        public System.DateTime? ConsentToEvaluateDate { get; set; }

        /// <summary>
        /// Consent to Evaluation Indicator
        /// <para>
        /// Indication parent agreed to evaluate student.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20707">Consent to Evaluation Indicator</a>
        /// </para>
        /// </summary>
        public System.Boolean? ConsentToEvaluateIndicator { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IIndividualizedProgram"/> model
        /// </summary>
        public Guid IndividualizedProgramId { get; set; }

        /// <summary>
        /// Eligibility Parent Observations Explanation
        /// <para>
        /// Explanation of parent's observations of student's characteristics and history used for determining eligibility.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20713">Eligibility Parent Observations Explanation</a>
        /// </para>
        /// </summary>
        public System.String ParentObservations { get; set; }

    }
}
