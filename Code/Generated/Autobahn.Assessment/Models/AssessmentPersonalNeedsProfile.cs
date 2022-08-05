//**********************************************************
//* DomainName: Autobahn.Assessment
//* FileName:   AssessmentPersonalNeedsProfile.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.Models;

namespace Autobahn.Assessment.Models
{
     /// <summary>
     /// The AssessmentPersonalNeedsProfile
     /// </summary>
    public partial class AssessmentPersonalNeedsProfile : AutobahnBase, Interfaces.IAssessmentPersonalNeedsProfile
    {
        /// <summary>
        /// Defines the AssessmentPersonalNeedsProfile.AssessmentNeedType non nullable property
        /// </summary>
        public System.String AssessmentNeedType { get; set; }

        /// <summary>
        /// Defines the AssessmentPersonalNeedsProfile.AssignedSupportFlag nullable property
        /// </summary>
        public System.Boolean? AssignedSupportFlag { get; set; }

        /// <summary>
        /// Defines the AssessmentPersonalNeedsProfile.ActivateByDefault nullable property
        /// </summary>
        public System.Boolean? ActivateByDefault { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="DataCollection"/> model
        /// </summary>
        public Guid? DataCollectionId { get; set; }

    }
}
