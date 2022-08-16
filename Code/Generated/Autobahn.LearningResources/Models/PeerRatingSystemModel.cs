//**********************************************************
//* DomainName: Learning Resources
//* FileName:   PeerRatingSystemModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.Models;

namespace Autobahn.LearningResources.Models
{
     /// <summary>
     /// The PeerRatingSystem Model
     /// </summary>
    public partial class PeerRatingSystemModel : AutobahnBase, Interfaces.IPeerRatingSystem
    {
        /// <summary>
        /// 
        /// </summary>
        public  MaximumValue { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  MinimumValue { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public Guid? Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  OptimumValue { get; set; }

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
