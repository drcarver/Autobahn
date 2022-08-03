//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   RefIPEDSGASBFunctionalExpense.cs
//**********************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.Common.Models
{
     /// <summary>
     /// The RefIPEDSGASBFunctionalExpense
     /// </summary>
    public partial class RefIPEDSGASBFunctionalExpense : IRefIPEDSGASBFunctionalExpense
    {
        /// <summary>
        /// Defines the RefIPEDSGASBFunctionalExpense.Description non nullable property
        /// </summary>
        public System.String Description { get; set; }

        /// <summary>
        /// Defines the RefIPEDSGASBFunctionalExpense.Code non nullable property
        /// </summary>
        public System.String Code { get; set; }

        /// <summary>
        /// Defines the RefIPEDSGASBFunctionalExpense.Definition non nullable property
        /// </summary>
        public System.String Definition { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefJurisdiction"/> model
        /// </summary>
        public Guid? RefJurisdictionId { get; set; }

        /// <summary>
        /// Defines the RefIPEDSGASBFunctionalExpense.SortOrder nullable property
        /// </summary>
        public System.Decimal? SortOrder { get; set; }

        /// <summary>
        /// Defines the RefIPEDSGASBFunctionalExpense.RecordStartDateTime nullable property
        /// </summary>
        public System.DateTime? RecordStartDateTime { get; set; }

        /// <summary>
        /// Defines the RefIPEDSGASBFunctionalExpense.RecordEndDateTime nullable property
        /// </summary>
        public System.DateTime? RecordEndDateTime { get; set; }

    }
}
