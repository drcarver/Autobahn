//**********************************************************
//* DomainName: Elementary and Secondary (K12)
//* FileName:   K12LeaSafeDrugFreeViewModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.ViewModels;

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
        private System.String _Baseline;

        // member variable for the BaselineYear property
        private System.String _BaselineYear;

        // member variable for the CollectionFrequency property
        private System.String _CollectionFrequency;

        // member variable for the IndicatorName property
        private System.String _IndicatorName;

        // member variable for the Instrument property
        private System.String _Instrument;

        // member variable for the K12LeaId property
        private Guid _K12LeaId;

        // member variable for the MostRecentCollection property
        private System.String _MostRecentCollection;

        // member variable for the Performance property
        private System.String _Performance;

        // member variable for the Target property
        private System.String _Target;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the K12LeaSafeDrugFreeViewModel
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// The name of the performance indicator for student behaviors under the Safe and Drug-Free Schools and Communities Act.
        /// </summary>
        public System.String Baseline { get => _Baseline; set => SetProperty(ref _Baseline, value); }

        /// <summary>
        /// The name of the performance indicator for student behaviors under the Safe and Drug-Free Schools and Communities Act.
        /// </summary>
        public System.String BaselineYear { get => _BaselineYear; set => SetProperty(ref _BaselineYear, value); }

        /// <summary>
        /// The name of the performance indicator for student behaviors under the Safe and Drug-Free Schools and Communities Act.
        /// </summary>
        public System.String CollectionFrequency { get => _CollectionFrequency; set => SetProperty(ref _CollectionFrequency, value); }

        /// <summary>
        /// The name of the performance indicator for student behaviors under the Safe and Drug-Free Schools and Communities Act.
        /// </summary>
        public System.String IndicatorName { get => _IndicatorName; set => SetProperty(ref _IndicatorName, value); }

        /// <summary>
        /// The name of the performance indicator for student behaviors under the Safe and Drug-Free Schools and Communities Act.
        /// </summary>
        public System.String Instrument { get => _Instrument; set => SetProperty(ref _Instrument, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="K12Lea"/> model
        /// </summary>
        public Guid K12LeaId { get => _K12LeaId; set => SetProperty(ref _K12LeaId, value); }

        /// <summary>
        /// The name of the performance indicator for student behaviors under the Safe and Drug-Free Schools and Communities Act.
        /// </summary>
        public System.String MostRecentCollection { get => _MostRecentCollection; set => SetProperty(ref _MostRecentCollection, value); }

        /// <summary>
        /// The name of the performance indicator for student behaviors under the Safe and Drug-Free Schools and Communities Act.
        /// </summary>
        public System.String Performance { get => _Performance; set => SetProperty(ref _Performance, value); }

        /// <summary>
        /// The name of the performance indicator for student behaviors under the Safe and Drug-Free Schools and Communities Act.
        /// </summary>
        public System.String Target { get => _Target; set => SetProperty(ref _Target, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IK12LeaSafeDrugFree model)
        {
            IsBusy = true;
            Id = model.Id;
            Baseline = model.Baseline;
            BaselineYear = model.BaselineYear;
            CollectionFrequency = model.CollectionFrequency;
            IndicatorName = model.IndicatorName;
            Instrument = model.Instrument;
            K12LeaId = model.K12LeaId;
            MostRecentCollection = model.MostRecentCollection;
            Performance = model.Performance;
            Target = model.Target;
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
