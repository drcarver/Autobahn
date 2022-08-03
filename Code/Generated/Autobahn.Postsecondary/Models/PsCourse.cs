//**********************************************************
//* DomainName: Autobahn.Postsecondary
//* FileName:   PsCourse.cs
//**********************************************************

using Autobahn.Postsecondary.Interfaces;

namespace Autobahn.Postsecondary.Models
{
     /// <summary>
     /// The PsCourse
     /// </summary>
    public partial class PsCourse : IPsCourse
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="Course"/> model
        /// </summary>
        public Guid CourseId { get; set; }

        /// <summary>
        /// Defines the PsCourse.CourseNumber non nullable property
        /// </summary>
        public System.String CourseNumber { get; set; }

        /// <summary>
        /// Defines the PsCourse.OriginalCourseIdentifier non nullable property
        /// </summary>
        public System.String OriginalCourseIdentifier { get; set; }

        /// <summary>
        /// Defines the PsCourse.OverrideSchoolCourseNumber non nullable property
        /// </summary>
        public System.String OverrideSchoolCourseNumber { get; set; }

        /// <summary>
        /// Defines the PsCourse.NCAAEligibilityInd nullable property
        /// </summary>
        public System.Int32? NCAAEligibilityInd { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefCourseCreditBasisType"/> model
        /// </summary>
        public Guid? RefCourseCreditBasisTypeId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefCourseCreditLevelType"/> model
        /// </summary>
        public Guid? RefCourseCreditLevelTypeId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefNCESCollegeCourseMapCode"/> model
        /// </summary>
        public Guid? RefNCESCollegeCourseMapCodeId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefCipCode"/> model
        /// </summary>
        public Guid? RefCipCodeId { get; set; }

        /// <summary>
        /// Defines the PsCourse.RecordStartDateTime nullable property
        /// </summary>
        public System.DateTime? RecordStartDateTime { get; set; }

        /// <summary>
        /// Defines the PsCourse.RecordEndDateTime nullable property
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
