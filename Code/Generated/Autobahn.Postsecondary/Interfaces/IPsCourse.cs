//***************************************************************************
//* DomainName: Postsecondary (PS) Interfaces (used by both models and View Models
//* FileName:   IPsCourse.cs
//***************************************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.Postsecondary.Interfaces
{
     /// <summary>
     /// The IPsCourse Interface
     /// </summary>
    public partial interface IPsCourse : IAutobahnBase
    {
        /// <summary>
        /// 
        /// </summary>
         CourseNumber { get; set; }

        /// <summary>
        /// 
        /// </summary>
         NCAAEligibilityInd { get; set; }

        /// <summary>
        /// 
        /// </summary>
         OriginalCourseIdentifier { get; set; }

        /// <summary>
        /// 
        /// </summary>
         OverrideSchoolCourseNumber { get; set; }

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
         RefCourseCreditBasisTypeId { get; set; }

        /// <summary>
        /// 
        /// </summary>
         RefCourseCreditLevelTypeId { get; set; }

        /// <summary>
        /// 
        /// </summary>
         RefNCESCollegeCourseMapCodeId { get; set; }

    }
}
