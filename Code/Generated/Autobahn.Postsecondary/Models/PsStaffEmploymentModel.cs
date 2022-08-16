//**********************************************************
//* DomainName: Postsecondary (PS)
//* FileName:   PsStaffEmploymentModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.Models;

namespace Autobahn.Postsecondary.Models
{
     /// <summary>
     /// The PsStaffEmployment Model
     /// </summary>
    public partial class PsStaffEmploymentModel : AutobahnBase, Interfaces.IPsStaffEmployment
    {
        /// <summary>
        /// 
        /// </summary>
        public  AnnualBaseContractualSalary { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  FacultyStatus { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  GraduateAssistantStatus { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  InstructionalStaffStatus { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  MedicalSchoolStaffStatus { get; set; }

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
        public  RefAcademicRankId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  RefEmploymentContractTypeId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  RefFullTimeStatusId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  RefGraduateAssistantIpedsCategoryId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  RefInstructionalStaffContractLengthId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  RefInstructionalStaffFacultyTenureId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  RefInstructionCreditTypeId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public Guid? RefIpedsOccupationalCategoryId { get; set; }

    }
}
