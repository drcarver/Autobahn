//**********************************************************
//* DomainName: Autobahn.EarlyLearning
//* FileName:   ELOrganizationAvailabilityViewModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.ViewModels;

namespace Autobahn.EarlyLearning.ViewModels
{
     /// <summary>
     /// The ELOrganizationAvailabilityViewModel
     /// </summary>
    public partial class ELOrganizationAvailabilityViewModel : ViewModelBase, Interfaces.IELOrganizationAvailabilityViewModel
    {
#region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from ELOrganizationAvailability";

        // member variable for the OrganizationId property
        private Guid _OrganizationId;

        // member variable for the DaysAvailablePerWeek property
        private System.Int32? _DaysAvailablePerWeek;

        // member variable for the HoursAvailablePerDay property
        private System.Decimal? _HoursAvailablePerDay;

        // member variable for the NumberOfClassrooms property
        private System.Int32? _NumberOfClassrooms;

        // member variable for the AnnualOperatingWeeks property
        private System.Int32? _AnnualOperatingWeeks;

        // member variable for the RefEnvironmentSettingId property
        private Guid? _RefEnvironmentSettingId;

        // member variable for the RefServiceOptionId property
        private Guid? _RefServiceOptionId;

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
        /// The title of the ELOrganizationAvailabilityViewModel
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// Reference to a required instance of the <see cref="OrganizationId"/> model
        /// </summary>
        public Guid OrganizationId { get => _OrganizationId; set => SetProperty(ref _OrganizationId, value); }

        public System.Int32? DaysAvailablePerWeek { get => _DaysAvailablePerWeek; set => SetProperty(ref _DaysAvailablePerWeek, value); }

        public System.Decimal? HoursAvailablePerDay { get => _HoursAvailablePerDay; set => SetProperty(ref _HoursAvailablePerDay, value); }

        public System.Int32? NumberOfClassrooms { get => _NumberOfClassrooms; set => SetProperty(ref _NumberOfClassrooms, value); }

        public System.Int32? AnnualOperatingWeeks { get => _AnnualOperatingWeeks; set => SetProperty(ref _AnnualOperatingWeeks, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefEnvironmentSettingId"/> model
        /// </summary>
        public Guid? RefEnvironmentSettingId { get => _RefEnvironmentSettingId; set => SetProperty(ref _RefEnvironmentSettingId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefServiceOptionId"/> model
        /// </summary>
        public Guid? RefServiceOptionId { get => _RefServiceOptionId; set => SetProperty(ref _RefServiceOptionId, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IELOrganizationAvailability model)
        {
            IsBusy = true;
            Id = model.Id;
            OrganizationId = model.OrganizationId;
            DaysAvailablePerWeek = model.DaysAvailablePerWeek;
            HoursAvailablePerDay = model.HoursAvailablePerDay;
            NumberOfClassrooms = model.NumberOfClassrooms;
            AnnualOperatingWeeks = model.AnnualOperatingWeeks;
            RefEnvironmentSettingId = model.RefEnvironmentSettingId;
            RefServiceOptionId = model.RefServiceOptionId;
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
