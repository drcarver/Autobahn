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
        /// An unambiguous reference to the competency framework using a network-resolvable URI.
        /// </summary>
        System.DateTime? CompetencyFrameworkPublicationDate { get; set; }

        /// <summary>
        /// An unambiguous reference to the competency framework using a network-resolvable URI.
        /// </summary>
        System.String CompetencyFrameworkSourceUrl { get; set; }

        /// <summary>
        /// An unambiguous reference to the competency framework using a network-resolvable URI.
        /// </summary>
        System.String Creator { get; set; }

        /// <summary>
        /// An unambiguous reference to the competency framework using a network-resolvable URI.
        /// </summary>
        System.String Jurisdiction { get; set; }

        /// <summary>
        /// An unambiguous reference to the competency framework using a network-resolvable URI.
        /// </summary>
        System.String License { get; set; }

        /// <summary>
        /// An unambiguous reference to the competency framework using a network-resolvable URI.
        /// </summary>
        System.String Publisher { get; set; }

        /// <summary>
        /// An unambiguous reference to the competency framework using a network-resolvable URI.
        /// </summary>
        Guid? RefCompetencyFrameworkPublicationStatusId { get; set; }

        /// <summary>
        /// An unambiguous reference to the competency framework using a network-resolvable URI.
        /// </summary>
        Guid? RefLanguageId { get; set; }

        /// <summary>
        /// An unambiguous reference to the competency framework using a network-resolvable URI.
        /// </summary>
        System.String Rights { get; set; }

        /// <summary>
        /// An unambiguous reference to the competency framework using a network-resolvable URI.
        /// </summary>
        System.String RightsHolder { get; set; }

        /// <summary>
        /// An unambiguous reference to the competency framework using a network-resolvable URI.
        /// </summary>
        System.String Subject { get; set; }

        /// <summary>
        /// An unambiguous reference to the competency framework using a network-resolvable URI.
        /// </summary>
        System.String Title { get; set; }

        /// <summary>
        /// An unambiguous reference to the competency framework using a network-resolvable URI.
        /// </summary>
        System.String URI { get; set; }

        /// <summary>
        /// An unambiguous reference to the competency framework using a network-resolvable URI.
        /// </summary>
        System.DateTime ValidEndDate { get; set; }

        /// <summary>
        /// An unambiguous reference to the competency framework using a network-resolvable URI.
        /// </summary>
        System.DateTime ValidStartDate { get; set; }

        /// <summary>
        /// An unambiguous reference to the competency framework using a network-resolvable URI.
        /// </summary>
        System.String Version { get; set; }

    }
}
