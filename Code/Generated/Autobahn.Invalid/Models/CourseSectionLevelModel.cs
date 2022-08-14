//**********************************************************
//* DomainName: Invalid or Unreferenced Models
//* FileName:   CourseSectionLevelModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.Models;

namespace Autobahn.Invalid.Models
{
     /// <summary>
     /// The CourseSectionLevel Model
     /// </summary>
    public partial class CourseSectionLevelModel : AutobahnBase, Interfaces.ICourseSectionLevel
    {
        /// <summary>
        /// The level of work which is reflected in the credits associated with the academic course being described or the level of the typical individual taking the academic course.
        /// </summary>
        public Guid CourseSectionId { get; set; }

        /// <summary>
        /// The level of work which is reflected in the credits associated with the academic course being described or the level of the typical individual taking the academic course.
        /// </summary>
        public Guid RefCourseLevelTypeId { get; set; }

    }
}
