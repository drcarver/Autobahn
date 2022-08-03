//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   RefIPEDSFASBFunctionalExpense.cs
//**********************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.Common.Models
{
     /// <summary>
     /// The RefIPEDSFASBFunctionalExpense
     /// </summary>
    public partial class RefIPEDSFASBFunctionalExpense : IRefIPEDSFASBFunctionalExpense
    {
        /// <summary>
        /// Defines the RefIPEDSFASBFunctionalExpense.Description non nullable property
        /// </summary>
        public System.String Description { get; set; }

        /// <summary>
        /// Defines the RefIPEDSFASBFunctionalExpense.Code non nullable property
        /// </summary>
        public System.String Code { get; set; }

        /// <summary>
        /// Defines the RefIPEDSFASBFunctionalExpense.Definition non nullable property
        /// </summary>
        public System.String Definition { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefJurisdiction"/> model
        /// </summary>
        public Guid? RefJurisdictionId { get; set; }

        /// <summary>
        /// Defines the RefIPEDSFASBFunctionalExpense.SortOrder nullable property
        /// </summary>
        public System.Decimal? SortOrder { get; set; }

        /// <summary>
        /// Defines the RefIPEDSFASBFunctionalExpense.RecordStartDateTime nullable property
        /// </summary>
        public System.DateTime? RecordStartDateTime { get; set; }

        /// <summary>
        /// Defines the RefIPEDSFASBFunctionalExpense.RecordEndDateTime nullable property
        /// </summary>
        public System.DateTime? RecordEndDateTime { get; set; }

    }
}
