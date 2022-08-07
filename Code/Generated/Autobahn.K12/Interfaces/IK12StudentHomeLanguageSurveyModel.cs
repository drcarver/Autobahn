//**********************************************************
//* DomainName: Autobahn.K12
//* FileName:   IK12StudentHomeLanguageSurveyModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.K12.Interfaces
{
     /// <summary>
     /// The IK12StudentHomeLanguageSurveyModel Interface
     /// </summary>
    public partial interface IK12StudentHomeLanguageSurveyModel : IAutobahnBase
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
