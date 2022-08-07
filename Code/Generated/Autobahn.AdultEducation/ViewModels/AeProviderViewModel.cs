//**********************************************************
//* DomainName: Autobahn.AdultEducation
//* FileName:   AeProviderViewModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.ViewModels;

namespace Autobahn.AdultEducation.ViewModels
{
     /// <summary>
     /// The AeProviderViewModel
     /// </summary>
    public partial class AeProviderViewModel : ViewModelBase, Interfaces.IAeProviderViewModel
    {
#region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from AeProvider";

        // member variable for the OrganizationId property
        private Guid _OrganizationId;

        // member variable for the RefLevelOfInstitutionId property
        private Guid _RefLevelOfInstitutionId;

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
        /// The title of the AeProviderViewModel
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// Reference to a required instance of the <see cref="OrganizationId"/> model
        /// </summary>
        public Guid OrganizationId { get => _OrganizationId; set => SetProperty(ref _OrganizationId, value); }

        /// <summary>
        /// Reference to a required instance of the <see cref="RefLevelOfInstitutionId"/> model
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
