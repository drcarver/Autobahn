//**********************************************************
//* DomainName: Autobahn.K12
//* FileName:   K12LeaPreKEligibleAgesIDEAViewModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.ViewModels;

namespace Autobahn.K12.ViewModels
{
     /// <summary>
     /// The K12LeaPreKEligibleAgesIDEAViewModel
     /// </summary>
    public partial class K12LeaPreKEligibleAgesIDEAViewModel : ViewModelBase, Interfaces.IK12LeaPreKEligibleAgesIDEAViewModel
    {
#region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from K12LeaPreKEligibleAgesIDEA";

        // member variable for the K12LEAPreKEligibleAgesIDEAId property
        private Guid _K12LEAPreKEligibleAgesIDEAId;

        // member variable for the K12LeaId property
        private Guid _K12LeaId;

        // member variable for the RefPreKEligibleAgesNonIDEAId property
        private Guid _RefPreKEligibleAgesNonIDEAId;

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
        /// The title of the K12LeaPreKEligibleAgesIDEAViewModel
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// Reference to a required instance of the <see cref="K12LEAPreKEligibleAgesIDEAId"/> model
        /// </summary>
        public Guid K12LEAPreKEligibleAgesIDEAId { get => _K12LEAPreKEligibleAgesIDEAId; set => SetProperty(ref _K12LEAPreKEligibleAgesIDEAId, value); }

        /// <summary>
        /// Reference to a required instance of the <see cref="K12LeaId"/> model
        /// </summary>
        public Guid K12LeaId { get => _K12LeaId; set => SetProperty(ref _K12LeaId, value); }

        /// <summary>
        /// Reference to a required instance of the <see cref="RefPreKEligibleAgesNonIDEAId"/> model
        /// </summary>
        public Guid RefPreKEligibleAgesNonIDEAId { get => _RefPreKEligibleAgesNonIDEAId; set => SetProperty(ref _RefPreKEligibleAgesNonIDEAId, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IK12LeaPreKEligibleAgesIDEA model)
        {
            IsBusy = true;
            Id = model.Id;
            K12LEAPreKEligibleAgesIDEAId = model.K12LEAPreKEligibleAgesIDEAId;
            K12LeaId = model.K12LeaId;
            RefPreKEligibleAgesNonIDEAId = model.RefPreKEligibleAgesNonIDEAId;
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
