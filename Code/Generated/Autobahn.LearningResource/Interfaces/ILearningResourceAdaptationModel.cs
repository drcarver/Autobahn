//**********************************************************
//* DomainName: Autobahn.LearningResource
//* FileName:   ILearningResourceAdaptationModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.LearningResource.Interfaces
{
     /// <summary>
     /// The ILearningResourceAdaptationModel Interface
     /// </summary>
    public partial interface ILearningResourceAdaptationModel : IAutobahnBase
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="LearningResource"/> model
        /// </summary>
        Guid LearningResourceId { get; set; }

        /// <summary>
        /// Defines the LearningResourceAdaptation.AdaptationURL non nullable property
        /// </summary>
        System.String AdaptationURL { get; set; }

    }
}
