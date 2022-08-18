//**********************************************************
//* DomainName: Postsecondary (PS)
//* FileName:   PsStaffEmploymentViewModel.cs
//* Name:       Annual Base Contractual Salary
//* Definition: The total annual base contractual salary of a person.
//***************************************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.ViewModels;

using Autobahn.Common.Models;
using System.ComponentModel;
using System.Windows.Input;

namespace Autobahn.Postsecondary.ViewModels
{
     /// <summary>
     /// The total annual base contractual salary of a person.
     /// </summary>
    public partial class PsStaffEmploymentViewModel : ViewModelBase, Interfaces.IPsStaffEmployment
    {
        #region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from PsStaffEmployment";

        // AnnualBaseContractualSalary -- (backing property for Annual Base Contractual Salary)
        private System.Decimal? _AnnualBaseContractualSalary;

        // FacultyStatus -- (backing property for Faculty Status)
        private System.Boolean? _FacultyStatus;

        // GraduateAssistantStatus -- (backing property for Graduate Assistant Status)
        private System.Boolean? _GraduateAssistantStatus;

        // InstructionalStaffStatus -- (backing property for Instructional Staff Status)
        private System.Boolean? _InstructionalStaffStatus;

        // MedicalSchoolStaffStatus -- (backing property for Medical School Staff Status)
        private System.Boolean? _MedicalSchoolStaffStatus;

        // RefAcademicRankId -- (backing property for Academic Rank)
        private Guid? _RefAcademicRankId;

        // RefEmploymentContractTypeId -- (backing property for Contract Type)
        private Guid? _RefEmploymentContractTypeId;

        // RefFullTimeStatusId -- (backing property for Full-time Status)
        private Guid? _RefFullTimeStatusId;

        // RefGraduateAssistantIpedsCategoryId -- (backing property for Graduate Assistant IPEDS Occupation Category)
        private Guid? _RefGraduateAssistantIpedsCategoryId;

        // RefInstructionalStaffContractLengthId -- (backing property for Instructional Staff Contract Length)
        private Guid? _RefInstructionalStaffContractLengthId;

        // RefInstructionalStaffFacultyTenureId -- (backing property for Instructional Staff Faculty Tenure Status)
        private Guid? _RefInstructionalStaffFacultyTenureId;

        // RefInstructionCreditTypeId -- (backing property for Instruction Credit Type)
        private Guid? _RefInstructionCreditTypeId;

        // RefIpedsOccupationalCategoryId -- (backing property for IPEDS Occupational Category)
        private Guid? _RefIpedsOccupationalCategoryId;

        // member variable for the StaffEmploymentId property
        private Guid _StaffEmploymentId;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the View Model
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// Annual Base Contractual Salary
        /// <para>
        /// The total annual base contractual salary of a person.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19722">Annual Base Contractual Salary</a>
        /// </para>
        /// </summary>
        /// </summary>
        public System.Decimal? AnnualBaseContractualSalary { get => _AnnualBaseContractualSalary; set => SetProperty(ref _AnnualBaseContractualSalary, value); }

        /// <summary>
        /// Faculty Status
        /// <para>
        /// Persons identified by the institution as such and typically those whose initial assignments are made for the purpose of conducting instruction, research or public service as a principal activity (or activities). They may hold academic rank titles of professor, associate professor, assistant professor, instructor, lecturer or the equivalent of any of those academic ranks. Faculty may also include the chancellor/president, provost, vice provosts, deans, directors or the equivalent, as well as associate deans, assistant deans and executive officers of academic departments (chairpersons, heads or the equivalent) if their principal activity is instruction combined with research and/or public service. The designation as "faculty" is separate from the activities to which they may be currently assigned. For example, a newly appointed president of an institution may also be appointed as a faculty member. Graduate, instruction, and research assistants are not included in this category.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19711">Faculty Status</a>
        /// </para>
        /// </summary>
        /// </summary>
        public System.Boolean? FacultyStatus { get => _FacultyStatus; set => SetProperty(ref _FacultyStatus, value); }

        /// <summary>
        /// Graduate Assistant Status
        /// <para>
        /// Graduate-level students employed on a part-time basis, not limited to, but often employed for the primary purpose of assisting in classroom or laboratory instruction or in the conduct of research.  Graduate students having titles such as graduate assistant, teaching assistant, teaching associate, teaching fellow, or research assistant typically hold these positions.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19720">Graduate Assistant Status</a>
        /// </para>
        /// </summary>
        /// </summary>
        public System.Boolean? GraduateAssistantStatus { get => _GraduateAssistantStatus; set => SetProperty(ref _GraduateAssistantStatus, value); }

        /// <summary>
        /// Instructional Staff Status
        /// <para>
        /// Staff whose primary function/occupational activity is primarily instruction or instruction combined with research and/or public service.  Does not include medical school staff.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19709">Instructional Staff Status</a>
        /// </para>
        /// </summary>
        /// </summary>
        public System.Boolean? InstructionalStaffStatus { get => _InstructionalStaffStatus; set => SetProperty(ref _InstructionalStaffStatus, value); }

        /// <summary>
        /// Medical School Staff Status
        /// <para>
        /// Staff employed by or employees working in the medical school component of a postsecondary institution or in a free standing medical school.  Does not include staff employed by or employees working strictly in a hospital associated with a medical school or those who work in health or allied health schools or departments such as dentistry, veterinary medicine, nursing or dental hygiene.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19710">Medical School Staff Status</a>
        /// </para>
        /// </summary>
        /// </summary>
        public System.Boolean? MedicalSchoolStaffStatus { get => _MedicalSchoolStaffStatus; set => SetProperty(ref _MedicalSchoolStaffStatus, value); }

