//**********************************************************
//* DomainName: Autobahn.Postsecondary
//* FileName:   IRefEmploymentStatusWhileEnrolled.cs
//**********************************************************

namespace Autobahn.Postsecondary.Interfaces
{
     /// <summary>
     /// The IRefEmploymentStatusWhileEnrolled
     /// </summary>
    public partial interface IRefEmploymentStatusWhileEnrolled
    {
        /// <summary>
        /// Defines the RefEmploymentStatusWhileEnrolled.Description non nullable property
        /// </summary>
        System.String Description { get; set; }

        /// <summary>
        /// Defines the RefEmploymentStatusWhileEnrolled.Code non nullable property
        /// </summary>
        System.String Code { get; set; }

        /// <summary>
        /// Defines the RefEmploymentStatusWhileEnrolled.Definition non nullable property
        /// </summary>
        System.String Definition { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefJurisdiction"/> model
        /// </summary>
        Guid? RefJurisdictionId { get; set; }

        /// <summary>
        /// Defines the RefEmploymentStatusWhileEnrolled.SortOrder nullable property
        /// </summary>
        System.Decimal? SortOrder { get; set; }

        /// <summary>
        /// Defines the RefEmploymentStatusWhileEnrolled.RecordStartDateTime nullable property
        /// </summary>
        System.DateTime? RecordStartDateTime { get; set; }

        /// <summary>
        /// Defines the RefEmploymentStatusWhileEnrolled.RecordEndDateTime nullable property
        /// </summary>
        System.DateTime? RecordEndDateTime { get; set; }

    }
}
