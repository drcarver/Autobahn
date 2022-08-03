//**********************************************************
//* DomainName: Autobahn.Assessment
//* FileName:   IRefAssessmentNeedIncreasedWhitespacingType.cs
//**********************************************************

namespace Autobahn.Assessment.Interfaces
{
     /// <summary>
     /// The IRefAssessmentNeedIncreasedWhitespacingType
     /// </summary>
    public partial interface IRefAssessmentNeedIncreasedWhitespacingType
    {
        /// <summary>
        /// Defines the RefAssessmentNeedIncreasedWhitespacingType.Description non nullable property
        /// </summary>
        System.String Description { get; set; }

        /// <summary>
        /// Defines the RefAssessmentNeedIncreasedWhitespacingType.Code non nullable property
        /// </summary>
        System.String Code { get; set; }

        /// <summary>
        /// Defines the RefAssessmentNeedIncreasedWhitespacingType.Definition non nullable property
        /// </summary>
        System.String Definition { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefJurisdiction"/> model
        /// </summary>
        Guid? RefJurisdictionId { get; set; }

        /// <summary>
        /// Defines the RefAssessmentNeedIncreasedWhitespacingType.SortOrder nullable property
        /// </summary>
        System.Decimal? SortOrder { get; set; }

        /// <summary>
        /// Defines the RefAssessmentNeedIncreasedWhitespacingType.RecordStartDateTime nullable property
        /// </summary>
        System.DateTime? RecordStartDateTime { get; set; }

        /// <summary>
        /// Defines the RefAssessmentNeedIncreasedWhitespacingType.RecordEndDateTime nullable property
        /// </summary>
        System.DateTime? RecordEndDateTime { get; set; }

    }
}
