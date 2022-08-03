//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   RefSCEDCourseSubjectArea.cs
//**********************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.Common.Models
{
     /// <summary>
     /// The RefSCEDCourseSubjectArea
     /// </summary>
    public partial class RefSCEDCourseSubjectArea : IRefSCEDCourseSubjectArea
    {
        /// <summary>
        /// Defines the RefSCEDCourseSubjectArea.Description non nullable property
        /// </summary>
        public System.String Description { get; set; }

        /// <summary>
        /// Defines the RefSCEDCourseSubjectArea.Code non nullable property
        /// </summary>
        public System.String Code { get; set; }

        /// <summary>
        /// Defines the RefSCEDCourseSubjectArea.Definition non nullable property
        /// </summary>
        public System.String Definition { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefJurisdiction"/> model
        /// </summary>
        public Guid? RefJurisdictionId { get; set; }

        /// <summary>
        /// Defines the RefSCEDCourseSubjectArea.SortOrder nullable property
        /// </summary>
        public System.Decimal? SortOrder { get; set; }

        /// <summary>
        /// Defines the RefSCEDCourseSubjectArea.RecordStartDateTime nullable property
        /// </summary>
        public System.DateTime? RecordStartDateTime { get; set; }

        /// <summary>
        /// Defines the RefSCEDCourseSubjectArea.RecordEndDateTime nullable property
        /// </summary>
        public System.DateTime? RecordEndDateTime { get; set; }

    }
}
