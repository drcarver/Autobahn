//**********************************************************
//* DomainName: Autobahn.Assessment
//* FileName:   IAssessmentPersonalNeedsProfile.cs
//**********************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.Assessment.Interfaces
{
     /// <summary>
     /// The IAssessmentPersonalNeedsProfile
     /// </summary>
    public partial interface IAssessmentPersonalNeedsProfile : IAutobahnBase
    {
        /// <summary>
        /// Defines the AssessmentPersonalNeedsProfile.AssessmentNeedType non nullable property
        /// </summary>
        System.String AssessmentNeedType { get; set; }

        /// <summary>
        /// Defines the AssessmentPersonalNeedsProfile.AssignedSupportFlag nullable property
        /// </summary>
        System.Boolean? AssignedSupportFlag { get; set; }

        /// <summary>
        /// Defines the AssessmentPersonalNeedsProfile.ActivateByDefault nullable property
        /// </summary>
        System.Boolean? ActivateByDefault { get; set; }

    }
}
