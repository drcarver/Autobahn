//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   IRefCourseGpaApplicability.cs
//**********************************************************

namespace Autobahn.Common.Interfaces
{
     /// <summary>
     /// The IRefCourseGpaApplicability
     /// </summary>
    public partial interface IRefCourseGpaApplicability
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="RefCourseGPAApplicability"/> model
        /// </summary>
        Guid RefCourseGPAApplicabilityId { get; set; }

        /// <summary>
        /// Defines the RefCourseGpaApplicability.Description non nullable property
        /// </summary>
        System.String Description { get; set; }

        /// <summary>
        /// Defines the RefCourseGpaApplicability.Code non nullable property
        /// </summary>
        System.String Code { get; set; }

        /// <summary>
        /// Defines the RefCourseGpaApplicability.Definition non nullable property
        /// </summary>
        System.String Definition { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefJurisdiction"/> model
        /// </summary>
        Guid? RefJurisdictionId { get; set; }

        /// <summary>
        /// Defines the RefCourseGpaApplicability.SortOrder nullable property
        /// </summary>
        System.Decimal? SortOrder { get; set; }

        /// <summary>
        /// Defines the RefCourseGpaApplicability.RecordStartDateTime nullable property
        /// </summary>
        System.DateTime? RecordStartDateTime { get; set; }

        /// <summary>
        /// Defines the RefCourseGpaApplicability.RecordEndDateTime nullable property
        /// </summary>
        System.DateTime? RecordEndDateTime { get; set; }

    }
}
