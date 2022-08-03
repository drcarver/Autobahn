//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   RefIPEDSFASBScholarshipsandFellowshipsRevenue.cs
//**********************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.Common.Models
{
     /// <summary>
     /// The RefIPEDSFASBScholarshipsandFellowshipsRevenue
     /// </summary>
    public partial class RefIPEDSFASBScholarshipsandFellowshipsRevenue : IRefIPEDSFASBScholarshipsandFellowshipsRevenue
    {
        /// <summary>
        /// Defines the RefIPEDSFASBScholarshipsandFellowshipsRevenue.Description non nullable property
        /// </summary>
        public System.String Description { get; set; }

        /// <summary>
        /// Defines the RefIPEDSFASBScholarshipsandFellowshipsRevenue.Code non nullable property
        /// </summary>
        public System.String Code { get; set; }

        /// <summary>
        /// Defines the RefIPEDSFASBScholarshipsandFellowshipsRevenue.Definition non nullable property
        /// </summary>
        public System.String Definition { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefJurisdiction"/> model
        /// </summary>
        public Guid? RefJurisdictionId { get; set; }

        /// <summary>
        /// Defines the RefIPEDSFASBScholarshipsandFellowshipsRevenue.SortOrder nullable property
        /// </summary>
        public System.Decimal? SortOrder { get; set; }

        /// <summary>
        /// Defines the RefIPEDSFASBScholarshipsandFellowshipsRevenue.RecordStartDateTime nullable property
        /// </summary>
        public System.DateTime? RecordStartDateTime { get; set; }

        /// <summary>
        /// Defines the RefIPEDSFASBScholarshipsandFellowshipsRevenue.RecordEndDateTime nullable property
        /// </summary>
        public System.DateTime? RecordEndDateTime { get; set; }

    }
}
