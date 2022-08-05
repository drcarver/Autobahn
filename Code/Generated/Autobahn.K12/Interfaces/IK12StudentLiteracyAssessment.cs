//**********************************************************
//* DomainName: Autobahn.K12
//* FileName:   IK12StudentLiteracyAssessment.cs
//**********************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.K12.Interfaces
{
     /// <summary>
     /// The IK12StudentLiteracyAssessment
     /// </summary>
    public partial interface IK12StudentLiteracyAssessment : IAutobahnBase
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="OrganizationPersonRole"/> model
        /// </summary>
        Guid OrganizationPersonRoleId { get; set; }

        /// <summary>
        /// Defines the K12StudentLiteracyAssessment.LiteracyPreTestStatus nullable property
        /// </summary>
        System.Boolean? LiteracyPreTestStatus { get; set; }

        /// <summary>
        /// Defines the K12StudentLiteracyAssessment.LiteracyPostTestStatus nullable property
        /// </summary>
        System.Boolean? LiteracyPostTestStatus { get; set; }

        /// <summary>
        /// Defines the K12StudentLiteracyAssessment.LiteracyGoalMetStatus nullable property
        /// </summary>
        System.Boolean? LiteracyGoalMetStatus { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefLiteracyAssessment"/> model
        /// </summary>
        Guid? RefLiteracyAssessmentId { get; set; }

    }
}
