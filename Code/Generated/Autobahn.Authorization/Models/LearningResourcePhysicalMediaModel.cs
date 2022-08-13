//**********************************************************
//* DomainName: Authentication and Authorization
//* FileName:   LearningResourcePhysicalMediaModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.Models;

namespace Autobahn.Authorization.Models
{
     /// <summary>
     /// The LearningResourcePhysicalMedia Model
     /// </summary>
    public partial class LearningResourcePhysicalMediaModel : AutobahnBase, Interfaces.ILearningResourcePhysicalMedia
    {
        /// <summary>
        /// A type of physical media on which the Learning Resource is delivered or available.
        /// </summary>
        public Guid LearningResourceId { get; set; }

        /// <summary>
        /// A type of physical media on which the Learning Resource is delivered or available.
        /// </summary>
        public Guid RefLearningResourcePhysicalMediaTypeId { get; set; }

    }
}
