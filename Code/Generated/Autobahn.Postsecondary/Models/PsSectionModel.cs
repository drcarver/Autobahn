//**********************************************************
//* DomainName: Postsecondary (PS)
//* FileName:   PsSectionModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.Models;

namespace Autobahn.Postsecondary.Models
{
     /// <summary>
     /// The PsSection Model
     /// </summary>
    public partial class PsSectionModel : AutobahnBase, Interfaces.IPsSection
    {
        /// <summary>
        /// 
        /// </summary>
        public  GradeValueQualifier { get; set; }

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
        public Guid? RefCipCodeId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  RefCourseGpaApplicabilityId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  RefCourseHonorsTypeId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  RefCourseInstructionMethodId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  RefCourseLevelTypeId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  RefDevelopmentalEducationTypeId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  RefWorkbasedLearningOpportunityTypeId { get; set; }

    }
}
