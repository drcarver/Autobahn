//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   RefAdvancedPlacementCourseCode.cs
//**********************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.Common.Models
{
     /// <summary>
     /// The RefAdvancedPlacementCourseCode
     /// </summary>
    public partial class RefAdvancedPlacementCourseCode : IRefAdvancedPlacementCourseCode
    {
        /// <summary>
        /// Defines the RefAdvancedPlacementCourseCode.Description non nullable property
        /// </summary>
        public System.String Description { get; set; }

        /// <summary>
        /// Defines the RefAdvancedPlacementCourseCode.Code non nullable property
        /// </summary>
        public System.String Code { get; set; }

        /// <summary>
        /// Defines the RefAdvancedPlacementCourseCode.Definition non nullable property
        /// </summary>
        public System.String Definition { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefJurisdiction"/> model
        /// </summary>
        public Guid? RefJurisdictionId { get; set; }

        /// <summary>
        /// Defines the RefAdvancedPlacementCourseCode.SortOrder nullable property
        /// </summary>
        public System.Decimal? SortOrder { get; set; }

        /// <summary>
        /// Defines the RefAdvancedPlacementCourseCode.RecordStartDateTime nullable property
        /// </summary>
        public System.DateTime? RecordStartDateTime { get; set; }

        /// <summary>
        /// Defines the RefAdvancedPlacementCourseCode.RecordEndDateTime nullable property
        /// </summary>
        public System.DateTime? RecordEndDateTime { get; set; }

    }
}
