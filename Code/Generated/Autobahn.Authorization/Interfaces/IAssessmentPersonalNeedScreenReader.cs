//***************************************************************************
//* DomainName: Authentication and Authorization Interfaces (used by both models and View Models
//* FileName:   IAssessmentPersonalNeedScreenReader.cs
//***************************************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.Authorization.Interfaces
{
     /// <summary>
     /// The IAssessmentPersonalNeedScreenReader Interface
     /// </summary>
    public partial interface IAssessmentPersonalNeedScreenReader : IAutobahnBase
    {
        /// <summary>
        /// Defines as part of an Assessment Personal Needs Profile the rating for the collection of Access for All (AfA) needs and preferences.
        /// </summary>
        Guid AssessmentPersonalNeedsProfileDisplayId { get; set; }

        /// <summary>
        /// Defines as part of an Assessment Personal Needs Profile the rating for the collection of Access for All (AfA) needs and preferences.
        /// </summary>
        System.Decimal? Pitch { get; set; }

        /// <summary>
        /// Defines as part of an Assessment Personal Needs Profile the rating for the collection of Access for All (AfA) needs and preferences.
        /// </summary>
        Guid? RefAssessmentNeedLinkIndicationTypeId { get; set; }

        /// <summary>
        /// Defines as part of an Assessment Personal Needs Profile the rating for the collection of Access for All (AfA) needs and preferences.
        /// </summary>
        Guid? RefAssessmentNeedUsageTypeId { get; set; }

        /// <summary>
        /// Defines as part of an Assessment Personal Needs Profile the rating for the collection of Access for All (AfA) needs and preferences.
        /// </summary>
        System.Int32? SpeechRate { get; set; }

        /// <summary>
        /// Defines as part of an Assessment Personal Needs Profile the rating for the collection of Access for All (AfA) needs and preferences.
        /// </summary>
        System.Decimal? Volume { get; set; }

    }
}
