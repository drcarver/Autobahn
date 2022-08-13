//**********************************************************
//* DomainName: Elementary and Secondary (K12)
//* FileName:   K12StudentLiteracyAssessmentModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.Models;

namespace Autobahn.K12.Models
{
     /// <summary>
     /// The K12StudentLiteracyAssessment Model
     /// </summary>
    public partial class K12StudentLiteracyAssessmentModel : AutobahnBase, Interfaces.IK12StudentLiteracyAssessment
    {
        /// <summary>
        /// The type of literacy test administered.
        /// </summary>
        public System.Boolean? LiteracyGoalMetStatus { get; set; }

        /// <summary>
        /// The type of literacy test administered.
        /// </summary>
        public System.Boolean? LiteracyPostTestStatus { get; set; }

        /// <summary>
        /// The type of literacy test administered.
        /// </summary>
        public System.Boolean? LiteracyPreTestStatus { get; set; }

        /// <summary>
        /// The type of literacy test administered.
        /// </summary>
        public Guid OrganizationPersonRoleId { get; set; }

        /// <summary>
        /// The type of literacy test administered.
        /// </summary>
        public Guid? RefLiteracyAssessmentId { get; set; }

    }
}
