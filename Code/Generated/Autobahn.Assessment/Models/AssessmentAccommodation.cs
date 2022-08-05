//**********************************************************
//* DomainName: Autobahn.Assessment
//* FileName:   AssessmentAccommodation.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.Models;

namespace Autobahn.Assessment.Models
{
     /// <summary>
     /// The AssessmentAccommodation
     /// </summary>
    public partial class AssessmentAccommodation : AutobahnBase, Interfaces.IAssessmentAccommodation
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
        /// Reference to an optional instance of the <see cref="DataCollection"/> model
        /// </summary>
        public Guid? DataCollectionId { get; set; }

    }
}
