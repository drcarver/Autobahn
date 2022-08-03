//**********************************************************
//* DomainName: Autobahn.Reference
//* FileName:   RefAssessmentELDevelopmentalDomain.cs
//**********************************************************

using Autobahn.Reference.Interfaces;

namespace Autobahn.Reference.Models
{
     /// <summary>
     /// The RefAssessmentELDevelopmentalDomain
     /// </summary>
    public partial class RefAssessmentELDevelopmentalDomain : IRefAssessmentELDevelopmentalDomain
    {
        /// <summary>
        /// Defines the RefAssessmentELDevelopmentalDomain.Description non nullable property
        /// </summary>
        public System.String Description { get; set; }

        /// <summary>
        /// Defines the RefAssessmentELDevelopmentalDomain.Code non nullable property
        /// </summary>
        public System.String Code { get; set; }

        /// <summary>
        /// Defines the RefAssessmentELDevelopmentalDomain.Definition non nullable property
        /// </summary>
        public System.String Definition { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefJurisdiction"/> model
        /// </summary>
        public Guid? RefJurisdictionId { get; set; }

        /// <summary>
        /// Defines the RefAssessmentELDevelopmentalDomain.SortOrder nullable property
        /// </summary>
        public System.Decimal? SortOrder { get; set; }

        /// <summary>
        /// Defines the RefAssessmentELDevelopmentalDomain.RecordStartDateTime nullable property
        /// </summary>
        public System.DateTime? RecordStartDateTime { get; set; }

        /// <summary>
        /// Defines the RefAssessmentELDevelopmentalDomain.RecordEndDateTime nullable property
        /// </summary>
        public System.DateTime? RecordEndDateTime { get; set; }

    }
}
