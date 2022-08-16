//**********************************************************
//* DomainName: Elementary and Secondary (K12)
//* FileName:   K12StudentGraduationPlanModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.Models;

namespace Autobahn.K12.Models
{
     /// <summary>
     /// The K12StudentGraduationPlan Model
     /// </summary>
    public partial class K12StudentGraduationPlanModel : AutobahnBase, Interfaces.IK12StudentGraduationPlan
    {
        /// <summary>
        /// 
        /// </summary>
        public  CreditsRequired { get; set; }

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
        public Guid? RefGradeLevelWhenCourseTakenId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  RefSCEDCourseSubjectAreaId { get; set; }

    }
}
