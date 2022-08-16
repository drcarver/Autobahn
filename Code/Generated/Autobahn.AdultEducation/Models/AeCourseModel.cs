//**********************************************************
//* DomainName: Adult Education (AE)
//* FileName:   AeCourseModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.Models;

namespace Autobahn.AdultEducation.Models
{
     /// <summary>
     /// The AeCourse Model
     /// </summary>
    public partial class AeCourseModel : AutobahnBase, Interfaces.IAeCourse
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
        public Guid? RefCareerClusterId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  RefCourseLevelTypeId { get; set; }

    }
}
