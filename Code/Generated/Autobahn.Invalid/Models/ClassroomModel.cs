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
        /// A unique number or alphanumeric code assigned to a room by a school, school system, state, or other agency or entity.
        /// </summary>
        public System.String ClassroomIdentifier { get; set; }

    }
}
