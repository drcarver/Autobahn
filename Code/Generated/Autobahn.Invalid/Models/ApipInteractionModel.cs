//**********************************************************
//* DomainName: Invalid or Unreferenced Models
//* FileName:   ApipInteractionModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.Models;

namespace Autobahn.Invalid.Models
{
     /// <summary>
     /// The ApipInteraction Model
     /// </summary>
    public partial class ApipInteractionModel : AutobahnBase, Interfaces.IApipInteraction
    {
        /// <summary>
        /// 
        /// </summary>
        public  APIPInteractionSequenceNumber { get; set; }

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
        public  RefApipInteractionTypeId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public Guid? Xml { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  XML { get; set; }

    }
}
