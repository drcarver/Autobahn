//**********************************************************
//* DomainName: Autobahn.Postsecondary
//* FileName:   IPsCourse.cs
//**********************************************************

namespace Autobahn.Postsecondary.Interfaces
{
     /// <summary>
     /// The IPsCourse
     /// </summary>
    public partial interface IPsCourse
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

        /// <summary>
        /// Defines the PsCourse.RecordStartDateTime nullable property
        /// </summary>
        System.DateTime? RecordStartDateTime { get; set; }

        /// <summary>
        /// Defines the PsCourse.RecordEndDateTime nullable property
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
