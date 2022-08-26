//***************************************************************************
//* DomainName: Elementary and Secondary (K12) Interfaces (used by both models and View Models
//* FileName:   IK12studentLiteracyAssessment.cs
//***************************************************************************

using Autobahn.Interfaces.Common;

namespace Autobahn.Interfaces.K12
{
     /// <summary>
     /// The IK12studentLiteracyAssessment Interface
     /// </summary>
    public partial interface IK12studentLiteracyAssessment : IAutobahnBase
    {
        Boolean? LiteracyGoalMetStatus { get; set; }

        Boolean? LiteracyPostTestStatus { get; set; }

        Boolean? LiteracyPreTestStatus { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IOrganizationPersonRole"/> model
        /// </summary>
        Guid OrganizationPersonRoleId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefLiteracyAssessment"/> model
        /// </summary>
        Guid? RefLiteracyAssessmentId { get; set; }

    }
}
