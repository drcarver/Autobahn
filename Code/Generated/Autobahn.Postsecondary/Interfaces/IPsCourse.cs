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
        /// A six-digit code in the form xx.xxxx that identifies instructional program specialties within educational institutions.
        /// </summary>
        Guid CourseId { get; set; }

        /// <summary>
        /// A six-digit code in the form xx.xxxx that identifies instructional program specialties within educational institutions.
        /// </summary>
        System.String CourseNumber { get; set; }

        /// <summary>
        /// A six-digit code in the form xx.xxxx that identifies instructional program specialties within educational institutions.
        /// </summary>
        System.Int32? NCAAEligibilityInd { get; set; }

        /// <summary>
        /// A six-digit code in the form xx.xxxx that identifies instructional program specialties within educational institutions.
        /// </summary>
        System.String OriginalCourseIdentifier { get; set; }

        /// <summary>
        /// A six-digit code in the form xx.xxxx that identifies instructional program specialties within educational institutions.
        /// </summary>
        System.String OverrideSchoolCourseNumber { get; set; }

        /// <summary>
        /// A six-digit code in the form xx.xxxx that identifies instructional program specialties within educational institutions.
        /// </summary>
        Guid? RefCipCodeId { get; set; }

        /// <summary>
        /// A six-digit code in the form xx.xxxx that identifies instructional program specialties within educational institutions.
        /// </summary>
        Guid? RefCourseCreditBasisTypeId { get; set; }

        /// <summary>
        /// A six-digit code in the form xx.xxxx that identifies instructional program specialties within educational institutions.
        /// </summary>
        Guid? RefCourseCreditLevelTypeId { get; set; }

        /// <summary>
        /// A six-digit code in the form xx.xxxx that identifies instructional program specialties within educational institutions.
        /// </summary>
        Guid? RefNCESCollegeCourseMapCodeId { get; set; }

    }
}
