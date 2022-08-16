//**********************************************************
//* DomainName: Postsecondary (PS)
//* FileName:   PsStudentApplicationModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.Models;

namespace Autobahn.Postsecondary.Models
{
     /// <summary>
     /// The PsStudentApplication Model
     /// </summary>
    public partial class PsStudentApplicationModel : AutobahnBase, Interfaces.IPsStudentApplication
    {
        /// <summary>
        /// 
        /// </summary>
        public  GradePointAverageCumulative { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  HighSchoolGraduatingClassSize { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  HighSchoolPercentile { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public Guid? HighSchoolStudentClassRank { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  PostsecondaryApplicant { get; set; }

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
        public  RefAdmittedStudentId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  RefGpaWeightedIndicatorId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  RefGradePointAverageDomainId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  WaitListedStudent { get; set; }

    }
}
