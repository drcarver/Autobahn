//**********************************************************
//* DomainName: Autobahn.Assessment
//* FileName:   IRefAssessmentNeedBrailleStatusCellType.cs
//**********************************************************

namespace Autobahn.Assessment.Interfaces
{
     /// <summary>
     /// The IRefAssessmentNeedBrailleStatusCellType
     /// </summary>
    public partial interface IRefAssessmentNeedBrailleStatusCellType
    {
        /// <summary>
        /// Defines the RefAssessmentNeedBrailleStatusCellType.Description non nullable property
        /// </summary>
        System.String Description { get; set; }

        /// <summary>
        /// Defines the RefAssessmentNeedBrailleStatusCellType.Code non nullable property
        /// </summary>
        System.String Code { get; set; }

        /// <summary>
        /// Defines the RefAssessmentNeedBrailleStatusCellType.Definition non nullable property
        /// </summary>
        System.String Definition { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefJurisdiction"/> model
        /// </summary>
        Guid? RefJurisdictionId { get; set; }

        /// <summary>
        /// Defines the RefAssessmentNeedBrailleStatusCellType.SortOrder nullable property
        /// </summary>
        System.Decimal? SortOrder { get; set; }

        /// <summary>
        /// Defines the RefAssessmentNeedBrailleStatusCellType.RecordStartDateTime nullable property
        /// </summary>
        System.DateTime? RecordStartDateTime { get; set; }

        /// <summary>
        /// Defines the RefAssessmentNeedBrailleStatusCellType.RecordEndDateTime nullable property
        /// </summary>
        System.DateTime? RecordEndDateTime { get; set; }

    }
}
