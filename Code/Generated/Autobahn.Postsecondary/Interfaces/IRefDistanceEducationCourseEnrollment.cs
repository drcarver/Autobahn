//**********************************************************
//* DomainName: Autobahn.Postsecondary
//* FileName:   IRefDistanceEducationCourseEnrollment.cs
//**********************************************************

namespace Autobahn.Postsecondary.Interfaces
{
     /// <summary>
     /// The IRefDistanceEducationCourseEnrollment
     /// </summary>
    public partial interface IRefDistanceEducationCourseEnrollment
    {
        /// <summary>
        /// Defines the RefDistanceEducationCourseEnrollment.Description non nullable property
        /// </summary>
        System.String Description { get; set; }

        /// <summary>
        /// Defines the RefDistanceEducationCourseEnrollment.Code non nullable property
        /// </summary>
        System.String Code { get; set; }

        /// <summary>
        /// Defines the RefDistanceEducationCourseEnrollment.Definition non nullable property
        /// </summary>
        System.String Definition { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefJurisdiction"/> model
        /// </summary>
        Guid? RefJurisdictionId { get; set; }

        /// <summary>
        /// Defines the RefDistanceEducationCourseEnrollment.SortOrder nullable property
        /// </summary>
        System.Decimal? SortOrder { get; set; }

        /// <summary>
        /// Defines the RefDistanceEducationCourseEnrollment.RecordStartDateTime nullable property
        /// </summary>
        System.DateTime? RecordStartDateTime { get; set; }

        /// <summary>
        /// Defines the RefDistanceEducationCourseEnrollment.RecordEndDateTime nullable property
        /// </summary>
        System.DateTime? RecordEndDateTime { get; set; }

    }
}
