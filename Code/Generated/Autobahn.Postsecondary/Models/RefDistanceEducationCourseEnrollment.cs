//**********************************************************
//* DomainName: Autobahn.Postsecondary
//* FileName:   RefDistanceEducationCourseEnrollment.cs
//**********************************************************

using Autobahn.Postsecondary.Interfaces;

namespace Autobahn.Postsecondary.Models
{
     /// <summary>
     /// The RefDistanceEducationCourseEnrollment
     /// </summary>
    public partial class RefDistanceEducationCourseEnrollment : IRefDistanceEducationCourseEnrollment
    {
        /// <summary>
        /// Defines the RefDistanceEducationCourseEnrollment.Description non nullable property
        /// </summary>
        public System.String Description { get; set; }

        /// <summary>
        /// Defines the RefDistanceEducationCourseEnrollment.Code non nullable property
        /// </summary>
        public System.String Code { get; set; }

        /// <summary>
        /// Defines the RefDistanceEducationCourseEnrollment.Definition non nullable property
        /// </summary>
        public System.String Definition { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefJurisdiction"/> model
        /// </summary>
        public Guid? RefJurisdictionId { get; set; }

        /// <summary>
        /// Defines the RefDistanceEducationCourseEnrollment.SortOrder nullable property
        /// </summary>
        public System.Decimal? SortOrder { get; set; }

        /// <summary>
        /// Defines the RefDistanceEducationCourseEnrollment.RecordStartDateTime nullable property
        /// </summary>
        public System.DateTime? RecordStartDateTime { get; set; }

        /// <summary>
        /// Defines the RefDistanceEducationCourseEnrollment.RecordEndDateTime nullable property
        /// </summary>
        public System.DateTime? RecordEndDateTime { get; set; }

    }
}
