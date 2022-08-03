//**********************************************************
//* DomainName: Autobahn.K12
//* FileName:   IK12StudentHomeLanguageSurvey.cs
//**********************************************************

namespace Autobahn.K12.Interfaces
{
     /// <summary>
     /// The IK12StudentHomeLanguageSurvey
     /// </summary>
    public partial interface IK12StudentHomeLanguageSurvey
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="OrganizationPersonRole"/> model
        /// </summary>
        Guid OrganizationPersonRoleId { get; set; }

        /// <summary>
        /// Defines the K12StudentHomeLanguageSurvey.HomeLanguageSurveyAdministrationDate nullable property
        /// </summary>
        System.DateTime? HomeLanguageSurveyAdministrationDate { get; set; }

        /// <summary>
        /// Defines the K12StudentHomeLanguageSurvey.HomeLanguageSurveyAdministrationIndicator nullable property
        /// </summary>
        System.Boolean? HomeLanguageSurveyAdministrationIndicator { get; set; }

        /// <summary>
        /// Defines the K12StudentHomeLanguageSurvey.RecordStartDateTime nullable property
        /// </summary>
        System.DateTime? RecordStartDateTime { get; set; }

        /// <summary>
        /// Defines the K12StudentHomeLanguageSurvey.RecordEndDateTime nullable property
        /// </summary>
        System.DateTime? RecordEndDateTime { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RecordStatus"/> model
        /// </summary>
        Guid? RecordStatusId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="DataCollection"/> model
        /// </summary>
        Guid? DataCollectionId { get; set; }

    }
}
