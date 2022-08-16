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
        /// 
        /// </summary>
        public  RecordEndDateTime { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  RecordStartDateTime { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public Guid? RefEducationLevelId { get; set; }

    }
}
