//**********************************************************
//* DomainName: Autobahn.Postsecondary
//* FileName:   PsStaffEmployment.cs
//**********************************************************

using Autobahn.Postsecondary.Interfaces;

namespace Autobahn.Postsecondary.Models
{
     /// <summary>
     /// The PsStaffEmployment
     /// </summary>
    public partial class PsStaffEmployment : IPsStaffEmployment
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="StaffEmployment"/> model
        /// </summary>
        public Guid StaffEmploymentId { get; set; }

        /// <summary>
        /// Defines the PsStaffEmployment.FacultyStatus nullable property
        /// </summary>
        public System.Boolean? FacultyStatus { get; set; }

        /// <summary>
        /// Defines the PsStaffEmployment.InstructionalStaffStatus nullable property
        /// </summary>
        public System.Boolean? InstructionalStaffStatus { get; set; }

        /// <summary>
        /// Defines the PsStaffEmployment.MedicalSchoolStaffStatus nullable property
        /// </summary>
        public System.Boolean? MedicalSchoolStaffStatus { get; set; }

        /// <summary>
        /// Defines the PsStaffEmployment.GraduateAssistantStatus nullable property
        /// </summary>
        public System.Boolean? GraduateAssistantStatus { get; set; }

        /// <summary>
        /// Defines the PsStaffEmployment.AnnualBaseContractualSalary nullable property
        /// </summary>
        public System.Decimal? AnnualBaseContractualSalary { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefFullTimeStatus"/> model
        /// </summary>
        public Guid? RefFullTimeStatusId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefEmploymentContractType"/> model
        /// </summary>
        public Guid? RefEmploymentContractTypeId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefIpedsOccupationalCategory"/> model
        /// </summary>
        public Guid? RefIpedsOccupationalCategoryId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefInstructionalStaffContractLength"/> model
        /// </summary>
        public Guid? RefInstructionalStaffContractLengthId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefInstructionalStaffFacultyTenure"/> model
        /// </summary>
        public Guid? RefInstructionalStaffFacultyTenureId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefAcademicRank"/> model
        /// </summary>
        public Guid? RefAcademicRankId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefInstructionCreditType"/> model
        /// </summary>
        public Guid? RefInstructionCreditTypeId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefGraduateAssistantIpedsCategory"/> model
        /// </summary>
        public Guid? RefGraduateAssistantIpedsCategoryId { get; set; }

        /// <summary>
        /// Defines the PsStaffEmployment.RecordStartDateTime nullable property
        /// </summary>
        public System.DateTime? RecordStartDateTime { get; set; }

        /// <summary>
        /// Defines the PsStaffEmployment.RecordEndDateTime nullable property
        /// </summary>
        public System.DateTime? RecordEndDateTime { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RecordStatus"/> model
        /// </summary>
        public Guid? RecordStatusId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="DataCollection"/> model
        /// </summary>
        public Guid? DataCollectionId { get; set; }

    }
}
