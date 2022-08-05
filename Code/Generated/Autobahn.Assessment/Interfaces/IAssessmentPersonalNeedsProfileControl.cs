//**********************************************************
//* DomainName: Autobahn.Assessment
//* FileName:   IAssessmentPersonalNeedsProfileControl.cs
//**********************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.Assessment.Interfaces
{
     /// <summary>
     /// The IAssessmentPersonalNeedsProfileControl
     /// </summary>
    public partial interface IAssessmentPersonalNeedsProfileControl : IAutobahnBase
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="AssessmentPersonalNeedsProfile"/> model
        /// </summary>
        Guid AssessmentPersonalNeedsProfileId { get; set; }

    }
}