        /// <summary>
        /// Academic Rank
        /// <para>
        /// The academic rank of staff whose primary responsibility is instruction, research, and/or public service.  Institutions without standard academic ranks should code staff whose primary responsibility is instruction, research, and/or public service as "No Academic Rank."
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19717">Academic Rank</a>
        /// </para>
        /// </summary>
        /// </summary>
        public Guid? RefAcademicRankId { get => _RefAcademicRankId; set => SetProperty(ref _RefAcademicRankId, value); }

        /// <summary>
        /// Contract Type
        /// <para>
        /// The type of employment contract used by an institution.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19714">Contract Type</a>
        /// </para>
        /// </summary>
        /// </summary>
        public Guid? RefEmploymentContractTypeId { get => _RefEmploymentContractTypeId; set => SetProperty(ref _RefEmploymentContractTypeId, value); }

        /// <summary>
        /// Full-time Status
        /// <para>
        /// An indication of whether an individual is employed for a standard number of hours (as determined by civil or organizational policies) in a week, month, or other period of time.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19713">Full-time Status</a>
        /// </para>
        /// </summary>
        /// </summary>
        public Guid? RefFullTimeStatusId { get => _RefFullTimeStatusId; set => SetProperty(ref _RefFullTimeStatusId, value); }

        /// <summary>
        /// Graduate Assistant IPEDS Occupation Category
        /// <para>
        /// The Integrated Postsecondary Education Data System (IPEDS) occupational categories used to report graduate assistants.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19721">Graduate Assistant IPEDS Occupation Category</a>
        /// </para>
        /// </summary>
        /// </summary>
        public Guid? RefGraduateAssistantIpedsCategoryId { get => _RefGraduateAssistantIpedsCategoryId; set => SetProperty(ref _RefGraduateAssistantIpedsCategoryId, value); }

        /// <summary>
        /// Instructional Staff Contract Length
        /// <para>
        /// The contracted teaching period for faculty.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19712">Instructional Staff Contract Length</a>
        /// </para>
        /// </summary>
        /// </summary>
        public Guid? RefInstructionalStaffContractLengthId { get => _RefInstructionalStaffContractLengthId; set => SetProperty(ref _RefInstructionalStaffContractLengthId, value); }

        /// <summary>
        /// Instructional Staff Faculty Tenure Status
        /// <para>
        /// An indicator of the type of faculty status a person has if, by institutional definition, a staff member has faculty status.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19716">Instructional Staff Faculty Tenure Status</a>
        /// </para>
        /// </summary>
        /// </summary>
        public Guid? RefInstructionalStaffFacultyTenureId { get => _RefInstructionalStaffFacultyTenureId; set => SetProperty(ref _RefInstructionalStaffFacultyTenureId, value); }

        /// <summary>
        /// Instruction Credit Type
        /// <para>
        /// A designation of the type(s) of instruction being delivered by staff whose primary responsibility is instruction.  Instruction that is for "credit" can be applied toward the requirements for a postsecondary degree, diploma, certificate or other formal award.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19719">Instruction Credit Type</a>
        /// </para>
        /// </summary>
        /// </summary>
        public Guid? RefInstructionCreditTypeId { get => _RefInstructionCreditTypeId; set => SetProperty(ref _RefInstructionCreditTypeId, value); }

        /// <summary>
        /// IPEDS Occupational Category
        /// <para>
        /// The Integrated Postsecondary Education Data System (IPEDS) occupational categories used to report employees.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19708">IPEDS Occupational Category</a>
        /// </para>
        /// </summary>
        /// </summary>
        public Guid? RefIpedsOccupationalCategoryId { get => _RefIpedsOccupationalCategoryId; set => SetProperty(ref _RefIpedsOccupationalCategoryId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IStaffEmployment"/> model
        /// </summary>
        public Guid StaffEmploymentId { get => _StaffEmploymentId; set => SetProperty(ref _StaffEmploymentId, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IPsStaffEmployment model)
        {
            IsBusy = true;
            Id = model.Id;
            AnnualBaseContractualSalary = model.AnnualBaseContractualSalary; // Annual Base Contractual Salary
            FacultyStatus = model.FacultyStatus; // Faculty Status
            GraduateAssistantStatus = model.GraduateAssistantStatus; // Graduate Assistant Status
            InstructionalStaffStatus = model.InstructionalStaffStatus; // Instructional Staff Status
            MedicalSchoolStaffStatus = model.MedicalSchoolStaffStatus; // Medical School Staff Status
            RefAcademicRankId = model.RefAcademicRankId; // Academic Rank
            RefEmploymentContractTypeId = model.RefEmploymentContractTypeId; // Contract Type
            RefFullTimeStatusId = model.RefFullTimeStatusId; // Full-time Status
            RefGraduateAssistantIpedsCategoryId = model.RefGraduateAssistantIpedsCategoryId; // Graduate Assistant IPEDS Occupation Category
            RefInstructionalStaffContractLengthId = model.RefInstructionalStaffContractLengthId; // Instructional Staff Contract Length
            RefInstructionalStaffFacultyTenureId = model.RefInstructionalStaffFacultyTenureId; // Instructional Staff Faculty Tenure Status
            RefInstructionCreditTypeId = model.RefInstructionCreditTypeId; // Instruction Credit Type
            RefIpedsOccupationalCategoryId = model.RefIpedsOccupationalCategoryId; // IPEDS Occupational Category
            StaffEmploymentId = model.StaffEmploymentId; // 
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
