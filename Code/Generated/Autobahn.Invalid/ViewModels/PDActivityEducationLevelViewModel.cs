//**********************************************************
//* DomainName: Invalid or Unreferenced Models
//* FileName:   PDActivityEducationLevelViewModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.ViewModels;

using System.ComponentModel;
using System.Windows.Input;

namespace Autobahn.Invalid.ViewModels
{
     /// <summary>
     /// The PDActivityEducationLevelViewModel
     /// </summary>
    public partial class PDActivityEducationLevelViewModel : ViewModelBase, Interfaces.IPDActivityEducationLevel
    {
        #region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from PDActivityEducationLevel";

        // member variable for the RecordEndDateTime property
        private  _RecordEndDateTime;

        // member variable for the RecordStartDateTime property
        private  _RecordStartDateTime;

        // member variable for the RefPDActivityEducationLevelsAddressedId property
        private Guid? _RefPDActivityEducationLevelsAddressedId;

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
        /// Reference to an optional instance of the <see cref="RefPDActivityEducationLevelsAddressed"/> model
        /// </summary>
        public Guid? RefPDActivityEducationLevelsAddressedId { get => _RefPDActivityEducationLevelsAddressedId; set => SetProperty(ref _RefPDActivityEducationLevelsAddressedId, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IPDActivityEducationLevel model)
        {
            IsBusy = true;
            Id = model.Id;
            RecordEndDateTime = model.RecordEndDateTime; // 
            RecordStartDateTime = model.RecordStartDateTime; // 
            RefPDActivityEducationLevelsAddressedId = model.RefPDActivityEducationLevelsAddressedId; // 
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
