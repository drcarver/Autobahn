//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   RefIPEDSGASBRevenue.cs
//**********************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.Common.Models
{
     /// <summary>
     /// The RefIPEDSGASBRevenue
     /// </summary>
    public partial class RefIPEDSGASBRevenue : IRefIPEDSGASBRevenue
    {
        /// <summary>
        /// Defines the RefIPEDSGASBRevenue.Description non nullable property
        /// </summary>
        public System.String Description { get; set; }

        /// <summary>
        /// Defines the RefIPEDSGASBRevenue.Code non nullable property
        /// </summary>
        public System.String Code { get; set; }

        /// <summary>
        /// Defines the RefIPEDSGASBRevenue.Definition non nullable property
        /// </summary>
        public System.String Definition { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefJurisdiction"/> model
        /// </summary>
        public Guid? RefJurisdictionId { get; set; }

        /// <summary>
        /// Defines the RefIPEDSGASBRevenue.SortOrder nullable property
        /// </summary>
        public System.Decimal? SortOrder { get; set; }

        /// <summary>
        /// Defines the RefIPEDSGASBRevenue.RecordStartDateTime nullable property
        /// </summary>
        public System.DateTime? RecordStartDateTime { get; set; }

        /// <summary>
        /// Defines the RefIPEDSGASBRevenue.RecordEndDateTime nullable property
        /// </summary>
        public System.DateTime? RecordEndDateTime { get; set; }

    }
}