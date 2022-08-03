namespace Autobahn.Common.Interfaces;

public interface IReferenceModel : IAutobahnBase
{
    /// <summary>
    /// Defines the RefAbsentAttendanceCategory.Description non nullable property
    /// </summary>
    System.String Description { get; set; }

    /// <summary>
    /// Defines the RefAbsentAttendanceCategory.Code non nullable property
    /// </summary>
    System.String Code { get; set; }

    /// <summary>
    /// Defines the RefAbsentAttendanceCategory.Definition non nullable property
    /// </summary>
    System.String Definition { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="RefJurisdiction"/> model
    /// </summary>
    Guid? RefJurisdictionId { get; set; }

    /// <summary>
    /// Defines the RefAbsentAttendanceCategory.SortOrder nullable property
    /// </summary>
    System.Decimal? SortOrder { get; set; }

    /// <summary>
    /// Defines the RefAbsentAttendanceCategory.RecordStartDateTime nullable property
    /// </summary>
    System.DateTime? RecordStartDateTime { get; set; }

    /// <summary>
    /// Defines the RefAbsentAttendanceCategory.RecordEndDateTime nullable property
    /// </summary>
    System.DateTime? RecordEndDateTime { get; set; }
}