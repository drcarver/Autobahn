//**********************************************************
//* DomainName: Autobahn.Postsecondary
//* FileName:   IRefCourseAcademicGradeStatusCode.cs
//**********************************************************

namespace Autobahn.Postsecondary.Interfaces
{
     /// <summary>
     /// The IRefCourseAcademicGradeStatusCode
     /// </summary>
    public partial interface IRefCourseAcademicGradeStatusCode
    {
        /// <summary>
        /// Defines the RefCourseAcademicGradeStatusCode.Description non nullable property
        /// </summary>
        System.String Description { get; set; }

        /// <summary>
        /// Defines the RefCourseAcademicGradeStatusCode.Code non nullable property
        /// </summary>
        System.String Code { get; set; }

        /// <summary>
        /// Defines the RefCourseAcademicGradeStatusCode.Definition non nullable property
        /// </summary>
        System.String Definition { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefJurisdiction"/> model
        /// </summary>
        Guid? RefJurisdictionId { get; set; }

        /// <summary>
        /// Defines the RefCourseAcademicGradeStatusCode.SortOrder nullable property
        /// </summary>
        System.Decimal? SortOrder { get; set; }

        /// <summary>
        /// Defines the RefCourseAcademicGradeStatusCode.RecordStartDateTime nullable property
        /// </summary>
        System.DateTime? RecordStartDateTime { get; set; }

        /// <summary>
        /// Defines the RefCourseAcademicGradeStatusCode.RecordEndDateTime nullable property
        /// </summary>
        System.DateTime? RecordEndDateTime { get; set; }

    }
}
