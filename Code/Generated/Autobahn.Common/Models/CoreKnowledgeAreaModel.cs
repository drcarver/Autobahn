//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   CoreKnowledgeAreaModel.cs
//**********************************************************


namespace Autobahn.Common.Models
{
     /// <summary>
     /// The CoreKnowledgeArea Model
     /// </summary>
    public partial class CoreKnowledgeAreaModel : AutobahnBase, Interfaces.ICoreKnowledgeAreaModel
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
