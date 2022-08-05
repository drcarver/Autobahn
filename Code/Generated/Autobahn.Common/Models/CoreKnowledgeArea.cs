//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   CoreKnowledgeArea.cs
//**********************************************************


namespace Autobahn.Common.Models
{
     /// <summary>
     /// The CoreKnowledgeArea
     /// </summary>
    public partial class CoreKnowledgeArea : AutobahnBase, Interfaces.ICoreKnowledgeArea
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
        /// Reference to an optional instance of the <see cref="DataCollection"/> model
        /// </summary>
        public Guid? DataCollectionId { get; set; }

    }
}
