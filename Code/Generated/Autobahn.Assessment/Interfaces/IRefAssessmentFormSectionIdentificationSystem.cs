//**********************************************************
//* DomainName: Autobahn.Assessment
//* FileName:   IRefAssessmentFormSectionIdentificationSystem.cs
//**********************************************************

namespace Autobahn.Assessment.Interfaces
{
     /// <summary>
     /// The IRefAssessmentFormSectionIdentificationSystem
     /// </summary>
    public partial interface IRefAssessmentFormSectionIdentificationSystem
    {
        /// <summary>
        /// Defines the RefAssessmentFormSectionIdentificationSystem.Description non nullable property
        /// </summary>
        System.String Description { get; set; }

        /// <summary>
        /// Defines the RefAssessmentFormSectionIdentificationSystem.Code non nullable property
        /// </summary>
        System.String Code { get; set; }

        /// <summary>
        /// Defines the RefAssessmentFormSectionIdentificationSystem.Definition non nullable property
        /// </summary>
        System.String Definition { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefJurisdiction"/> model
        /// </summary>
        Guid? RefJurisdictionId { get; set; }

        /// <summary>
        /// Defines the RefAssessmentFormSectionIdentificationSystem.SortOrder nullable property
        /// </summary>
        System.Decimal? SortOrder { get; set; }

        /// <summary>
        /// Defines the RefAssessmentFormSectionIdentificationSystem.RecordStartDateTime nullable property
        /// </summary>
        System.DateTime? RecordStartDateTime { get; set; }

        /// <summary>
        /// Defines the RefAssessmentFormSectionIdentificationSystem.RecordEndDateTime nullable property
        /// </summary>
        System.DateTime? RecordEndDateTime { get; set; }

    }
}
