//**********************************************************
//* DomainName: Elementary and Secondary (K12)
//* FileName:   K12studentCohortModel.cs
//***************************************************************************

using Autobahn.Interfaces.K12;
using Autobahn.Interfaces.Common;
using Autobahn.Common.Models;

namespace Autobahn.K12.Models
{
     /// <summary>
     /// The K12studentCohort Model
     /// </summary>
    public partial class K12studentCohortModel : AutobahnBase, IK12studentCohort
    {
        public System.String CohortDescription { get; set; }

        public System.String CohortGraduationYear { get; set; }

        public System.String CohortYear { get; set; }

        public System.String GraduationRateSurveyCohortYear { get; set; }

        public Boolean? GraduationRateSurveyIndicator { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IOrganizationPersonRole"/> model
        /// </summary>
        public Guid OrganizationPersonRoleId { get; set; }

    }
}
