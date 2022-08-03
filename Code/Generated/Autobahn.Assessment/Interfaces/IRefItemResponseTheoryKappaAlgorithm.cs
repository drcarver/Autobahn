//**********************************************************
//* DomainName: Autobahn.Assessment
//* FileName:   IRefItemResponseTheoryKappaAlgorithm.cs
//**********************************************************

namespace Autobahn.Assessment.Interfaces
{
     /// <summary>
     /// The IRefItemResponseTheoryKappaAlgorithm
     /// </summary>
    public partial interface IRefItemResponseTheoryKappaAlgorithm
    {
        /// <summary>
        /// Defines the RefItemResponseTheoryKappaAlgorithm.Description non nullable property
        /// </summary>
        System.String Description { get; set; }

        /// <summary>
        /// Defines the RefItemResponseTheoryKappaAlgorithm.Code non nullable property
        /// </summary>
        System.String Code { get; set; }

        /// <summary>
        /// Defines the RefItemResponseTheoryKappaAlgorithm.Definition non nullable property
        /// </summary>
        System.String Definition { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefJurisdiction"/> model
        /// </summary>
        Guid? RefJurisdictionId { get; set; }

        /// <summary>
        /// Defines the RefItemResponseTheoryKappaAlgorithm.SortOrder nullable property
        /// </summary>
        System.Decimal? SortOrder { get; set; }

        /// <summary>
        /// Defines the RefItemResponseTheoryKappaAlgorithm.RecordStartDateTime nullable property
        /// </summary>
        System.DateTime? RecordStartDateTime { get; set; }

        /// <summary>
        /// Defines the RefItemResponseTheoryKappaAlgorithm.RecordEndDateTime nullable property
        /// </summary>
        System.DateTime? RecordEndDateTime { get; set; }

    }
}
