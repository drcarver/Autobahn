//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   StaffCompensationViewModel.cs
//**********************************************************


namespace Autobahn.Common.ViewModels
{
     /// <summary>
     /// The StaffCompensationViewModel
     /// </summary>
    public partial class StaffCompensationViewModel : ViewModelBase, Interfaces.IStaffCompensationViewModel
    {
#region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from StaffCompensation";

        // member variable for the StaffEmploymentId property
        private Guid _StaffEmploymentId;

        // member variable for the StaffCompensationAnnualSupplement property
        private System.Decimal? _StaffCompensationAnnualSupplement;

        // member variable for the StaffCompensationBaseSalary property
        private System.Decimal? _StaffCompensationBaseSalary;

        // member variable for the StaffCompensationHealthBenefits property
        private System.Decimal? _StaffCompensationHealthBenefits;

        // member variable for the StaffCompensationLongevity property
        private System.Decimal? _StaffCompensationLongevity;

        // member variable for the StaffCompensationOtherBenefits property
        private System.Decimal? _StaffCompensationOtherBenefits;

        // member variable for the StaffCompensationRetirementBenefits property
        private System.Decimal? _StaffCompensationRetirementBenefits;

        // member variable for the StaffCompensationTotalBenefits property
        private System.Decimal? _StaffCompensationTotalBenefits;

        // member variable for the StaffCompensationTotalSalary property
        private System.Decimal? _StaffCompensationTotalSalary;

        // member variable for the RefStaffCompensationSourceTypeId property
        private Guid? _RefStaffCompensationSourceTypeId;

        // member variable for the RecordStartDateTime property
        private System.DateTime? _RecordStartDateTime;

        // member variable for the RecordEndDateTime property
        private System.DateTime? _RecordEndDateTime;

        // member variable for the RecordStatusId property
        private Guid? _RecordStatusId;

        // member variable for the DataCollectionId property
        private Guid? _DataCollectionId;

#endregion

        #region Properties
        /// <summary>
        /// The title of the StaffCompensationViewModel
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// Reference to a required instance of the <see cref="StaffEmploymentId"/> model
        /// </summary>
        public Guid StaffEmploymentId { get => _StaffEmploymentId; set => SetProperty(ref _StaffEmploymentId, value); }

        public System.Decimal? StaffCompensationAnnualSupplement { get => _StaffCompensationAnnualSupplement; set => SetProperty(ref _StaffCompensationAnnualSupplement, value); }

        public System.Decimal? StaffCompensationBaseSalary { get => _StaffCompensationBaseSalary; set => SetProperty(ref _StaffCompensationBaseSalary, value); }

        public System.Decimal? StaffCompensationHealthBenefits { get => _StaffCompensationHealthBenefits; set => SetProperty(ref _StaffCompensationHealthBenefits, value); }

        public System.Decimal? StaffCompensationLongevity { get => _StaffCompensationLongevity; set => SetProperty(ref _StaffCompensationLongevity, value); }

        public System.Decimal? StaffCompensationOtherBenefits { get => _StaffCompensationOtherBenefits; set => SetProperty(ref _StaffCompensationOtherBenefits, value); }

        public System.Decimal? StaffCompensationRetirementBenefits { get => _StaffCompensationRetirementBenefits; set => SetProperty(ref _StaffCompensationRetirementBenefits, value); }

        public System.Decimal? StaffCompensationTotalBenefits { get => _StaffCompensationTotalBenefits; set => SetProperty(ref _StaffCompensationTotalBenefits, value); }

        public System.Decimal? StaffCompensationTotalSalary { get => _StaffCompensationTotalSalary; set => SetProperty(ref _StaffCompensationTotalSalary, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefStaffCompensationSourceTypeId"/> model
        /// </summary>
        public Guid? RefStaffCompensationSourceTypeId { get => _RefStaffCompensationSourceTypeId; set => SetProperty(ref _RefStaffCompensationSourceTypeId, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IStaffCompensation model)
        {
            IsBusy = true;
            Id = model.Id;
            StaffEmploymentId = model.StaffEmploymentId;
            StaffCompensationAnnualSupplement = model.StaffCompensationAnnualSupplement;
            StaffCompensationBaseSalary = model.StaffCompensationBaseSalary;
            StaffCompensationHealthBenefits = model.StaffCompensationHealthBenefits;
            StaffCompensationLongevity = model.StaffCompensationLongevity;
            StaffCompensationOtherBenefits = model.StaffCompensationOtherBenefits;
            StaffCompensationRetirementBenefits = model.StaffCompensationRetirementBenefits;
            StaffCompensationTotalBenefits = model.StaffCompensationTotalBenefits;
            StaffCompensationTotalSalary = model.StaffCompensationTotalSalary;
            RefStaffCompensationSourceTypeId = model.RefStaffCompensationSourceTypeId;
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
