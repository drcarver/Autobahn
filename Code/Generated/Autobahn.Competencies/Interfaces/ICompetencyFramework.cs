//***************************************************************************
//* DomainName: Competencies Interfaces (used by both models and View Models
//* FileName:   ICompetencyFramework.cs
//***************************************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.Competencies.Interfaces
{
     /// <summary>
     /// The ICompetencyFramework Interface
     /// </summary>
    public partial interface ICompetencyFramework : IAutobahnBase
    {
        /// <summary>
        /// Competency Framework Publication Date
        /// <para>
        /// The date on which this content was first published.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20548">Competency Framework Publication Date</a>
        /// </para>
        /// </summary>
        System.DateTime? CompetencyFrameworkPublicationDate { get; set; }

        /// <summary>
        /// Competency Framework Source URL
        /// <para>
        /// A URL that resolves to the original or authoritative competency framework document.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20888">Competency Framework Source URL</a>
        /// </para>
        /// </summary>
        System.String CompetencyFrameworkSourceUrl { get; set; }

        /// <summary>
        /// Competency Framework Creator
        /// <para>
        /// The person or organization chiefly responsible for the intellectual content of the competency framework.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19673">Competency Framework Creator</a>
        /// </para>
        /// </summary>
        System.String Creator { get; set; }

        /// <summary>
        /// Competency Framework Jurisdiction
        /// <para>
        /// A legal, quasi-legal, organizational or institutional domain of the entity mandating the use of the statement--e.g., California.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19676">Competency Framework Jurisdiction</a>
        /// </para>
        /// </summary>
        System.String Jurisdiction { get; set; }

        /// <summary>
        /// Competency Framework License
        /// <para>
        /// A legal document giving official permission to do something with the competency framework.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19882">Competency Framework License</a>
        /// </para>
        /// </summary>
        System.String License { get; set; }

        /// <summary>
        /// Competency Framework Publisher
        /// <para>
        /// The entity responsible for making the competency framework available.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19884">Competency Framework Publisher</a>
        /// </para>
        /// </summary>
        System.String Publisher { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefCompetencyFrameworkPublicationStatus"/> model
        /// </summary>
        Guid? RefCompetencyFrameworkPublicationStatusId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefLanguage"/> model
        /// </summary>
        Guid? RefLanguageId { get; set; }

        /// <summary>
        /// Competency Framework Rights
        /// <para>
        /// The information about rights held in and over the resource.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19885">Competency Framework Rights</a>
        /// </para>
        /// </summary>
        System.String Rights { get; set; }

        /// <summary>
        /// Competency Framework Rights Holder
        /// <para>
        /// The person or organization owning or managing rights over the competency framework.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19886">Competency Framework Rights Holder</a>
        /// </para>
        /// </summary>
        System.String RightsHolder { get; set; }

        /// <summary>
        /// Competency Framework Subject
        /// <para>
        /// The topic or academic subject of the competency framework.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19679">Competency Framework Subject</a>
        /// </para>
        /// </summary>
        System.String Subject { get; set; }

        /// <summary>
        /// Competency Framework Title
        /// <para>
        /// The name of the competency framework.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19671">Competency Framework Title</a>
        /// </para>
        /// </summary>
        System.String Title { get; set; }

        /// <summary>
        /// Competency Framework Identifier URI
        /// <para>
        /// An unambiguous reference to the competency framework using a network-resolvable URI.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19670">Competency Framework Identifier URI</a>
        /// </para>
        /// </summary>
        System.String URI { get; set; }

        /// <summary>
        /// Competency Framework Valid End Date
        /// <para>
        /// The year, month and day the competency framework was deprecated/replaced by the jurisdiction in which it was intended to apply.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19678">Competency Framework Valid End Date</a>
        /// </para>
        /// </summary>
        System.DateTime ValidEndDate { get; set; }

        /// <summary>
        /// Competency Framework Valid Start Date
        /// <para>
        /// The year, month and day the competency framework was adopted by the jurisdiction in which it was intended to apply.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19677">Competency Framework Valid Start Date</a>
        /// </para>
        /// </summary>
        System.DateTime ValidStartDate { get; set; }

        /// <summary>
        /// Competency Framework Version
        /// <para>
        /// Defines the revision of the competency framework as a version number or date.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19672">Competency Framework Version</a>
        /// </para>
        /// </summary>
        System.String Version { get; set; }

    }
}
