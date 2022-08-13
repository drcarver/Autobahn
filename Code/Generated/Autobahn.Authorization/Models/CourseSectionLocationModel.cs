//**********************************************************
//* DomainName: Authentication and Authorization
//* FileName:   CourseSectionLocationModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.Models;

namespace Autobahn.Authorization.Models
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

        /// <summary>
        /// A unique number or alphanumeric code assigned to a room by a school, school system, state, or other agency or entity.
        /// </summary>
        public Guid CourseSectionId { get; set; }

        /// <summary>
        /// A unique number or alphanumeric code assigned to a room by a school, school system, state, or other agency or entity.
        /// </summary>
        public Guid? RefInstructionLocationTypeId { get; set; }

    }
}
