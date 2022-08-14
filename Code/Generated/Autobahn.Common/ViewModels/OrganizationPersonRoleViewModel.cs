//**********************************************************
//* DomainName: Common Models
//* FileName:   OrganizationPersonRoleViewModel.cs
//**********************************************************

namespace Autobahn.Common.ViewModels
{
     /// <summary>
     /// The OrganizationPersonRoleViewModel
     /// </summary>
    public partial class OrganizationPersonRoleViewModel : ViewModelBase, Interfaces.IOrganizationPersonRole
    {
        #region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from OrganizationPersonRole";

        // member variable for the EntryDate property
        private System.DateTime? _EntryDate;

        // member variable for the ExitDate property
        private System.DateTime? _ExitDate;

        // member variable for the OrganizationId property
        private Guid _OrganizationId;

        // member variable for the PersonId property
        private Guid _PersonId;

        // member variable for the RoleId property
        private Guid _RoleId;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the OrganizationPersonRoleViewModel
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// The year, month and day on which the person began to participate in the activity.
        /// </summary>
        public System.DateTime? EntryDate { get => _EntryDate; set => SetProperty(ref _EntryDate, value); }

        /// <summary>
        /// The year, month and day on which the person began to participate in the activity.
        /// </summary>
        public System.DateTime? ExitDate { get => _ExitDate; set => SetProperty(ref _ExitDate, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="Organization"/> model
        /// </summary>
        public Guid OrganizationId { get => _OrganizationId; set => SetProperty(ref _OrganizationId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="Person"/> model
        /// </summary>
        public Guid PersonId { get => _PersonId; set => SetProperty(ref _PersonId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="Role"/> model
        /// </summary>
        public Guid RoleId { get => _RoleId; set => SetProperty(ref _RoleId, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IOrganizationPersonRole model)
        {
            IsBusy = true;
            Id = model.Id;
            EntryDate = model.EntryDate;
            ExitDate = model.ExitDate;
            OrganizationId = model.OrganizationId;
            PersonId = model.PersonId;
            RoleId = model.RoleId;
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
