//**********************************************************
//* DomainName: Autobahn.Assessment
//* FileName:   RefItemResponseTheoryKappaAlgorithm.cs
//**********************************************************

using Autobahn.Assessment.Interfaces;

namespace Autobahn.Assessment.Models
{
     /// <summary>
     /// The RefItemResponseTheoryKappaAlgorithm
     /// </summary>
    public partial class RefItemResponseTheoryKappaAlgorithm : IRefItemResponseTheoryKappaAlgorithm
    {
        /// <summary>
        /// Defines the RefItemResponseTheoryKappaAlgorithm.Description non nullable property
        /// </summary>
        public System.String Description { get; set; }

        /// <summary>
        /// Defines the RefItemResponseTheoryKappaAlgorithm.Code non nullable property
        /// </summary>
        public System.String Code { get; set; }

        /// <summary>
        /// Defines the RefItemResponseTheoryKappaAlgorithm.Definition non nullable property
        /// </summary>
        public System.String Definition { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefJurisdiction"/> model
        /// </summary>
        public Guid? RefJurisdictionId { get; set; }

        /// <summary>
        /// Defines the RefItemResponseTheoryKappaAlgorithm.SortOrder nullable property
        /// </summary>
        public System.Decimal? SortOrder { get; set; }

        /// <summary>
        /// Defines the RefItemResponseTheoryKappaAlgorithm.RecordStartDateTime nullable property
        /// </summary>
        public System.DateTime? RecordStartDateTime { get; set; }

        /// <summary>
        /// Defines the RefItemResponseTheoryKappaAlgorithm.RecordEndDateTime nullable property
        /// </summary>
        public System.DateTime? RecordEndDateTime { get; set; }

    }
}
