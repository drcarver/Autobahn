//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   IRefDegreeOrCertificateType.cs
//**********************************************************

namespace Autobahn.Common.Interfaces
{
     /// <summary>
     /// The IRefDegreeOrCertificateType
     /// </summary>
    public partial interface IRefDegreeOrCertificateType
    {
        /// <summary>
        /// Defines the RefDegreeOrCertificateType.Description non nullable property
        /// </summary>
        System.String Description { get; set; }

        /// <summary>
        /// Defines the RefDegreeOrCertificateType.Code non nullable property
        /// </summary>
        System.String Code { get; set; }

        /// <summary>
        /// Defines the RefDegreeOrCertificateType.Definition non nullable property
        /// </summary>
        System.String Definition { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefJurisdiction"/> model
        /// </summary>
        Guid? RefJurisdictionId { get; set; }

        /// <summary>
        /// Defines the RefDegreeOrCertificateType.SortOrder nullable property
        /// </summary>
        System.Decimal? SortOrder { get; set; }

        /// <summary>
        /// Defines the RefDegreeOrCertificateType.RecordStartDateTime nullable property
        /// </summary>
        System.DateTime? RecordStartDateTime { get; set; }

        /// <summary>
        /// Defines the RefDegreeOrCertificateType.RecordEndDateTime nullable property
        /// </summary>
        System.DateTime? RecordEndDateTime { get; set; }

    }
}
