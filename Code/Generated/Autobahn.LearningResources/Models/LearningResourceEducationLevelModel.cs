//**********************************************************
//* DomainName: Learning Resources
//* FileName:   LearningResourceEducationLevelModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.Models;

namespace Autobahn.LearningResources.Models
{
     /// <summary>
     /// The LearningResourceEducationLevel Model
     /// </summary>
    public partial class LearningResourceEducationLevelModel : AutobahnBase, Interfaces.ILearningResourceEducationLevel
    {
        /// <summary>
        /// The education level, grade level or primary instructional level at which a Learning Resource is intended.
        /// </summary>
        public Guid LearningResourceId { get; set; }

        /// <summary>
        /// The education level, grade level or primary instructional level at which a Learning Resource is intended.
        /// </summary>
        public Guid RefEducationLevelId { get; set; }

    }
}
