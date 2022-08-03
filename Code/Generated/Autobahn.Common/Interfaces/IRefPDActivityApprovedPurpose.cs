//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   IRefPDActivityApprovedPurpose.cs
//**********************************************************

namespace Autobahn.Common.Interfaces
{
     /// <summary>
     /// The IRefPDActivityApprovedPurpose
     /// </summary>
    public partial interface IRefPDActivityApprovedPurpose
    {
        /// <summary>
        /// Defines the RefPDActivityApprovedPurpose.Description non nullable property
        /// </summary>
        System.String Description { get; set; }

        /// <summary>
        /// Defines the RefPDActivityApprovedPurpose.Code non nullable property
        /// </summary>
        System.String Code { get; set; }

        /// <summary>
        /// Defines the RefPDActivityApprovedPurpose.Definition non nullable property
        /// </summary>
        System.String Definition { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefJurisdiction"/> model
        /// </summary>
        Guid? RefJurisdictionId { get; set; }

        /// <summary>
        /// Defines the RefPDActivityApprovedPurpose.SortOrder nullable property
        /// </summary>
        System.Decimal? SortOrder { get; set; }

        /// <summary>
        /// Defines the RefPDActivityApprovedPurpose.RecordStartDateTime nullable property
        /// </summary>
        System.DateTime? RecordStartDateTime { get; set; }

        /// <summary>
        /// Defines the RefPDActivityApprovedPurpose.RecordEndDateTime nullable property
        /// </summary>
        System.DateTime? RecordEndDateTime { get; set; }

    }
}
