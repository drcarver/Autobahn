//**********************************************************
//* DomainName: Assessments
//* FileName:   LearnerActivityLearningResourceModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.Models;

namespace Autobahn.Assessments.Models
{
     /// <summary>
     /// The LearnerActivityLearningResource Model
     /// </summary>
    public partial class LearnerActivityLearningResourceModel : AutobahnBase, Interfaces.ILearnerActivityLearningResource
    {
        /// <summary>
        /// 
        /// </summary>
        public  RecordEndDateTime { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public Guid? RecordStartDateTime { get; set; }

    }
}
