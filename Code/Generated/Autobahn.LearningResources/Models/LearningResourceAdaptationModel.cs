//**********************************************************
//* DomainName: Learning Resources
//* FileName:   LearningResourceAdaptationModel.cs
//***************************************************************************

using Autobahn.Interfaces.LearningResources;
using Autobahn.Interfaces.Common;
using Autobahn.Common.Models;

namespace Autobahn.LearningResources.Models
{
     /// <summary>
     /// The LearningResourceAdaptation Model
     /// </summary>
    public partial class LearningResourceAdaptationModel : AutobahnBase, ILearningResourceAdaptation
    {
        public System.String AdaptationUrl { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="ILearningResource"/> model
        /// </summary>
        public Guid LearningResourceId { get; set; }

    }
}
