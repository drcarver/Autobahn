//**********************************************************
//* DomainName: Autobahn.Assessment
//* FileName:   IAssessmentPersonalNeedsProfileDisplay.cs
//**********************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.Assessment.Interfaces
{
     /// <summary>
     /// The IAssessmentPersonalNeedsProfileDisplay
     /// </summary>
    public partial interface IAssessmentPersonalNeedsProfileDisplay : IAutobahnBase
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="AssessmentPersonalNeedsProfile"/> model
        /// </summary>
        Guid AssessmentPersonalNeedsProfileId { get; set; }

    }
}
