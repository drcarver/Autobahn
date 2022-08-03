//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   RefAttendanceEventType.cs
//**********************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.Common.Models
{
     /// <summary>
     /// The RefAttendanceEventType
     /// </summary>
    public partial class RefAttendanceEventType : IRefAttendanceEventType
    {
        /// <summary>
        /// Defines the RefAttendanceEventType.Description non nullable property
        /// </summary>
        public System.String Description { get; set; }

        /// <summary>
        /// Defines the RefAttendanceEventType.Code non nullable property
        /// </summary>
        public System.String Code { get; set; }

        /// <summary>
        /// Defines the RefAttendanceEventType.Definition non nullable property
        /// </summary>
        public System.String Definition { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefJurisdiction"/> model
        /// </summary>
        public Guid? RefJurisdictionId { get; set; }

        /// <summary>
        /// Defines the RefAttendanceEventType.SortOrder nullable property
        /// </summary>
        public System.Decimal? SortOrder { get; set; }

        /// <summary>
        /// Defines the RefAttendanceEventType.RecordStartDateTime nullable property
        /// </summary>
        public System.DateTime? RecordStartDateTime { get; set; }

        /// <summary>
        /// Defines the RefAttendanceEventType.RecordEndDateTime nullable property
        /// </summary>
        public System.DateTime? RecordEndDateTime { get; set; }

    }
}