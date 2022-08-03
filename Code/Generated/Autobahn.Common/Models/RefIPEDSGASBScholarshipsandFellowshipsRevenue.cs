//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   RefIPEDSGASBScholarshipsandFellowshipsRevenue.cs
//**********************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.Common.Models
{
     /// <summary>
     /// The RefIPEDSGASBScholarshipsandFellowshipsRevenue
     /// </summary>
    public partial class RefIPEDSGASBScholarshipsandFellowshipsRevenue : IRefIPEDSGASBScholarshipsandFellowshipsRevenue
    {
        /// <summary>
        /// Defines the RefIPEDSGASBScholarshipsandFellowshipsRevenue.Description non nullable property
        /// </summary>
        public System.String Description { get; set; }

        /// <summary>
        /// Defines the RefIPEDSGASBScholarshipsandFellowshipsRevenue.Code non nullable property
        /// </summary>
        public System.String Code { get; set; }

        /// <summary>
        /// Defines the RefIPEDSGASBScholarshipsandFellowshipsRevenue.Definition non nullable property
        /// </summary>
        public System.String Definition { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefJurisdiction"/> model
        /// </summary>
        public Guid? RefJurisdictionId { get; set; }

        /// <summary>
        /// Defines the RefIPEDSGASBScholarshipsandFellowshipsRevenue.SortOrder nullable property
        /// </summary>
        public System.Decimal? SortOrder { get; set; }

        /// <summary>
        /// Defines the RefIPEDSGASBScholarshipsandFellowshipsRevenue.RecordStartDateTime nullable property
        /// </summary>
        public System.DateTime? RecordStartDateTime { get; set; }

        /// <summary>
        /// Defines the RefIPEDSGASBScholarshipsandFellowshipsRevenue.RecordEndDateTime nullable property
        /// </summary>
        public System.DateTime? RecordEndDateTime { get; set; }

    }
}
