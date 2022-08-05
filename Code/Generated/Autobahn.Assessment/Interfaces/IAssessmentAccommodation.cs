//**********************************************************
//* DomainName: Autobahn.Assessment
//* FileName:   IAssessmentAccommodation.cs
//**********************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.Assessment.Interfaces
{
     /// <summary>
     /// The IAssessmentAccommodation
     /// </summary>
    public partial interface IAssessmentAccommodation : IAutobahnBase
    {
        /// <summary>
        /// Defines the AssessmentAccommodation.OtherDescription non nullable property
        /// </summary>
        System.String OtherDescription { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefAccommodationType"/> model
        /// </summary>
        Guid? RefAccommodationTypeId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefAssessmentAccommodationCategory"/> model
        /// </summary>
        Guid? RefAssessmentAccommodationCategoryId { get; set; }

    }
}
