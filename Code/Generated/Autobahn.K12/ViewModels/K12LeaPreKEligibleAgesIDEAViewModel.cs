//**********************************************************
//* DomainName: Elementary and Secondary (K12)
//* FileName:   K12LeaPreKEligibleAgesIDEAViewModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.ViewModels;

using System.ComponentModel;
using System.Windows.Input;

namespace Autobahn.K12.ViewModels
{
     /// <summary>
     /// The K12LeaPreKEligibleAgesIDEAViewModel
     /// </summary>
    public partial class K12LeaPreKEligibleAgesIDEAViewModel : ViewModelBase, Interfaces.IK12LeaPreKEligibleAgesIDEA
    {
        #region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from K12LeaPreKEligibleAgesIDEA";

        // member variable for the RecordEndDateTime property
        private  _RecordEndDateTime;

        // member variable for the RecordStartDateTime property
        private  _RecordStartDateTime;

        // member variable for the RefPreKEligibleAgesNonIDEAId property
        private Guid? _RefPreKEligibleAgesNonIDEAId;

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
        /// Reference to an optional instance of the <see cref="RefPreKEligibleAgesNonIDEA"/> model
        /// </summary>
        public Guid? RefPreKEligibleAgesNonIDEAId { get => _RefPreKEligibleAgesNonIDEAId; set => SetProperty(ref _RefPreKEligibleAgesNonIDEAId, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IK12LeaPreKEligibleAgesIDEA model)
        {
            IsBusy = true;
            Id = model.Id;
            RecordEndDateTime = model.RecordEndDateTime; // 
            RecordStartDateTime = model.RecordStartDateTime; // 
            RefPreKEligibleAgesNonIDEAId = model.RefPreKEligibleAgesNonIDEAId; // 
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
