//**********************************************************
//* DomainName: Autobahn.Assessment
//* FileName:   IAssessmentAccommodation.cs
//**********************************************************

namespace Autobahn.Assessment.Interfaces
{
     /// <summary>
     /// The IAssessmentAccommodation
     /// </summary>
    public partial interface IAssessmentAccommodation
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

        /// <summary>
        /// Defines the AssessmentAccommodation.RecordStartDateTime nullable property
        /// </summary>
        System.DateTime? RecordStartDateTime { get; set; }

        /// <summary>
        /// Defines the AssessmentAccommodation.RecordEndDateTime nullable property
        /// </summary>
        System.DateTime? RecordEndDateTime { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RecordStatus"/> model
        /// </summary>
        Guid? RecordStatusId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="DataCollection"/> model
        /// </summary>
        Guid? DataCollectionId { get; set; }

    }
}
