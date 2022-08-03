//**********************************************************
//* DomainName: Autobahn.Assessment
//* FileName:   RefAssessmentSessionSpecialCircumstanceType.cs
//**********************************************************

using Autobahn.Assessment.Interfaces;

namespace Autobahn.Assessment.Models
{
     /// <summary>
     /// The RefAssessmentSessionSpecialCircumstanceType
     /// </summary>
    public partial class RefAssessmentSessionSpecialCircumstanceType : IRefAssessmentSessionSpecialCircumstanceType
    {
        /// <summary>
        /// Defines the RefAssessmentSessionSpecialCircumstanceType.Description non nullable property
        /// </summary>
        public System.String Description { get; set; }

        /// <summary>
        /// Defines the RefAssessmentSessionSpecialCircumstanceType.Code non nullable property
        /// </summary>
        public System.String Code { get; set; }

        /// <summary>
        /// Defines the RefAssessmentSessionSpecialCircumstanceType.Definition non nullable property
        /// </summary>
        public System.String Definition { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefJurisdiction"/> model
        /// </summary>
        public Guid? RefJurisdictionId { get; set; }

        /// <summary>
        /// Defines the RefAssessmentSessionSpecialCircumstanceType.SortOrder nullable property
        /// </summary>
        public System.Decimal? SortOrder { get; set; }

        /// <summary>
        /// Defines the RefAssessmentSessionSpecialCircumstanceType.RecordStartDateTime nullable property
        /// </summary>
        public System.DateTime? RecordStartDateTime { get; set; }

        /// <summary>
        /// Defines the RefAssessmentSessionSpecialCircumstanceType.RecordEndDateTime nullable property
        /// </summary>
        public System.DateTime? RecordEndDateTime { get; set; }

    }
}
