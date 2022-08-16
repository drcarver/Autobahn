//**********************************************************
//* DomainName: Learning Resources
//* FileName:   LearningResourceAdaptationModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.Models;

namespace Autobahn.LearningResources.Models
{
     /// <summary>
     /// The LearningResourceAdaptation Model
     /// </summary>
    public partial class LearningResourceAdaptationModel : AutobahnBase, Interfaces.ILearningResourceAdaptation
    {
        /// <summary>
        /// 
        /// </summary>
        public Guid? AdaptationURL { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  RecordEndDateTime { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  RecordStartDateTime { get; set; }

    }
}
