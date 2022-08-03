//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   RefELTrainerCoreKnowledgeArea.cs
//**********************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.Common.Models
{
     /// <summary>
     /// The RefELTrainerCoreKnowledgeArea
     /// </summary>
    public partial class RefELTrainerCoreKnowledgeArea : IRefELTrainerCoreKnowledgeArea
    {
        /// <summary>
        /// Defines the RefELTrainerCoreKnowledgeArea.Description non nullable property
        /// </summary>
        public System.String Description { get; set; }

        /// <summary>
        /// Defines the RefELTrainerCoreKnowledgeArea.Code non nullable property
        /// </summary>
        public System.String Code { get; set; }

        /// <summary>
        /// Defines the RefELTrainerCoreKnowledgeArea.Definition non nullable property
        /// </summary>
        public System.String Definition { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefJurisdiction"/> model
        /// </summary>
        public Guid? RefJurisdictionId { get; set; }

        /// <summary>
        /// Defines the RefELTrainerCoreKnowledgeArea.SortOrder nullable property
        /// </summary>
        public System.Decimal? SortOrder { get; set; }

        /// <summary>
        /// Defines the RefELTrainerCoreKnowledgeArea.RecordStartDateTime nullable property
        /// </summary>
        public System.DateTime? RecordStartDateTime { get; set; }

        /// <summary>
        /// Defines the RefELTrainerCoreKnowledgeArea.RecordEndDateTime nullable property
        /// </summary>
        public System.DateTime? RecordEndDateTime { get; set; }

    }
}
