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
        /// The Integrated Postsecondary Education Data System (IPEDS) occupational categories used to report employees.
        /// </summary>
        public System.Decimal? AnnualBaseContractualSalary { get; set; }

        /// <summary>
        /// The Integrated Postsecondary Education Data System (IPEDS) occupational categories used to report employees.
        /// </summary>
        public System.Boolean? FacultyStatus { get; set; }

        /// <summary>
        /// The Integrated Postsecondary Education Data System (IPEDS) occupational categories used to report employees.
        /// </summary>
        public System.Boolean? GraduateAssistantStatus { get; set; }

        /// <summary>
        /// The Integrated Postsecondary Education Data System (IPEDS) occupational categories used to report employees.
        /// </summary>
        public System.Boolean? InstructionalStaffStatus { get; set; }

        /// <summary>
        /// The Integrated Postsecondary Education Data System (IPEDS) occupational categories used to report employees.
        /// </summary>
        public System.Boolean? MedicalSchoolStaffStatus { get; set; }

        /// <summary>
        /// The Integrated Postsecondary Education Data System (IPEDS) occupational categories used to report employees.
        /// </summary>
        public Guid? RefAcademicRankId { get; set; }

        /// <summary>
        /// The Integrated Postsecondary Education Data System (IPEDS) occupational categories used to report employees.
        /// </summary>
        public Guid? RefEmploymentContractTypeId { get; set; }

        /// <summary>
        /// The Integrated Postsecondary Education Data System (IPEDS) occupational categories used to report employees.
        /// </summary>
        public Guid? RefFullTimeStatusId { get; set; }

        /// <summary>
        /// The Integrated Postsecondary Education Data System (IPEDS) occupational categories used to report employees.
        /// </summary>
        public Guid? RefGraduateAssistantIpedsCategoryId { get; set; }

        /// <summary>
        /// The Integrated Postsecondary Education Data System (IPEDS) occupational categories used to report employees.
        /// </summary>
        public Guid? RefInstructionalStaffContractLengthId { get; set; }

        /// <summary>
        /// The Integrated Postsecondary Education Data System (IPEDS) occupational categories used to report employees.
        /// </summary>
        public Guid? RefInstructionalStaffFacultyTenureId { get; set; }

        /// <summary>
        /// The Integrated Postsecondary Education Data System (IPEDS) occupational categories used to report employees.
        /// </summary>
        public Guid? RefInstructionCreditTypeId { get; set; }

        /// <summary>
        /// The Integrated Postsecondary Education Data System (IPEDS) occupational categories used to report employees.
        /// </summary>
        public Guid? RefIpedsOccupationalCategoryId { get; set; }

        /// <summary>
        /// The Integrated Postsecondary Education Data System (IPEDS) occupational categories used to report employees.
        /// </summary>
        public Guid StaffEmploymentId { get; set; }

    }
}
