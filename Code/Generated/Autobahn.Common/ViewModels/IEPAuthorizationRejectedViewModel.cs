//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   IEPAuthorizationRejectedViewModel.cs
//**********************************************************


namespace Autobahn.Common.ViewModels
{
     /// <summary>
     /// The IEPAuthorizationRejectedViewModel
     /// </summary>
    public partial class IEPAuthorizationRejectedViewModel : ViewModelBase, Interfaces.IIEPAuthorizationRejected
    {
#region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from IEPAuthorizationRejected";

        // member variable for the IEPAuthorizationId property
        private Guid _IEPAuthorizationId;

        // member variable for the PortionDescription property
        private System.String _PortionDescription;

        // member variable for the PortionExplanation property
        private System.String _PortionExplanation;

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
        /// The title of the IEPAuthorizationRejectedViewModel
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// Reference to a required instance of the <see cref="IEPAuthorizationId"/> model
        /// </summary>
        public Guid IEPAuthorizationId { get => _IEPAuthorizationId; set => SetProperty(ref _IEPAuthorizationId, value); }

        public System.String PortionDescription  { get => _PortionDescription; set => SetProperty(ref _PortionDescription, value); }

        public System.String PortionExplanation  { get => _PortionExplanation; set => SetProperty(ref _PortionExplanation, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IIEPAuthorizationRejected model)
        {
            IsBusy = true;
            Id = model.Id;
            IEPAuthorizationId = model.IEPAuthorizationId;
            PortionDescription = model.PortionDescription;
            PortionExplanation = model.PortionExplanation;
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
