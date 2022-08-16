//**********************************************************
//* DomainName: Postsecondary (PS)
//* FileName:   PsStudentAcademicAwardModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.Models;

namespace Autobahn.Postsecondary.Models
{
     /// <summary>
     /// The PsStudentAcademicAward Model
     /// </summary>
    public partial class PsStudentAcademicAwardModel : AutobahnBase, Interfaces.IPsStudentAcademicAward
    {
        /// <summary>
        /// 
        /// </summary>
        public Guid? AcademicAwardDate { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  AcademicAwardTitle { get; set; }

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
        public  RefAcademicAwardLevelId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  RefAcademicAwardPrerequisiteTypeId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  RefPESCAwardLevelTypeId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  RequirementsURL { get; set; }

    }
}
