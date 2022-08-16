//**********************************************************
//* DomainName: Invalid or Unreferenced Models
//* FileName:   LocationModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.Models;

namespace Autobahn.Invalid.Models
{
     /// <summary>
     /// The Location Model
     /// </summary>
    public partial class LocationModel : AutobahnBase, Interfaces.ILocation
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
