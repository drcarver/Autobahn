//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   OrganizationTechnicalAssistanceViewModel.cs
//**********************************************************


namespace Autobahn.Common.ViewModels
{
     /// <summary>
     /// The OrganizationTechnicalAssistanceViewModel
     /// </summary>
    public partial class OrganizationTechnicalAssistanceViewModel : ViewModelBase, Interfaces.IOrganizationTechnicalAssistanceViewModel
    {
#region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from OrganizationTechnicalAssistance";

        // member variable for the OrganizationId property
        private Guid _OrganizationId;

        // member variable for the RefTechnicalAssistanceTypeId property
        private Guid? _RefTechnicalAssistanceTypeId;

        // member variable for the RefTechnicalAssistanceDeliveryTypeId property
        private Guid? _RefTechnicalAssistanceDeliveryTypeId;

        // member variable for the TechnicalAssistanceApprovedInd property
        private System.Boolean? _TechnicalAssistanceApprovedInd;

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
        /// The title of the OrganizationTechnicalAssistanceViewModel
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// Reference to a required instance of the <see cref="OrganizationId"/> model
        /// </summary>
        public Guid OrganizationId { get => _OrganizationId; set => SetProperty(ref _OrganizationId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefTechnicalAssistanceTypeId"/> model
        /// </summary>
        public Guid? RefTechnicalAssistanceTypeId { get => _RefTechnicalAssistanceTypeId; set => SetProperty(ref _RefTechnicalAssistanceTypeId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefTechnicalAssistanceDeliveryTypeId"/> model
        /// </summary>
        public Guid? RefTechnicalAssistanceDeliveryTypeId { get => _RefTechnicalAssistanceDeliveryTypeId; set => SetProperty(ref _RefTechnicalAssistanceDeliveryTypeId, value); }

        public System.Boolean? TechnicalAssistanceApprovedInd { get => _TechnicalAssistanceApprovedInd; set => SetProperty(ref _TechnicalAssistanceApprovedInd, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IOrganizationTechnicalAssistance model)
        {
            IsBusy = true;
            Id = model.Id;
            OrganizationId = model.OrganizationId;
            RefTechnicalAssistanceTypeId = model.RefTechnicalAssistanceTypeId;
            RefTechnicalAssistanceDeliveryTypeId = model.RefTechnicalAssistanceDeliveryTypeId;
            TechnicalAssistanceApprovedInd = model.TechnicalAssistanceApprovedInd;
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
