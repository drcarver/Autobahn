//**********************************************************
//* DomainName: Adult Education (AE)
//* FileName:   AeProviderViewModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.ViewModels;

namespace Autobahn.AdultEducation.ViewModels
{
     /// <summary>
     /// The AeProviderViewModel
     /// </summary>
    public partial class AeProviderViewModel : ViewModelBase, Interfaces.IAeProvider
    {
        #region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from AeProvider";

        // member variable for the OrganizationId property
        private Guid _OrganizationId;

        // member variable for the RefLevelOfInstitutionId property
        private Guid _RefLevelOfInstitutionId;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the AeProviderViewModel
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="Organization"/> model
        /// </summary>
        public Guid OrganizationId { get => _OrganizationId; set => SetProperty(ref _OrganizationId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefLevelOfInstitution"/> model
        /// </summary>
        public Guid RefLevelOfInstitutionId { get => _RefLevelOfInstitutionId; set => SetProperty(ref _RefLevelOfInstitutionId, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IAeProvider model)
        {
            IsBusy = true;
            Id = model.Id;
            OrganizationId = model.OrganizationId;
            RefLevelOfInstitutionId = model.RefLevelOfInstitutionId;
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
