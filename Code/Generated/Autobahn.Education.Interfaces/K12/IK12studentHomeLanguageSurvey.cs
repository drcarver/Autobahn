//***************************************************************************
//* DomainName: Elementary and Secondary (K12) Interfaces (used by both models and View Models
//* FileName:   IK12studentHomeLanguageSurvey.cs
//***************************************************************************

using Autobahn.Education.Interfaces.Common;

namespace Autobahn.Education.Interfaces.K12
{
     /// <summary>
     /// The IK12studentHomeLanguageSurvey Interface
     /// </summary>
    public partial interface IK12studentHomeLanguageSurvey : IAutobahnBase
    {
        #region IK12studentHomeLanguageSurvey
        DateTime? HomeLanguageSurveyAdministrationDate { get; set; }

        Boolean? HomeLanguageSurveyAdministrationIndicator { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IOrganizationPersonRole"/> model
        /// </summary>
        Guid OrganizationPersonRoleId { get; set; }

        #endregion
    }
}
