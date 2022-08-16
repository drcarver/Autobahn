//**********************************************************
//* DomainName: Postsecondary (PS)
//* FileName:   PsStaffEmploymentViewModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.ViewModels;

using System.ComponentModel;
using System.Windows.Input;

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
        private  _AnnualBaseContractualSalary;

        // member variable for the FacultyStatus property
        private  _FacultyStatus;

        // member variable for the GraduateAssistantStatus property
        private  _GraduateAssistantStatus;

        // member variable for the InstructionalStaffStatus property
        private  _InstructionalStaffStatus;

        // member variable for the MedicalSchoolStaffStatus property
        private  _MedicalSchoolStaffStatus;

        // member variable for the RecordEndDateTime property
        private  _RecordEndDateTime;

        // member variable for the RecordStartDateTime property
        private  _RecordStartDateTime;

        // member variable for the RefAcademicRankId property
        private  _RefAcademicRankId;

        // member variable for the RefEmploymentContractTypeId property
        private  _RefEmploymentContractTypeId;

        // member variable for the RefFullTimeStatusId property
        private  _RefFullTimeStatusId;

        // member variable for the RefGraduateAssistantIpedsCategoryId property
        private  _RefGraduateAssistantIpedsCategoryId;

        // member variable for the RefInstructionalStaffContractLengthId property
        private  _RefInstructionalStaffContractLengthId;

        // member variable for the RefInstructionalStaffFacultyTenureId property
        private  _RefInstructionalStaffFacultyTenureId;

        // member variable for the RefInstructionCreditTypeId property
        private  _RefInstructionCreditTypeId;

        // member variable for the RefIpedsOccupationalCategoryId property
        private Guid? _RefIpedsOccupationalCategoryId;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the View Model
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// </summary>
        public  AnnualBaseContractualSalary { get => _AnnualBaseContractualSalary; set => SetProperty(ref _AnnualBaseContractualSalary, value); }

        /// <summary>
        /// </summary>
        public  FacultyStatus { get => _FacultyStatus; set => SetProperty(ref _FacultyStatus, value); }

        /// <summary>
        /// </summary>
        public  GraduateAssistantStatus { get => _GraduateAssistantStatus; set => SetProperty(ref _GraduateAssistantStatus, value); }

        /// <summary>
        /// </summary>
        public  InstructionalStaffStatus { get => _InstructionalStaffStatus; set => SetProperty(ref _InstructionalStaffStatus, value); }

        /// <summary>
        /// </summary>
        public  MedicalSchoolStaffStatus { get => _MedicalSchoolStaffStatus; set => SetProperty(ref _MedicalSchoolStaffStatus, value); }

        /// <summary>
        /// </summary>
        public  RecordEndDateTime { get => _RecordEndDateTime; set => SetProperty(ref _RecordEndDateTime, value); }

        /// <summary>
        /// </summary>
        public  RecordStartDateTime { get => _RecordStartDateTime; set => SetProperty(ref _RecordStartDateTime, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefAcademicRank"/> model
        /// </summary>
        public  RefAcademicRankId { get => _RefAcademicRankId; set => SetProperty(ref _RefAcademicRankId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefEmploymentContractType"/> model
        /// </summary>
        public  RefEmploymentContractTypeId { get => _RefEmploymentContractTypeId; set => SetProperty(ref _RefEmploymentContractTypeId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefFullTimeStatus"/> model
        /// </summary>
        public  RefFullTimeStatusId { get => _RefFullTimeStatusId; set => SetProperty(ref _RefFullTimeStatusId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefGraduateAssistantIpedsCategory"/> model
        /// </summary>
        public  RefGraduateAssistantIpedsCategoryId { get => _RefGraduateAssistantIpedsCategoryId; set => SetProperty(ref _RefGraduateAssistantIpedsCategoryId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefInstructionalStaffContractLength"/> model
        /// </summary>
        public  RefInstructionalStaffContractLengthId { get => _RefInstructionalStaffContractLengthId; set => SetProperty(ref _RefInstructionalStaffContractLengthId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefInstructionalStaffFacultyTenure"/> model
        /// </summary>
        public  RefInstructionalStaffFacultyTenureId { get => _RefInstructionalStaffFacultyTenureId; set => SetProperty(ref _RefInstructionalStaffFacultyTenureId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefInstructionCreditType"/> model
        /// </summary>
        public  RefInstructionCreditTypeId { get => _RefInstructionCreditTypeId; set => SetProperty(ref _RefInstructionCreditTypeId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefIpedsOccupationalCategory"/> model
        /// </summary>
        public Guid? RefIpedsOccupationalCategoryId { get => _RefIpedsOccupationalCategoryId; set => SetProperty(ref _RefIpedsOccupationalCategoryId, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IPsStaffEmployment model)
        {
            IsBusy = true;
            Id = model.Id;
            AnnualBaseContractualSalary = model.AnnualBaseContractualSalary; // 
            FacultyStatus = model.FacultyStatus; // 
            GraduateAssistantStatus = model.GraduateAssistantStatus; // 
            InstructionalStaffStatus = model.InstructionalStaffStatus; // 
            MedicalSchoolStaffStatus = model.MedicalSchoolStaffStatus; // 
            RecordEndDateTime = model.RecordEndDateTime; // 
            RecordStartDateTime = model.RecordStartDateTime; // 
            RefAcademicRankId = model.RefAcademicRankId; // 
            RefEmploymentContractTypeId = model.RefEmploymentContractTypeId; // 
            RefFullTimeStatusId = model.RefFullTimeStatusId; // 
            RefGraduateAssistantIpedsCategoryId = model.RefGraduateAssistantIpedsCategoryId; // 
            RefInstructionalStaffContractLengthId = model.RefInstructionalStaffContractLengthId; // 
            RefInstructionalStaffFacultyTenureId = model.RefInstructionalStaffFacultyTenureId; // 
            RefInstructionCreditTypeId = model.RefInstructionCreditTypeId; // 
            RefIpedsOccupationalCategoryId = model.RefIpedsOccupationalCategoryId; // 
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
