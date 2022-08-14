//**********************************************************
//* DomainName: Competencies
//* FileName:   CompetencyFrameworkModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.Models;

namespace Autobahn.Competencies.Models
{
     /// <summary>
     /// The CompetencyFramework Model
     /// </summary>
    public partial class CompetencyFrameworkModel : AutobahnBase, Interfaces.ICompetencyFramework
    {
        /// <summary>
        /// An unambiguous reference to the competency framework using a network-resolvable URI.
        /// </summary>
        public System.DateTime? CompetencyFrameworkPublicationDate { get; set; }

        /// <summary>
        /// An unambiguous reference to the competency framework using a network-resolvable URI.
        /// </summary>
        public System.String CompetencyFrameworkSourceUrl { get; set; }

        /// <summary>
        /// An unambiguous reference to the competency framework using a network-resolvable URI.
        /// </summary>
        public System.String Creator { get; set; }

        /// <summary>
        /// An unambiguous reference to the competency framework using a network-resolvable URI.
        /// </summary>
        public System.String Jurisdiction { get; set; }

        /// <summary>
        /// An unambiguous reference to the competency framework using a network-resolvable URI.
        /// </summary>
        public System.String License { get; set; }

        /// <summary>
        /// An unambiguous reference to the competency framework using a network-resolvable URI.
        /// </summary>
        public System.String Publisher { get; set; }

        /// <summary>
        /// An unambiguous reference to the competency framework using a network-resolvable URI.
        /// </summary>
        public Guid? RefCompetencyFrameworkPublicationStatusId { get; set; }

        /// <summary>
        /// An unambiguous reference to the competency framework using a network-resolvable URI.
        /// </summary>
        public Guid? RefLanguageId { get; set; }

        /// <summary>
        /// An unambiguous reference to the competency framework using a network-resolvable URI.
        /// </summary>
        public System.String Rights { get; set; }

        /// <summary>
        /// An unambiguous reference to the competency framework using a network-resolvable URI.
        /// </summary>
        public System.String RightsHolder { get; set; }

        /// <summary>
        /// An unambiguous reference to the competency framework using a network-resolvable URI.
        /// </summary>
        public System.String Subject { get; set; }

        /// <summary>
        /// An unambiguous reference to the competency framework using a network-resolvable URI.
        /// </summary>
        public System.String Title { get; set; }

        /// <summary>
        /// An unambiguous reference to the competency framework using a network-resolvable URI.
        /// </summary>
        public System.String URI { get; set; }

        /// <summary>
        /// An unambiguous reference to the competency framework using a network-resolvable URI.
        /// </summary>
        public System.DateTime ValidEndDate { get; set; }

        /// <summary>
        /// An unambiguous reference to the competency framework using a network-resolvable URI.
        /// </summary>
        public System.DateTime ValidStartDate { get; set; }

        /// <summary>
        /// An unambiguous reference to the competency framework using a network-resolvable URI.
        /// </summary>
        public System.String Version { get; set; }

    }
}
