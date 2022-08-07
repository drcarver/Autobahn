//**********************************************************
//* DomainName: Autobahn.EarlyLearning
//* FileName:   ELClassSectionViewModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.ViewModels;

namespace Autobahn.EarlyLearning.ViewModels
{
     /// <summary>
     /// The ELClassSectionViewModel
     /// </summary>
    public partial class ELClassSectionViewModel : ViewModelBase, Interfaces.IELClassSectionViewModel
    {
#region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from ELClassSection";

        // member variable for the OrganizationId property
        private Guid _OrganizationId;

        // member variable for the HoursAvailablePerDay property
        private System.Decimal? _HoursAvailablePerDay;

        // member variable for the DaysAvailablePerWeek property
        private System.Int32? _DaysAvailablePerWeek;

        // member variable for the ELProgramAnnualOperatingWeeks property
        private System.Int32? _ELProgramAnnualOperatingWeeks;

        // member variable for the LanguageTranslationPolicy property
        private System.Boolean? _LanguageTranslationPolicy;

        // member variable for the GroupSize property
        private System.Int32? _GroupSize;

        // member variable for the RefServiceOptionId property
        private Guid? _RefServiceOptionId;

        // member variable for the RefEnvironmentSettingId property
        private Guid? _RefEnvironmentSettingId;

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
        /// The title of the ELClassSectionViewModel
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// Reference to a required instance of the <see cref="OrganizationId"/> model
        /// </summary>
        public Guid OrganizationId { get => _OrganizationId; set => SetProperty(ref _OrganizationId, value); }

        public System.Decimal? HoursAvailablePerDay { get => _HoursAvailablePerDay; set => SetProperty(ref _HoursAvailablePerDay, value); }

        public System.Int32? DaysAvailablePerWeek { get => _DaysAvailablePerWeek; set => SetProperty(ref _DaysAvailablePerWeek, value); }

        public System.Int32? ELProgramAnnualOperatingWeeks { get => _ELProgramAnnualOperatingWeeks; set => SetProperty(ref _ELProgramAnnualOperatingWeeks, value); }

        public System.Boolean? LanguageTranslationPolicy { get => _LanguageTranslationPolicy; set => SetProperty(ref _LanguageTranslationPolicy, value); }

        public System.Int32? GroupSize { get => _GroupSize; set => SetProperty(ref _GroupSize, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefServiceOptionId"/> model
        /// </summary>
        public Guid? RefServiceOptionId { get => _RefServiceOptionId; set => SetProperty(ref _RefServiceOptionId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefEnvironmentSettingId"/> model
        /// </summary>
        public Guid? RefEnvironmentSettingId { get => _RefEnvironmentSettingId; set => SetProperty(ref _RefEnvironmentSettingId, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IELClassSection model)
        {
            IsBusy = true;
            Id = model.Id;
            OrganizationId = model.OrganizationId;
            HoursAvailablePerDay = model.HoursAvailablePerDay;
            DaysAvailablePerWeek = model.DaysAvailablePerWeek;
            ELProgramAnnualOperatingWeeks = model.ELProgramAnnualOperatingWeeks;
            LanguageTranslationPolicy = model.LanguageTranslationPolicy;
            GroupSize = model.GroupSize;
            RefServiceOptionId = model.RefServiceOptionId;
            RefEnvironmentSettingId = model.RefEnvironmentSettingId;
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
