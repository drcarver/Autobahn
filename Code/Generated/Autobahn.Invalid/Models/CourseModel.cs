//**********************************************************
//* DomainName: Invalid or Unreferenced Models
//* FileName:   CourseModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.Models;

namespace Autobahn.Invalid.Models
{
     /// <summary>
     /// The Course Model
     /// </summary>
    public partial class CourseModel : AutobahnBase, Interfaces.ICourse
    {
        /// <summary>
        /// 
        /// </summary>
        public  CertificationDescription { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  CreditValue { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  Description { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  InstructionalMinutes { get; set; }

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
        public  RefCourseApplicableEducationLevelId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public Guid? RefCourseCreditUnitId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  RefCourseLevelCharacteristicsId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  RefInstructionLanguageId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  RepeatabilityMaximumNumber { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  SCEDSequenceOfCourse { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  SubjectAbbreviation { get; set; }

    }
}
