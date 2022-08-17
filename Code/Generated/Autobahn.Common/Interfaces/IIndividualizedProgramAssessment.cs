//***************************************************************************
//* DomainName: Common Models Interfaces (used by both models and View Models
//* FileName:   IIndividualizedProgramAssessment.cs
//***************************************************************************


namespace Autobahn.Common.Interfaces
{
     /// <summary>
     /// The IIndividualizedProgramAssessment Interface
     /// </summary>
    public partial interface IIndividualizedProgramAssessment : IAutobahnBase
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
        Guid AssessmentId { get; set; }

        /// <summary>
        /// IEP Alternative Assessment Rationale
        /// <para>
        /// A statement of why-
        /// </para>
        /// </summary>
        System.String IEPAlternativeAssessmentRationale { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IIndividualizedProgram"/> model
        /// </summary>
        Guid IndividualizedProgramId { get; set; }

    }
}
