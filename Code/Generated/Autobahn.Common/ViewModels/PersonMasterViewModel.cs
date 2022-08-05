//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   PersonMasterViewModel.cs
//**********************************************************


namespace Autobahn.Common.ViewModels
{
     /// <summary>
     /// The PersonMasterViewModel
     /// </summary>
    public partial class PersonMasterViewModel : ViewModelBase, Interfaces.IPersonMaster
    {
#region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from PersonMaster";

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
        /// The title of the PersonMasterViewModel
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IPersonMaster model)
        {
            IsBusy = true;
            Id = model.Id;
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
