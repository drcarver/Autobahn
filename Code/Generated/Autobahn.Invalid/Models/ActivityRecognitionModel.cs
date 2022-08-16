//**********************************************************
//* DomainName: Invalid or Unreferenced Models
//* FileName:   ActivityRecognitionModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.Models;

namespace Autobahn.Invalid.Models
{
     /// <summary>
     /// The ActivityRecognition Model
     /// </summary>
    public partial class ActivityRecognitionModel : AutobahnBase, Interfaces.IActivityRecognition
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
        public Guid? RefActivityRecognitionTypeId { get; set; }

    }
}
