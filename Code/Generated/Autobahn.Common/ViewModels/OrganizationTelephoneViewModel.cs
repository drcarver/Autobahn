//**********************************************************
//* DomainName: Common Models
//* FileName:   OrganizationTelephoneViewModel.cs
//**********************************************************

using System.ComponentModel;
using System.Windows.Input;

namespace Autobahn.Common.ViewModels
{
     /// <summary>
     /// The OrganizationTelephoneViewModel
     /// </summary>
    public partial class OrganizationTelephoneViewModel : ViewModelBase, Interfaces.IOrganizationTelephone
    {
        #region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from OrganizationTelephone";

        // member variable for the RefInstitutionTelephoneTypeId property
        private Guid? _RefInstitutionTelephoneTypeId;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the OrganizationTelephoneViewModel
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefInstitutionTelephoneType"/> model
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19167">Institution Telephone Number Type</a>
        /// </para>
        /// </summary>
        [DisplayName("Institution Telephone Number Type")]
        public Guid? RefInstitutionTelephoneTypeId { get => _RefInstitutionTelephoneTypeId; set => SetProperty(ref _RefInstitutionTelephoneTypeId, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IOrganizationTelephone model)
        {
            IsBusy = true;
            Id = model.Id;
            RefInstitutionTelephoneTypeId = model.RefInstitutionTelephoneTypeId; // Institution Telephone Number Type
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
