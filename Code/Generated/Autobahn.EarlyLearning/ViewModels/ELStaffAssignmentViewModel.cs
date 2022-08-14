//**********************************************************
//* DomainName: Early Learning (EL)
//* FileName:   ELStaffAssignmentViewModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.ViewModels;

namespace Autobahn.EarlyLearning.ViewModels
{
     /// <summary>
     /// The ELStaffAssignmentViewModel
     /// </summary>
    public partial class ELStaffAssignmentViewModel : ViewModelBase, Interfaces.IELStaffAssignment
    {
        #region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from ELStaffAssignment";

        // member variable for the ItinerantProvider property
        private System.Boolean _ItinerantProvider;

        // member variable for the OrganizationPersonRoleId property
        private Guid _OrganizationPersonRoleId;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the ELStaffAssignmentViewModel
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// An indication of whether a person provides services at more than one site.
        /// </summary>
        public System.Boolean ItinerantProvider { get => _ItinerantProvider; set => SetProperty(ref _ItinerantProvider, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="OrganizationPersonRole"/> model
        /// </summary>
        public Guid OrganizationPersonRoleId { get => _OrganizationPersonRoleId; set => SetProperty(ref _OrganizationPersonRoleId, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IELStaffAssignment model)
        {
            IsBusy = true;
            Id = model.Id;
            ItinerantProvider = model.ItinerantProvider;
            OrganizationPersonRoleId = model.OrganizationPersonRoleId;
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
