//**********************************************************
//* DomainName: Elementary and Secondary (K12)
//* FileName:   K12studentLiteracyAssessmentModel.cs
//***************************************************************************

using Autobahn.Interfaces.K12;
using Autobahn.Interfaces.Common;
using Autobahn.Common.Models;

namespace Autobahn.K12.Models
{
     /// <summary>
     /// The K12studentLiteracyAssessment Model
     /// </summary>
    public partial class K12studentLiteracyAssessmentModel : AutobahnBase, IK12studentLiteracyAssessment
    {
        public Boolean? LiteracyGoalMetStatus { get; set; }

        public Boolean? LiteracyPostTestStatus { get; set; }

        public Boolean? LiteracyPreTestStatus { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IOrganizationPersonRole"/> model
        /// </summary>
        public Guid OrganizationPersonRoleId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefLiteracyAssessment"/> model
        /// </summary>
        public Guid? RefLiteracyAssessmentId { get; set; }

    }
}
