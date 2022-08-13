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
        /// The Integrated Postsecondary Education Data System (IPEDS) occupational categories used to report employees.
        /// </summary>
        System.Decimal? AnnualBaseContractualSalary { get; set; }

        /// <summary>
        /// The Integrated Postsecondary Education Data System (IPEDS) occupational categories used to report employees.
        /// </summary>
        System.Boolean? FacultyStatus { get; set; }

        /// <summary>
        /// The Integrated Postsecondary Education Data System (IPEDS) occupational categories used to report employees.
        /// </summary>
        System.Boolean? GraduateAssistantStatus { get; set; }

        /// <summary>
        /// The Integrated Postsecondary Education Data System (IPEDS) occupational categories used to report employees.
        /// </summary>
        System.Boolean? InstructionalStaffStatus { get; set; }

        /// <summary>
        /// The Integrated Postsecondary Education Data System (IPEDS) occupational categories used to report employees.
        /// </summary>
        System.Boolean? MedicalSchoolStaffStatus { get; set; }

        /// <summary>
        /// The Integrated Postsecondary Education Data System (IPEDS) occupational categories used to report employees.
        /// </summary>
        Guid? RefAcademicRankId { get; set; }

        /// <summary>
        /// The Integrated Postsecondary Education Data System (IPEDS) occupational categories used to report employees.
        /// </summary>
        Guid? RefEmploymentContractTypeId { get; set; }

        /// <summary>
        /// The Integrated Postsecondary Education Data System (IPEDS) occupational categories used to report employees.
        /// </summary>
        Guid? RefFullTimeStatusId { get; set; }

        /// <summary>
        /// The Integrated Postsecondary Education Data System (IPEDS) occupational categories used to report employees.
        /// </summary>
        Guid? RefGraduateAssistantIpedsCategoryId { get; set; }

        /// <summary>
        /// The Integrated Postsecondary Education Data System (IPEDS) occupational categories used to report employees.
        /// </summary>
        Guid? RefInstructionalStaffContractLengthId { get; set; }

        /// <summary>
        /// The Integrated Postsecondary Education Data System (IPEDS) occupational categories used to report employees.
        /// </summary>
        Guid? RefInstructionalStaffFacultyTenureId { get; set; }

        /// <summary>
        /// The Integrated Postsecondary Education Data System (IPEDS) occupational categories used to report employees.
        /// </summary>
        Guid? RefInstructionCreditTypeId { get; set; }

        /// <summary>
        /// The Integrated Postsecondary Education Data System (IPEDS) occupational categories used to report employees.
        /// </summary>
        Guid? RefIpedsOccupationalCategoryId { get; set; }

        /// <summary>
        /// The Integrated Postsecondary Education Data System (IPEDS) occupational categories used to report employees.
        /// </summary>
        Guid StaffEmploymentId { get; set; }

    }
}
