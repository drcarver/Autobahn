//**********************************************************
//* DomainName: Autobahn.Assessment
//* FileName:   RefAssessmentNeedIncreasedWhitespacingType.cs
//**********************************************************

using Autobahn.Assessment.Interfaces;

namespace Autobahn.Assessment.Models
{
     /// <summary>
     /// The RefAssessmentNeedIncreasedWhitespacingType
     /// </summary>
    public partial class RefAssessmentNeedIncreasedWhitespacingType : IRefAssessmentNeedIncreasedWhitespacingType
    {
        /// <summary>
        /// Defines the RefAssessmentNeedIncreasedWhitespacingType.Description non nullable property
        /// </summary>
        public System.String Description { get; set; }

        /// <summary>
        /// Defines the RefAssessmentNeedIncreasedWhitespacingType.Code non nullable property
        /// </summary>
        public System.String Code { get; set; }

        /// <summary>
        /// Defines the RefAssessmentNeedIncreasedWhitespacingType.Definition non nullable property
        /// </summary>
        public System.String Definition { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefJurisdiction"/> model
        /// </summary>
        public Guid? RefJurisdictionId { get; set; }

        /// <summary>
        /// Defines the RefAssessmentNeedIncreasedWhitespacingType.SortOrder nullable property
        /// </summary>
        public System.Decimal? SortOrder { get; set; }

        /// <summary>
        /// Defines the RefAssessmentNeedIncreasedWhitespacingType.RecordStartDateTime nullable property
        /// </summary>
        public System.DateTime? RecordStartDateTime { get; set; }

        /// <summary>
        /// Defines the RefAssessmentNeedIncreasedWhitespacingType.RecordEndDateTime nullable property
        /// </summary>
        public System.DateTime? RecordEndDateTime { get; set; }

    }
}
