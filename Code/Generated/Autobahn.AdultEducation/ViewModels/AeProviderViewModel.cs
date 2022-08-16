//**********************************************************
//* DomainName: Adult Education (AE)
//* FileName:   AeProviderViewModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.ViewModels;

using System.ComponentModel;
using System.Windows.Input;

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

        // member variable for the RecordEndDateTime property
        private  _RecordEndDateTime;

        // member variable for the RecordStartDateTime property
        private  _RecordStartDateTime;

        // member variable for the RefLevelOfInstitutionId property
        private Guid? _RefLevelOfInstitutionId;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the View Model
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// </summary>
        public  RecordEndDateTime { get => _RecordEndDateTime; set => SetProperty(ref _RecordEndDateTime, value); }

        /// <summary>
        /// </summary>
        public  RecordStartDateTime { get => _RecordStartDateTime; set => SetProperty(ref _RecordStartDateTime, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefLevelOfInstitution"/> model
        /// </summary>
        public Guid? RefLevelOfInstitutionId { get => _RefLevelOfInstitutionId; set => SetProperty(ref _RefLevelOfInstitutionId, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IAeProvider model)
        {
            IsBusy = true;
            Id = model.Id;
            RecordEndDateTime = model.RecordEndDateTime; // 
            RecordStartDateTime = model.RecordStartDateTime; // 
            RefLevelOfInstitutionId = model.RefLevelOfInstitutionId; // 
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
