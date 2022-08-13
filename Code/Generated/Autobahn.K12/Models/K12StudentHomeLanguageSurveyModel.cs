//**********************************************************
//* DomainName: Elementary and Secondary (K12)
//* FileName:   K12StudentHomeLanguageSurveyModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.Models;

namespace Autobahn.K12.Models
{
     /// <summary>
     /// The K12StudentHomeLanguageSurvey Model
     /// </summary>
    public partial class K12StudentHomeLanguageSurveyModel : AutobahnBase, Interfaces.IK12StudentHomeLanguageSurvey
    {
        /// <summary>
        /// The start date and, optionally, time that a record is active as used to support version control.
        /// </summary>
        public System.DateTime? HomeLanguageSurveyAdministrationDate { get; set; }

        /// <summary>
        /// The start date and, optionally, time that a record is active as used to support version control.
        /// </summary>
        public System.Boolean? HomeLanguageSurveyAdministrationIndicator { get; set; }

        /// <summary>
        /// The start date and, optionally, time that a record is active as used to support version control.
        /// </summary>
        public Guid OrganizationPersonRoleId { get; set; }

    }
}
