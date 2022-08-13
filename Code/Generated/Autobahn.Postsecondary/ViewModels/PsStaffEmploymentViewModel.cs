//**********************************************************
//* DomainName: Postsecondary (PS)
//* FileName:   PsStaffEmploymentViewModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.ViewModels;
using CommunityToolkit.Maui;

namespace Autobahn.Postsecondary.ViewModels
{
     /// <summary>
     /// The PsStaffEmploymentViewModel
     /// </summary>
    public partial class PsStaffEmploymentViewModel : ViewModelBase, Interfaces.IPsStaffEmployment
    {
        #region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from PsStaffEmployment";

        // member variable for the AnnualBaseContractualSalary property
        private System.Decimal? _AnnualBaseContractualSalary;

        // member variable for the FacultyStatus property
        private System.Boolean? _FacultyStatus;

        // member variable for the GraduateAssistantStatus property
        private System.Boolean? _GraduateAssistantStatus;

        // member variable for the InstructionalStaffStatus property
        private System.Boolean? _InstructionalStaffStatus;

        // member variable for the MedicalSchoolStaffStatus property
        private System.Boolean? _MedicalSchoolStaffStatus;

        // member variable for the RefAcademicRankId property
        private Guid? _RefAcademicRankId;

        // member variable for the RefEmploymentContractTypeId property
        private Guid? _RefEmploymentContractTypeId;

        // member variable for the RefFullTimeStatusId property
        private Guid? _RefFullTimeStatusId;

        // member variable for the RefGraduateAssistantIpedsCategoryId property
        private Guid? _RefGraduateAssistantIpedsCategoryId;

        // member variable for the RefInstructionalStaffContractLengthId property
        private Guid? _RefInstructionalStaffContractLengthId;

        // member variable for the RefInstructionalStaffFacultyTenureId property
        private Guid? _RefInstructionalStaffFacultyTenureId;

        // member variable for the RefInstructionCreditTypeId property
        private Guid? _RefInstructionCreditTypeId;

        // member variable for the RefIpedsOccupationalCategoryId property
        private Guid? _RefIpedsOccupationalCategoryId;

        // member variable for the StaffEmploymentId property
        private Guid _StaffEmploymentId;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the PsStaffEmploymentViewModel
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// The Integrated Postsecondary Education Data System (IPEDS) occupational categories used to report employees.
        /// </summary>
        public System.Decimal? AnnualBaseContractualSalary { get => _AnnualBaseContractualSalary; set => SetProperty(ref _AnnualBaseContractualSalary, value); }

        /// <summary>
        /// The Integrated Postsecondary Education Data System (IPEDS) occupational categories used to report employees.
        /// </summary>
        public System.Boolean? FacultyStatus { get => _FacultyStatus; set => SetProperty(ref _FacultyStatus, value); }

        /// <summary>
        /// The Integrated Postsecondary Education Data System (IPEDS) occupational categories used to report employees.
        /// </summary>
        public System.Boolean? GraduateAssistantStatus { get => _GraduateAssistantStatus; set => SetProperty(ref _GraduateAssistantStatus, value); }

        /// <summary>
        /// The Integrated Postsecondary Education Data System (IPEDS) occupational categories used to report employees.
        /// </summary>
        public System.Boolean? InstructionalStaffStatus { get => _InstructionalStaffStatus; set => SetProperty(ref _InstructionalStaffStatus, value); }

        /// <summary>
        /// The Integrated Postsecondary Education Data System (IPEDS) occupational categories used to report employees.
        /// </summary>
        public System.Boolean? MedicalSchoolStaffStatus { get => _MedicalSchoolStaffStatus; set => SetProperty(ref _MedicalSchoolStaffStatus, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefAcademicRank"/> model
        /// </summary>
        public Guid? RefAcademicRankId { get => _RefAcademicRankId; set => SetProperty(ref _RefAcademicRankId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefEmploymentContractType"/> model
        /// </summary>
        public Guid? RefEmploymentContractTypeId { get => _RefEmploymentContractTypeId; set => SetProperty(ref _RefEmploymentContractTypeId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefFullTimeStatus"/> model
        /// </summary>
        public Guid? RefFullTimeStatusId { get => _RefFullTimeStatusId; set => SetProperty(ref _RefFullTimeStatusId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefGraduateAssistantIpedsCategory"/> model
        /// </summary>
        public Guid? RefGraduateAssistantIpedsCategoryId { get => _RefGraduateAssistantIpedsCategoryId; set => SetProperty(ref _RefGraduateAssistantIpedsCategoryId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefInstructionalStaffContractLength"/> model
        /// </summary>
        public Guid? RefInstructionalStaffContractLengthId { get => _RefInstructionalStaffContractLengthId; set => SetProperty(ref _RefInstructionalStaffContractLengthId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefInstructionalStaffFacultyTenure"/> model
        /// </summary>
        public Guid? RefInstructionalStaffFacultyTenureId { get => _RefInstructionalStaffFacultyTenureId; set => SetProperty(ref _RefInstructionalStaffFacultyTenureId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefInstructionCreditType"/> model
        /// </summary>
        public Guid? RefInstructionCreditTypeId { get => _RefInstructionCreditTypeId; set => SetProperty(ref _RefInstructionCreditTypeId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefIpedsOccupationalCategory"/> model
        /// </summary>
        public Guid? RefIpedsOccupationalCategoryId { get => _RefIpedsOccupationalCategoryId; set => SetProperty(ref _RefIpedsOccupationalCategoryId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="StaffEmployment"/> model
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
            AnnualBaseContractualSalary = model.AnnualBaseContractualSalary;
            FacultyStatus = model.FacultyStatus;
            GraduateAssistantStatus = model.GraduateAssistantStatus;
            InstructionalStaffStatus = model.InstructionalStaffStatus;
            MedicalSchoolStaffStatus = model.MedicalSchoolStaffStatus;
            RefAcademicRankId = model.RefAcademicRankId;
            RefEmploymentContractTypeId = model.RefEmploymentContractTypeId;
            RefFullTimeStatusId = model.RefFullTimeStatusId;
            RefGraduateAssistantIpedsCategoryId = model.RefGraduateAssistantIpedsCategoryId;
            RefInstructionalStaffContractLengthId = model.RefInstructionalStaffContractLengthId;
            RefInstructionalStaffFacultyTenureId = model.RefInstructionalStaffFacultyTenureId;
            RefInstructionCreditTypeId = model.RefInstructionCreditTypeId;
            RefIpedsOccupationalCategoryId = model.RefIpedsOccupationalCategoryId;
            StaffEmploymentId = model.StaffEmploymentId;
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
