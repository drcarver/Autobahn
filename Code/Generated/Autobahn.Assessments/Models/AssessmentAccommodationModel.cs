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
        /// 
        /// </summary>
        public  OtherDescription { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  RecordEndDateTime { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  RecordStartDateTime { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  RefAccommodationTypeId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public Guid? RefAssessmentAccommodationCategoryId { get; set; }

    }
}
