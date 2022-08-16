//**********************************************************
//* DomainName: Invalid or Unreferenced Models
//* FileName:   ActivityModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.Models;

namespace Autobahn.Invalid.Models
{
     /// <summary>
     /// The Activity Model
     /// </summary>
    public partial class ActivityModel : AutobahnBase, Interfaces.IActivity
    {
        /// <summary>
        /// 
        /// </summary>
        public Guid? ActivityDescription { get; set; }

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
