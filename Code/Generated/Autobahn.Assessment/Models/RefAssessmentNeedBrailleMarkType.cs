//**********************************************************
//* DomainName: Autobahn.Assessment
//* FileName:   RefAssessmentNeedBrailleMarkType.cs
//**********************************************************

using Autobahn.Assessment.Interfaces;

namespace Autobahn.Assessment.Models
{
     /// <summary>
     /// The RefAssessmentNeedBrailleMarkType
     /// </summary>
    public partial class RefAssessmentNeedBrailleMarkType : IRefAssessmentNeedBrailleMarkType
    {
        /// <summary>
        /// Defines the RefAssessmentNeedBrailleMarkType.Description non nullable property
        /// </summary>
        public System.String Description { get; set; }

        /// <summary>
        /// Defines the RefAssessmentNeedBrailleMarkType.Code non nullable property
        /// </summary>
        public System.String Code { get; set; }

        /// <summary>
        /// Defines the RefAssessmentNeedBrailleMarkType.Definition non nullable property
        /// </summary>
        public System.String Definition { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefJurisdiction"/> model
        /// </summary>
        public Guid? RefJurisdictionId { get; set; }

        /// <summary>
        /// Defines the RefAssessmentNeedBrailleMarkType.SortOrder nullable property
        /// </summary>
        public System.Decimal? SortOrder { get; set; }

        /// <summary>
        /// Defines the RefAssessmentNeedBrailleMarkType.RecordStartDateTime nullable property
        /// </summary>
        public System.DateTime? RecordStartDateTime { get; set; }

        /// <summary>
        /// Defines the RefAssessmentNeedBrailleMarkType.RecordEndDateTime nullable property
        /// </summary>
        public System.DateTime? RecordEndDateTime { get; set; }

    }
}
