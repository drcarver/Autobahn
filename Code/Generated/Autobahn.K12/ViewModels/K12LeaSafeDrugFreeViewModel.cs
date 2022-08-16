//**********************************************************
//* DomainName: Elementary and Secondary (K12)
//* FileName:   K12LeaSafeDrugFreeViewModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.ViewModels;

using System.ComponentModel;
using System.Windows.Input;

namespace Autobahn.K12.ViewModels
{
     /// <summary>
     /// The K12LeaSafeDrugFreeViewModel
     /// </summary>
    public partial class K12LeaSafeDrugFreeViewModel : ViewModelBase, Interfaces.IK12LeaSafeDrugFree
    {
        #region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from K12LeaSafeDrugFree";

        // member variable for the Baseline property
        private  _Baseline;

        // member variable for the BaselineYear property
        private  _BaselineYear;

        // member variable for the CollectionFrequency property
        private  _CollectionFrequency;

        // member variable for the IndicatorName property
        private Guid? _IndicatorName;

        // member variable for the Instrument property
        private  _Instrument;

        // member variable for the MostRecentCollection property
        private  _MostRecentCollection;

        // member variable for the Performance property
        private  _Performance;

        // member variable for the RecordEndDateTime property
        private  _RecordEndDateTime;

        // member variable for the RecordStartDateTime property
        private  _RecordStartDateTime;

        // member variable for the Target property
        private  _Target;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the View Model
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// </summary>
        public  Baseline { get => _Baseline; set => SetProperty(ref _Baseline, value); }

        /// <summary>
        /// </summary>
        public  BaselineYear { get => _BaselineYear; set => SetProperty(ref _BaselineYear, value); }

        /// <summary>
        /// </summary>
        public  CollectionFrequency { get => _CollectionFrequency; set => SetProperty(ref _CollectionFrequency, value); }

        /// <summary>
        /// </summary>
        public Guid? IndicatorName { get => _IndicatorName; set => SetProperty(ref _IndicatorName, value); }

        /// <summary>
        /// </summary>
        public  Instrument { get => _Instrument; set => SetProperty(ref _Instrument, value); }

        /// <summary>
        /// </summary>
        public  MostRecentCollection { get => _MostRecentCollection; set => SetProperty(ref _MostRecentCollection, value); }

        /// <summary>
        /// </summary>
        public  Performance { get => _Performance; set => SetProperty(ref _Performance, value); }

        /// <summary>
        /// </summary>
        public  RecordEndDateTime { get => _RecordEndDateTime; set => SetProperty(ref _RecordEndDateTime, value); }

        /// <summary>
        /// </summary>
        public  RecordStartDateTime { get => _RecordStartDateTime; set => SetProperty(ref _RecordStartDateTime, value); }

        /// <summary>
        /// </summary>
        public  Target { get => _Target; set => SetProperty(ref _Target, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IK12LeaSafeDrugFree model)
        {
            IsBusy = true;
            Id = model.Id;
            Baseline = model.Baseline; // 
            BaselineYear = model.BaselineYear; // 
            CollectionFrequency = model.CollectionFrequency; // 
            IndicatorName = model.IndicatorName; // 
            Instrument = model.Instrument; // 
            MostRecentCollection = model.MostRecentCollection; // 
            Performance = model.Performance; // 
            RecordEndDateTime = model.RecordEndDateTime; // 
            RecordStartDateTime = model.RecordStartDateTime; // 
            Target = model.Target; // 
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
