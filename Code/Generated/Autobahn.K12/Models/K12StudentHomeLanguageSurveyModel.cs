//**********************************************************
//* DomainName: Elementary and Secondary (K12)
//* FileName:   K12studentHomeLanguageSurveyModel.cs
//***************************************************************************

using Autobahn.Interfaces.K12;
using Autobahn.Interfaces.Common;
using Autobahn.Common.Models;

namespace Autobahn.K12.Models
{
     /// <summary>
     /// The K12studentHomeLanguageSurvey Model
     /// </summary>
    public partial class K12studentHomeLanguageSurveyModel : AutobahnBase, IK12studentHomeLanguageSurvey
    {
        public DateTime? HomeLanguageSurveyAdministrationDate { get; set; }

        public Boolean? HomeLanguageSurveyAdministrationIndicator { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IOrganizationPersonRole"/> model
        /// </summary>
        public Guid OrganizationPersonRoleId { get; set; }

    }
}
