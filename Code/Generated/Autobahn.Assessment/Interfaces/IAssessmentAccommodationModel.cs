//**********************************************************
//* DomainName: Autobahn.Assessment
//* FileName:   IAssessmentAccommodationModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.Assessment.Interfaces
{
     /// <summary>
     /// The IAssessmentAccommodationModel Interface
     /// </summary>
    public partial interface IAssessmentAccommodationModel : IAutobahnBase
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
