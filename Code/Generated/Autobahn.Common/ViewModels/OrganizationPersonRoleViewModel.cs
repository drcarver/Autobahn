//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   OrganizationPersonRoleViewModel.cs
//**********************************************************


namespace Autobahn.Common.ViewModels
{
     /// <summary>
     /// The OrganizationPersonRoleViewModel
     /// </summary>
    public partial class OrganizationPersonRoleViewModel : ViewModelBase, Interfaces.IOrganizationPersonRoleViewModel
    {
#region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from OrganizationPersonRole";

        // member variable for the OrganizationId property
        private Guid _OrganizationId;

        // member variable for the PersonId property
        private Guid _PersonId;

        // member variable for the RoleId property
        private Guid _RoleId;

        // member variable for the EntryDate property
        private System.DateTime? _EntryDate;

        // member variable for the ExitDate property
        private System.DateTime? _ExitDate;

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
        /// The title of the OrganizationPersonRoleViewModel
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// Reference to a required instance of the <see cref="OrganizationId"/> model
        /// </summary>
        public Guid OrganizationId { get => _OrganizationId; set => SetProperty(ref _OrganizationId, value); }

        /// <summary>
        /// Reference to a required instance of the <see cref="PersonId"/> model
        /// </summary>
        public Guid PersonId { get => _PersonId; set => SetProperty(ref _PersonId, value); }

        /// <summary>
        /// Reference to a required instance of the <see cref="RoleId"/> model
        /// </summary>
        public Guid RoleId { get => _RoleId; set => SetProperty(ref _RoleId, value); }

        public System.DateTime? EntryDate { get => _EntryDate; set => SetProperty(ref _EntryDate, value); }

        public System.DateTime? ExitDate { get => _ExitDate; set => SetProperty(ref _ExitDate, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IOrganizationPersonRole model)
        {
            IsBusy = true;
            Id = model.Id;
            OrganizationId = model.OrganizationId;
            PersonId = model.PersonId;
            RoleId = model.RoleId;
            EntryDate = model.EntryDate;
            ExitDate = model.ExitDate;
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
