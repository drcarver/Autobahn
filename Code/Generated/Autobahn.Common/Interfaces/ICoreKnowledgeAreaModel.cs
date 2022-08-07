//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   ICoreKnowledgeAreaModel.cs
//**********************************************************


namespace Autobahn.Common.Interfaces
{
     /// <summary>
     /// The ICoreKnowledgeAreaModel Interface
     /// </summary>
    public partial interface ICoreKnowledgeAreaModel : IAutobahnBase
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="ProfessionalDevelopmentActivity"/> model
        /// </summary>
        Guid ProfessionalDevelopmentActivityId { get; set; }

        /// <summary>
        /// Reference to a required instance of the <see cref="RefCoreKnowledgeArea"/> model
        /// </summary>
        Guid RefCoreKnowledgeAreaId { get; set; }

    }
}
