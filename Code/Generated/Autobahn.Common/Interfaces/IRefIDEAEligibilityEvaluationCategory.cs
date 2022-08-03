//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   IRefIDEAEligibilityEvaluationCategory.cs
//**********************************************************

namespace Autobahn.Common.Interfaces
{
     /// <summary>
     /// The IRefIDEAEligibilityEvaluationCategory
     /// </summary>
    public partial interface IRefIDEAEligibilityEvaluationCategory
    {
        /// <summary>
        /// Defines the RefIDEAEligibilityEvaluationCategory.Description non nullable property
        /// </summary>
        System.String Description { get; set; }

        /// <summary>
        /// Defines the RefIDEAEligibilityEvaluationCategory.Code non nullable property
        /// </summary>
        System.String Code { get; set; }

        /// <summary>
        /// Defines the RefIDEAEligibilityEvaluationCategory.Definition non nullable property
        /// </summary>
        System.String Definition { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefJurisdiction"/> model
        /// </summary>
        Guid? RefJurisdictionId { get; set; }

        /// <summary>
        /// Defines the RefIDEAEligibilityEvaluationCategory.SortOrder nullable property
        /// </summary>
        System.Decimal? SortOrder { get; set; }

        /// <summary>
        /// Defines the RefIDEAEligibilityEvaluationCategory.RecordStartDateTime nullable property
        /// </summary>
        System.DateTime? RecordStartDateTime { get; set; }

        /// <summary>
        /// Defines the RefIDEAEligibilityEvaluationCategory.RecordEndDateTime nullable property
        /// </summary>
        System.DateTime? RecordEndDateTime { get; set; }

    }
}
