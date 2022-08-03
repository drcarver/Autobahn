//**********************************************************
//* DomainName: Autobahn.Competencies
//* FileName:   IRefCompetencyDefNodeAccessibilityProfile.cs
//**********************************************************

namespace Autobahn.Competencies.Interfaces
{
     /// <summary>
     /// The IRefCompetencyDefNodeAccessibilityProfile
     /// </summary>
    public partial interface IRefCompetencyDefNodeAccessibilityProfile
    {
        /// <summary>
        /// Defines the RefCompetencyDefNodeAccessibilityProfile.Description non nullable property
        /// </summary>
        System.String Description { get; set; }

        /// <summary>
        /// Defines the RefCompetencyDefNodeAccessibilityProfile.Code non nullable property
        /// </summary>
        System.String Code { get; set; }

        /// <summary>
        /// Defines the RefCompetencyDefNodeAccessibilityProfile.Definition non nullable property
        /// </summary>
        System.String Definition { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefJurisdiction"/> model
        /// </summary>
        Guid? RefJurisdictionId { get; set; }

        /// <summary>
        /// Defines the RefCompetencyDefNodeAccessibilityProfile.SortOrder nullable property
        /// </summary>
        System.Decimal? SortOrder { get; set; }

        /// <summary>
        /// Defines the RefCompetencyDefNodeAccessibilityProfile.RecordStartDateTime nullable property
        /// </summary>
        System.DateTime? RecordStartDateTime { get; set; }

        /// <summary>
        /// Defines the RefCompetencyDefNodeAccessibilityProfile.RecordEndDateTime nullable property
        /// </summary>
        System.DateTime? RecordEndDateTime { get; set; }

    }
}
