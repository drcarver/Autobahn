//***************************************************************************
//* DomainName: Learning Resources Interfaces (used by both models and View Models
//* FileName:   ILearningResourceEducationLevel.cs
//***************************************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.LearningResources.Interfaces
{
     /// <summary>
     /// The ILearningResourceEducationLevel Interface
     /// </summary>
    public partial interface ILearningResourceEducationLevel : IAutobahnBase
    {
        /// <summary>
        /// Learning Resource Adapted From URL
        /// <para>
        /// URL identifier of a learning resource for which this resource is an adaptation.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20367">Learning Resource Adapted From URL</a>
        /// </para>
        /// </summary>
        Guid LearningResourceId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefEducationLevel"/> model
        /// </summary>
        Guid RefEducationLevelId { get; set; }

    }
}
