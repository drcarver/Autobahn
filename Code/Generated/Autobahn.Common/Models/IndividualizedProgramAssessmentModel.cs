//**********************************************************
//* DomainName: Common Models
//* FileName:   IndividualizedProgramAssessmentModel.cs
//***************************************************************************


namespace Autobahn.Common.Models
{
     /// <summary>
     /// The IndividualizedProgramAssessment Model
     /// </summary>
    public partial class IndividualizedProgramAssessmentModel : AutobahnBase, Interfaces.IIndividualizedProgramAssessment
    {
        /// <summary>
        /// Assessment Family Short Name
        /// <para>
        /// The abbreviated title of the Assessment Family. An Assessment Family is a set of assessments with a common name, jurisdiction, or focus.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19934">Assessment Family Short Name</a>
        /// </para>
        /// </summary>
        public Guid AssessmentId { get; set; }

        /// <summary>
        /// IEP Alternative Assessment Rationale
        /// <para>
        /// A statement of why-
        /// </para>
        /// </summary>
        public System.String IEPAlternativeAssessmentRationale { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IIndividualizedProgram"/> model
        /// </summary>
        public Guid IndividualizedProgramId { get; set; }

    }
}
