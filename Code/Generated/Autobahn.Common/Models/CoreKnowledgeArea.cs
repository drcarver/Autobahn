//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   CoreKnowledgeArea.cs
//**********************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.Common.Models
{
     /// <summary>
     /// The CoreKnowledgeArea
     /// </summary>
    public partial class CoreKnowledgeArea : ICoreKnowledgeArea
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="ProfessionalDevelopmentActivity"/> model
        /// </summary>
        public Guid ProfessionalDevelopmentActivityId { get; set; }

        /// <summary>
        /// Reference to a required instance of the <see cref="RefCoreKnowledgeArea"/> model
        /// </summary>
        public Guid RefCoreKnowledgeAreaId { get; set; }

        /// <summary>
        /// Defines the CoreKnowledgeArea.RecordStartDateTime nullable property
        /// </summary>
        public System.DateTime? RecordStartDateTime { get; set; }

        /// <summary>
        /// Defines the CoreKnowledgeArea.RecordEndDateTime nullable property
        /// </summary>
        public System.DateTime? RecordEndDateTime { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RecordStatus"/> model
        /// </summary>
        public Guid? RecordStatusId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="DataCollection"/> model
        /// </summary>
        public Guid? DataCollectionId { get; set; }

    }
}
