//***************************************************************************
//* DomainName: Postsecondary (PS) Interfaces (used by both models and View Models
//* FileName:   IPsStaffEmployment.cs
//***************************************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.Postsecondary.Interfaces
{
     /// <summary>
     /// The IPsStaffEmployment Interface
     /// </summary>
    public partial interface IPsStaffEmployment : IAutobahnBase
    {
        /// <summary>
        /// 
        /// </summary>
         AnnualBaseContractualSalary { get; set; }

        /// <summary>
        /// 
        /// </summary>
         FacultyStatus { get; set; }

        /// <summary>
        /// 
        /// </summary>
         GraduateAssistantStatus { get; set; }

        /// <summary>
        /// 
        /// </summary>
         InstructionalStaffStatus { get; set; }

        /// <summary>
        /// 
        /// </summary>
         MedicalSchoolStaffStatus { get; set; }

        /// <summary>
        /// 
        /// </summary>
         RecordEndDateTime { get; set; }

        /// <summary>
        /// 
        /// </summary>
         RecordStartDateTime { get; set; }

        /// <summary>
        /// 
        /// </summary>
         RefAcademicRankId { get; set; }

        /// <summary>
        /// 
        /// </summary>
         RefEmploymentContractTypeId { get; set; }

        /// <summary>
        /// 
        /// </summary>
         RefFullTimeStatusId { get; set; }

        /// <summary>
        /// 
        /// </summary>
         RefGraduateAssistantIpedsCategoryId { get; set; }

        /// <summary>
        /// 
        /// </summary>
         RefInstructionalStaffContractLengthId { get; set; }

        /// <summary>
        /// 
        /// </summary>
         RefInstructionalStaffFacultyTenureId { get; set; }

        /// <summary>
        /// 
        /// </summary>
         RefInstructionCreditTypeId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        Guid? RefIpedsOccupationalCategoryId { get; set; }

    }
}
