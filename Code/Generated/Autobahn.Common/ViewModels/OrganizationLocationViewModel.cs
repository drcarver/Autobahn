//**********************************************************
//* DomainName: Common Models
//* FileName:   OrganizationLocationViewModel.cs
//**********************************************************

using System.ComponentModel;
using System.Windows.Input;

namespace Autobahn.Common.ViewModels
{
     /// <summary>
     /// The OrganizationLocationViewModel
     /// </summary>
    public partial class OrganizationLocationViewModel : ViewModelBase, Interfaces.IOrganizationLocation
    {
        #region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from OrganizationLocation";

        // member variable for the RefOrganizationLocationTypeId property
        private Guid? _RefOrganizationLocationTypeId;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the OrganizationLocationViewModel
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefOrganizationLocationType"/> model
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19644">Address Type for Organization</a>
        /// </para>
        /// </summary>
        [DisplayName("Address Type for Organization")]
        public Guid? RefOrganizationLocationTypeId { get => _RefOrganizationLocationTypeId; set => SetProperty(ref _RefOrganizationLocationTypeId, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IOrganizationLocation model)
        {
            IsBusy = true;
            Id = model.Id;
            RefOrganizationLocationTypeId = model.RefOrganizationLocationTypeId; // Address Type for Organization
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
