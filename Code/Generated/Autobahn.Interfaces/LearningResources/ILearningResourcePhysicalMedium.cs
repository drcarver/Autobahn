//***************************************************************************
//* DomainName: Learning Resources Interfaces (used by both models and View Models
//* FileName:   ILearningResourcePhysicalMedium.cs
//***************************************************************************

using Autobahn.Interfaces.Common;

namespace Autobahn.Interfaces.LearningResources
{
     /// <summary>
     /// The ILearningResourcePhysicalMedium Interface
     /// </summary>
    public partial interface ILearningResourcePhysicalMedium : IAutobahnBase
    {
        /// <summary>
        /// Reference to an optional instance of the <see cref="ILearningResource"/> model
        /// </summary>
        Guid LearningResourceId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="ILearningResourcePhysicalMedia"/> model
        /// </summary>
        Guid LearningResourcePhysicalMediaId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefLearningResourcePhysicalMediaType"/> model
        /// </summary>
        Guid RefLearningResourcePhysicalMediaTypeId { get; set; }

    }
}
