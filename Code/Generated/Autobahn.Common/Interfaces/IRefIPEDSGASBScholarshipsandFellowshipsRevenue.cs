//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   IRefIPEDSGASBScholarshipsandFellowshipsRevenue.cs
//**********************************************************

namespace Autobahn.Common.Interfaces
{
     /// <summary>
     /// The IRefIPEDSGASBScholarshipsandFellowshipsRevenue
     /// </summary>
    public partial interface IRefIPEDSGASBScholarshipsandFellowshipsRevenue
    {
        /// <summary>
        /// Defines the RefIPEDSGASBScholarshipsandFellowshipsRevenue.Description non nullable property
        /// </summary>
        System.String Description { get; set; }

        /// <summary>
        /// Defines the RefIPEDSGASBScholarshipsandFellowshipsRevenue.Code non nullable property
        /// </summary>
        System.String Code { get; set; }

        /// <summary>
        /// Defines the RefIPEDSGASBScholarshipsandFellowshipsRevenue.Definition non nullable property
        /// </summary>
        System.String Definition { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefJurisdiction"/> model
        /// </summary>
        Guid? RefJurisdictionId { get; set; }

        /// <summary>
        /// Defines the RefIPEDSGASBScholarshipsandFellowshipsRevenue.SortOrder nullable property
        /// </summary>
        System.Decimal? SortOrder { get; set; }

        /// <summary>
        /// Defines the RefIPEDSGASBScholarshipsandFellowshipsRevenue.RecordStartDateTime nullable property
        /// </summary>
        System.DateTime? RecordStartDateTime { get; set; }

        /// <summary>
        /// Defines the RefIPEDSGASBScholarshipsandFellowshipsRevenue.RecordEndDateTime nullable property
        /// </summary>
        System.DateTime? RecordEndDateTime { get; set; }

    }
}
