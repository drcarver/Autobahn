//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   PersonAddressNcesSideViewModel.cs
//**********************************************************


namespace Autobahn.Common.ViewModels
{
     /// <summary>
     /// The PersonAddressNcesSideViewModel
     /// </summary>
    public partial class PersonAddressNcesSideViewModel : ViewModelBase, Interfaces.IPersonAddressNcesSide
    {
#region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from PersonAddressNcesSide";

        // member variable for the PersonAddressId property
        private Guid _PersonAddressId;

        // member variable for the NcesSideDateProcessed property
        private System.DateTime? _NcesSideDateProcessed;

        // member variable for the NcesSideEstimate property
        private System.Decimal? _NcesSideEstimate;

        // member variable for the NcesSideStandardError property
        private System.Decimal? _NcesSideStandardError;

        // member variable for the NcesSideVintageBeginYear property
        private System.String _NcesSideVintageBeginYear;

        // member variable for the NcesSideVintageEndYear property
        private System.String _NcesSideVintageEndYear;

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
        /// The title of the PersonAddressNcesSideViewModel
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// Reference to a required instance of the <see cref="PersonAddressId"/> model
        /// </summary>
        public Guid PersonAddressId { get => _PersonAddressId; set => SetProperty(ref _PersonAddressId, value); }

        public System.DateTime? NcesSideDateProcessed { get => _NcesSideDateProcessed; set => SetProperty(ref _NcesSideDateProcessed, value); }

        public System.Decimal? NcesSideEstimate { get => _NcesSideEstimate; set => SetProperty(ref _NcesSideEstimate, value); }

        public System.Decimal? NcesSideStandardError { get => _NcesSideStandardError; set => SetProperty(ref _NcesSideStandardError, value); }

        public System.String NcesSideVintageBeginYear  { get => _NcesSideVintageBeginYear; set => SetProperty(ref _NcesSideVintageBeginYear, value); }

        public System.String NcesSideVintageEndYear  { get => _NcesSideVintageEndYear; set => SetProperty(ref _NcesSideVintageEndYear, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IPersonAddressNcesSide model)
        {
            IsBusy = true;
            Id = model.Id;
            PersonAddressId = model.PersonAddressId;
            NcesSideDateProcessed = model.NcesSideDateProcessed;
            NcesSideEstimate = model.NcesSideEstimate;
            NcesSideStandardError = model.NcesSideStandardError;
            NcesSideVintageBeginYear = model.NcesSideVintageBeginYear;
            NcesSideVintageEndYear = model.NcesSideVintageEndYear;
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
