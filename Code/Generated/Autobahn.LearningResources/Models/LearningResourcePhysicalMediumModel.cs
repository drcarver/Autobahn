//**********************************************************
//* DomainName: Learning Resources
//* FileName:   LearningResourcePhysicalMediumModel.cs
//***************************************************************************

using Autobahn.Interfaces.LearningResources;
using Autobahn.Interfaces.Common;
using Autobahn.Common.Models;

namespace Autobahn.LearningResources.Models
{
     /// <summary>
     /// The LearningResourcePhysicalMedium Model
     /// </summary>
    public partial class LearningResourcePhysicalMediumModel : AutobahnBase, ILearningResourcePhysicalMedium
    {
        /// <summary>
        /// Reference to an optional instance of the <see cref="ILearningResource"/> model
        /// </summary>
        public Guid LearningResourceId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="ILearningResourcePhysicalMedia"/> model
        /// </summary>
        public Guid LearningResourcePhysicalMediaId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefLearningResourcePhysicalMediaType"/> model
        /// </summary>
        public Guid RefLearningResourcePhysicalMediaTypeId { get; set; }

    }
}
