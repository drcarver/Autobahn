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
        /// 
        /// </summary>
         OtherDescription { get; set; }

        /// <summary>
        /// 
        /// </summary>
         RecordEndDateTime { get; set; }

        /// <summary>
        /// 
        /// </summary>
         RecordStartDateTime { get; set; }

        /// <summary>
        /// 
        /// </summary>
         RefAccommodationTypeId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        Guid? RefAssessmentAccommodationCategoryId { get; set; }

    }
}
