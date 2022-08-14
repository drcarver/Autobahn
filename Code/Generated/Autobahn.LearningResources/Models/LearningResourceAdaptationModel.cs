//**********************************************************
//* DomainName: Learning Resources
//* FileName:   LearningResourceAdaptationModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.Models;

namespace Autobahn.LearningResources.Models
{
     /// <summary>
     /// The LearningResourceAdaptation Model
     /// </summary>
    public partial class LearningResourceAdaptationModel : AutobahnBase, Interfaces.ILearningResourceAdaptation
    {
        /// <summary>
        /// The Uniform Resource Locator of a learning resource that is an adaptation for this resource.
        /// </summary>
        public System.String AdaptationURL { get; set; }

        /// <summary>
        /// The Uniform Resource Locator of a learning resource that is an adaptation for this resource.
        /// </summary>
        public Guid LearningResourceId { get; set; }

    }
}
