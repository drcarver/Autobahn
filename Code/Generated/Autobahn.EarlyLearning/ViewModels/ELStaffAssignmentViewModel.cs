//**********************************************************
//* DomainName: Autobahn.EarlyLearning
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

        // member variable for the OrganizationPersonRoleId property
        private Guid _OrganizationPersonRoleId;

        // member variable for the ItinerantProvider property
        private System.Boolean _ItinerantProvider;

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
        /// The title of the ELStaffAssignmentViewModel
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// Reference to a required instance of the <see cref="OrganizationPersonRoleId"/> model
        /// </summary>
        public Guid OrganizationPersonRoleId { get => _OrganizationPersonRoleId; set => SetProperty(ref _OrganizationPersonRoleId, value); }

        public System.Boolean ItinerantProvider  { get => _ItinerantProvider; set => SetProperty(ref _ItinerantProvider, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IELStaffAssignment model)
        {
            IsBusy = true;
            Id = model.Id;
            OrganizationPersonRoleId = model.OrganizationPersonRoleId;
            ItinerantProvider = model.ItinerantProvider;
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
