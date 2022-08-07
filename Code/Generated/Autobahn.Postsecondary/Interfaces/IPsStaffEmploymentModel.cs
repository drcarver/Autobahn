//**********************************************************
//* DomainName: Autobahn.Postsecondary
//* FileName:   IPsStaffEmploymentModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.Postsecondary.Interfaces
{
     /// <summary>
     /// The IPsStaffEmploymentModel Interface
     /// </summary>
    public partial interface IPsStaffEmploymentModel : IAutobahnBase
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="StaffEmployment"/> model
        /// </summary>
        Guid StaffEmploymentId { get; set; }

        /// <summary>
        /// Defines the PsStaffEmployment.FacultyStatus nullable property
        /// </summary>
        System.Boolean? FacultyStatus { get; set; }

        /// <summary>
        /// Defines the PsStaffEmployment.InstructionalStaffStatus nullable property
        /// </summary>
        System.Boolean? InstructionalStaffStatus { get; set; }

        /// <summary>
        /// Defines the PsStaffEmployment.MedicalSchoolStaffStatus nullable property
        /// </summary>
        System.Boolean? MedicalSchoolStaffStatus { get; set; }

        /// <summary>
        /// Defines the PsStaffEmployment.GraduateAssistantStatus nullable property
        /// </summary>
        System.Boolean? GraduateAssistantStatus { get; set; }

        /// <summary>
        /// Defines the PsStaffEmployment.AnnualBaseContractualSalary nullable property
        /// </summary>
        System.Decimal? AnnualBaseContractualSalary { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefFullTimeStatus"/> model
        /// </summary>
        Guid? RefFullTimeStatusId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefEmploymentContractType"/> model
        /// </summary>
        Guid? RefEmploymentContractTypeId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefIpedsOccupationalCategory"/> model
        /// </summary>
        Guid? RefIpedsOccupationalCategoryId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefInstructionalStaffContractLength"/> model
        /// </summary>
        Guid? RefInstructionalStaffContractLengthId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefInstructionalStaffFacultyTenure"/> model
        /// </summary>
        Guid? RefInstructionalStaffFacultyTenureId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefAcademicRank"/> model
        /// </summary>
        Guid? RefAcademicRankId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefInstructionCreditType"/> model
        /// </summary>
        Guid? RefInstructionCreditTypeId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefGraduateAssistantIpedsCategory"/> model
        /// </summary>
        Guid? RefGraduateAssistantIpedsCategoryId { get; set; }

    }
}
