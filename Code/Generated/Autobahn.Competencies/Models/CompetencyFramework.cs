//**********************************************************
//* DomainName: Autobahn.Competencies
//* FileName:   CompetencyFramework.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.Models;

namespace Autobahn.Competencies.Models
{
     /// <summary>
     /// The CompetencyFramework
     /// </summary>
    public partial class CompetencyFramework : AutobahnBase, Interfaces.ICompetencyFramework
    {
        /// <summary>
        /// Defines the CompetencyFramework.URI non nullable property
        /// </summary>
        public System.String URI { get; set; }

        /// <summary>
        /// Defines the CompetencyFramework.Title non nullable property
        /// </summary>
        public System.String Title { get; set; }

        /// <summary>
        /// Defines the CompetencyFramework.Subject non nullable property
        /// </summary>
        public System.String Subject { get; set; }

        /// <summary>
        /// Defines the CompetencyFramework.Version non nullable property
        /// </summary>
        public System.String Version { get; set; }

        /// <summary>
        /// Defines the CompetencyFramework.Creator non nullable property
        /// </summary>
        public System.String Creator { get; set; }

        /// <summary>
        /// Defines the CompetencyFramework.Jurisdiction non nullable property
        /// </summary>
        public System.String Jurisdiction { get; set; }

        /// <summary>
        /// Defines the CompetencyFramework.Description non nullable property
        /// </summary>
        public System.String Description { get; set; }

        /// <summary>
        /// Defines the CompetencyFramework.Publisher non nullable property
        /// </summary>
        public System.String Publisher { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefCompetencyFrameworkPublicationStatus"/> model
        /// </summary>
        public Guid? RefCompetencyFrameworkPublicationStatusId { get; set; }

        /// <summary>
        /// Defines the CompetencyFramework.ValidStartDate non nullable property
        /// </summary>
        public System.DateTime ValidStartDate { get; set; }

        /// <summary>
        /// Defines the CompetencyFramework.ValidEndDate non nullable property
        /// </summary>
        public System.DateTime ValidEndDate { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefLanguage"/> model
        /// </summary>
        public Guid? RefLanguageId { get; set; }

        /// <summary>
        /// Defines the CompetencyFramework.License non nullable property
        /// </summary>
        public System.String License { get; set; }

        /// <summary>
        /// Defines the CompetencyFramework.Rights non nullable property
        /// </summary>
        public System.String Rights { get; set; }

        /// <summary>
        /// Defines the CompetencyFramework.RightsHolder non nullable property
        /// </summary>
        public System.String RightsHolder { get; set; }

        /// <summary>
        /// Defines the CompetencyFramework.CompetencyFrameworkPublicationDate nullable property
        /// </summary>
        public System.DateTime? CompetencyFrameworkPublicationDate { get; set; }

        /// <summary>
        /// Defines the CompetencyFramework.CompetencyFrameworkSourceUrl non nullable property
        /// </summary>
        public System.String CompetencyFrameworkSourceUrl { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="DataCollection"/> model
        /// </summary>
        public Guid? DataCollectionId { get; set; }

    }
}
