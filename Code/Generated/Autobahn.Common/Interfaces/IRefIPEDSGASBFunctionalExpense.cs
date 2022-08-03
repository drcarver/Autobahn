//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   IRefIPEDSGASBFunctionalExpense.cs
//**********************************************************

namespace Autobahn.Common.Interfaces
{
     /// <summary>
     /// The IRefIPEDSGASBFunctionalExpense
     /// </summary>
    public partial interface IRefIPEDSGASBFunctionalExpense
    {
        /// <summary>
        /// Defines the RefIPEDSGASBFunctionalExpense.Description non nullable property
        /// </summary>
        System.String Description { get; set; }

        /// <summary>
        /// Defines the RefIPEDSGASBFunctionalExpense.Code non nullable property
        /// </summary>
        System.String Code { get; set; }

        /// <summary>
        /// Defines the RefIPEDSGASBFunctionalExpense.Definition non nullable property
        /// </summary>
        System.String Definition { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefJurisdiction"/> model
        /// </summary>
        Guid? RefJurisdictionId { get; set; }

        /// <summary>
        /// Defines the RefIPEDSGASBFunctionalExpense.SortOrder nullable property
        /// </summary>
        System.Decimal? SortOrder { get; set; }

        /// <summary>
        /// Defines the RefIPEDSGASBFunctionalExpense.RecordStartDateTime nullable property
        /// </summary>
        System.DateTime? RecordStartDateTime { get; set; }

        /// <summary>
        /// Defines the RefIPEDSGASBFunctionalExpense.RecordEndDateTime nullable property
        /// </summary>
        System.DateTime? RecordEndDateTime { get; set; }

    }
}
