//**********************************************************
//* DomainName: Common Models
//* FileName:   OrganizationIndicatorViewModel.cs
//**********************************************************

using System.ComponentModel;
using System.Windows.Input;

namespace Autobahn.Common.ViewModels
{
     /// <summary>
     /// The OrganizationIndicatorViewModel
     /// </summary>
    public partial class OrganizationIndicatorViewModel : ViewModelBase, Interfaces.IOrganizationIndicator
    {
        #region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from OrganizationIndicator";

        // member variable for the RefOrganizationIndicatorId property
        private Guid _RefOrganizationIndicatorId;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the OrganizationIndicatorViewModel
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefOrganizationIndicator"/> model
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19000">Ability Grouping Status</a>
        /// </para>
        /// </summary>
        [DisplayName("Ability Grouping Status")]
        public Guid RefOrganizationIndicatorId { get => _RefOrganizationIndicatorId; set => SetProperty(ref _RefOrganizationIndicatorId, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IOrganizationIndicator model)
        {
            IsBusy = true;
            Id = model.Id;
            RefOrganizationIndicatorId = model.RefOrganizationIndicatorId; // Ability Grouping Status
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
