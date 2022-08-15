//**********************************************************
//* DomainName: Invalid or Unreferenced Models
//* FileName:   CourseSectionLocationModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.Models;

namespace Autobahn.Invalid.Models
{
     /// <summary>
     /// The CourseSectionLocation Model
     /// </summary>
    public partial class CourseSectionLocationModel : AutobahnBase, Interfaces.ICourseSectionLocation
    {
        /// <summary>
        /// A unique number or alphanumeric code assigned to a room by a school, school system, state, or other agency or entity.
        /// </summary>
        public Guid ClassroomId { get; set; }

    }
}
