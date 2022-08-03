//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   RefCriticalTeacherShortageCandidate.cs
//**********************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.Common.Models
{
     /// <summary>
     /// The RefCriticalTeacherShortageCandidate
     /// </summary>
    public partial class RefCriticalTeacherShortageCandidate : IRefCriticalTeacherShortageCandidate
    {
        /// <summary>
        /// Defines the RefCriticalTeacherShortageCandidate.Description non nullable property
        /// </summary>
        public System.String Description { get; set; }

        /// <summary>
        /// Defines the RefCriticalTeacherShortageCandidate.Code non nullable property
        /// </summary>
        public System.String Code { get; set; }

        /// <summary>
        /// Defines the RefCriticalTeacherShortageCandidate.Definition non nullable property
        /// </summary>
        public System.String Definition { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefJurisdiction"/> model
        /// </summary>
        public Guid? RefJurisdictionId { get; set; }

        /// <summary>
        /// Defines the RefCriticalTeacherShortageCandidate.SortOrder nullable property
        /// </summary>
        public System.Decimal? SortOrder { get; set; }

        /// <summary>
        /// Defines the RefCriticalTeacherShortageCandidate.RecordStartDateTime nullable property
        /// </summary>
        public System.DateTime? RecordStartDateTime { get; set; }

        /// <summary>
        /// Defines the RefCriticalTeacherShortageCandidate.RecordEndDateTime nullable property
        /// </summary>
        public System.DateTime? RecordEndDateTime { get; set; }

    }
}
