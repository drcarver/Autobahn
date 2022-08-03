//**********************************************************
//* DomainName: Autobahn.Postsecondary
//* FileName:   RefCourseAcademicGradeStatusCode.cs
//**********************************************************

using Autobahn.Postsecondary.Interfaces;

namespace Autobahn.Postsecondary.Models
{
     /// <summary>
     /// The RefCourseAcademicGradeStatusCode
     /// </summary>
    public partial class RefCourseAcademicGradeStatusCode : IRefCourseAcademicGradeStatusCode
    {
        /// <summary>
        /// Defines the RefCourseAcademicGradeStatusCode.Description non nullable property
        /// </summary>
        public System.String Description { get; set; }

        /// <summary>
        /// Defines the RefCourseAcademicGradeStatusCode.Code non nullable property
        /// </summary>
        public System.String Code { get; set; }

        /// <summary>
        /// Defines the RefCourseAcademicGradeStatusCode.Definition non nullable property
        /// </summary>
        public System.String Definition { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefJurisdiction"/> model
        /// </summary>
        public Guid? RefJurisdictionId { get; set; }

        /// <summary>
        /// Defines the RefCourseAcademicGradeStatusCode.SortOrder nullable property
        /// </summary>
        public System.Decimal? SortOrder { get; set; }

        /// <summary>
        /// Defines the RefCourseAcademicGradeStatusCode.RecordStartDateTime nullable property
        /// </summary>
        public System.DateTime? RecordStartDateTime { get; set; }

        /// <summary>
        /// Defines the RefCourseAcademicGradeStatusCode.RecordEndDateTime nullable property
        /// </summary>
        public System.DateTime? RecordEndDateTime { get; set; }

    }
}
