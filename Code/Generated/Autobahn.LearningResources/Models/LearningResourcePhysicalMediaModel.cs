//**********************************************************
//* DomainName: Learning Resources
//* FileName:   LearningResourcePhysicalMediaModel.cs
//***************************************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.Models;

namespace Autobahn.LearningResources.Interfaces
{
     /// <summary>
     /// The LearningResourcePhysicalMedia Model
     /// </summary>
    public partial class LearningResourcePhysicalMediaModel : AutobahnBase, Interfaces.ILearningResourcePhysicalMedia
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
        public Guid LearningResourceId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IRefLearningResourcePhysicalMediaType"/> model
        /// </summary>
        public Guid RefLearningResourcePhysicalMediaTypeId { get; set; }

    }
}
