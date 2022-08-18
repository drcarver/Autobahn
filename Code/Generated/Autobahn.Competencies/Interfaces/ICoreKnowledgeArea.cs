//***************************************************************************
//* DomainName: Competencies Interfaces (used by both models and View Models
//* FileName:   ICoreKnowledgeArea.cs
//***************************************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.Competencies.Interfaces
{
     /// <summary>
     /// The ICoreKnowledgeArea Interface
     /// </summary>
    public partial interface ICoreKnowledgeArea : IAutobahnBase
    {
        /// <summary>
        /// Professional Development Activity Code
        /// <para>
        /// A code assigned to an professional development activity by the organization offering the activity that is unique to the non-variable activity details.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20404">Professional Development Activity Code</a>
        /// </para>
        /// </summary>
        Guid ProfessionalDevelopmentActivityId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefCoreKnowledgeArea"/> model
        /// </summary>
        Guid RefCoreKnowledgeAreaId { get; set; }

    }
}
