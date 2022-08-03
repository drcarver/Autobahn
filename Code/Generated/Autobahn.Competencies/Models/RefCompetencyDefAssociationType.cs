//**********************************************************
//* DomainName: Autobahn.Competencies
//* FileName:   RefCompetencyDefAssociationType.cs
//**********************************************************

using Autobahn.Competencies.Interfaces;

namespace Autobahn.Competencies.Models
{
     /// <summary>
     /// The RefCompetencyDefAssociationType
     /// </summary>
    public partial class RefCompetencyDefAssociationType : IRefCompetencyDefAssociationType
    {
        /// <summary>
        /// Defines the RefCompetencyDefAssociationType.Description non nullable property
        /// </summary>
        public System.String Description { get; set; }

        /// <summary>
        /// Defines the RefCompetencyDefAssociationType.Code non nullable property
        /// </summary>
        public System.String Code { get; set; }

        /// <summary>
        /// Defines the RefCompetencyDefAssociationType.Definition non nullable property
        /// </summary>
        public System.String Definition { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefJurisdiction"/> model
        /// </summary>
        public Guid? RefJurisdictionId { get; set; }

        /// <summary>
        /// Defines the RefCompetencyDefAssociationType.SortOrder nullable property
        /// </summary>
        public System.Decimal? SortOrder { get; set; }

        /// <summary>
        /// Defines the RefCompetencyDefAssociationType.RecordStartDateTime nullable property
        /// </summary>
        public System.DateTime? RecordStartDateTime { get; set; }

        /// <summary>
        /// Defines the RefCompetencyDefAssociationType.RecordEndDateTime nullable property
        /// </summary>
        public System.DateTime? RecordEndDateTime { get; set; }

    }
}
