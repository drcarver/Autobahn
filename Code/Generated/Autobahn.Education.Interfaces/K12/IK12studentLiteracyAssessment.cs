//***************************************************************************
//* DomainName: Elementary and Secondary (K12) Interfaces (used by both models and View Models
//* FileName:   IK12studentLiteracyAssessment.cs
//***************************************************************************

using Autobahn.Education.Interfaces.Common;

namespace Autobahn.Education.Interfaces.K12
{
     /// <summary>
     /// The IK12studentLiteracyAssessment Interface
     /// </summary>
    public partial interface IK12studentLiteracyAssessment : IAutobahnBase
    {
        #region IK12studentLiteracyAssessment
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

        #endregion
    }
}
