//**********************************************************
//* DomainName: Autobahn.Assessment
//* FileName:   IRefELOutcomeMeasurementLevel.cs
//**********************************************************

namespace Autobahn.Assessment.Interfaces
{
     /// <summary>
     /// The IRefELOutcomeMeasurementLevel
     /// </summary>
    public partial interface IRefELOutcomeMeasurementLevel
    {
        /// <summary>
        /// Defines the RefELOutcomeMeasurementLevel.Description non nullable property
        /// </summary>
        System.String Description { get; set; }

        /// <summary>
        /// Defines the RefELOutcomeMeasurementLevel.Code non nullable property
        /// </summary>
        System.String Code { get; set; }

        /// <summary>
        /// Defines the RefELOutcomeMeasurementLevel.Definition non nullable property
        /// </summary>
        System.String Definition { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefJurisdiction"/> model
        /// </summary>
        Guid? RefJurisdictionId { get; set; }

        /// <summary>
        /// Defines the RefELOutcomeMeasurementLevel.SortOrder nullable property
        /// </summary>
        System.Decimal? SortOrder { get; set; }

        /// <summary>
        /// Defines the RefELOutcomeMeasurementLevel.RecordStartDateTime nullable property
        /// </summary>
        System.DateTime? RecordStartDateTime { get; set; }

        /// <summary>
        /// Defines the RefELOutcomeMeasurementLevel.RecordEndDateTime nullable property
        /// </summary>
        System.DateTime? RecordEndDateTime { get; set; }

    }
}
