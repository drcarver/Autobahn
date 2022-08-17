//***************************************************************************
//* DomainName: Common Models Interfaces (used by both models and View Models
//* FileName:   IRubric.cs
//***************************************************************************


namespace Autobahn.Common.Interfaces
{
     /// <summary>
     /// The IRubric Interface
     /// </summary>
    public partial interface IRubric : IAutobahnBase
    {
        /// <summary>
        /// Rubric Identifier
        /// <para>
        /// An identifier assigned to a rubric.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19412">Rubric Identifier</a>
        /// </para>
        /// </summary>
        System.String Identifier { get; set; }

        /// <summary>
        /// Rubric Title
        /// <para>
        /// The title of the rubric.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19411">Rubric Title</a>
        /// </para>
        /// </summary>
        System.String Title { get; set; }

        /// <summary>
        /// Rubric URL Reference
        /// <para>
        /// The URL location where the rubric may be found.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19413">Rubric URL Reference</a>
        /// </para>
        /// </summary>
        System.String UrlReference { get; set; }

    }
}
