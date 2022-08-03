//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   RefFinancialExpenditureLevelOfInstructionCode.cs
//**********************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.Common.Models
{
     /// <summary>
     /// The RefFinancialExpenditureLevelOfInstructionCode
     /// </summary>
    public partial class RefFinancialExpenditureLevelOfInstructionCode : IRefFinancialExpenditureLevelOfInstructionCode
    {
        /// <summary>
        /// Defines the RefFinancialExpenditureLevelOfInstructionCode.Description non nullable property
        /// </summary>
        public System.String Description { get; set; }

        /// <summary>
        /// Defines the RefFinancialExpenditureLevelOfInstructionCode.Code non nullable property
        /// </summary>
        public System.String Code { get; set; }

        /// <summary>
        /// Defines the RefFinancialExpenditureLevelOfInstructionCode.Definition non nullable property
        /// </summary>
        public System.String Definition { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefJurisdiction"/> model
        /// </summary>
        public Guid? RefJurisdictionId { get; set; }

        /// <summary>
        /// Defines the RefFinancialExpenditureLevelOfInstructionCode.SortOrder nullable property
        /// </summary>
        public System.Decimal? SortOrder { get; set; }

        /// <summary>
        /// Defines the RefFinancialExpenditureLevelOfInstructionCode.RecordStartDateTime nullable property
        /// </summary>
        public System.DateTime? RecordStartDateTime { get; set; }

        /// <summary>
        /// Defines the RefFinancialExpenditureLevelOfInstructionCode.RecordEndDateTime nullable property
        /// </summary>
        public System.DateTime? RecordEndDateTime { get; set; }

    }
}
