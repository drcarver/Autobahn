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
        /// 
        /// </summary>
        public Guid? ClassroomId { get; set; }

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
        public  RefInstructionLocationTypeId { get; set; }

    }
}
