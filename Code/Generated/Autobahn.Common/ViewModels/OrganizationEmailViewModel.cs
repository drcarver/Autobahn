//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   OrganizationEmailViewModel.cs
//**********************************************************


namespace Autobahn.Common.ViewModels
{
     /// <summary>
     /// The OrganizationEmailViewModel
     /// </summary>
    public partial class OrganizationEmailViewModel : ViewModelBase, Interfaces.IOrganizationEmail
    {
#region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from OrganizationEmail";

        // member variable for the OrganizationId property
        private Guid _OrganizationId;

        // member variable for the ElectronicMailAddress property
        private System.String _ElectronicMailAddress;

        // member variable for the RefEmailTypeId property
        private Guid? _RefEmailTypeId;

        // member variable for the RecordStartDateTime property
        private System.DateTime? _RecordStartDateTime;

        // member variable for the RecordEndDateTime property
        private System.DateTime? _RecordEndDateTime;

        // member variable for the DoNotPublishIndicator property
        private System.Boolean? _DoNotPublishIndicator;

        // member variable for the RecordStatusId property
        private Guid? _RecordStatusId;

        // member variable for the DataCollectionId property
        private Guid? _DataCollectionId;

#endregion

        #region Properties
        /// <summary>
        /// The title of the OrganizationEmailViewModel
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// Reference to a required instance of the <see cref="OrganizationId"/> model
        /// </summary>
        public Guid OrganizationId { get => _OrganizationId; set => SetProperty(ref _OrganizationId, value); }

        public System.String ElectronicMailAddress  { get => _ElectronicMailAddress; set => SetProperty(ref _ElectronicMailAddress, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefEmailTypeId"/> model
        /// </summary>
        public Guid? RefEmailTypeId { get => _RefEmailTypeId; set => SetProperty(ref _RefEmailTypeId, value); }

        public System.Boolean? DoNotPublishIndicator { get => _DoNotPublishIndicator; set => SetProperty(ref _DoNotPublishIndicator, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IOrganizationEmail model)
        {
            IsBusy = true;
            Id = model.Id;
            OrganizationId = model.OrganizationId;
            ElectronicMailAddress = model.ElectronicMailAddress;
            RefEmailTypeId = model.RefEmailTypeId;
            DoNotPublishIndicator = model.DoNotPublishIndicator;
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
