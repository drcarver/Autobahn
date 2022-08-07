//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   PersonDigitalAccessViewModel.cs
//**********************************************************


namespace Autobahn.Common.ViewModels
{
     /// <summary>
     /// The PersonDigitalAccessViewModel
     /// </summary>
    public partial class PersonDigitalAccessViewModel : ViewModelBase, Interfaces.IPersonDigitalAccessViewModel
    {
#region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from PersonDigitalAccess";

        // member variable for the PersonId property
        private Guid _PersonId;

        // member variable for the InternetAccessInResidence property
        private System.Boolean? _InternetAccessInResidence;

        // member variable for the PersonAddressId property
        private Guid? _PersonAddressId;

        // member variable for the RefBarrierToInternetAccessInResidenceId property
        private Guid? _RefBarrierToInternetAccessInResidenceId;

        // member variable for the RefInternetAccessTypeInResidenceId property
        private Guid? _RefInternetAccessTypeInResidenceId;

        // member variable for the RefInternetPerformanceInResidenceId property
        private Guid? _RefInternetPerformanceInResidenceId;

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
        /// The title of the PersonDigitalAccessViewModel
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// Reference to a required instance of the <see cref="PersonId"/> model
        /// </summary>
        public Guid PersonId { get => _PersonId; set => SetProperty(ref _PersonId, value); }

        public System.Boolean? InternetAccessInResidence { get => _InternetAccessInResidence; set => SetProperty(ref _InternetAccessInResidence, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="PersonAddressId"/> model
        /// </summary>
        public Guid? PersonAddressId { get => _PersonAddressId; set => SetProperty(ref _PersonAddressId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefBarrierToInternetAccessInResidenceId"/> model
        /// </summary>
        public Guid? RefBarrierToInternetAccessInResidenceId { get => _RefBarrierToInternetAccessInResidenceId; set => SetProperty(ref _RefBarrierToInternetAccessInResidenceId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefInternetAccessTypeInResidenceId"/> model
        /// </summary>
        public Guid? RefInternetAccessTypeInResidenceId { get => _RefInternetAccessTypeInResidenceId; set => SetProperty(ref _RefInternetAccessTypeInResidenceId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefInternetPerformanceInResidenceId"/> model
        /// </summary>
        public Guid? RefInternetPerformanceInResidenceId { get => _RefInternetPerformanceInResidenceId; set => SetProperty(ref _RefInternetPerformanceInResidenceId, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IPersonDigitalAccess model)
        {
            IsBusy = true;
            Id = model.Id;
            PersonId = model.PersonId;
            InternetAccessInResidence = model.InternetAccessInResidence;
            PersonAddressId = model.PersonAddressId;
            RefBarrierToInternetAccessInResidenceId = model.RefBarrierToInternetAccessInResidenceId;
            RefInternetAccessTypeInResidenceId = model.RefInternetAccessTypeInResidenceId;
            RefInternetPerformanceInResidenceId = model.RefInternetPerformanceInResidenceId;
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
