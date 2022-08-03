//**********************************************************
//* DomainName: Autobahn.Reference
//* FileName:   IRefAssessmentELDevelopmentalDomain.cs
//**********************************************************

namespace Autobahn.Reference.Interfaces
{
     /// <summary>
     /// The IRefAssessmentELDevelopmentalDomain
     /// </summary>
    public partial interface IRefAssessmentELDevelopmentalDomain
    {
        /// <summary>
        /// Defines the RefAssessmentELDevelopmentalDomain.Description non nullable property
        /// </summary>
        System.String Description { get; set; }

        /// <summary>
        /// Defines the RefAssessmentELDevelopmentalDomain.Code non nullable property
        /// </summary>
        System.String Code { get; set; }

        /// <summary>
        /// Defines the RefAssessmentELDevelopmentalDomain.Definition non nullable property
        /// </summary>
        System.String Definition { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefJurisdiction"/> model
        /// </summary>
        Guid? RefJurisdictionId { get; set; }

        /// <summary>
        /// Defines the RefAssessmentELDevelopmentalDomain.SortOrder nullable property
        /// </summary>
        System.Decimal? SortOrder { get; set; }

        /// <summary>
        /// Defines the RefAssessmentELDevelopmentalDomain.RecordStartDateTime nullable property
        /// </summary>
        System.DateTime? RecordStartDateTime { get; set; }

        /// <summary>
        /// Defines the RefAssessmentELDevelopmentalDomain.RecordEndDateTime nullable property
        /// </summary>
        System.DateTime? RecordEndDateTime { get; set; }

    }
}
