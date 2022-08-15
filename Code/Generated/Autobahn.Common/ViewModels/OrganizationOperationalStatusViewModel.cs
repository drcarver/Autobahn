//**********************************************************
//* DomainName: Common Models
//* FileName:   OrganizationOperationalStatusViewModel.cs
//**********************************************************

using System.ComponentModel;
using System.Windows.Input;

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

        // member variable for the RefOperationalStatusId property
        private Guid _RefOperationalStatusId;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the OrganizationOperationalStatusViewModel
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefOperationalStatus"/> model
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19174">Local Education Agency Operational Status</a>
        /// </para>
        /// </summary>
        [DisplayName("Local Education Agency Operational Status")]
        public Guid RefOperationalStatusId { get => _RefOperationalStatusId; set => SetProperty(ref _RefOperationalStatusId, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IOrganizationOperationalStatus model)
        {
            IsBusy = true;
            Id = model.Id;
            RefOperationalStatusId = model.RefOperationalStatusId; // Local Education Agency Operational Status
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
