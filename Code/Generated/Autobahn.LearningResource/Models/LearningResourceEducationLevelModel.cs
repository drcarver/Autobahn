//**********************************************************
//* DomainName: Autobahn.LearningResource
//* FileName:   LearningResourceEducationLevelModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.Models;

namespace Autobahn.LearningResource.Models
{
     /// <summary>
     /// The LearningResourceEducationLevel Model
     /// </summary>
    public partial class LearningResourceEducationLevelModel : AutobahnBase, Interfaces.ILearningResourceEducationLevelModel
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="LearningResource"/> model
        /// </summary>
        public Guid LearningResourceId { get; set; }

        /// <summary>
        /// Reference to a required instance of the <see cref="RefEducationLevel"/> model
        /// </summary>
        public Guid RefEducationLevelId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="DataCollection"/> model
        /// </summary>
        public Guid? DataCollectionId { get; set; }

    }
}
