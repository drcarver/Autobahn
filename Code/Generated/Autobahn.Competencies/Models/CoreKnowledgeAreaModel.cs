//**********************************************************
//* DomainName: Competencies
//* FileName:   CoreKnowledgeAreaModel.cs
//***************************************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.Models;

namespace Autobahn.Competencies.Models
{
     /// <summary>
     /// The CoreKnowledgeArea Model
     /// </summary>
    public partial class CoreKnowledgeAreaModel : AutobahnBase, Interfaces.ICoreKnowledgeArea
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
        public Guid ProfessionalDevelopmentActivityId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefCoreKnowledgeArea"/> model
        /// </summary>
        public Guid RefCoreKnowledgeAreaId { get; set; }

    }
}
