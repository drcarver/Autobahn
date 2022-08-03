//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   IRefAltRouteToCertificationOrLicensure.cs
//**********************************************************

namespace Autobahn.Common.Interfaces
{
     /// <summary>
     /// The IRefAltRouteToCertificationOrLicensure
     /// </summary>
    public partial interface IRefAltRouteToCertificationOrLicensure
    {
        /// <summary>
        /// Defines the RefAltRouteToCertificationOrLicensure.Description non nullable property
        /// </summary>
        System.String Description { get; set; }

        /// <summary>
        /// Defines the RefAltRouteToCertificationOrLicensure.Code non nullable property
        /// </summary>
        System.String Code { get; set; }

        /// <summary>
        /// Defines the RefAltRouteToCertificationOrLicensure.Definition non nullable property
        /// </summary>
        System.String Definition { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefJurisdiction"/> model
        /// </summary>
        Guid? RefJurisdictionId { get; set; }

        /// <summary>
        /// Defines the RefAltRouteToCertificationOrLicensure.SortOrder nullable property
        /// </summary>
        System.Decimal? SortOrder { get; set; }

        /// <summary>
        /// Defines the RefAltRouteToCertificationOrLicensure.RecordStartDateTime nullable property
        /// </summary>
        System.DateTime? RecordStartDateTime { get; set; }

        /// <summary>
        /// Defines the RefAltRouteToCertificationOrLicensure.RecordEndDateTime nullable property
        /// </summary>
        System.DateTime? RecordEndDateTime { get; set; }

    }
}
