//***************************************************************************
//* DomainName: Authentication and Authorization Interfaces (used by both models and View Models
//* FileName:   IAssessmentNeedBraille.cs
//***************************************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.Authorization.Interfaces
{
     /// <summary>
     /// The IAssessmentNeedBraille Interface
     /// </summary>
    public partial interface IAssessmentNeedBraille : IAutobahnBase
    {
        /// <summary>
        /// Defines as part of an Assessment Personal Needs Profile the rating for the collection of Access for All (AfA) needs and preferences.
        /// </summary>
        Guid? AssessmentPersonalNeedsProfileDisplayId { get; set; }

        /// <summary>
        /// Defines as part of an Assessment Personal Needs Profile the rating for the collection of Access for All (AfA) needs and preferences.
        /// </summary>
        System.Decimal? BrailleDotPressure { get; set; }

        /// <summary>
        /// Defines as part of an Assessment Personal Needs Profile the rating for the collection of Access for All (AfA) needs and preferences.
        /// </summary>
        System.Int32? NumberOfBrailleCells { get; set; }

        /// <summary>
        /// Defines as part of an Assessment Personal Needs Profile the rating for the collection of Access for All (AfA) needs and preferences.
        /// </summary>
        Guid? RefAssessmentNeedBrailleGradeTypeId { get; set; }

        /// <summary>
        /// Defines as part of an Assessment Personal Needs Profile the rating for the collection of Access for All (AfA) needs and preferences.
        /// </summary>
        Guid? RefAssessmentNeedBrailleMarkTypeId { get; set; }

        /// <summary>
        /// Defines as part of an Assessment Personal Needs Profile the rating for the collection of Access for All (AfA) needs and preferences.
        /// </summary>
        Guid? RefAssessmentNeedBrailleStatusCellTypeId { get; set; }

        /// <summary>
        /// Defines as part of an Assessment Personal Needs Profile the rating for the collection of Access for All (AfA) needs and preferences.
        /// </summary>
        Guid? RefAssessmentNeedNumberOfBrailleDotsId { get; set; }

        /// <summary>
        /// Defines as part of an Assessment Personal Needs Profile the rating for the collection of Access for All (AfA) needs and preferences.
        /// </summary>
        Guid? RefAssessmentNeedUsageTypeId { get; set; }

    }
}
