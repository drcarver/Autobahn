//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   RoleStatusViewModel.cs
//**********************************************************


namespace Autobahn.Common.ViewModels
{
     /// <summary>
     /// The RoleStatusViewModel
     /// </summary>
    public partial class RoleStatusViewModel : ViewModelBase, Interfaces.IRoleStatusViewModel
    {
#region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from RoleStatus";

        // member variable for the StatusStartDate property
        private System.DateTime _StatusStartDate;

        // member variable for the StatusEndDate property
        private System.DateTime? _StatusEndDate;

        // member variable for the RefRoleStatusId property
        private Guid? _RefRoleStatusId;

        // member variable for the OrganizationPersonRoleId property
        private Guid _OrganizationPersonRoleId;

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
        /// The title of the RoleStatusViewModel
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        public System.DateTime StatusStartDate  { get => _StatusStartDate; set => SetProperty(ref _StatusStartDate, value); }

        public System.DateTime? StatusEndDate { get => _StatusEndDate; set => SetProperty(ref _StatusEndDate, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefRoleStatusId"/> model
        /// </summary>
        public Guid? RefRoleStatusId { get => _RefRoleStatusId; set => SetProperty(ref _RefRoleStatusId, value); }

        /// <summary>
        /// Reference to a required instance of the <see cref="OrganizationPersonRoleId"/> model
        /// </summary>
        public Guid OrganizationPersonRoleId { get => _OrganizationPersonRoleId; set => SetProperty(ref _OrganizationPersonRoleId, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IRoleStatus model)
        {
            IsBusy = true;
            Id = model.Id;
            StatusStartDate = model.StatusStartDate;
            StatusEndDate = model.StatusEndDate;
            RefRoleStatusId = model.RefRoleStatusId;
            OrganizationPersonRoleId = model.OrganizationPersonRoleId;
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
