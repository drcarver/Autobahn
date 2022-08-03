//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   RefIDEAEligibilityEvaluationCategory.cs
//**********************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.Common.Models
{
     /// <summary>
     /// The RefIDEAEligibilityEvaluationCategory
     /// </summary>
    public partial class RefIDEAEligibilityEvaluationCategory : IRefIDEAEligibilityEvaluationCategory
    {
        /// <summary>
        /// Defines the RefIDEAEligibilityEvaluationCategory.Description non nullable property
        /// </summary>
        public System.String Description { get; set; }

        /// <summary>
        /// Defines the RefIDEAEligibilityEvaluationCategory.Code non nullable property
        /// </summary>
        public System.String Code { get; set; }

        /// <summary>
        /// Defines the RefIDEAEligibilityEvaluationCategory.Definition non nullable property
        /// </summary>
        public System.String Definition { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefJurisdiction"/> model
        /// </summary>
        public Guid? RefJurisdictionId { get; set; }

        /// <summary>
        /// Defines the RefIDEAEligibilityEvaluationCategory.SortOrder nullable property
        /// </summary>
        public System.Decimal? SortOrder { get; set; }

        /// <summary>
        /// Defines the RefIDEAEligibilityEvaluationCategory.RecordStartDateTime nullable property
        /// </summary>
        public System.DateTime? RecordStartDateTime { get; set; }

        /// <summary>
        /// Defines the RefIDEAEligibilityEvaluationCategory.RecordEndDateTime nullable property
        /// </summary>
        public System.DateTime? RecordEndDateTime { get; set; }

    }
}
