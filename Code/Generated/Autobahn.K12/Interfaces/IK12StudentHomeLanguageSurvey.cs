//***************************************************************************
//* DomainName: Elementary and Secondary (K12) Interfaces (used by both models and View Models
//* FileName:   IK12StudentHomeLanguageSurvey.cs
//***************************************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.K12.Interfaces
{
     /// <summary>
     /// The IK12StudentHomeLanguageSurvey Interface
     /// </summary>
    public partial interface IK12StudentHomeLanguageSurvey : IAutobahnBase
    {
        /// <summary>
        /// The start date and, optionally, time that a record is active as used to support version control.
        /// </summary>
        System.DateTime? HomeLanguageSurveyAdministrationDate { get; set; }

        /// <summary>
        /// The start date and, optionally, time that a record is active as used to support version control.
        /// </summary>
        System.Boolean? HomeLanguageSurveyAdministrationIndicator { get; set; }

        /// <summary>
        /// The start date and, optionally, time that a record is active as used to support version control.
        /// </summary>
        Guid OrganizationPersonRoleId { get; set; }

    }
}
