//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   RefAltRouteToCertificationOrLicensure.cs
//**********************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.Common.Models
{
     /// <summary>
     /// The RefAltRouteToCertificationOrLicensure
     /// </summary>
    public partial class RefAltRouteToCertificationOrLicensure : IRefAltRouteToCertificationOrLicensure
    {
        /// <summary>
        /// Defines the RefAltRouteToCertificationOrLicensure.Description non nullable property
        /// </summary>
        public System.String Description { get; set; }

        /// <summary>
        /// Defines the RefAltRouteToCertificationOrLicensure.Code non nullable property
        /// </summary>
        public System.String Code { get; set; }

        /// <summary>
        /// Defines the RefAltRouteToCertificationOrLicensure.Definition non nullable property
        /// </summary>
        public System.String Definition { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefJurisdiction"/> model
        /// </summary>
        public Guid? RefJurisdictionId { get; set; }

        /// <summary>
        /// Defines the RefAltRouteToCertificationOrLicensure.SortOrder nullable property
        /// </summary>
        public System.Decimal? SortOrder { get; set; }

        /// <summary>
        /// Defines the RefAltRouteToCertificationOrLicensure.RecordStartDateTime nullable property
        /// </summary>
        public System.DateTime? RecordStartDateTime { get; set; }

        /// <summary>
        /// Defines the RefAltRouteToCertificationOrLicensure.RecordEndDateTime nullable property
        /// </summary>
        public System.DateTime? RecordEndDateTime { get; set; }

    }
}
