//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   RecordStatusViewModel.cs
//**********************************************************


namespace Autobahn.Common.ViewModels
{
     /// <summary>
     /// The RecordStatusViewModel
     /// </summary>
    public partial class RecordStatusViewModel : ViewModelBase, Interfaces.IRecordStatus
    {
#region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from RecordStatus";

        // member variable for the RecordStatusCreatorOrganizationId property
        private Guid? _RecordStatusCreatorOrganizationId;

        // member variable for the RecordStatusCreatorPersonId property
        private Guid? _RecordStatusCreatorPersonId;

        // member variable for the RecordStatusDate property
        private System.DateTime? _RecordStatusDate;

        // member variable for the RefRecordStatusTypeId property
        private Guid _RefRecordStatusTypeId;

        // member variable for the RefRecordStatusCreatorEntityId property
        private Guid? _RefRecordStatusCreatorEntityId;

#endregion

        #region Properties
        /// <summary>
        /// The title of the RecordStatusViewModel
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RecordStatusCreatorOrganizationId"/> model
        /// </summary>
        public Guid? RecordStatusCreatorOrganizationId { get => _RecordStatusCreatorOrganizationId; set => SetProperty(ref _RecordStatusCreatorOrganizationId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RecordStatusCreatorPersonId"/> model
        /// </summary>
        public Guid? RecordStatusCreatorPersonId { get => _RecordStatusCreatorPersonId; set => SetProperty(ref _RecordStatusCreatorPersonId, value); }

        public System.DateTime? RecordStatusDate { get => _RecordStatusDate; set => SetProperty(ref _RecordStatusDate, value); }

        /// <summary>
        /// Reference to a required instance of the <see cref="RefRecordStatusTypeId"/> model
        /// </summary>
        public Guid RefRecordStatusTypeId { get => _RefRecordStatusTypeId; set => SetProperty(ref _RefRecordStatusTypeId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefRecordStatusCreatorEntityId"/> model
        /// </summary>
        public Guid? RefRecordStatusCreatorEntityId { get => _RefRecordStatusCreatorEntityId; set => SetProperty(ref _RefRecordStatusCreatorEntityId, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IRecordStatus model)
        {
            IsBusy = true;
            Id = model.Id;
            RecordStatusCreatorOrganizationId = model.RecordStatusCreatorOrganizationId;
            RecordStatusCreatorPersonId = model.RecordStatusCreatorPersonId;
            RecordStatusDate = model.RecordStatusDate;
            RefRecordStatusTypeId = model.RefRecordStatusTypeId;
            RefRecordStatusCreatorEntityId = model.RefRecordStatusCreatorEntityId;
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
