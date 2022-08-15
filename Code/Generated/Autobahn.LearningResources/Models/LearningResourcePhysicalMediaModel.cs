//**********************************************************
//* DomainName: Learning Resources
//* FileName:   LearningResourcePhysicalMediaModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.Models;

namespace Autobahn.LearningResources.Models
{
     /// <summary>
     /// The LearningResourcePhysicalMedia Model
     /// </summary>
    public partial class LearningResourcePhysicalMediaModel : AutobahnBase, Interfaces.ILearningResourcePhysicalMedia
    {
        /// <summary>
        /// A type of physical media on which the Learning Resource is delivered or available.
        /// </summary>
        public Guid RefLearningResourcePhysicalMediaTypeId { get; set; }

    }
}
