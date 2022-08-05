//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   OrganizationEmployeeBenefitViewModel.cs
//**********************************************************


namespace Autobahn.Common.ViewModels
{
     /// <summary>
     /// The OrganizationEmployeeBenefitViewModel
     /// </summary>
    public partial class OrganizationEmployeeBenefitViewModel : ViewModelBase, Interfaces.IOrganizationEmployeeBenefit
    {
#region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from OrganizationEmployeeBenefit";

        // member variable for the OrganizationId property
        private Guid _OrganizationId;

        // member variable for the FullTimeBenefitIndicator property
        private System.Boolean? _FullTimeBenefitIndicator;

        // member variable for the PartTimeBenefitIndicator property
        private System.Boolean? _PartTimeBenefitIndicator;

        // member variable for the RefEmployeeBenefitId property
        private Guid? _RefEmployeeBenefitId;

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
        /// The title of the OrganizationEmployeeBenefitViewModel
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// Reference to a required instance of the <see cref="OrganizationId"/> model
        /// </summary>
        public Guid OrganizationId { get => _OrganizationId; set => SetProperty(ref _OrganizationId, value); }

        public System.Boolean? FullTimeBenefitIndicator { get => _FullTimeBenefitIndicator; set => SetProperty(ref _FullTimeBenefitIndicator, value); }

        public System.Boolean? PartTimeBenefitIndicator { get => _PartTimeBenefitIndicator; set => SetProperty(ref _PartTimeBenefitIndicator, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefEmployeeBenefitId"/> model
        /// </summary>
        public Guid? RefEmployeeBenefitId { get => _RefEmployeeBenefitId; set => SetProperty(ref _RefEmployeeBenefitId, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IOrganizationEmployeeBenefit model)
        {
            IsBusy = true;
            Id = model.Id;
            OrganizationId = model.OrganizationId;
            FullTimeBenefitIndicator = model.FullTimeBenefitIndicator;
            PartTimeBenefitIndicator = model.PartTimeBenefitIndicator;
            RefEmployeeBenefitId = model.RefEmployeeBenefitId;
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
