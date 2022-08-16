//**********************************************************
//* DomainName: Postsecondary (PS)
//* FileName:   PsCourseModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.Models;

namespace Autobahn.Postsecondary.Models
{
     /// <summary>
     /// The PsCourse Model
     /// </summary>
    public partial class PsCourseModel : AutobahnBase, Interfaces.IPsCourse
    {
        /// <summary>
        /// 
        /// </summary>
        public  CourseNumber { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  NCAAEligibilityInd { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  OriginalCourseIdentifier { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  OverrideSchoolCourseNumber { get; set; }

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
        public Guid? RefCipCodeId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  RefCourseCreditBasisTypeId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  RefCourseCreditLevelTypeId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  RefNCESCollegeCourseMapCodeId { get; set; }

    }
}
