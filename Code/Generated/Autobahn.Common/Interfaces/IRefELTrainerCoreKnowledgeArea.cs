//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   IRefELTrainerCoreKnowledgeArea.cs
//**********************************************************

namespace Autobahn.Common.Interfaces
{
     /// <summary>
     /// The IRefELTrainerCoreKnowledgeArea
     /// </summary>
    public partial interface IRefELTrainerCoreKnowledgeArea
    {
        /// <summary>
        /// Defines the RefELTrainerCoreKnowledgeArea.Description non nullable property
        /// </summary>
        System.String Description { get; set; }

        /// <summary>
        /// Defines the RefELTrainerCoreKnowledgeArea.Code non nullable property
        /// </summary>
        System.String Code { get; set; }

        /// <summary>
        /// Defines the RefELTrainerCoreKnowledgeArea.Definition non nullable property
        /// </summary>
        System.String Definition { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefJurisdiction"/> model
        /// </summary>
        Guid? RefJurisdictionId { get; set; }

        /// <summary>
        /// Defines the RefELTrainerCoreKnowledgeArea.SortOrder nullable property
        /// </summary>
        System.Decimal? SortOrder { get; set; }

        /// <summary>
        /// Defines the RefELTrainerCoreKnowledgeArea.RecordStartDateTime nullable property
        /// </summary>
        System.DateTime? RecordStartDateTime { get; set; }

        /// <summary>
        /// Defines the RefELTrainerCoreKnowledgeArea.RecordEndDateTime nullable property
        /// </summary>
        System.DateTime? RecordEndDateTime { get; set; }

    }
}
