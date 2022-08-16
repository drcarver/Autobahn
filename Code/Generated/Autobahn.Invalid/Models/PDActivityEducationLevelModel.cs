//**********************************************************
//* DomainName: Invalid or Unreferenced Models
//* FileName:   PDActivityEducationLevelModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.Models;

namespace Autobahn.Invalid.Models
{
     /// <summary>
     /// The PDActivityEducationLevel Model
     /// </summary>
    public partial class PDActivityEducationLevelModel : AutobahnBase, Interfaces.IPDActivityEducationLevel
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
        public Guid? RefPDActivityEducationLevelsAddressedId { get; set; }

    }
}
