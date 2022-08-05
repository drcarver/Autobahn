//**********************************************************
//* DomainName: Autobahn.Assessment
//* FileName:   IAssessmentPersonalNeedsProfileScreenEnhancement.cs
//**********************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.Assessment.Interfaces
{
     /// <summary>
     /// The IAssessmentPersonalNeedsProfileScreenEnhancement
     /// </summary>
    public partial interface IAssessmentPersonalNeedsProfileScreenEnhancement : IAutobahnBase
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="AssessmentPersonalNeedsProfile"/> model
        /// </summary>
        Guid AssessmentPersonalNeedsProfileId { get; set; }

    }
}
