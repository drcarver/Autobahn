//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   ICoreKnowledgeArea.cs
//**********************************************************


namespace Autobahn.Common.Interfaces
{
     /// <summary>
     /// The ICoreKnowledgeArea
     /// </summary>
    public partial interface ICoreKnowledgeArea : IAutobahnBase
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
