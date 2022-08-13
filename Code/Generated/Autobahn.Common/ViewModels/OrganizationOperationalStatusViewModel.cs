//**********************************************************
//* DomainName: Common Models
//* FileName:   OrganizationOperationalStatusViewModel.cs
//**********************************************************

using CommunityToolkit.Maui;

namespace Autobahn.Common.ViewModels
{
     /// <summary>
     /// The OrganizationOperationalStatusViewModel
     /// </summary>
    public partial class OrganizationOperationalStatusViewModel : ViewModelBase, Interfaces.IOrganizationOperationalStatus
    {
        #region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from OrganizationOperationalStatus";

        // member variable for the OperationalStatusEffectiveDate property
        private System.DateTime? _OperationalStatusEffectiveDate;

        // member variable for the OrganizationId property
        private Guid _OrganizationId;

        // member variable for the RefOperationalStatusId property
        private Guid _RefOperationalStatusId;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the OrganizationOperationalStatusViewModel
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// The classification of the operational condition of a local education agency (LEA) at the start of the school year.
        /// </summary>
        public System.DateTime? OperationalStatusEffectiveDate { get => _OperationalStatusEffectiveDate; set => SetProperty(ref _OperationalStatusEffectiveDate, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="Organization"/> model
        /// </summary>
        public Guid OrganizationId { get => _OrganizationId; set => SetProperty(ref _OrganizationId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefOperationalStatus"/> model
        /// </summary>
        public Guid RefOperationalStatusId { get => _RefOperationalStatusId; set => SetProperty(ref _RefOperationalStatusId, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IOrganizationOperationalStatus model)
        {
            IsBusy = true;
            Id = model.Id;
            OperationalStatusEffectiveDate = model.OperationalStatusEffectiveDate;
            OrganizationId = model.OrganizationId;
            RefOperationalStatusId = model.RefOperationalStatusId;
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
