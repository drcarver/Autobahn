//***************************************************************************
//* DomainName: Assessments Interfaces (used by both models and View Models
//* FileName:   IAssessmentNeedScreenEnhancement.cs
//***************************************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.Assessments.Interfaces
{
     /// <summary>
     /// The IAssessmentNeedScreenEnhancement Interface
     /// </summary>
    public partial interface IAssessmentNeedScreenEnhancement : IAutobahnBase
    {
        /// <summary>
        /// Defines as part of an Assessment Personal Needs Profile the Access for All (AfA) preference to invert the foreground and background Colors.
        /// </summary>
        System.Boolean? InvertColorChoice { get; set; }

    }
}
