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
        public Guid? RefCourseLevelTypeId { get; set; }

    }
}