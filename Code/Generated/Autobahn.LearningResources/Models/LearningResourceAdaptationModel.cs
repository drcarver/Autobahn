//**********************************************************
//* DomainName: Learning Resources
//* FileName:   LearningResourceAdaptationModel.cs
//* Name:       Learning Resource Adaptation URL
//* Definition: The Uniform Resource Locator of a learning resource that is an adaptation for this resource.
//***************************************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.Models;

namespace Autobahn.LearningResources.Models
{
     /// <summary>
     /// The Uniform Resource Locator of a learning resource that is an adaptation for this resource.
     /// </summary>
    public partial class LearningResourceAdaptationModel : AutobahnBase, Interfaces.ILearningResourceAdaptation
    {
        /// <summary>
        /// Learning Resource Adaptation URL
        /// <para>
        /// The Uniform Resource Locator of a learning resource that is an adaptation for this resource.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20361">Learning Resource Adaptation URL</a>
        /// </para>
        /// </summary>
        public System.String AdaptationURL { get; set; }

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

    }
}
