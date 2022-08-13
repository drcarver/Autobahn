//***************************************************************************
//* DomainName: Authentication and Authorization Interfaces (used by both models and View Models
//* FileName:   ILearningResourcePhysicalMedia.cs
//***************************************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.Authorization.Interfaces
{
     /// <summary>
     /// The ILearningResourcePhysicalMedia Interface
     /// </summary>
    public partial interface ILearningResourcePhysicalMedia : IAutobahnBase
    {
        /// <summary>
        /// A type of physical media on which the Learning Resource is delivered or available.
        /// </summary>
        Guid LearningResourceId { get; set; }

        /// <summary>
        /// A type of physical media on which the Learning Resource is delivered or available.
        /// </summary>
        Guid RefLearningResourcePhysicalMediaTypeId { get; set; }

    }
}
