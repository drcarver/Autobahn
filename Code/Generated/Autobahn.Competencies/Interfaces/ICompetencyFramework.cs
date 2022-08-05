//**********************************************************
//* DomainName: Autobahn.Competencies
//* FileName:   ICompetencyFramework.cs
//**********************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.Competencies.Interfaces
{
     /// <summary>
     /// The ICompetencyFramework
     /// </summary>
    public partial interface ICompetencyFramework : IAutobahnBase
    {
        /// <summary>
        /// Defines the CompetencyFramework.URI non nullable property
        /// </summary>
        System.String URI { get; set; }

        /// <summary>
        /// Defines the CompetencyFramework.Title non nullable property
        /// </summary>
        System.String Title { get; set; }

        /// <summary>
        /// Defines the CompetencyFramework.Subject non nullable property
        /// </summary>
        System.String Subject { get; set; }

        /// <summary>
        /// Defines the CompetencyFramework.Version non nullable property
        /// </summary>
        System.String Version { get; set; }

        /// <summary>
        /// Defines the CompetencyFramework.Creator non nullable property
        /// </summary>
        System.String Creator { get; set; }

        /// <summary>
        /// Defines the CompetencyFramework.Jurisdiction non nullable property
        /// </summary>
        System.String Jurisdiction { get; set; }

        /// <summary>
        /// Defines the CompetencyFramework.Description non nullable property
        /// </summary>
        System.String Description { get; set; }

        /// <summary>
        /// Defines the CompetencyFramework.Publisher non nullable property
        /// </summary>
        System.String Publisher { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefCompetencyFrameworkPublicationStatus"/> model
        /// </summary>
        Guid? RefCompetencyFrameworkPublicationStatusId { get; set; }

        /// <summary>
        /// Defines the CompetencyFramework.ValidStartDate non nullable property
        /// </summary>
        System.DateTime ValidStartDate { get; set; }

        /// <summary>
        /// Defines the CompetencyFramework.ValidEndDate non nullable property
        /// </summary>
        System.DateTime ValidEndDate { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefLanguage"/> model
        /// </summary>
        Guid? RefLanguageId { get; set; }

        /// <summary>
        /// Defines the CompetencyFramework.License non nullable property
        /// </summary>
        System.String License { get; set; }

        /// <summary>
        /// Defines the CompetencyFramework.Rights non nullable property
        /// </summary>
        System.String Rights { get; set; }

        /// <summary>
        /// Defines the CompetencyFramework.RightsHolder non nullable property
        /// </summary>
        System.String RightsHolder { get; set; }

        /// <summary>
        /// Defines the CompetencyFramework.CompetencyFrameworkPublicationDate nullable property
        /// </summary>
        System.DateTime? CompetencyFrameworkPublicationDate { get; set; }

        /// <summary>
        /// Defines the CompetencyFramework.CompetencyFrameworkSourceUrl non nullable property
        /// </summary>
        System.String CompetencyFrameworkSourceUrl { get; set; }

    }
}
