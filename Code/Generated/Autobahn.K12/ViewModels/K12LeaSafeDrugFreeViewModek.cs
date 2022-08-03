//**********************************************************
//* DomainName: Autobahn.K12
//* FileName:   K12LeaSafeDrugFreeViewModel.cs
//**********************************************************

using Prism.Mvvm;
using Autobahn.Common.Interfaces;
using Autobahn.Autobahn.K12.Interfaces;

namespace Autobahn.K12.ViewModels
{
     /// <summary>
     /// The K12LeaSafeDrugFreeViewModel
     /// </summary>
    public partial class K12LeaSafeDrugFreeViewModel : BindableBase, IK12LeaSafeDrugFree
    {
#region "Backing Fields"
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

#endregion

#region Properties
        /// <summary>
        /// Reference to a required instance of the <see cref="K12LeaId"/> model
        /// </summary>
        public Guid K12LeaId { get; set; }

        public System.String Baseline  { get => _Baseline; set => SetProperty(ref _Baseline, value); }

        public System.String BaselineYear  { get => _BaselineYear; set => SetProperty(ref _BaselineYear, value); }

        public System.String CollectionFrequency  { get => _CollectionFrequency; set => SetProperty(ref _CollectionFrequency, value); }

        public System.String IndicatorName  { get => _IndicatorName; set => SetProperty(ref _IndicatorName, value); }

        public System.String Instrument  { get => _Instrument; set => SetProperty(ref _Instrument, value); }

        public System.String Performance  { get => _Performance; set => SetProperty(ref _Performance, value); }

        public System.String Target  { get => _Target; set => SetProperty(ref _Target, value); }

        public System.String MostRecentCollection  { get => _MostRecentCollection; set => SetProperty(ref _MostRecentCollection, value); }

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
        public void Load(IK12LeaSafeDrugFree model)
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
