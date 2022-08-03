//**********************************************************
//* DomainName: Autobahn.Postsecondary
//* FileName:   PsStaffEmploymentViewModel.cs
//**********************************************************

using Prism.Mvvm;
using Autobahn.Common.Interfaces;
using Autobahn.Autobahn.Postsecondary.Interfaces;

namespace Autobahn.Postsecondary.ViewModels
{
     /// <summary>
     /// The PsStaffEmploymentViewModel
     /// </summary>
    public partial class PsStaffEmploymentViewModel : BindableBase, IPsStaffEmployment
    {
#region "Backing Fields"
        // member variable for the FacultyStatus property
        private System.Boolean? _FacultyStatus;

        // member variable for the InstructionalStaffStatus property
        private System.Boolean? _InstructionalStaffStatus;

        // member variable for the MedicalSchoolStaffStatus property
        private System.Boolean? _MedicalSchoolStaffStatus;

        // member variable for the GraduateAssistantStatus property
        private System.Boolean? _GraduateAssistantStatus;

        // member variable for the AnnualBaseContractualSalary property
        private System.Decimal? _AnnualBaseContractualSalary;

        // member variable for the RecordStartDateTime property
        private System.DateTime? _RecordStartDateTime;

        // member variable for the RecordEndDateTime property
        private System.DateTime? _RecordEndDateTime;

#endregion

#region Properties
        /// <summary>
        /// Reference to a required instance of the <see cref="StaffEmploymentId"/> model
        /// </summary>
        public Guid StaffEmploymentId { get; set; }

        public System.Boolean? FacultyStatus { get => _FacultyStatus; set => SetProperty(ref _FacultyStatus, value); }

        public System.Boolean? InstructionalStaffStatus { get => _InstructionalStaffStatus; set => SetProperty(ref _InstructionalStaffStatus, value); }

        public System.Boolean? MedicalSchoolStaffStatus { get => _MedicalSchoolStaffStatus; set => SetProperty(ref _MedicalSchoolStaffStatus, value); }

        public System.Boolean? GraduateAssistantStatus { get => _GraduateAssistantStatus; set => SetProperty(ref _GraduateAssistantStatus, value); }

        public System.Decimal? AnnualBaseContractualSalary { get => _AnnualBaseContractualSalary; set => SetProperty(ref _AnnualBaseContractualSalary, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefFullTimeStatusId"/> model
        /// </summary>
        public Guid? RefFullTimeStatusId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefEmploymentContractTypeId"/> model
        /// </summary>
        public Guid? RefEmploymentContractTypeId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefIpedsOccupationalCategoryId"/> model
        /// </summary>
        public Guid? RefIpedsOccupationalCategoryId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefInstructionalStaffContractLengthId"/> model
        /// </summary>
        public Guid? RefInstructionalStaffContractLengthId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefInstructionalStaffFacultyTenureId"/> model
        /// </summary>
        public Guid? RefInstructionalStaffFacultyTenureId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefAcademicRankId"/> model
        /// </summary>
        public Guid? RefAcademicRankId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefInstructionCreditTypeId"/> model
        /// </summary>
        public Guid? RefInstructionCreditTypeId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefGraduateAssistantIpedsCategoryId"/> model
        /// </summary>
        public Guid? RefGraduateAssistantIpedsCategoryId { get; set; }

        public System.DateTime? RecordStartDateTime { get => _RecordStartDateTime; set => SetProperty(ref _RecordStartDateTime, value); }

        public System.DateTime? RecordEndDateTime { get => _RecordEndDateTime; set => SetProperty(ref _RecordEndDateTime, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RecordStatusId"/> model
        /// </summary>
        public Guid? RecordStatusId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="DataCollectionId"/> model
        /// </summary>
        public Guid? DataCollectionId { get; set; }

#endregion


        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(IPsStaffEmployment model)
        {
            IsBusy = true;
            Id = model.Id;
            StaffEmploymentId = model.StaffEmploymentId;
            FacultyStatus = model.FacultyStatus;
            InstructionalStaffStatus = model.InstructionalStaffStatus;
            MedicalSchoolStaffStatus = model.MedicalSchoolStaffStatus;
            GraduateAssistantStatus = model.GraduateAssistantStatus;
            AnnualBaseContractualSalary = model.AnnualBaseContractualSalary;
            RefFullTimeStatusId = model.RefFullTimeStatusId;
            RefEmploymentContractTypeId = model.RefEmploymentContractTypeId;
            RefIpedsOccupationalCategoryId = model.RefIpedsOccupationalCategoryId;
            RefInstructionalStaffContractLengthId = model.RefInstructionalStaffContractLengthId;
            RefInstructionalStaffFacultyTenureId = model.RefInstructionalStaffFacultyTenureId;
            RefAcademicRankId = model.RefAcademicRankId;
            RefInstructionCreditTypeId = model.RefInstructionCreditTypeId;
            RefGraduateAssistantIpedsCategoryId = model.RefGraduateAssistantIpedsCategoryId;
            RecordStartDateTime = model.RecordStartDateTime;
            RecordEndDateTime = model.RecordEndDateTime;
            RecordStatusId = model.RecordStatusId;
            DataCollectionId = model.DataCollectionId;
            IsChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
