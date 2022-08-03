//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   RefCourseApplicableEducationLevel.cs
//**********************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.Common.Models
{
     /// <summary>
     /// The RefCourseApplicableEducationLevel
     /// </summary>
    public partial class RefCourseApplicableEducationLevel : IRefCourseApplicableEducationLevel
    {
        /// <summary>
        /// Defines the RefCourseApplicableEducationLevel.Description non nullable property
        /// </summary>
        public System.String Description { get; set; }

        /// <summary>
        /// Defines the RefCourseApplicableEducationLevel.Code non nullable property
        /// </summary>
        public System.String Code { get; set; }

        /// <summary>
        /// Defines the RefCourseApplicableEducationLevel.Definition non nullable property
        /// </summary>
        public System.String Definition { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefJurisdiction"/> model
        /// </summary>
        public Guid? RefJurisdictionId { get; set; }

        /// <summary>
        /// Defines the RefCourseApplicableEducationLevel.SortOrder nullable property
        /// </summary>
        public System.Decimal? SortOrder { get; set; }

        /// <summary>
        /// Defines the RefCourseApplicableEducationLevel.RecordStartDateTime nullable property
        /// </summary>
        public System.DateTime? RecordStartDateTime { get; set; }

        /// <summary>
        /// Defines the RefCourseApplicableEducationLevel.RecordEndDateTime nullable property
        /// </summary>
        public System.DateTime? RecordEndDateTime { get; set; }

    }
}
