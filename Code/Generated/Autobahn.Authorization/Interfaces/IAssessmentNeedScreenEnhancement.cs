//***************************************************************************
//* DomainName: Authentication and Authorization Interfaces (used by both models and View Models
//* FileName:   IAssessmentNeedScreenEnhancement.cs
//***************************************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.Authorization.Interfaces
{
     /// <summary>
     /// The IAssessmentNeedScreenEnhancement Interface
     /// </summary>
    public partial interface IAssessmentNeedScreenEnhancement : IAutobahnBase
    {
        /// <summary>
        /// Defines as part of an Assessment Personal Needs Profile the Access for All (AfA) preference to invert the foreground and background Colors.
        /// </summary>
        Guid AssessmentPersonalNeedsProfileDisplayId { get; set; }

        /// <summary>
        /// Defines as part of an Assessment Personal Needs Profile the Access for All (AfA) preference to invert the foreground and background Colors.
        /// </summary>
        Guid? AssessmentPersonalNeedsProfileScreenEnhancementId { get; set; }

        /// <summary>
        /// Defines as part of an Assessment Personal Needs Profile the Access for All (AfA) preference to invert the foreground and background Colors.
        /// </summary>
        System.String ForegroundColor { get; set; }

        /// <summary>
        /// Defines as part of an Assessment Personal Needs Profile the Access for All (AfA) preference to invert the foreground and background Colors.
        /// </summary>
        System.Boolean? InvertColorChoice { get; set; }

        /// <summary>
        /// Defines as part of an Assessment Personal Needs Profile the Access for All (AfA) preference to invert the foreground and background Colors.
        /// </summary>
        System.Decimal? Magnification { get; set; }

    }
}
