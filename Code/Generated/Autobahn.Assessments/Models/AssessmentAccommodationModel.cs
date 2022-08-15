//**********************************************************
//* DomainName: Assessments
//* FileName:   AssessmentAccommodationModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.Models;

namespace Autobahn.Assessments.Models
{
     /// <summary>
     /// The AssessmentAccommodation Model
     /// </summary>
    public partial class AssessmentAccommodationModel : AutobahnBase, Interfaces.IAssessmentAccommodation
    {
        /// <summary>
        /// A category of accommodations needed for a given assessment.
        /// </summary>
        public Guid? RefAssessmentAccommodationCategoryId { get; set; }

    }
}
