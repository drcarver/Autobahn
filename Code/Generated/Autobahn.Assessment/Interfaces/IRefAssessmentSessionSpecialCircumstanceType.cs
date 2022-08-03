//**********************************************************
//* DomainName: Autobahn.Assessment
//* FileName:   IRefAssessmentSessionSpecialCircumstanceType.cs
//**********************************************************

namespace Autobahn.Assessment.Interfaces
{
     /// <summary>
     /// The IRefAssessmentSessionSpecialCircumstanceType
     /// </summary>
    public partial interface IRefAssessmentSessionSpecialCircumstanceType
    {
        /// <summary>
        /// Defines the RefAssessmentSessionSpecialCircumstanceType.Description non nullable property
        /// </summary>
        System.String Description { get; set; }

        /// <summary>
        /// Defines the RefAssessmentSessionSpecialCircumstanceType.Code non nullable property
        /// </summary>
        System.String Code { get; set; }

        /// <summary>
        /// Defines the RefAssessmentSessionSpecialCircumstanceType.Definition non nullable property
        /// </summary>
        System.String Definition { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefJurisdiction"/> model
        /// </summary>
        Guid? RefJurisdictionId { get; set; }

        /// <summary>
        /// Defines the RefAssessmentSessionSpecialCircumstanceType.SortOrder nullable property
        /// </summary>
        System.Decimal? SortOrder { get; set; }

        /// <summary>
        /// Defines the RefAssessmentSessionSpecialCircumstanceType.RecordStartDateTime nullable property
        /// </summary>
        System.DateTime? RecordStartDateTime { get; set; }

        /// <summary>
        /// Defines the RefAssessmentSessionSpecialCircumstanceType.RecordEndDateTime nullable property
        /// </summary>
        System.DateTime? RecordEndDateTime { get; set; }

    }
}
