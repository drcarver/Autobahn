//**********************************************************
//* DomainName: Autobahn.Assessment
//* FileName:   IRefAcademicSubject.cs
//**********************************************************

namespace Autobahn.Assessment.Interfaces
{
     /// <summary>
     /// The IRefAcademicSubject
     /// </summary>
    public partial interface IRefAcademicSubject
    {
        /// <summary>
        /// Defines the RefAcademicSubject.Description non nullable property
        /// </summary>
        System.String Description { get; set; }

        /// <summary>
        /// Defines the RefAcademicSubject.Code non nullable property
        /// </summary>
        System.String Code { get; set; }

        /// <summary>
        /// Defines the RefAcademicSubject.Definition non nullable property
        /// </summary>
        System.String Definition { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefJurisdiction"/> model
        /// </summary>
        Guid? RefJurisdictionId { get; set; }

        /// <summary>
        /// Defines the RefAcademicSubject.SortOrder nullable property
        /// </summary>
        System.Decimal? SortOrder { get; set; }

        /// <summary>
        /// Defines the RefAcademicSubject.RecordStartDateTime nullable property
        /// </summary>
        System.DateTime? RecordStartDateTime { get; set; }

        /// <summary>
        /// Defines the RefAcademicSubject.RecordEndDateTime nullable property
        /// </summary>
        System.DateTime? RecordEndDateTime { get; set; }

    }
}
