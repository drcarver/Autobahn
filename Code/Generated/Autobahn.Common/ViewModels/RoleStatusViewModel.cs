//**********************************************************
//* DomainName: Common Models
//* FileName:   RoleStatusViewModel.cs
//**********************************************************

using CommunityToolkit.Maui;

namespace Autobahn.Common.ViewModels
{
     /// <summary>
     /// The RoleStatusViewModel
     /// </summary>
    public partial class RoleStatusViewModel : ViewModelBase, Interfaces.IRoleStatus
    {
        #region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from RoleStatus";

        // member variable for the OrganizationPersonRoleId property
        private Guid _OrganizationPersonRoleId;

        // member variable for the RefRoleStatusId property
        private Guid? _RefRoleStatusId;

        // member variable for the StatusEndDate property
        private System.DateTime? _StatusEndDate;

        // member variable for the StatusStartDate property
        private System.DateTime _StatusStartDate;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the RoleStatusViewModel
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="OrganizationPersonRole"/> model
        /// </summary>
        public Guid OrganizationPersonRoleId { get => _OrganizationPersonRoleId; set => SetProperty(ref _OrganizationPersonRoleId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefRoleStatus"/> model
        /// </summary>
        public Guid? RefRoleStatusId { get => _RefRoleStatusId; set => SetProperty(ref _RefRoleStatusId, value); }

        /// <summary>
        /// An indication as to whether a student's name was, is, or will be officially registered on the roll of a school or schools.
        /// </summary>
        public System.DateTime? StatusEndDate { get => _StatusEndDate; set => SetProperty(ref _StatusEndDate, value); }

        /// <summary>
        /// An indication as to whether a student's name was, is, or will be officially registered on the roll of a school or schools.
        /// </summary>
        public System.DateTime StatusStartDate { get => _StatusStartDate; set => SetProperty(ref _StatusStartDate, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IRoleStatus model)
        {
            IsBusy = true;
            Id = model.Id;
            OrganizationPersonRoleId = model.OrganizationPersonRoleId;
            RefRoleStatusId = model.RefRoleStatusId;
            StatusEndDate = model.StatusEndDate;
            StatusStartDate = model.StatusStartDate;
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
