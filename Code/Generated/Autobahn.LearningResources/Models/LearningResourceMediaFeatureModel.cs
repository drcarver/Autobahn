//**********************************************************
//* DomainName: Learning Resources
//* FileName:   LearningResourceMediaFeatureModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.Models;

namespace Autobahn.LearningResources.Models
{
     /// <summary>
     /// The LearningResourceMediaFeature Model
     /// </summary>
    public partial class LearningResourceMediaFeatureModel : AutobahnBase, Interfaces.ILearningResourceMediaFeature
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
        public Guid? RefLearningResourceMediaFeatureTypeId { get; set; }

    }
}
