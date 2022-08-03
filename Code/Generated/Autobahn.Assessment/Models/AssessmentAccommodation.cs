//**********************************************************
//* DomainName: Autobahn.Assessment
//* FileName:   AssessmentAccommodation.cs
//**********************************************************

using Autobahn.Assessment.Interfaces;

namespace Autobahn.Assessment.Models
{
     /// <summary>
     /// The AssessmentAccommodation
     /// </summary>
    public partial class AssessmentAccommodation : IAssessmentAccommodation
    {
        /// <summary>
        /// Defines the AssessmentAccommodation.OtherDescription non nullable property
        /// </summary>
        public System.String OtherDescription { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefAccommodationType"/> model
        /// </summary>
        public Guid? RefAccommodationTypeId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefAssessmentAccommodationCategory"/> model
        /// </summary>
        public Guid? RefAssessmentAccommodationCategoryId { get; set; }

        /// <summary>
        /// Defines the AssessmentAccommodation.RecordStartDateTime nullable property
        /// </summary>
        public System.DateTime? RecordStartDateTime { get; set; }

        /// <summary>
        /// Defines the AssessmentAccommodation.RecordEndDateTime nullable property
        /// </summary>
        public System.DateTime? RecordEndDateTime { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RecordStatus"/> model
        /// </summary>
        public Guid? RecordStatusId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="DataCollection"/> model
        /// </summary>
        public Guid? DataCollectionId { get; set; }

    }
}
