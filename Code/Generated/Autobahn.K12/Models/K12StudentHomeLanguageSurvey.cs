//**********************************************************
//* DomainName: Autobahn.K12
//* FileName:   K12StudentHomeLanguageSurvey.cs
//**********************************************************

using Autobahn.K12.Interfaces;

namespace Autobahn.K12.Models
{
     /// <summary>
     /// The K12StudentHomeLanguageSurvey
     /// </summary>
    public partial class K12StudentHomeLanguageSurvey : IK12StudentHomeLanguageSurvey
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="OrganizationPersonRole"/> model
        /// </summary>
        public Guid OrganizationPersonRoleId { get; set; }

        /// <summary>
        /// Defines the K12StudentHomeLanguageSurvey.HomeLanguageSurveyAdministrationDate nullable property
        /// </summary>
        public System.DateTime? HomeLanguageSurveyAdministrationDate { get; set; }

        /// <summary>
        /// Defines the K12StudentHomeLanguageSurvey.HomeLanguageSurveyAdministrationIndicator nullable property
        /// </summary>
        public System.Boolean? HomeLanguageSurveyAdministrationIndicator { get; set; }

        /// <summary>
        /// Defines the K12StudentHomeLanguageSurvey.RecordStartDateTime nullable property
        /// </summary>
        public System.DateTime? RecordStartDateTime { get; set; }

        /// <summary>
        /// Defines the K12StudentHomeLanguageSurvey.RecordEndDateTime nullable property
        /// </summary>
        public System.DateTime? RecordEndDateTime { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RecordStatus"/> model
        /// </summary>
        public Guid? RecordStatusId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="DataCollection"/> model
        /// </summary>
        public Guid? DataCollectionId { get; set; }

    }
}
