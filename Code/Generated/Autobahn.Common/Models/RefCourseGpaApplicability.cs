//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   RefCourseGpaApplicability.cs
//**********************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.Common.Models
{
     /// <summary>
     /// The RefCourseGpaApplicability
     /// </summary>
    public partial class RefCourseGpaApplicability : IRefCourseGpaApplicability
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="RefCourseGPAApplicability"/> model
        /// </summary>
        public Guid RefCourseGPAApplicabilityId { get; set; }

        /// <summary>
        /// Defines the RefCourseGpaApplicability.Description non nullable property
        /// </summary>
        public System.String Description { get; set; }

        /// <summary>
        /// Defines the RefCourseGpaApplicability.Code non nullable property
        /// </summary>
        public System.String Code { get; set; }

        /// <summary>
        /// Defines the RefCourseGpaApplicability.Definition non nullable property
        /// </summary>
        public System.String Definition { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefJurisdiction"/> model
        /// </summary>
        public Guid? RefJurisdictionId { get; set; }

        /// <summary>
        /// Defines the RefCourseGpaApplicability.SortOrder nullable property
        /// </summary>
        public System.Decimal? SortOrder { get; set; }

        /// <summary>
        /// Defines the RefCourseGpaApplicability.RecordStartDateTime nullable property
        /// </summary>
        public System.DateTime? RecordStartDateTime { get; set; }

        /// <summary>
        /// Defines the RefCourseGpaApplicability.RecordEndDateTime nullable property
        /// </summary>
        public System.DateTime? RecordEndDateTime { get; set; }

    }
}
