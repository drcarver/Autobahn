//**********************************************************
//* DomainName: Autobahn.Competencies
//* FileName:   RefBloomsTaxonomyDomain.cs
//**********************************************************

using Autobahn.Competencies.Interfaces;

namespace Autobahn.Competencies.Models
{
     /// <summary>
     /// The RefBloomsTaxonomyDomain
     /// </summary>
    public partial class RefBloomsTaxonomyDomain : IRefBloomsTaxonomyDomain
    {
        /// <summary>
        /// Defines the RefBloomsTaxonomyDomain.Description non nullable property
        /// </summary>
        public System.String Description { get; set; }

        /// <summary>
        /// Defines the RefBloomsTaxonomyDomain.Code non nullable property
        /// </summary>
        public System.String Code { get; set; }

        /// <summary>
        /// Defines the RefBloomsTaxonomyDomain.Definition non nullable property
        /// </summary>
        public System.String Definition { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefJurisdiction"/> model
        /// </summary>
        public Guid? RefJurisdictionId { get; set; }

        /// <summary>
        /// Defines the RefBloomsTaxonomyDomain.SortOrder nullable property
        /// </summary>
        public System.Decimal? SortOrder { get; set; }

        /// <summary>
        /// Defines the RefBloomsTaxonomyDomain.RecordStartDateTime nullable property
        /// </summary>
        public System.DateTime? RecordStartDateTime { get; set; }

        /// <summary>
        /// Defines the RefBloomsTaxonomyDomain.RecordEndDateTime nullable property
        /// </summary>
        public System.DateTime? RecordEndDateTime { get; set; }

    }
}
