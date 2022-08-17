//***************************************************************************
//* DomainName: Elementary and Secondary (K12) Interfaces (used by both models and View Models
//* FileName:   IK12StudentLiteracyAssessment.cs
//***************************************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.K12.Interfaces
{
     /// <summary>
     /// The IK12StudentLiteracyAssessment Interface
     /// </summary>
    public partial interface IK12StudentLiteracyAssessment : IAutobahnBase
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
        System.Boolean? LiteracyGoalMetStatus { get; set; }

        /// <summary>
        /// Literacy Post Test Status
        /// <para>
        /// The participant completed a literacy post-test.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19458">Literacy Post Test Status</a>
        /// </para>
        /// </summary>
        System.Boolean? LiteracyPostTestStatus { get; set; }

        /// <summary>
        /// Literacy Pre Test Status
        /// <para>
        /// The participant completed a literacy pre-test.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19459">Literacy Pre Test Status</a>
        /// </para>
        /// </summary>
        System.Boolean? LiteracyPreTestStatus { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IOrganizationPersonRole"/> model
        /// </summary>
        Guid OrganizationPersonRoleId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IRefLiteracyAssessment"/> model
        /// </summary>
        Guid? RefLiteracyAssessmentId { get; set; }

    }
}
