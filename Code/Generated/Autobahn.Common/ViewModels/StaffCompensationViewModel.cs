//**********************************************************
//* DomainName: Common Models
//* FileName:   StaffCompensationViewModel.cs
//**********************************************************

using System.ComponentModel;
using System.Windows.Input;

namespace Autobahn.Common.ViewModels
{
     /// <summary>
     /// The StaffCompensationViewModel
     /// </summary>
    public partial class StaffCompensationViewModel : ViewModelBase, Interfaces.IStaffCompensation
    {
        #region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from StaffCompensation";

        // member variable for the RecordEndDateTime property
        private  _RecordEndDateTime;

        // member variable for the RecordStartDateTime property
        private  _RecordStartDateTime;

        // member variable for the RefStaffCompensationSourceTypeId property
        private  _RefStaffCompensationSourceTypeId;

        // member variable for the StaffCompensationAnnualSupplement property
        private  _StaffCompensationAnnualSupplement;

        // member variable for the StaffCompensationBaseSalary property
        private Guid? _StaffCompensationBaseSalary;

        // member variable for the StaffCompensationHealthBenefits property
        private  _StaffCompensationHealthBenefits;

        // member variable for the StaffCompensationLongevity property
        private  _StaffCompensationLongevity;

        // member variable for the StaffCompensationOtherBenefits property
        private  _StaffCompensationOtherBenefits;

        // member variable for the StaffCompensationRetirementBenefits property
        private  _StaffCompensationRetirementBenefits;

        // member variable for the StaffCompensationTotalBenefits property
        private  _StaffCompensationTotalBenefits;

        // member variable for the StaffCompensationTotalSalary property
        private  _StaffCompensationTotalSalary;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the View Model
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// </summary>
        public  RecordEndDateTime { get => _RecordEndDateTime; set => SetProperty(ref _RecordEndDateTime, value); }

        /// <summary>
        /// </summary>
        public  RecordStartDateTime { get => _RecordStartDateTime; set => SetProperty(ref _RecordStartDateTime, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefStaffCompensationSourceType"/> model
        /// </summary>
        public  RefStaffCompensationSourceTypeId { get => _RefStaffCompensationSourceTypeId; set => SetProperty(ref _RefStaffCompensationSourceTypeId, value); }

        /// <summary>
        /// </summary>
        public  StaffCompensationAnnualSupplement { get => _StaffCompensationAnnualSupplement; set => SetProperty(ref _StaffCompensationAnnualSupplement, value); }

        /// <summary>
        /// </summary>
        public Guid? StaffCompensationBaseSalary { get => _StaffCompensationBaseSalary; set => SetProperty(ref _StaffCompensationBaseSalary, value); }

        /// <summary>
        /// </summary>
        public  StaffCompensationHealthBenefits { get => _StaffCompensationHealthBenefits; set => SetProperty(ref _StaffCompensationHealthBenefits, value); }

        /// <summary>
        /// </summary>
        public  StaffCompensationLongevity { get => _StaffCompensationLongevity; set => SetProperty(ref _StaffCompensationLongevity, value); }

        /// <summary>
        /// </summary>
        public  StaffCompensationOtherBenefits { get => _StaffCompensationOtherBenefits; set => SetProperty(ref _StaffCompensationOtherBenefits, value); }

        /// <summary>
        /// </summary>
        public  StaffCompensationRetirementBenefits { get => _StaffCompensationRetirementBenefits; set => SetProperty(ref _StaffCompensationRetirementBenefits, value); }

        /// <summary>
        /// </summary>
        public  StaffCompensationTotalBenefits { get => _StaffCompensationTotalBenefits; set => SetProperty(ref _StaffCompensationTotalBenefits, value); }

        /// <summary>
        /// </summary>
        public  StaffCompensationTotalSalary { get => _StaffCompensationTotalSalary; set => SetProperty(ref _StaffCompensationTotalSalary, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IStaffCompensation model)
        {
            IsBusy = true;
            Id = model.Id;
            RecordEndDateTime = model.RecordEndDateTime; // 
            RecordStartDateTime = model.RecordStartDateTime; // 
            RefStaffCompensationSourceTypeId = model.RefStaffCompensationSourceTypeId; // 
            StaffCompensationAnnualSupplement = model.StaffCompensationAnnualSupplement; // 
            StaffCompensationBaseSalary = model.StaffCompensationBaseSalary; // 
            StaffCompensationHealthBenefits = model.StaffCompensationHealthBenefits; // 
            StaffCompensationLongevity = model.StaffCompensationLongevity; // 
            StaffCompensationOtherBenefits = model.StaffCompensationOtherBenefits; // 
            StaffCompensationRetirementBenefits = model.StaffCompensationRetirementBenefits; // 
            StaffCompensationTotalBenefits = model.StaffCompensationTotalBenefits; // 
            StaffCompensationTotalSalary = model.StaffCompensationTotalSalary; // 
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
