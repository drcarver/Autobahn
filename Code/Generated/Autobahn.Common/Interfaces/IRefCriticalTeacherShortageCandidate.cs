//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   IRefCriticalTeacherShortageCandidate.cs
//**********************************************************

namespace Autobahn.Common.Interfaces
{
     /// <summary>
     /// The IRefCriticalTeacherShortageCandidate
     /// </summary>
    public partial interface IRefCriticalTeacherShortageCandidate
    {
        /// <summary>
        /// Defines the RefCriticalTeacherShortageCandidate.Description non nullable property
        /// </summary>
        System.String Description { get; set; }

        /// <summary>
        /// Defines the RefCriticalTeacherShortageCandidate.Code non nullable property
        /// </summary>
        System.String Code { get; set; }

        /// <summary>
        /// Defines the RefCriticalTeacherShortageCandidate.Definition non nullable property
        /// </summary>
        System.String Definition { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefJurisdiction"/> model
        /// </summary>
        Guid? RefJurisdictionId { get; set; }

        /// <summary>
        /// Defines the RefCriticalTeacherShortageCandidate.SortOrder nullable property
        /// </summary>
        System.Decimal? SortOrder { get; set; }

        /// <summary>
        /// Defines the RefCriticalTeacherShortageCandidate.RecordStartDateTime nullable property
        /// </summary>
        System.DateTime? RecordStartDateTime { get; set; }

        /// <summary>
        /// Defines the RefCriticalTeacherShortageCandidate.RecordEndDateTime nullable property
        /// </summary>
        System.DateTime? RecordEndDateTime { get; set; }

    }
}
