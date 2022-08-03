//**********************************************************
//* DomainName: Autobahn.K12
//* FileName:   IRefCourseSectionEnrollmentStatusType.cs
//**********************************************************

namespace Autobahn.K12.Interfaces
{
     /// <summary>
     /// The IRefCourseSectionEnrollmentStatusType
     /// </summary>
    public partial interface IRefCourseSectionEnrollmentStatusType
    {
        /// <summary>
        /// Defines the RefCourseSectionEnrollmentStatusType.Description non nullable property
        /// </summary>
        System.String Description { get; set; }

        /// <summary>
        /// Defines the RefCourseSectionEnrollmentStatusType.Code non nullable property
        /// </summary>
        System.String Code { get; set; }

        /// <summary>
        /// Defines the RefCourseSectionEnrollmentStatusType.Definition non nullable property
        /// </summary>
        System.String Definition { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefJurisdiction"/> model
        /// </summary>
        Guid? RefJurisdictionId { get; set; }

        /// <summary>
        /// Defines the RefCourseSectionEnrollmentStatusType.SortOrder nullable property
        /// </summary>
        System.Decimal? SortOrder { get; set; }

        /// <summary>
        /// Defines the RefCourseSectionEnrollmentStatusType.RecordStartDateTime nullable property
        /// </summary>
        System.DateTime? RecordStartDateTime { get; set; }

        /// <summary>
        /// Defines the RefCourseSectionEnrollmentStatusType.RecordEndDateTime nullable property
        /// </summary>
        System.DateTime? RecordEndDateTime { get; set; }

    }
}
