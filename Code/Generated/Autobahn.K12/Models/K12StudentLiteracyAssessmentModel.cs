//**********************************************************
//* DomainName: Elementary and Secondary (K12)
//* FileName:   K12StudentLiteracyAssessmentModel.cs
//***************************************************************************

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
        /// Literacy Goal Met Status
        /// <para>
        /// The participant showed "significant learning gains" on measures of reading, the definition of which is determined at the State level.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19457">Literacy Goal Met Status</a>
        /// </para>
        /// </summary>
        public System.Boolean? LiteracyGoalMetStatus { get; set; }

        /// <summary>
        /// Literacy Post Test Status
        /// <para>
        /// The participant completed a literacy post-test.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19458">Literacy Post Test Status</a>
        /// </para>
        /// </summary>
        public System.Boolean? LiteracyPostTestStatus { get; set; }

        /// <summary>
        /// Literacy Pre Test Status
        /// <para>
        /// The participant completed a literacy pre-test.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19459">Literacy Pre Test Status</a>
        /// </para>
        /// </summary>
        public System.Boolean? LiteracyPreTestStatus { get; set; }

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
