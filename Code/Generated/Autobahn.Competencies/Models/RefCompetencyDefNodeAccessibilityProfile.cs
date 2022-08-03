//**********************************************************
//* DomainName: Autobahn.Competencies
//* FileName:   RefCompetencyDefNodeAccessibilityProfile.cs
//**********************************************************

using Autobahn.Competencies.Interfaces;

namespace Autobahn.Competencies.Models
{
     /// <summary>
     /// The RefCompetencyDefNodeAccessibilityProfile
     /// </summary>
    public partial class RefCompetencyDefNodeAccessibilityProfile : IRefCompetencyDefNodeAccessibilityProfile
    {
        /// <summary>
        /// Defines the RefCompetencyDefNodeAccessibilityProfile.Description non nullable property
        /// </summary>
        public System.String Description { get; set; }

        /// <summary>
        /// Defines the RefCompetencyDefNodeAccessibilityProfile.Code non nullable property
        /// </summary>
        public System.String Code { get; set; }

        /// <summary>
        /// Defines the RefCompetencyDefNodeAccessibilityProfile.Definition non nullable property
        /// </summary>
        public System.String Definition { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefJurisdiction"/> model
        /// </summary>
        public Guid? RefJurisdictionId { get; set; }

        /// <summary>
        /// Defines the RefCompetencyDefNodeAccessibilityProfile.SortOrder nullable property
        /// </summary>
        public System.Decimal? SortOrder { get; set; }

        /// <summary>
        /// Defines the RefCompetencyDefNodeAccessibilityProfile.RecordStartDateTime nullable property
        /// </summary>
        public System.DateTime? RecordStartDateTime { get; set; }

        /// <summary>
        /// Defines the RefCompetencyDefNodeAccessibilityProfile.RecordEndDateTime nullable property
        /// </summary>
        public System.DateTime? RecordEndDateTime { get; set; }

    }
}
