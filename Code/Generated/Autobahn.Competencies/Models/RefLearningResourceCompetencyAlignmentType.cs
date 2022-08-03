//**********************************************************
//* DomainName: Autobahn.Competencies
//* FileName:   RefLearningResourceCompetencyAlignmentType.cs
//**********************************************************

using Autobahn.Competencies.Interfaces;

namespace Autobahn.Competencies.Models
{
     /// <summary>
     /// The RefLearningResourceCompetencyAlignmentType
     /// </summary>
    public partial class RefLearningResourceCompetencyAlignmentType : IRefLearningResourceCompetencyAlignmentType
    {
        /// <summary>
        /// Defines the RefLearningResourceCompetencyAlignmentType.Description non nullable property
        /// </summary>
        public System.String Description { get; set; }

        /// <summary>
        /// Defines the RefLearningResourceCompetencyAlignmentType.Code non nullable property
        /// </summary>
        public System.String Code { get; set; }

        /// <summary>
        /// Defines the RefLearningResourceCompetencyAlignmentType.Definition non nullable property
        /// </summary>
        public System.String Definition { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefJurisdiction"/> model
        /// </summary>
        public Guid? RefJurisdictionId { get; set; }

        /// <summary>
        /// Defines the RefLearningResourceCompetencyAlignmentType.SortOrder nullable property
        /// </summary>
        public System.Decimal? SortOrder { get; set; }

        /// <summary>
        /// Defines the RefLearningResourceCompetencyAlignmentType.RecordStartDateTime nullable property
        /// </summary>
        public System.DateTime? RecordStartDateTime { get; set; }

        /// <summary>
        /// Defines the RefLearningResourceCompetencyAlignmentType.RecordEndDateTime nullable property
        /// </summary>
        public System.DateTime? RecordEndDateTime { get; set; }

    }
}
