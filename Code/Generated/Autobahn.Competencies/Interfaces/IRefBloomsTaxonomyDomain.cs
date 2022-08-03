//**********************************************************
//* DomainName: Autobahn.Competencies
//* FileName:   IRefBloomsTaxonomyDomain.cs
//**********************************************************

namespace Autobahn.Competencies.Interfaces
{
     /// <summary>
     /// The IRefBloomsTaxonomyDomain
     /// </summary>
    public partial interface IRefBloomsTaxonomyDomain
    {
        /// <summary>
        /// Defines the RefBloomsTaxonomyDomain.Description non nullable property
        /// </summary>
        System.String Description { get; set; }

        /// <summary>
        /// Defines the RefBloomsTaxonomyDomain.Code non nullable property
        /// </summary>
        System.String Code { get; set; }

        /// <summary>
        /// Defines the RefBloomsTaxonomyDomain.Definition non nullable property
        /// </summary>
        System.String Definition { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefJurisdiction"/> model
        /// </summary>
        Guid? RefJurisdictionId { get; set; }

        /// <summary>
        /// Defines the RefBloomsTaxonomyDomain.SortOrder nullable property
        /// </summary>
        System.Decimal? SortOrder { get; set; }

        /// <summary>
        /// Defines the RefBloomsTaxonomyDomain.RecordStartDateTime nullable property
        /// </summary>
        System.DateTime? RecordStartDateTime { get; set; }

        /// <summary>
        /// Defines the RefBloomsTaxonomyDomain.RecordEndDateTime nullable property
        /// </summary>
        System.DateTime? RecordEndDateTime { get; set; }

    }
}
