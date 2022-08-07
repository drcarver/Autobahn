//**********************************************************
//* DomainName: Autobahn.K12
//* FileName:   K12LeaSafeDrugFreeViewModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.ViewModels;

namespace Autobahn.K12.ViewModels
{
     /// <summary>
     /// The K12LeaSafeDrugFreeViewModel
     /// </summary>
    public partial class K12LeaSafeDrugFreeViewModel : ViewModelBase, Interfaces.IK12LeaSafeDrugFreeViewModel
    {
#region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from K12LeaSafeDrugFree";

        // member variable for the K12LeaId property
        private Guid _K12LeaId;

        // member variable for the Baseline property
        private System.String _Baseline;

        // member variable for the BaselineYear property
        private System.String _BaselineYear;

        // member variable for the CollectionFrequency property
        private System.String _CollectionFrequency;

        // member variable for the IndicatorName property
        private System.String _IndicatorName;

        // member variable for the Instrument property
        private System.String _Instrument;

        // member variable for the Performance property
        private System.String _Performance;

        // member variable for the Target property
        private System.String _Target;

        // member variable for the MostRecentCollection property
        private System.String _MostRecentCollection;

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
        /// The title of the K12LeaSafeDrugFreeViewModel
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// Reference to a required instance of the <see cref="K12LeaId"/> model
        /// </summary>
        public Guid K12LeaId { get => _K12LeaId; set => SetProperty(ref _K12LeaId, value); }

        public System.String Baseline  { get => _Baseline; set => SetProperty(ref _Baseline, value); }

        public System.String BaselineYear  { get => _BaselineYear; set => SetProperty(ref _BaselineYear, value); }

        public System.String CollectionFrequency  { get => _CollectionFrequency; set => SetProperty(ref _CollectionFrequency, value); }

        public System.String IndicatorName  { get => _IndicatorName; set => SetProperty(ref _IndicatorName, value); }

        public System.String Instrument  { get => _Instrument; set => SetProperty(ref _Instrument, value); }

        public System.String Performance  { get => _Performance; set => SetProperty(ref _Performance, value); }

        public System.String Target  { get => _Target; set => SetProperty(ref _Target, value); }

        public System.String MostRecentCollection  { get => _MostRecentCollection; set => SetProperty(ref _MostRecentCollection, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IK12LeaSafeDrugFree model)
        {
            IsBusy = true;
            Id = model.Id;
            K12LeaId = model.K12LeaId;
            Baseline = model.Baseline;
            BaselineYear = model.BaselineYear;
            CollectionFrequency = model.CollectionFrequency;
            IndicatorName = model.IndicatorName;
            Instrument = model.Instrument;
            Performance = model.Performance;
            Target = model.Target;
            MostRecentCollection = model.MostRecentCollection;
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
