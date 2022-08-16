//**********************************************************
//* DomainName: Elementary and Secondary (K12)
//* FileName:   K12StudentCourseSectionMarkModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.Models;

namespace Autobahn.K12.Models
{
     /// <summary>
     /// The K12StudentCourseSectionMark Model
     /// </summary>
    public partial class K12StudentCourseSectionMarkModel : AutobahnBase, Interfaces.IK12StudentCourseSectionMark
    {
        /// <summary>
        /// 
        /// </summary>
        public  FinalIndicator { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public Guid? GradeEarned { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  GradeValueQualifier { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  MarkingPeriodName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  MidTermMark { get; set; }

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
        public  StudentCourseSectionGradeNarrative { get; set; }

    }
}
