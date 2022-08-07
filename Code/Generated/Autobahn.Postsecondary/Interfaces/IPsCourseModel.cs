//**********************************************************
//* DomainName: Autobahn.Postsecondary
//* FileName:   IPsCourseModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.Postsecondary.Interfaces
{
     /// <summary>
     /// The IPsCourseModel Interface
     /// </summary>
    public partial interface IPsCourseModel : IAutobahnBase
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="Course"/> model
        /// </summary>
        Guid CourseId { get; set; }

        /// <summary>
        /// Defines the PsCourse.CourseNumber non nullable property
        /// </summary>
        System.String CourseNumber { get; set; }

        /// <summary>
        /// Defines the PsCourse.OriginalCourseIdentifier non nullable property
        /// </summary>
        System.String OriginalCourseIdentifier { get; set; }

        /// <summary>
        /// Defines the PsCourse.OverrideSchoolCourseNumber non nullable property
        /// </summary>
        System.String OverrideSchoolCourseNumber { get; set; }

        /// <summary>
        /// Defines the PsCourse.NCAAEligibilityInd nullable property
        /// </summary>
        System.Int32? NCAAEligibilityInd { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefCourseCreditBasisType"/> model
        /// </summary>
        Guid? RefCourseCreditBasisTypeId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefCourseCreditLevelType"/> model
        /// </summary>
        Guid? RefCourseCreditLevelTypeId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefNCESCollegeCourseMapCode"/> model
        /// </summary>
        Guid? RefNCESCollegeCourseMapCodeId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefCipCode"/> model
        /// </summary>
        Guid? RefCipCodeId { get; set; }

    }
}
