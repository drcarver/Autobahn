//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   ICoreKnowledgeArea.cs
//**********************************************************

namespace Autobahn.Common.Interfaces
{
     /// <summary>
     /// The ICoreKnowledgeArea
     /// </summary>
    public partial interface ICoreKnowledgeArea
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="ProfessionalDevelopmentActivity"/> model
        /// </summary>
        Guid ProfessionalDevelopmentActivityId { get; set; }

        /// <summary>
        /// Reference to a required instance of the <see cref="RefCoreKnowledgeArea"/> model
        /// </summary>
        Guid RefCoreKnowledgeAreaId { get; set; }

        /// <summary>
        /// Defines the CoreKnowledgeArea.RecordStartDateTime nullable property
        /// </summary>
        System.DateTime? RecordStartDateTime { get; set; }

        /// <summary>
        /// Defines the CoreKnowledgeArea.RecordEndDateTime nullable property
        /// </summary>
        System.DateTime? RecordEndDateTime { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RecordStatus"/> model
        /// </summary>
        Guid? RecordStatusId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="DataCollection"/> model
        /// </summary>
        Guid? DataCollectionId { get; set; }

    }
}
