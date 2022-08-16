//**********************************************************
//* DomainName: Learning Resources
//* FileName:   LearningResourcePeerRatingModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.Models;

namespace Autobahn.LearningResources.Models
{
     /// <summary>
     /// The LearningResourcePeerRating Model
     /// </summary>
    public partial class LearningResourcePeerRatingModel : AutobahnBase, Interfaces.ILearningResourcePeerRating
    {
        /// <summary>
        /// 
        /// </summary>
        public  Date { get; set; }

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
        public Guid? Value { get; set; }

    }
}