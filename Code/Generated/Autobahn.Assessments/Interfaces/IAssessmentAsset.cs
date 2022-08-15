//***************************************************************************
//* DomainName: Assessments Interfaces (used by both models and View Models
//* FileName:   IAssessmentAsset.cs
//***************************************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.Assessments.Interfaces
{
     /// <summary>
     /// The IAssessmentAsset Interface
     /// </summary>
    public partial interface IAssessmentAsset : IAutobahnBase
    {
        /// <summary>
        /// The language in which the assessment form is designed to be delivered.
        /// </summary>
        Guid? RefAssessmentLanguageId { get; set; }

    }
}
