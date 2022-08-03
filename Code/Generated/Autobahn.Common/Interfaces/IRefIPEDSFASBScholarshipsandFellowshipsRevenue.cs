//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   IRefIPEDSFASBScholarshipsandFellowshipsRevenue.cs
//**********************************************************

namespace Autobahn.Common.Interfaces
{
     /// <summary>
     /// The IRefIPEDSFASBScholarshipsandFellowshipsRevenue
     /// </summary>
    public partial interface IRefIPEDSFASBScholarshipsandFellowshipsRevenue
    {
        /// <summary>
        /// Defines the RefIPEDSFASBScholarshipsandFellowshipsRevenue.Description non nullable property
        /// </summary>
        System.String Description { get; set; }

        /// <summary>
        /// Defines the RefIPEDSFASBScholarshipsandFellowshipsRevenue.Code non nullable property
        /// </summary>
        System.String Code { get; set; }

        /// <summary>
        /// Defines the RefIPEDSFASBScholarshipsandFellowshipsRevenue.Definition non nullable property
        /// </summary>
        System.String Definition { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefJurisdiction"/> model
        /// </summary>
        Guid? RefJurisdictionId { get; set; }

        /// <summary>
        /// Defines the RefIPEDSFASBScholarshipsandFellowshipsRevenue.SortOrder nullable property
        /// </summary>
        System.Decimal? SortOrder { get; set; }

        /// <summary>
        /// Defines the RefIPEDSFASBScholarshipsandFellowshipsRevenue.RecordStartDateTime nullable property
        /// </summary>
        System.DateTime? RecordStartDateTime { get; set; }

        /// <summary>
        /// Defines the RefIPEDSFASBScholarshipsandFellowshipsRevenue.RecordEndDateTime nullable property
        /// </summary>
        System.DateTime? RecordEndDateTime { get; set; }

    }
}
