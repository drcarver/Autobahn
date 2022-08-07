//**********************************************************
//* DomainName: Autobahn.LearningResource
//* FileName:   ILearningResourcePhysicalMediaModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.LearningResource.Interfaces
{
     /// <summary>
     /// The ILearningResourcePhysicalMediaModel Interface
     /// </summary>
    public partial interface ILearningResourcePhysicalMediaModel : IAutobahnBase
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="LearningResource"/> model
        /// </summary>
        Guid LearningResourceId { get; set; }

        /// <summary>
        /// Reference to a required instance of the <see cref="RefLearningResourcePhysicalMediaType"/> model
        /// </summary>
        Guid RefLearningResourcePhysicalMediaTypeId { get; set; }

    }
}
