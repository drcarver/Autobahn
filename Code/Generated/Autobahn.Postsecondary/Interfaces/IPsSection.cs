//***************************************************************************
//* DomainName: Postsecondary (PS) Interfaces (used by both models and View Models
//* FileName:   IPsSection.cs
//***************************************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.Postsecondary.Interfaces
{
     /// <summary>
     /// The IPsSection Interface
     /// </summary>
    public partial interface IPsSection : IAutobahnBase
    {
        /// <summary>
        /// 
        /// </summary>
         GradeValueQualifier { get; set; }

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
        Guid? RefCipCodeId { get; set; }

        /// <summary>
        /// 
        /// </summary>
         RefCourseGpaApplicabilityId { get; set; }

        /// <summary>
        /// 
        /// </summary>
         RefCourseHonorsTypeId { get; set; }

        /// <summary>
        /// 
        /// </summary>
         RefCourseInstructionMethodId { get; set; }

        /// <summary>
        /// 
        /// </summary>
         RefCourseLevelTypeId { get; set; }

        /// <summary>
        /// 
        /// </summary>
         RefDevelopmentalEducationTypeId { get; set; }

        /// <summary>
        /// 
        /// </summary>
         RefWorkbasedLearningOpportunityTypeId { get; set; }

    }
}
