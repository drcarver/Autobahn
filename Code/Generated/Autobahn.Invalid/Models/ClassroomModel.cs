//**********************************************************
//* DomainName: Invalid or Unreferenced Models
//* FileName:   ClassroomModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.Models;

namespace Autobahn.Invalid.Models
{
     /// <summary>
     /// The Classroom Model
     /// </summary>
    public partial class ClassroomModel : AutobahnBase, Interfaces.IClassroom
    {
        /// <summary>
        /// 
        /// </summary>
        public Guid? ClassroomIdentifier { get; set; }

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
