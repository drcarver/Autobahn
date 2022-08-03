//**********************************************************
//* DomainName: Autobahn.Competencies
//* FileName:   IRefLearningResourceCompetencyAlignmentType.cs
//**********************************************************

namespace Autobahn.Competencies.Interfaces
{
     /// <summary>
     /// The IRefLearningResourceCompetencyAlignmentType
     /// </summary>
    public partial interface IRefLearningResourceCompetencyAlignmentType
    {
        /// <summary>
        /// Defines the RefLearningResourceCompetencyAlignmentType.Description non nullable property
        /// </summary>
        System.String Description { get; set; }

        /// <summary>
        /// Defines the RefLearningResourceCompetencyAlignmentType.Code non nullable property
        /// </summary>
        System.String Code { get; set; }

        /// <summary>
        /// Defines the RefLearningResourceCompetencyAlignmentType.Definition non nullable property
        /// </summary>
        System.String Definition { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefJurisdiction"/> model
        /// </summary>
        Guid? RefJurisdictionId { get; set; }

        /// <summary>
        /// Defines the RefLearningResourceCompetencyAlignmentType.SortOrder nullable property
        /// </summary>
        System.Decimal? SortOrder { get; set; }

        /// <summary>
        /// Defines the RefLearningResourceCompetencyAlignmentType.RecordStartDateTime nullable property
        /// </summary>
        System.DateTime? RecordStartDateTime { get; set; }

        /// <summary>
        /// Defines the RefLearningResourceCompetencyAlignmentType.RecordEndDateTime nullable property
        /// </summary>
        System.DateTime? RecordEndDateTime { get; set; }

    }
}
