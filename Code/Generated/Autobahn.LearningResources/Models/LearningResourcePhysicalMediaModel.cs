//**********************************************************
//* DomainName: Learning Resources
//* FileName:   LearningResourcePhysicalMediaModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.Models;

namespace Autobahn.LearningResources.Models
{
     /// <summary>
     /// The LearningResourcePhysicalMedia Model
     /// </summary>
    public partial class LearningResourcePhysicalMediaModel : AutobahnBase, Interfaces.ILearningResourcePhysicalMedia
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
        public Guid? RefLearningResourcePhysicalMediaTypeId { get; set; }

    }
}
