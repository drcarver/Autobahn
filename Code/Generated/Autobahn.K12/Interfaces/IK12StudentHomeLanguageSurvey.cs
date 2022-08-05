//**********************************************************
//* DomainName: Autobahn.K12
//* FileName:   IK12StudentHomeLanguageSurvey.cs
//**********************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.K12.Interfaces
{
     /// <summary>
     /// The IK12StudentHomeLanguageSurvey
     /// </summary>
    public partial interface IK12StudentHomeLanguageSurvey : IAutobahnBase
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

    }
}
