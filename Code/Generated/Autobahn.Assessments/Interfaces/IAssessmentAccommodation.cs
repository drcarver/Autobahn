//***************************************************************************
//* DomainName: Assessments Interfaces (used by both models and View Models
//* FileName:   IAssessmentAccommodation.cs
//***************************************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.Assessments.Interfaces
{
     /// <summary>
     /// The IAssessmentAccommodation Interface
     /// </summary>
    public partial interface IAssessmentAccommodation : IAutobahnBase
    {
        /// <summary>
        /// A category of accommodations needed for a given assessment.
        /// </summary>
        Guid? RefAssessmentAccommodationCategoryId { get; set; }

    }
}
