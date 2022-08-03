//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   StaffCompensationViewModel.cs
//**********************************************************

using Prism.Mvvm;
using Autobahn.Common.Interfaces;
using Autobahn.Autobahn.Common.Interfaces;

namespace Autobahn.Common.ViewModels
{
     /// <summary>
     /// The StaffCompensationViewModel
     /// </summary>
    public partial class StaffCompensationViewModel : BindableBase, IStaffCompensation
    {
#region "Backing Fields"
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
        public Guid? RefStaffCompensationSourceTypeId { get; set; }

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
        public void Load(IStaffCompensation model)
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
